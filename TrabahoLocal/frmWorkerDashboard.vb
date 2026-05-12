Imports System.Drawing
Imports MySql.Data.MySqlClient

Public Class frmWorkerDashboard

    Private WithEvents fadeTimer As New Timer()

    ' --- LOAD EVENT ---
    Private Sub frmWorkerDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        Me.Opacity = 0
        fadeTimer.Interval = 15
        fadeTimer.Start()

        btnLogout.BringToFront()

        ' ERP: Load the worker's total financial earnings!
        UpdateWorkerStats()

        ' Start on Find Jobs by default
        btnFindJobs.PerformClick()
    End Sub

    Private Sub fadeTimer_Tick(sender As Object, e As EventArgs) Handles fadeTimer.Tick
        If Me.Opacity < 1.0 Then
            Me.Opacity += 0.05
        Else
            fadeTimer.Stop()
        End If
    End Sub

    Private Sub frmWorkerDashboard_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If pnlContent IsNot Nothing Then
            pnlContent.Left = CInt((Me.Width - pnlContent.Width) / 2)
            pnlContent.Top = CInt((Me.Height - pnlContent.Height) / 2) + 40
        End If

        If btnLogout IsNot Nothing AndAlso pnlHeader IsNot Nothing Then
            btnLogout.Location = New Point(Me.Width - btnLogout.Width - 20, 15)
        End If
    End Sub

    ' ==========================================
    ' TOP NAVIGATION SYSTEM (MODERN UI)
    ' ==========================================
    Private Sub ResetNavButtons()
        btnFindJobs.ForeColor = Color.FromArgb(108, 117, 125)
        btnActiveJobs.ForeColor = Color.FromArgb(108, 117, 125)
        btnMyApplications.ForeColor = Color.FromArgb(108, 117, 125)
        btnGlobalInbox.ForeColor = Color.FromArgb(108, 117, 125)

        btnFindJobs.BackColor = Color.White
        btnActiveJobs.BackColor = Color.White
        btnMyApplications.BackColor = Color.White
        btnGlobalInbox.BackColor = Color.White
    End Sub

    ' --- NAVIGATION: Available Jobs ---
    Private Sub btnFindJobs_Click(sender As Object, e As EventArgs) Handles btnFindJobs.Click
        ResetNavButtons()
        btnFindJobs.ForeColor = Color.FromArgb(0, 82, 204)
        btnFindJobs.BackColor = Color.FromArgb(245, 246, 248)
        btnViewReceipt.Visible = False

        lblTitle.Text = "Available Local Jobs"
        dgvMyApplications.Visible = False
        btnMarkDone.Visible = False
        btnChatEmployer.Visible = False

        ' Show Search Engine UI
        lblSearch.Visible = True
        txtSearch.Visible = True
        txtSearch.Clear()

        flpJobs.Visible = True
        LoadAvailableJobs()
    End Sub

    ' --- NAVIGATION: Current Work ---
    Private Sub btnActiveJobs_Click(sender As Object, e As EventArgs) Handles btnActiveJobs.Click
        ResetNavButtons()
        btnActiveJobs.ForeColor = Color.FromArgb(0, 82, 204)
        btnActiveJobs.BackColor = Color.FromArgb(245, 246, 248)
        btnViewReceipt.Visible = False

        lblTitle.Text = "My Current Projects"
        flpJobs.Visible = False

        ' Hide Search Engine UI
        lblSearch.Visible = False
        txtSearch.Visible = False

        dgvMyApplications.Visible = True
        btnMarkDone.Visible = True
        btnChatEmployer.Visible = True

        LoadActiveJobs()
    End Sub

    ' --- NAVIGATION: History ---
    Private Sub btnMyApplications_Click(sender As Object, e As EventArgs) Handles btnMyApplications.Click
        ResetNavButtons()
        btnMyApplications.ForeColor = Color.FromArgb(0, 82, 204)
        btnMyApplications.BackColor = Color.FromArgb(245, 246, 248)
        btnViewReceipt.Visible = True

        lblTitle.Text = "My Job Applications"
        flpJobs.Visible = False
        btnMarkDone.Visible = False

        btnChatEmployer.Visible = True

        ' Hide Search Engine UI
        lblSearch.Visible = False
        txtSearch.Visible = False

        dgvMyApplications.Visible = True
        LoadMyApplications()
    End Sub

    ' --- NAVIGATION: Edit My Profile ---
    Private Sub btnMyProfile_Click(sender As Object, e As EventArgs) Handles btnMyProfile.Click
        Dim profileForm As New frmWorkerProfile()
        profileForm.IsViewOnly = False
        profileForm.ShowDialog()
    End Sub

    ' ==========================================
    ' NAVIGATION: Open Global Inbox
    ' ==========================================
    Private Sub btnGlobalInbox_Click(sender As Object, e As EventArgs) Handles btnGlobalInbox.Click
        ' Open the Inbox in "General View" (No specific chat pre-selected)
        Dim globalInbox As New frmInbox()
        globalInbox.ShowDialog()

        ' Refresh the notification bell when they close the inbox
        Dim unreadCount As Integer = NotificationManager.GetUnreadCount(CurrentUserID)
        If unreadCount > 0 Then
            btnNotifications.Text = "🔔 Alerts (" & unreadCount & ")"
            btnNotifications.ForeColor = Color.Yellow
        Else
            btnNotifications.Text = "🔔 Alerts"
            btnNotifications.ForeColor = Color.White
        End If
    End Sub

    ' ==========================================
    ' ERP HR MODULE: Calculate Total Earnings
    ' ==========================================
    Private Sub UpdateWorkerStats()
        Try
            openConn()
            Dim query As String = "SELECT SUM(AmountPaid) FROM tblTransactions WHERE WorkerID = (SELECT WorkerID FROM tblworkers WHERE UserID = @uid)"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@uid", CurrentUserID)

            Dim total As Object = cmd.ExecuteScalar()
            If total IsNot DBNull.Value AndAlso total IsNot Nothing Then
                lblTotalEarnings.Text = "Total Earnings: ₱" & String.Format("{0:N2}", total)
            Else
                lblTotalEarnings.Text = "Total Earnings: ₱0.00"
            End If
        Catch ex As Exception
            ' Silently handle if no earnings yet
            lblTotalEarnings.Text = "Total Earnings: ₱0.00"
        Finally
            closeConn()
        End Try
    End Sub

    ' ==========================================
    ' DATABASE LOGIC (WITH LIVE SEARCH ENGINE)
    ' ==========================================
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        ' Triggers every time the user types a letter!
        LoadAvailableJobs(txtSearch.Text.Trim())
    End Sub

    Private Sub LoadAvailableJobs(Optional searchQuery As String = "")
        Try
            openConn()

            ' Base query for available jobs
            Dim query As String = "SELECT JobID, JobTitle, Location, PayType, PayRate, Salary, Description FROM tbljobs WHERE Status = 'Open'"

            ' Append Search Filter if they typed something
            If searchQuery <> "" Then
                query &= " AND (JobTitle LIKE @search OR Location LIKE @search OR Description LIKE @search)"
            End If

            query &= " ORDER BY JobID DESC"

            Dim cmd As New MySqlCommand(query, conn)

            If searchQuery <> "" Then
                cmd.Parameters.AddWithValue("@search", "%" & searchQuery & "%")
            End If

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            flpJobs.Controls.Clear()

            While reader.Read()
                Dim card As New ucJobCard()

                Dim payRate As Decimal = Convert.ToDecimal(reader("PayRate"))
                Dim displayFee As String

                If payRate > 0 Then
                    displayFee = reader("PayType").ToString() & ": ₱ " & payRate.ToString("N2")
                Else
                    displayFee = "Fee: ₱ " & reader("Salary").ToString()
                End If

                card.SetJobData(
                    Convert.ToInt32(reader("JobID")),
                    reader("JobTitle").ToString(),
                    reader("Location").ToString(),
                    displayFee,
                    reader("Description").ToString()
                )

                AddHandler card.ApplyClicked, AddressOf HandleJobApplication
                flpJobs.Controls.Add(card)
            End While
            reader.Close()

        Catch ex As Exception
            MsgBox("Error loading available jobs: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            closeConn()
        End Try
    End Sub

    Private Sub LoadActiveJobs()
        Try
            openConn()
            Dim query As String = "SELECT a.ApplicationID, j.JobTitle AS 'Project', e.FullName AS 'Employer', " &
                                  "j.PayType AS 'Type', IF(j.PayType='Fixed', j.Salary, j.PayRate) AS 'Rate (₱)', " &
                                  "e.ContactNumber AS 'Contact Info' " &
                                  "FROM tblApplications a " &
                                  "JOIN tbljobs j ON a.JobID = j.JobID " &
                                  "JOIN tblemployeers e ON j.EmployeerID = e.EmployeerID " &
                                  "WHERE a.WorkerID = (SELECT WorkerID FROM tblworkers WHERE UserID = @uid) " &
                                  "AND a.Status = 'Accepted'"

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@uid", CurrentUserID)

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()

            adapter.Fill(table)
            dgvMyApplications.DataSource = table

            If dgvMyApplications.Columns.Contains("ApplicationID") Then dgvMyApplications.Columns("ApplicationID").Visible = False
        Catch ex As Exception
        Finally
            closeConn()
        End Try
    End Sub

    Private Sub LoadMyApplications()
        Try
            openConn()
            Dim query As String = "SELECT a.ApplicationID, j.JobTitle AS 'Job Role', e.FullName AS 'Employer Name', " &
                                  "j.PayType AS 'Type', IF(j.PayType='Fixed', j.Salary, j.PayRate) AS 'Rate (₱)', " &
                                  "a.ApplicationDate AS 'Date Applied', a.Status " &
                                  "FROM tblApplications a " &
                                  "JOIN tbljobs j ON a.JobID = j.JobID " &
                                  "JOIN tblemployeers e ON j.EmployeerID = e.EmployeerID " &
                                  "WHERE a.WorkerID = (SELECT WorkerID FROM tblworkers WHERE UserID = @uid) " &
                                  "ORDER BY a.ApplicationDate DESC"

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@uid", CurrentUserID)

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()

            adapter.Fill(table)
            dgvMyApplications.DataSource = table

            If dgvMyApplications.Columns.Contains("ApplicationID") Then dgvMyApplications.Columns("ApplicationID").Visible = False
        Catch ex As Exception
        Finally
            closeConn()
        End Try
    End Sub

    ' --- ACTION: Apply for Job (WITH SECURITY GATE) ---
    Private Sub HandleJobApplication(jobID As Integer, jobTitle As String)
        Try
            openConn()
            Dim cmdCheck As New MySqlCommand("SELECT IsVerified FROM tblworkers WHERE UserID = @uid", conn)
            cmdCheck.Parameters.AddWithValue("@uid", CurrentUserID)
            Dim isVerified As Boolean = Convert.ToBoolean(If(IsDBNull(cmdCheck.ExecuteScalar()), False, cmdCheck.ExecuteScalar()))
            closeConn()

            If Not isVerified Then
                MsgBox("You must be Verified by an Admin before you can apply for jobs. Please go to 'Edit Profile' to upload your Government ID.", MsgBoxStyle.Exclamation, "Verification Required")
                Exit Sub
            End If
        Catch ex As Exception
            closeConn()
            MsgBox("Verification Check Error: " & ex.Message)
            Exit Sub
        End Try

        Dim applyForm As New frmApplyJob()
        applyForm.TargetJobID = jobID

        If applyForm.ShowDialog() = DialogResult.OK Then
            LoadAvailableJobs()
        End If
    End Sub

    ' --- ACTION: Mark Job as Finished ---
    Private Sub btnMarkDone_Click(sender As Object, e As EventArgs) Handles btnMarkDone.Click
        If dgvMyApplications.SelectedRows.Count > 0 Then
            Dim appID As Integer = Convert.ToInt32(dgvMyApplications.SelectedRows(0).Cells("ApplicationID").Value)
            Dim jobName As String = dgvMyApplications.SelectedRows(0).Cells("Project").Value.ToString()

            Dim confirm As DialogResult = MsgBox("Confirm that you have finished the work for: " & jobName & "?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question)
            If confirm = DialogResult.Yes Then
                If JobManager.CompleteJob(appID) Then
                    MsgBox("Job marked as Completed! Your employer has been notified.", MsgBoxStyle.Information)
                    LoadActiveJobs()
                End If
            End If
        Else
            MsgBox("Please select a project to mark as finished.")
        End If
    End Sub

    ' ==========================================
    ' ACTION: Open Chat Inbox (Worker Side)
    ' ==========================================
    Private Sub btnChatEmployer_Click(sender As Object, e As EventArgs) Handles btnChatEmployer.Click
        If dgvMyApplications.SelectedRows.Count > 0 Then
            Dim appID As Integer = Convert.ToInt32(dgvMyApplications.SelectedRows(0).Cells("ApplicationID").Value)

            ' Launch the new Enterprise Inbox
            Dim inboxForm As New frmInbox()
            inboxForm.PreSelectedAppID = appID
            inboxForm.ShowDialog()
        Else
            MsgBox("Please select a project to message the employer.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        UpdateWorkerStats()
        If flpJobs.Visible Then
            LoadAvailableJobs(txtSearch.Text)
        ElseIf lblTitle.Text.Contains("Projects") Then
            LoadActiveJobs()
        Else
            LoadMyApplications()
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim home As New frmHome()
        home.Show()
        Me.Close()
    End Sub

    ' ==========================================
    ' WORKER UI: Modern Interactive Hover Effects
    ' ==========================================
    Private Sub ActionButtons_MouseEnter(sender As Object, e As EventArgs) Handles btnMarkDone.MouseEnter, btnChatEmployer.MouseEnter
        Dim btn As Button = CType(sender, Button)
        If btn.Name = "btnChatEmployer" Then
            btn.BackColor = Color.FromArgb(133, 79, 232)
        Else
            btn.BackColor = Color.FromArgb(44, 185, 76)
        End If
    End Sub

    Private Sub ActionButtons_MouseLeave(sender As Object, e As EventArgs) Handles btnMarkDone.MouseLeave, btnChatEmployer.MouseLeave
        Dim btn As Button = CType(sender, Button)
        If btn.Name = "btnChatEmployer" Then
            btn.BackColor = Color.FromArgb(111, 66, 193)
        Else
            btn.BackColor = Color.FromArgb(40, 167, 69)
        End If
    End Sub

    Private Sub NavButtons_MouseEnter(sender As Object, e As EventArgs) Handles btnFindJobs.MouseEnter, btnActiveJobs.MouseEnter, btnMyApplications.MouseEnter, btnMyProfile.MouseEnter, btnGlobalInbox.MouseEnter
        Dim btn As Button = CType(sender, Button)
        If btn.BackColor <> Color.FromArgb(245, 246, 248) Then
            btn.BackColor = Color.FromArgb(245, 246, 248)
        End If
    End Sub

    Private Sub NavButtons_MouseLeave(sender As Object, e As EventArgs) Handles btnFindJobs.MouseLeave, btnActiveJobs.MouseLeave, btnMyApplications.MouseLeave, btnMyProfile.MouseLeave, btnGlobalInbox.MouseLeave
        Dim btn As Button = CType(sender, Button)
        If btn.ForeColor <> Color.FromArgb(0, 82, 204) Then
            btn.BackColor = Color.White
        End If
    End Sub

    Private Sub btnRefresh_MouseEnter(sender As Object, e As EventArgs) Handles btnRefresh.MouseEnter
        btnRefresh.BackColor = Color.FromArgb(26, 188, 212)
    End Sub

    Private Sub btnRefresh_MouseLeave(sender As Object, e As EventArgs) Handles btnRefresh.MouseLeave
        btnRefresh.BackColor = Color.FromArgb(23, 162, 184)
    End Sub

    ' ==========================================
    ' ERP NOTIFICATION ENGINE (LIVE PULSE)
    ' ==========================================
    Private Sub notifTimer_Tick(sender As Object, e As EventArgs) Handles notifTimer.Tick
        Dim unreadCount As Integer = NotificationManager.GetUnreadCount(CurrentUserID)

        If unreadCount > 0 Then
            btnNotifications.Text = "🔔 Alerts (" & unreadCount & ")"
            btnNotifications.ForeColor = Color.Yellow ' Make it pop when they have a message!
        Else
            btnNotifications.Text = "🔔 Alerts"
            btnNotifications.ForeColor = Color.White
        End If
    End Sub

    Private Sub btnNotifications_Click(sender As Object, e As EventArgs) Handles btnNotifications.Click
        Dim unreadCount As Integer = NotificationManager.GetUnreadCount(CurrentUserID)

        If unreadCount > 0 Then
            MsgBox("You have new system alerts! Check your message inbox.", MsgBoxStyle.Information)
            NotificationManager.MarkAllAsRead(CurrentUserID)
            ' Force the UI to update immediately
            btnNotifications.Text = "🔔 Alerts"
            btnNotifications.ForeColor = Color.White
        Else
            MsgBox("You have no new alerts.", MsgBoxStyle.Information)
        End If
    End Sub

    ' ==========================================
    ' ACTION: Open the Digital Receipt
    ' ==========================================
    Private Sub btnViewReceipt_Click(sender As Object, e As EventArgs) Handles btnViewReceipt.Click
        If dgvMyApplications.SelectedRows.Count > 0 Then
            ' Look at the status column in the data grid
            Dim status As String = dgvMyApplications.SelectedRows(0).Cells("Status").Value.ToString()

            If status = "Closed" Then
                ' Grab the ID and pass it to the Receipt Form
                Dim appID As Integer = Convert.ToInt32(dgvMyApplications.SelectedRows(0).Cells("ApplicationID").Value)
                Dim receipt As New frmReceipt()
                receipt.TargetApplicationID = appID
                receipt.ShowDialog()
            Else
                MsgBox("Receipts are only available for jobs that have been completed and fully paid. This job is currently: " & status, MsgBoxStyle.Information)
            End If
        Else
            MsgBox("Please select a job from the table first.", MsgBoxStyle.Exclamation)
        End If
    End Sub

End Class