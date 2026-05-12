Imports System.Drawing
Imports MySql.Data.MySqlClient

Public Class frmChat
    ' The Dashboard passes these details before opening the form
    Public CurrentAppID As Integer
    Public OtherPartyName As String

    Private lastMessageCount As Integer = 0

    Private Sub frmChat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblChatName.Text = "💬 " & OtherPartyName
        LoadMessages()
        tmrRefresh.Start() ' Start auto-refreshing the chat every 3 seconds
    End Sub

    Private Sub LoadMessages()
        Try
            openConn()

            Dim query As String = "SELECT m.MessageText, m.SentDate, m.SenderID, u.FullName " &
                                  "FROM tblMessages m " &
                                  "JOIN tblusers u ON m.SenderID = u.UserID " &
                                  "WHERE m.ApplicationID = @appID " &
                                  "ORDER BY m.SentDate ASC"

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@appID", CurrentAppID)

            Dim table As New DataTable()
            Dim adapter As New MySqlDataAdapter(cmd)
            adapter.Fill(table)

            ' Only update the RichTextBox if new messages arrived (prevents flickering)
            If table.Rows.Count > lastMessageCount Then
                rtbChatHistory.Clear()

                For Each row As DataRow In table.Rows
                    Dim senderName As String = row("FullName").ToString()
                    Dim msgText As String = row("MessageText").ToString()

                    ' FIX: Adjusted to exactly match your database column names
                    Dim msgTime As DateTime = Convert.ToDateTime(row("SentDate"))
                    Dim isMe As Boolean = (Convert.ToInt32(row("SenderID")) = CurrentUserID)

                    ' ==========================================================
                    ' MESSENGER UI TRICK: Left/Right Alignment & Avatar Icons
                    ' ==========================================================
                    If isMe Then
                        ' Align MY messages to the RIGHT
                        rtbChatHistory.SelectionAlignment = HorizontalAlignment.Right
                        rtbChatHistory.SelectionFont = New Drawing.Font("Segoe UI", 9, Drawing.FontStyle.Regular)
                        rtbChatHistory.SelectionColor = Drawing.Color.Gray
                        rtbChatHistory.AppendText(msgTime.ToString("hh:mm tt") & "  ")

                        rtbChatHistory.SelectionFont = New Drawing.Font("Segoe UI", 11, Drawing.FontStyle.Bold)
                        rtbChatHistory.SelectionColor = Drawing.Color.FromArgb(0, 132, 255) ' Messenger Blue
                        rtbChatHistory.AppendText("👤 You" & vbCrLf)

                        rtbChatHistory.SelectionAlignment = HorizontalAlignment.Right
                        rtbChatHistory.SelectionFont = New Drawing.Font("Segoe UI", 13, Drawing.FontStyle.Regular)
                        rtbChatHistory.SelectionColor = Drawing.Color.Black
                        rtbChatHistory.AppendText(msgText & vbCrLf & vbCrLf)
                    Else
                        ' Align THEIR messages to the LEFT
                        rtbChatHistory.SelectionAlignment = HorizontalAlignment.Left
                        rtbChatHistory.SelectionFont = New Drawing.Font("Segoe UI", 11, Drawing.FontStyle.Bold)
                        rtbChatHistory.SelectionColor = Drawing.Color.FromArgb(40, 167, 69) ' Green
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

                lastMessageCount = table.Rows.Count
            End If

        Catch ex As Exception
            tmrRefresh.Stop()
            MsgBox("Error loading messages: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            closeConn()
        End Try
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        If txtMessage.Text.Trim() = "" Then Exit Sub

        Try
            openConn()
            ' FIX: Adjusted INSERT query to exactly match your database column names
            Dim query As String = "INSERT INTO tblMessages (ApplicationID, SenderID, MessageText, SentDate) VALUES (@appID, @uid, @msg, @time)"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@appID", CurrentAppID)
            cmd.Parameters.AddWithValue("@uid", CurrentUserID)
            cmd.Parameters.AddWithValue("@msg", txtMessage.Text.Trim())
            cmd.Parameters.AddWithValue("@time", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))

            cmd.ExecuteNonQuery()

            ' Clear the box and reload immediately
            txtMessage.Clear()
            LoadMessages()

        Catch ex As Exception
            MsgBox("Error sending message: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            closeConn()
        End Try
    End Sub

    ' Allow pressing "Enter" to send the message
    Private Sub txtMessage_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMessage.KeyDown
        If e.KeyCode = Keys.Enter AndAlso Not e.Shift Then
            e.SuppressKeyPress = True ' Prevent the "ding" sound
            btnSend.PerformClick()
        End If
    End Sub

    ' The auto-refresh timer loop
    Private Sub tmrRefresh_Tick(sender As Object, e As EventArgs) Handles tmrRefresh.Tick
        LoadMessages()
    End Sub

    ' Close button
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        tmrRefresh.Stop()
        Me.Close()
    End Sub
End Class