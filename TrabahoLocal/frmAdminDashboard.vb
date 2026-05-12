Imports System.Drawing
Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmAdminDashboard

    Private WithEvents fadeTimer As New Timer()

    ' ==================================================
    ' ADMIN: Dynamic Right-Click Menu
    ' ==================================================
    Private WithEvents cmsAdminMenu As New ContextMenuStrip()
    Private WithEvents mnuViewProfile As New ToolStripMenuItem("👁️ View User Profile")
    Private WithEvents mnuVerify As New ToolStripMenuItem("🪪 Review & Verify ID")
    Private WithEvents mnuEdit As New ToolStripMenuItem("✏️ Edit Selected Record")
    Private WithEvents mnuDelete As New ToolStripMenuItem("❌ Delete Selected Record (DANGER)")

    ' --- LOAD EVENT ---
    Private Sub frmAdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        Me.Opacity = 0
        fadeTimer.Interval = 15
        fadeTimer.Start()

        btnLogout.BringToFront()

        ' Setup Admin Right-Click Menu Styling
        mnuViewProfile.BackColor = Color.White
        mnuVerify.BackColor = Color.FromArgb(232, 245, 233) ' Very Light Green
        mnuEdit.BackColor = Color.White
        mnuDelete.BackColor = Color.FromArgb(255, 235, 238) ' Very Light Red
        mnuDelete.ForeColor = Color.Red

        cmsAdminMenu.Items.Add(mnuViewProfile)
        cmsAdminMenu.Items.Add(mnuVerify)
        cmsAdminMenu.Items.Add(New ToolStripSeparator())
        cmsAdminMenu.Items.Add(mnuEdit)
        cmsAdminMenu.Items.Add(mnuDelete)
        dgvData.ContextMenuStrip = cmsAdminMenu

        ' Default the dropdown to Pending Verifications
        cmbView.SelectedIndex = 0

        LoadSystemStats()
        LoadDataGrid()
    End Sub

    Private Sub fadeTimer_Tick(sender As Object, e As EventArgs) Handles fadeTimer.Tick
        If Me.Opacity < 1.0 Then
            Me.Opacity += 0.05
        Else
            fadeTimer.Stop()
        End If
    End Sub

    ' --- ADMIN LOGIC: Load Quick Stats ---
    Private Sub LoadSystemStats()
        Try
            openConn()

            ' 1. Pending IDs (COMBINED Workers and Employers)
            Dim queryPending As String = "SELECT (SELECT COUNT(*) FROM tblworkers WHERE IDImagePath IS NOT NULL AND IsVerified = FALSE) + " &
                                         "(SELECT COUNT(*) FROM tblemployeers WHERE IDImagePath IS NOT NULL AND IsVerified = FALSE)"
            Dim cmdPending As New MySqlCommand(queryPending, conn)
            Dim pendingCount = cmdPending.ExecuteScalar()
            lblPendingCount.Text = "Pending Verifications: " & pendingCount.ToString()

            ' 2. Total Users
            Dim cmdUsers As New MySqlCommand("SELECT COUNT(*) FROM tblusers", conn)
            Dim totalUsers = cmdUsers.ExecuteScalar()
            lblTotalUsers.Text = "Users: " & totalUsers.ToString()

            ' 3. Total Jobs
            Dim cmdJobs As New MySqlCommand("SELECT COUNT(*) FROM tbljobs", conn)
            Dim totalJobs = cmdJobs.ExecuteScalar()
            lblTotalJobs.Text = "Jobs Posted: " & totalJobs.ToString()

            ' 4. ERP FINANCE MODULE: Total Money in the Economy
            Dim cmdMoney As New MySqlCommand("SELECT SUM(AmountPaid) FROM tblTransactions", conn)
            Dim totalMoney = cmdMoney.ExecuteScalar()

            If totalMoney IsNot DBNull.Value AndAlso totalMoney IsNot Nothing Then
                lblTotalMoney.Text = "Economy: ₱" & String.Format("{0:N2}", totalMoney)
            Else
                lblTotalMoney.Text = "Economy: ₱0.00"
            End If

        Catch ex As Exception
        Finally
            closeConn()
        End Try
    End Sub

    ' --- ADMIN LOGIC: Load DataGrid (with ERP Auto-Highlighting) ---
    Private Sub LoadDataGrid()
        Try
            openConn()
            Dim query As String = ""
            Dim currentView = cmbView.SelectedItem.ToString()

            Select Case currentView
                Case "Pending Verifications"
                    query = "SELECT u.UserID, u.FullName, w.IDImagePath, u.AccountType AS 'Role' " &
                            "FROM tblusers u JOIN tblworkers w ON u.UserID = w.UserID " &
                            "WHERE w.IDImagePath IS NOT NULL AND w.IsVerified = FALSE " &
                            "UNION " &
                            "SELECT u.UserID, u.FullName, e.IDImagePath, u.AccountType AS 'Role' " &
                            "FROM tblusers u JOIN tblemployeers e ON u.UserID = e.UserID " &
                            "WHERE e.IDImagePath IS NOT NULL AND e.IsVerified = FALSE"
                Case "All Users"
                    query = "SELECT UserID, Username, FullName, AccountType AS 'Role' FROM tblusers"
                Case "All Jobs"
                    query = "SELECT j.JobID, j.JobTitle, IFNULL(e.FullName, 'System') AS 'Employer', j.Location, IF(j.PayType='Fixed', j.Salary, j.PayRate) AS 'Rate', j.Status " &
                            "FROM tbljobs j LEFT JOIN tblemployeers e ON j.EmployeerID = e.EmployeerID"
                Case "Closed Projects (Financials)"
                    query = "SELECT t.TransactionID, t.TransactionDate, uE.FullName AS 'Employer', uW.FullName AS 'Worker', t.AmountPaid AS 'Paid (₱)' " &
                            "FROM tblTransactions t " &
                            "JOIN tblemployeers emp ON t.EmployerID = emp.EmployeerID " &
                            "JOIN tblusers uE ON emp.UserID = uE.UserID " &
                            "JOIN tblworkers wrk ON t.WorkerID = wrk.WorkerID " &
                            "JOIN tblusers uW ON wrk.UserID = uW.UserID " &
                            "ORDER BY t.TransactionDate DESC"
            End Select

            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim table As New DataTable()
            adapter.Fill(table)
            dgvData.DataSource = table

            ' ERP Feature: Auto-highlight unverified users in RED
            If currentView = "Pending Verifications" Then
                For Each row As DataGridViewRow In dgvData.Rows
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 235, 238) ' Light Red tint
                Next
            End If

        Catch ex As Exception
            MsgBox("Error loading admin data: " & ex.Message)
        Finally
            closeConn()
        End Try
    End Sub

    ' ==================================================
    ' ERP FEATURE: OMNI-SEARCH ENGINE (LIVE FILTERING)
    ' ==================================================
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            ' Get the underlying DataTable from the grid
            Dim dt As DataTable = TryCast(dgvData.DataSource, DataTable)

            If dt IsNot Nothing Then
                If String.IsNullOrWhiteSpace(txtSearch.Text) Then
                    ' If box is empty, show everything
                    dt.DefaultView.RowFilter = ""
                Else
                    ' Clean the input to prevent SQL crashes if they type an apostrophe
                    Dim searchTxt As String = txtSearch.Text.Replace("'", "''")
                    Dim filterParts As New List(Of String)()

                    ' Dynamically build a search query for EVERY column in the grid
                    For Each col As DataColumn In dt.Columns
                        ' We convert numbers/dates to strings on the fly so LIKE works universally
                        filterParts.Add($"CONVERT([{col.ColumnName}], 'System.String') LIKE '%{searchTxt}%'")
                    Next

                    ' Apply the filter (e.g., Column1 LIKE '%text%' OR Column2 LIKE '%text%')
                    dt.DefaultView.RowFilter = String.Join(" OR ", filterParts)
                End If

                ' Maintain the Red Highlight for unverified users even after filtering
                Dim currentView = cmbView.SelectedItem.ToString()
                If currentView = "Pending Verifications" Then
                    For Each row As DataGridViewRow In dgvData.Rows
                        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 235, 238) ' Light Red
                    Next
                End If
            End If
        Catch ex As Exception
            ' Fail silently on complex typing to prevent UI crashes while typing fast
        End Try
    End Sub

    ' ==================================================
    ' ADMIN: VERIFY ID (ERP DECISION ENGINE)
    ' ==================================================
    Private Sub mnuVerify_Click(sender As Object, e As EventArgs) Handles mnuVerify.Click
        If dgvData.SelectedRows.Count = 0 OrElse cmbView.SelectedItem.ToString() <> "Pending Verifications" Then
            MsgBox("Please select a user from the 'Pending Verifications' tab.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim userId = Convert.ToInt32(dgvData.SelectedRows(0).Cells("UserID").Value)
        Dim userName = dgvData.SelectedRows(0).Cells("FullName").Value.ToString()
        Dim imagePath = dgvData.SelectedRows(0).Cells("IDImagePath").Value.ToString()
        Dim userRole = dgvData.SelectedRows(0).Cells("Role").Value.ToString()
        Dim tableName As String = If(userRole = "Employer", "tblemployeers", "tblworkers")

        ' 1. Review Image Phase
        If IO.File.Exists(imagePath) Then
            Process.Start(imagePath)
        Else
            MsgBox("System Warning: ID image file not found on server at: " & imagePath, MsgBoxStyle.Critical)
            ' Fallback for demo purposes: continue even if file missing
        End If

        ' 2. Decision Phase
        Dim choice As DialogResult = MsgBox("ID REVIEW FOR: " & userName & vbCrLf & vbCrLf &
                                           "Click [YES] to Verify User" & vbCrLf &
                                           "Click [NO] to Reject ID and request re-upload" & vbCrLf &
                                           "Click [CANCEL] to exit without changes.",
                                           MsgBoxStyle.YesNoCancel Or MsgBoxStyle.Question, "ERP Verification Center")

        If choice = DialogResult.Yes Then
            ' --- ACTION: VERIFY ---
            Try
                openConn()
                Dim cmd As New MySqlCommand("UPDATE " & tableName & " SET IsVerified = TRUE WHERE UserID = @uid", conn)
                cmd.Parameters.AddWithValue("@uid", userId)
                cmd.ExecuteNonQuery()

                NotificationManager.Send(userId, "System Update: Your identity has been verified. Your account is now fully active.")
                MsgBox("Identity Confirmed. Account Activated.", MsgBoxStyle.Information)
            Finally
                closeConn()
            End Try

        ElseIf choice = DialogResult.No Then
            ' --- ACTION: REJECT WITH REASON (ERP Logic) ---
            Dim reason As String = InputBox("Please enter the reason for rejection (this will be sent to the user):",
                                            "Rejection Reason", "The uploaded ID image was unclear or unreadable.")

            If Not String.IsNullOrWhiteSpace(reason) Then
                Try
                    openConn()
                    ' Clear the image path so they have to upload a new one
                    Dim cmd As New MySqlCommand("UPDATE " & tableName & " SET IDImagePath = NULL WHERE UserID = @uid", conn)
                    cmd.Parameters.AddWithValue("@uid", userId)
                    cmd.ExecuteNonQuery()

                    NotificationManager.Send(userId, "ID Verification Rejected: " & reason)
                    MsgBox("ID Rejected and user notified. They must re-upload a valid document.", MsgBoxStyle.Information)
                Finally
                    closeConn()
                End Try
            End If
        End If

        LoadDataGrid()
        LoadSystemStats()
    End Sub

    ' --- VIEW PROFILE LOGIC ---
    Private Sub mnuViewProfile_Click(sender As Object, e As EventArgs) Handles mnuViewProfile.Click
        If dgvData.SelectedRows.Count = 0 Then Exit Sub
        Dim selectedView = cmbView.SelectedItem.ToString()

        If selectedView = "All Users" Or selectedView = "Pending Verifications" Then
            Dim userId = Convert.ToInt32(dgvData.SelectedRows(0).Cells("UserID").Value)
            Dim userRole = dgvData.SelectedRows(0).Cells("Role").Value.ToString()

            If userRole = "Employer" Then
                Dim empProfile As New frmEmployeerProfile()
                empProfile.IsViewOnly = True
                empProfile.ViewOnlyUserID = userId
                empProfile.ShowDialog()
            Else
                Dim workerProfile As New frmWorkerProfile()
                workerProfile.IsViewOnly = True
                workerProfile.ViewOnlyUserID = userId
                workerProfile.ShowDialog()
            End If
        Else
            MsgBox("Profiles can only be viewed from the Users or Verifications tabs.", MsgBoxStyle.Information)
        End If
    End Sub

    ' --- EDIT RECORD ---
    Private Sub mnuEdit_Click(sender As Object, e As EventArgs) Handles mnuEdit.Click
        If dgvData.SelectedRows.Count = 0 Then Exit Sub
        Dim selectedView = cmbView.SelectedItem.ToString()

        If selectedView = "All Users" Then
            Dim userId = dgvData.SelectedRows(0).Cells("UserID").Value
            Dim currentName = dgvData.SelectedRows(0).Cells("FullName").Value.ToString()
            Dim newName = InputBox("Enter new Full Name for User ID " & userId & ":", "Admin Edit", currentName)

            If newName <> "" AndAlso newName <> currentName Then
                Try
                    openConn()
                    Dim cmd As New MySqlCommand("UPDATE tblusers SET FullName = @name WHERE UserID = @id", conn)
                    cmd.Parameters.AddWithValue("@name", newName)
                    cmd.Parameters.AddWithValue("@id", userId)
                    cmd.ExecuteNonQuery()
                    MsgBox("Updated!", MsgBoxStyle.Information)
                    LoadDataGrid()
                Finally
                    closeConn()
                End Try
            End If
        Else
            MsgBox("Manual editing is restricted for this data type.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    ' --- DELETE RECORD ---
    Private Sub mnuDelete_Click(sender As Object, e As EventArgs) Handles mnuDelete.Click
        If dgvData.SelectedRows.Count = 0 Then Exit Sub
        Dim selectedView = cmbView.SelectedItem.ToString()

        If selectedView = "All Users" Then
            Dim userId = dgvData.SelectedRows(0).Cells("UserID").Value
            If MsgBox("WARNING: Permanently delete User ID " & userId & "?", MsgBoxStyle.YesNo Or MsgBoxStyle.Critical) = MsgBoxResult.Yes Then
                Try
                    openConn()
                    Dim cmd As New MySqlCommand("DELETE FROM tblusers WHERE UserID = @id", conn)
                    cmd.Parameters.AddWithValue("@id", userId)
                    cmd.ExecuteNonQuery()
                    LoadDataGrid()
                    LoadSystemStats()
                Finally
                    closeConn()
                End Try
            End If
        End If
    End Sub

    ' --- NAVIGATION & EXPORT ---
    Private Sub cmbView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbView.SelectedIndexChanged
        ' Clear the search box when switching tabs to prevent filter logic bugs
        If txtSearch IsNot Nothing Then txtSearch.Clear()
        LoadDataGrid()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadSystemStats()
        LoadDataGrid()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim home As New frmHome()
        home.Show()
        Me.Close()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        If dgvData.Rows.Count = 0 Then Exit Sub
        Dim sfd As New SaveFileDialog()
        sfd.Filter = "CSV File (*.csv)|*.csv"
        sfd.FileName = "TrabahoLocal_Report_" & DateTime.Now.ToString("yyyyMMdd")

        If sfd.ShowDialog() = DialogResult.OK Then
            Try
                Dim sb As New System.Text.StringBuilder()
                Dim headers = String.Join(",", dgvData.Columns.Cast(Of DataGridViewColumn).Select(Function(c) c.HeaderText))
                sb.AppendLine(headers)

                For Each row As DataGridViewRow In dgvData.Rows
                    Dim cells = row.Cells.Cast(Of DataGridViewCell).Select(Function(c) """" & If(c.Value, "").ToString().Replace("""", """""") & """")
                    sb.AppendLine(String.Join(",", cells))
                Next

                File.WriteAllText(sfd.FileName, sb.ToString())
                MsgBox("Export successful!", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox("Export Error: " & ex.Message)
            End Try
        End If
    End Sub

End Class