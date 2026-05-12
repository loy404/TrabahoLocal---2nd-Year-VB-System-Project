Imports System.Drawing
Imports System.Net.Mail ' Required for sending Email
Imports MySql.Data.MySqlClient ' Required for Database updates

Public Class frmForgotPassword
    Private generatedOTP As String
    Private targetEmail As String

    Private Sub frmForgotPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        ' Initially hide the OTP and New Password fields
        pnlStep2.Visible = False
        pnlStep3.Visible = False
    End Sub

    Private Sub frmForgotPassword_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ' Center the card dynamically
        If pnlCard IsNot Nothing Then
            pnlCard.Left = (Me.Width - pnlCard.Width) / 2
            pnlCard.Top = (Me.Height - pnlCard.Height) / 2
        End If
    End Sub

    ' --- STEP 1: Send OTP to Email ---
    Private Sub btnSendOTP_Click(sender As Object, e As EventArgs) Handles btnSendOTP.Click
        targetEmail = txtEmail.Text.Trim()

        If targetEmail = "" Then
            MsgBox("Please enter your registered email.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        ' Generate 6-digit OTP
        Dim rand As New Random()
        generatedOTP = rand.Next(100000, 999999).ToString()

        Try
            ' Gmail SMTP configuration with App Password
            Dim myEmail As String = "juliosofiotare@gmail.com"
            Dim myAppPassword As String = "suivjwqpmnwpayaz"

            Dim mail As New MailMessage(myEmail, targetEmail)
            mail.Subject = "TrabahoLocal - Password Reset OTP"
            mail.Body = "Your One-Time Password for resetting your password is: " & generatedOTP

            Dim smtp As New SmtpClient("smtp.gmail.com")
            smtp.Port = 587
            smtp.EnableSsl = True
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network
            smtp.UseDefaultCredentials = False
            smtp.Credentials = New System.Net.NetworkCredential(myEmail, myAppPassword)

            smtp.Send(mail)
            MsgBox("OTP sent to your email!", MsgBoxStyle.Information)

            ' Move to Step 2 UI
            pnlStep1.Enabled = False
            pnlStep2.Visible = True

        Catch ex As Exception
            MsgBox("Error sending email: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    ' --- STEP 2: Verify OTP ---
    Private Sub btnVerifyOTP_Click(sender As Object, e As EventArgs) Handles btnVerifyOTP.Click
        If txtInputOTP.Text = generatedOTP Then
            MsgBox("OTP Verified! Please set your new password.", MsgBoxStyle.Information)
            pnlStep2.Enabled = False
            pnlStep3.Visible = True
        Else
            MsgBox("Invalid OTP. Please check your email again.", MsgBoxStyle.Critical)
        End If
    End Sub

    ' --- STEP 3: Reset Password ---
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        If txtNewPass.Text.Length < 6 Then
            MsgBox("Password must be at least 6 characters.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        ' --- ACTUAL DATABASE UPDATE ---
        Try
            openConn()
            ' Update the password for the matching email in tblusers
            Dim query As String = "UPDATE tblusers SET Password = @newpass WHERE Email = @email"
            Dim cmd As New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@newpass", txtNewPass.Text)
            cmd.Parameters.AddWithValue("@email", targetEmail)

            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MsgBox("Password updated successfully! You can now log in.", MsgBoxStyle.Information, "Success")
                Dim login As New frmLogin()
                login.Show()
                Me.Close()
            Else
                MsgBox("Error: Could not update the password. Email not found.", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox("Database error: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            closeConn()
        End Try
    End Sub

    ' --- BACK TO LOGIN ---
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim login As New frmLogin()
        login.Show()
        Me.Close()
    End Sub
End Class