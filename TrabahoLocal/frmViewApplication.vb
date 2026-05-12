Imports MySql.Data.MySqlClient

Public Class frmViewApplication
    Public SelectedAppID As Integer
    Private SelectedWorkerUserID As Integer

    Private Sub frmViewApplication_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadApplicationDetails()
    End Sub

    Private Sub LoadApplicationDetails()
        Try
            openConn()
            ' FIX: Added a.Status to the query so we know if it's already closed/rejected
            Dim query As String = "SELECT w.FullName, w.UserID, j.JobTitle, a.ApplicationDate, a.CoverLetter, a.Status " &
                                  "FROM tblApplications a " &
                                  "JOIN tblworkers w ON a.WorkerID = w.WorkerID " &
                                  "JOIN tbljobs j ON a.JobID = j.JobID " &
                                  "WHERE a.ApplicationID = @appID"

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@appID", SelectedAppID)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                lblApplicantName.Text = reader("FullName").ToString()
                lblJobTitle.Text = "Applied for: " & reader("JobTitle").ToString()
                lblDate.Text = Convert.ToDateTime(reader("ApplicationDate")).ToString("MMM dd, yyyy")
                
                ' We grab the UserID here so we can use it to send notifications later!
                SelectedWorkerUserID = Convert.ToInt32(reader("UserID"))

                ' ==================================================
                ' ERP SECURITY LOCK: Hide buttons if already processed
                ' ==================================================
                Dim currentStatus As String = reader("Status").ToString()
                If currentStatus <> "Pending" Then
                    btnAccept.Visible = False
                    btnReject.Visible = False
                Else
                    btnAccept.Visible = True
                    btnReject.Visible = True
                End If

                ' Load the cover letter. If empty, show a default message.
                Dim coverText As String = reader("CoverLetter").ToString()
                If String.IsNullOrWhiteSpace(coverText) Then
                    txtCoverLetter.Text = "This applicant did not provide a cover letter."
                    txtCoverLetter.ForeColor = Drawing.Color.Gray
                Else
                    txtCoverLetter.Text = coverText
                    txtCoverLetter.ForeColor = Drawing.Color.Black
                End If
            End If
            reader.Close()

        Catch ex As Exception
            MsgBox("Error loading application: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            closeConn()
        End Try
    End Sub

    ' --- OPEN WORKER RESUME ---
    Private Sub btnViewProfile_Click(sender As Object, e As EventArgs) Handles btnViewProfile.Click
        Dim profileForm As New frmWorkerProfile()
        profileForm.IsViewOnly = True
        profileForm.ViewOnlyUserID = SelectedWorkerUserID
        profileForm.ShowDialog()
    End Sub

    ' --- HIRE THE WORKER ---
    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        Dim confirm As DialogResult = MsgBox("Are you sure you want to HIRE " & lblApplicantName.Text & "?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Confirm Hire")
        If confirm = DialogResult.Yes Then
            If JobManager.UpdateApplicationStatus(SelectedAppID, "Accepted") Then

                ' ==================================================
                ' ERP NOTIFICATION: Tell the worker they got hired!
                ' ==================================================
                NotificationManager.Send(SelectedWorkerUserID, "Great news! Your application was accepted after review. You are officially hired!")

                MsgBox("Success! You have officially hired " & lblApplicantName.Text & ".", MsgBoxStyle.Information)
                Me.DialogResult = DialogResult.OK
                Me.Close()
            End If
        End If
    End Sub

    ' --- REJECT THE WORKER ---
    Private Sub btnReject_Click(sender As Object, e As EventArgs) Handles btnReject.Click
        Dim confirm As DialogResult = MsgBox("Are you sure you want to REJECT this application?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Confirm Rejection")
        If confirm = DialogResult.Yes Then
            If JobManager.UpdateApplicationStatus(SelectedAppID, "Rejected") Then

                ' ==================================================
                ' ERP NOTIFICATION: Let the worker know gently.
                ' ==================================================
                NotificationManager.Send(SelectedWorkerUserID, "Update: The employer has reviewed your cover letter and decided to move forward with other candidates.")

                MsgBox("Application rejected.", MsgBoxStyle.Information)
                Me.DialogResult = DialogResult.OK
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmViewApplication_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested

    End Sub
End Class