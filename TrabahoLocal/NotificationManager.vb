Imports MySql.Data.MySqlClient

Public Class NotificationManager

    ' --- 1. SEND A NOTIFICATION ---
    Public Shared Sub Send(userID As Integer, msg As String)
        Try
            openConn()
            Dim cmd As New MySqlCommand("INSERT INTO tblNotifications (UserID, Message) VALUES (@uid, @msg)", conn)
            cmd.Parameters.AddWithValue("@uid", userID)
            cmd.Parameters.AddWithValue("@msg", msg)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            ' THIS WILL TELL US IF THE SQL FAILS:
            MsgBox("SYSTEM ALERT ERROR: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            closeConn()
        End Try
    End Sub

    ' --- 2. CHECK FOR UNREAD ALERTS ---
    Public Shared Function GetUnreadCount(userID As Integer) As Integer
        Try
            openConn()
            Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM tblNotifications WHERE UserID = @uid AND IsRead = 0", conn)
            cmd.Parameters.AddWithValue("@uid", userID)
            Return Convert.ToInt32(cmd.ExecuteScalar())
        Catch ex As Exception
            Return 0
        Finally
            closeConn()
        End Try
    End Function

    ' --- 3. MARK ALL AS READ ---
    Public Shared Sub MarkAllAsRead(userID As Integer)
        Try
            openConn()
            Dim cmd As New MySqlCommand("UPDATE tblNotifications SET IsRead = 1 WHERE UserID = @uid", conn)
            cmd.Parameters.AddWithValue("@uid", userID)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            closeConn()
        End Try
    End Sub

End Class