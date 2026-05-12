Imports System.Drawing
Imports MySql.Data.MySqlClient

Public Class frmInbox
    ' These will update dynamically when you click a contact on the left
    Private ActiveAppID As Integer = 0
    Private ActiveOtherPartyName As String = ""
    Private lastMessageCount As Integer = 0

    ' Public variable so Dashboards can pre-select a specific chat!
    Public PreSelectedAppID As Integer = 0

    Private Sub frmInbox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadConversations()

        ' If a dashboard told this form to open a specific chat immediately
        If PreSelectedAppID > 0 Then
            SelectConversation(PreSelectedAppID)
        Else
            ' Ensure no conversation is accidentally selected on load
            dgvConversations.ClearSelection()
        End If
    End Sub

    ' ==========================================================
    ' THE SMART SIDEBAR: Load all active/past working relationships
    ' ==========================================================
    Private Sub LoadConversations()
        Try
            openConn()
            Dim query As String = "SELECT a.ApplicationID, j.JobTitle, " &
                                  "IF(w.UserID = @uid, e.FullName, w.FullName) AS 'Contact' " &
                                  "FROM tblApplications a " &
                                  "JOIN tbljobs j ON a.JobID = j.JobID " &
                                  "JOIN tblworkers w ON a.WorkerID = w.WorkerID " &
                                  "JOIN tblemployeers e ON j.EmployeerID = e.EmployeerID " &
                                  "WHERE (w.UserID = @uid OR e.UserID = @uid) " &
                                  "AND a.Status IN ('Accepted', 'Completed', 'Closed') " &
                                  "ORDER BY a.ApplicationID DESC"

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@uid", CurrentUserID)

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            dgvConversations.DataSource = table

            ' Hide the ID, so the sidebar only shows the Name and Job Title
            If dgvConversations.Columns.Contains("ApplicationID") Then
                dgvConversations.Columns("ApplicationID").Visible = False
            End If

        Catch ex As Exception
            MsgBox("Error loading contact list: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            closeConn()
        End Try
    End Sub

    ' ==========================================================
    ' ERP FIX: Replaced CellClick with SelectionChanged (100% Reliable)
    ' ==========================================================
    Private Sub dgvConversations_SelectionChanged(sender As Object, e As EventArgs) Handles dgvConversations.SelectionChanged
        If dgvConversations.SelectedRows.Count > 0 Then
            Dim clickedAppID As Integer = Convert.ToInt32(dgvConversations.SelectedRows(0).Cells("ApplicationID").Value)

            ' Only update if they actually picked a new person!
            If ActiveAppID <> clickedAppID Then
                SelectConversation(clickedAppID)
            End If
        End If
    End Sub

    ' Helper function to activate a specific chat
    Private Sub SelectConversation(appID As Integer)
        ' Find the row in the grid to get the names
        For Each row As DataGridViewRow In dgvConversations.Rows
            If Convert.ToInt32(row.Cells("ApplicationID").Value) = appID Then

                ' Force visual selection (triggers SelectionChanged, but our IF guard stops infinite loops)
                row.Selected = True

                ActiveAppID = appID
                ActiveOtherPartyName = row.Cells("Contact").Value.ToString()

                ' Update the Header Labels
                lblChatName.Text = "Chatting with: " & ActiveOtherPartyName
                lblChatJobTitle.Text = "Project Context: " & row.Cells("JobTitle").Value.ToString()

                ' ERP BUG FIX: Force clear the old messages and reset the counter to -1!
                ' This guarantees the new chat will load perfectly, even if it has 0 messages.
                rtbChatHistory.Clear()
                lastMessageCount = -1

                LoadChatHistory()
                tmrRefresh.Start()
                Exit For
            End If
        Next
    End Sub

    ' ==========================================================
    ' RIGHT PANEL: The Actual Chat Engine
    ' ==========================================================
    Private Sub LoadChatHistory()
        If ActiveAppID = 0 Then Exit Sub

        Try
            openConn()
            Dim query As String = "SELECT m.MessageText, m.SentDate, m.SenderID, u.FullName " &
                                  "FROM tblMessages m " &
                                  "JOIN tblusers u ON m.SenderID = u.UserID " &
                                  "WHERE m.ApplicationID = @appID " &
                                  "ORDER BY m.SentDate ASC"

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@appID", ActiveAppID)

            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter(cmd)
            adapter.Fill(table)

            ' ERP BUG FIX: Check if count changed OR if it's currently at -1 (brand new chat)
            If table.Rows.Count <> lastMessageCount Then
                rtbChatHistory.Clear()

                If table.Rows.Count = 0 Then
                    ' Display an elegant empty state message
                    rtbChatHistory.SelectionAlignment = HorizontalAlignment.Center
                    rtbChatHistory.SelectionFont = New Drawing.Font("Segoe UI", 10, Drawing.FontStyle.Italic)
                    rtbChatHistory.SelectionColor = Drawing.Color.Gray
                    rtbChatHistory.AppendText(vbCrLf & vbCrLf & vbCrLf & "No messages yet." & vbCrLf & "Send a message to start the conversation!" & vbCrLf)
                Else
                    For Each row As DataRow In table.Rows
                        Dim senderName As String = row("FullName").ToString()
                        Dim msgText As String = row("MessageText").ToString()
                        Dim msgTime As DateTime = Convert.ToDateTime(row("SentDate"))
                        Dim isMe As Boolean = (Convert.ToInt32(row("SenderID")) = CurrentUserID)

                        If isMe Then
                            ' Align MY messages to the RIGHT
                            rtbChatHistory.SelectionAlignment = HorizontalAlignment.Right
                            rtbChatHistory.SelectionFont = New Drawing.Font("Segoe UI", 9, Drawing.FontStyle.Regular)
                            rtbChatHistory.SelectionColor = Drawing.Color.Gray
                            rtbChatHistory.AppendText(msgTime.ToString("hh:mm tt") & "  ")

                            rtbChatHistory.SelectionFont = New Drawing.Font("Segoe UI", 11, Drawing.FontStyle.Bold)
                            rtbChatHistory.SelectionColor = Drawing.Color.FromArgb(0, 132, 255)
                            rtbChatHistory.AppendText("👤 You" & vbCrLf)

                            rtbChatHistory.SelectionAlignment = HorizontalAlignment.Right
                            rtbChatHistory.SelectionFont = New Drawing.Font("Segoe UI", 13, Drawing.FontStyle.Regular)
                            rtbChatHistory.SelectionColor = Drawing.Color.Black
                            rtbChatHistory.AppendText(msgText & vbCrLf & vbCrLf)
                        Else
                            ' Align THEIR messages to the LEFT
                            rtbChatHistory.SelectionAlignment = HorizontalAlignment.Left
                            rtbChatHistory.SelectionFont = New Drawing.Font("Segoe UI", 11, Drawing.FontStyle.Bold)
                            rtbChatHistory.SelectionColor = Drawing.Color.FromArgb(40, 167, 69)
                            rtbChatHistory.AppendText("👥 " & senderName)

                            rtbChatHistory.SelectionFont = New Drawing.Font("Segoe UI", 9, Drawing.FontStyle.Regular)
                            rtbChatHistory.SelectionColor = Drawing.Color.Gray
                            rtbChatHistory.AppendText("  (" & msgTime.ToString("hh:mm tt") & ")" & vbCrLf)

                            rtbChatHistory.SelectionAlignment = HorizontalAlignment.Left
                            rtbChatHistory.SelectionFont = New Drawing.Font("Segoe UI", 13, Drawing.FontStyle.Regular)
                            rtbChatHistory.SelectionColor = Drawing.Color.Black
                            rtbChatHistory.AppendText(msgText & vbCrLf & vbCrLf)
                        End If
                    Next

                    ' Auto-scroll to the bottom of the chat
                    rtbChatHistory.SelectionStart = rtbChatHistory.Text.Length
                    rtbChatHistory.ScrollToCaret()
                End If

                lastMessageCount = table.Rows.Count
            End If

        Catch ex As Exception
            tmrRefresh.Stop()
        Finally
            closeConn()
        End Try
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        If ActiveAppID = 0 Then
            MsgBox("Please select a conversation from the left menu first.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If txtMessage.Text.Trim() = "" Then Exit Sub

        Try
            openConn()
            Dim query As String = "INSERT INTO tblMessages (ApplicationID, SenderID, MessageText, SentDate) VALUES (@appID, @uid, @msg, @time)"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@appID", ActiveAppID)
            cmd.Parameters.AddWithValue("@uid", CurrentUserID)
            cmd.Parameters.AddWithValue("@msg", txtMessage.Text.Trim())
            cmd.Parameters.AddWithValue("@time", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
            cmd.ExecuteNonQuery()

            txtMessage.Clear()
            LoadChatHistory()

        Catch ex As Exception
            MsgBox("Error sending message: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            closeConn()
        End Try
    End Sub

    Private Sub txtMessage_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMessage.KeyDown
        If e.KeyCode = Keys.Enter AndAlso Not e.Shift Then
            e.SuppressKeyPress = True
            btnSend.PerformClick()
        End If
    End Sub

    Private Sub tmrRefresh_Tick(sender As Object, e As EventArgs) Handles tmrRefresh.Tick
        LoadChatHistory()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        tmrRefresh.Stop()
        Me.Close()
    End Sub
End Class