Imports MySql.Data.MySqlClient
Imports System.Net.Mail

Public Class RegistrationManager

    ' Checks if a username is already taken
    Public Shared Function IsUsernameTaken(username As String) As Boolean
        Dim isTaken As Boolean = False
        Try
            openConn()
            Dim checkCmd As New MySqlCommand("SELECT COUNT(*) FROM tblUsers WHERE Username = @user", conn)
            checkCmd.Parameters.AddWithValue("@user", username)
            If Convert.ToInt32(checkCmd.ExecuteScalar()) > 0 Then
                isTaken = True
            End If
        Catch ex As Exception
            MsgBox("Database Error: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            closeConn()
        End Try
        Return isTaken
    End Function

    ' Checks if an email is already used in either the Employer or Worker tables
    Public Shared Function IsEmailTaken(email As String) As Boolean
        Dim isTaken As Boolean = False
        Try
            openConn()
            Dim query As String = "SELECT (SELECT COUNT(*) FROM tblEmployeers WHERE ContactNumber = @email) + " &
                                  "(SELECT COUNT(*) FROM tblWorkers WHERE ContactNumber = @email) AS Total"
            Dim checkCmd As New MySqlCommand(query, conn)
            checkCmd.Parameters.AddWithValue("@email", email)

            If Convert.ToInt32(checkCmd.ExecuteScalar()) > 0 Then
                isTaken = True
            End If
        Catch ex As Exception
            MsgBox("Database Error: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            closeConn()
        End Try
        Return isTaken
    End Function

    ' Sends the OTP Email
    Public Shared Function SendOTPEmail(userEmail As String, fullName As String, otpCode As String) As Boolean
        Try
            Dim mail As New MailMessage()
            Dim SmtpServer As New SmtpClient("smtp.gmail.com")

            ' IMPORTANT: Put your actual email and 16-digit App Password here
            Dim yourGmail As String = "juliosofiotare@gmail.com"
            Dim yourAppPassword As String = "suivjwqpmnwpayaz"

            mail.From = New MailAddress(yourGmail)
            mail.To.Add(userEmail)
            mail.Subject = "TrabahoLocal - Registration OTP"
            mail.Body = "Hello " & fullName & "," & vbCrLf & vbCrLf & "Your verification code is: " & otpCode & vbCrLf & vbCrLf & "Please enter this code to complete your registration."

            SmtpServer.Port = 587
            SmtpServer.Credentials = New Net.NetworkCredential(yourGmail, yourAppPassword)
            SmtpServer.EnableSsl = True

            SmtpServer.Send(mail)
            Return True
        Catch ex As Exception
            MsgBox("Failed to send OTP email. Please check your internet connection." & vbCrLf & "Error: " & ex.Message, MsgBoxStyle.Critical)
            Return False
        End Try
    End Function

    ' Saves the new user to the database
    Public Shared Function RegisterNewUser(user As String, pass As String, role As String, name As String, loc As String, email As String) As Boolean
        Try
            openConn()
            ' 1. Insert into Main Users Table
            Dim cmdUser As New MySqlCommand("INSERT INTO tblUsers (Username, Password, AccountType) VALUES (@user, @pass, @role)", conn)
            cmdUser.Parameters.AddWithValue("@user", user)
            cmdUser.Parameters.AddWithValue("@pass", pass)
            cmdUser.Parameters.AddWithValue("@role", role)
            cmdUser.ExecuteNonQuery()

            ' Get the new UserID
            Dim newUserID As Integer = Convert.ToInt32(New MySqlCommand("SELECT LAST_INSERT_ID()", conn).ExecuteScalar())

            ' 2. Insert into the specific Role Table
            Dim insertQuery As String = ""
            If role = "Employeer" Then
                insertQuery = "INSERT INTO tblEmployeers (UserID, FullName, Location, ContactNumber) VALUES (@uid, @fname, @loc, @contact)"
            ElseIf role = "Worker" Then
                insertQuery = "INSERT INTO tblWorkers (UserID, FullName, Location, ContactNumber) VALUES (@uid, @fname, @loc, @contact)"
            End If

            Dim cmdProfile As New MySqlCommand(insertQuery, conn)
            cmdProfile.Parameters.AddWithValue("@uid", newUserID)
            cmdProfile.Parameters.AddWithValue("@fname", name)
            cmdProfile.Parameters.AddWithValue("@loc", loc)
            cmdProfile.Parameters.AddWithValue("@contact", email)
            cmdProfile.ExecuteNonQuery()

            Return True
        Catch ex As Exception
            MsgBox("Registration Error: " & ex.Message, MsgBoxStyle.Critical)
            Return False
        Finally
            closeConn()
        End Try
    End Function

End Class