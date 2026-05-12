Imports MySql.Data.MySqlClient

Public Class frmApplyJob
    ' We will pass this ID from the Dashboard when the user clicks "Apply Now"
    Public TargetJobID As Integer

    Private Sub frmApplyJob_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadJobDetails()
    End Sub

    Private Sub LoadJobDetails()
        Try
            openConn()
            Dim query As String = "SELECT j.JobTitle, j.Salary, j.Location, e.FullName AS EmployerName " &
                                  "FROM tbljobs j " &
                                  "JOIN tblemployeers e ON j.EmployeerID = e.EmployeerID " &
                                  "WHERE j.JobID = @jid"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@jid", TargetJobID)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                lblJobTitle.Text = reader("JobTitle").ToString()
                lblEmployerName.Text = reader("EmployerName").ToString()
                lblSalary.Text = "₱ " & reader("Salary").ToString()
                lblLocation.Text = reader("Location").ToString()

                ' Pre-fill the subject line automatically!
                txtSubject.Text = "Application for " & reader("JobTitle").ToString()
            End If
            reader.Close()
        Catch ex As Exception
            MsgBox("Error loading job details: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            closeConn()
        End Try
    End Sub

    Private Sub btnSendEmail_Click(sender As Object, e As EventArgs) Handles btnSendEmail.Click
        If txtMessage.Text.Trim() = "" Then
            MsgBox("Please write a cover letter or message to the employer.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        ' UPDATE: Pass the txtMessage.Text as the 3rd parameter to JobManager!
        If JobManager.ApplyForJob(TargetJobID, CurrentUserID, txtMessage.Text) Then
            MsgBox("Your application has been successfully sent to the employer!", MsgBoxStyle.Information, "Application Sent")
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    ' Hover effect for the green button
    Private Sub btnSendEmail_MouseEnter(sender As Object, e As EventArgs) Handles btnSendEmail.MouseEnter
        btnSendEmail.BackColor = Drawing.Color.FromArgb(85, 160, 60)
    End Sub
    Private Sub btnSendEmail_MouseLeave(sender As Object, e As EventArgs) Handles btnSendEmail.MouseLeave
        btnSendEmail.BackColor = Drawing.Color.FromArgb(106, 190, 80)
    End Sub
End Class