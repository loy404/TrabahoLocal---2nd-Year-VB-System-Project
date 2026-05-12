Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class JobManager

    ' ==========================================
    ' ERP LOGIC: Apply For Job (Worker)
    ' ==========================================
    Public Shared Function ApplyForJob(jobID As Integer, currentUserID As Integer, coverLetter As String) As Boolean
        Try
            openConn()
            Dim queryWorker As String = "SELECT WorkerID FROM tblworkers WHERE UserID = @uid"
            Dim cmdWorker As New MySqlCommand(queryWorker, conn)
            cmdWorker.Parameters.AddWithValue("@uid", currentUserID)
            Dim workerID As Integer = Convert.ToInt32(cmdWorker.ExecuteScalar())

            Dim query As String = "INSERT INTO tblApplications (JobID, WorkerID, ApplicationDate, Status, CoverLetter) VALUES (@jobID, @workerID, @date, 'Pending', @message)"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@jobID", jobID)
            cmd.Parameters.AddWithValue("@workerID", workerID)
            cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
            cmd.Parameters.AddWithValue("@message", coverLetter)

            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox("Error applying for job: " & ex.Message, MsgBoxStyle.Critical)
            Return False
        Finally
            closeConn()
        End Try
    End Function

    ' ==========================================
    ' ERP LOGIC: Update Application Status & Auto-Close Jobs (Employer)
    ' ==========================================
    Public Shared Function UpdateApplicationStatus(appID As Integer, newStatus As String) As Boolean
        Try
            openConn()
            Dim query As String = "UPDATE tblApplications SET Status = @status WHERE ApplicationID = @id"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@status", newStatus)
            cmd.Parameters.AddWithValue("@id", appID)
            cmd.ExecuteNonQuery()

            If newStatus = "Accepted" Then
                Dim queryGetJob As String = "SELECT JobID FROM tblApplications WHERE ApplicationID = @appId"
                Dim cmdGetJob As New MySqlCommand(queryGetJob, conn)
                cmdGetJob.Parameters.AddWithValue("@appId", appID)
                Dim relatedJobID As Integer = Convert.ToInt32(cmdGetJob.ExecuteScalar())

                Dim queryCloseJob As String = "UPDATE tbljobs SET Status = 'Filled' WHERE JobID = @jobId"
                Dim cmdCloseJob As New MySqlCommand(queryCloseJob, conn)
                cmdCloseJob.Parameters.AddWithValue("@jobId", relatedJobID)
                cmdCloseJob.ExecuteNonQuery()

                Dim queryRejectOthers As String = "UPDATE tblApplications SET Status = 'Rejected' WHERE JobID = @jobId AND ApplicationID <> @appId AND Status = 'Pending'"
                Dim cmdRejectOthers As New MySqlCommand(queryRejectOthers, conn)
                cmdRejectOthers.Parameters.AddWithValue("@jobId", relatedJobID)
                cmdRejectOthers.Parameters.AddWithValue("@appId", appID)
                cmdRejectOthers.ExecuteNonQuery()
            End If

            Return True
        Catch ex As Exception
            MsgBox("Error updating status: " & ex.Message, MsgBoxStyle.Critical)
            Return False
        Finally
            closeConn()
        End Try
    End Function

    ' ==========================================
    ' ERP LOGIC: Complete Job (Worker)
    ' ==========================================
    Public Shared Function CompleteJob(appID As Integer) As Boolean
        Return UpdateApplicationStatus(appID, "Completed")
    End Function

    ' ==========================================
    ' ERP LOGIC: Finalize Job (Saves Review)
    ' ==========================================
    Public Shared Function FinalizeAndPay(appID As Integer, rating As Integer, comments As String) As Boolean
        Try
            openConn()
            ' HR MODULE: Save Performance Feedback
            ' We keep this focused ONLY on the Review so it doesn't double-pay the worker!
            Dim queryReview As String = "INSERT INTO tblReviews (ApplicationID, Rating, Comments, ReviewDate) VALUES (@appID, @rating, @comments, NOW())"
            Dim cmdReview As New MySqlCommand(queryReview, conn)
            cmdReview.Parameters.AddWithValue("@appID", appID)
            cmdReview.Parameters.AddWithValue("@rating", rating)
            cmdReview.Parameters.AddWithValue("@comments", comments)
            cmdReview.ExecuteNonQuery()

            ' Note: The Application Status is usually updated to 'Closed' in the Dashboard 
            ' during the Payment step. We just return True here to confirm the review is saved.
            Return True
        Catch ex As Exception
            MsgBox("Review Submission Error: " & ex.Message)
            Return False
        Finally
            closeConn()
        End Try
    End Function

    ' ==========================================
    ' ERP LOGIC: Post a New Job (Employer)
    ' ==========================================
    Public Shared Function PostNewJob(userID As Integer, jobTitle As String, location As String, payType As String, rateOrSalary As String, description As String) As Boolean
        Try
            openConn()
            Dim empCmd As New MySqlCommand("SELECT EmployeerID FROM tblemployeers WHERE UserID = @uid", conn)
            empCmd.Parameters.AddWithValue("@uid", userID)
            Dim empID As Integer = Convert.ToInt32(empCmd.ExecuteScalar())

            Dim isFixed As Boolean = (payType = "Fixed")
            Dim salary As Decimal = 0
            Dim payRate As Decimal = 0

            If isFixed Then
                salary = Convert.ToDecimal(rateOrSalary)
            Else
                payRate = Convert.ToDecimal(rateOrSalary)
            End If

            Dim query As String = "INSERT INTO tbljobs (EmployeerID, JobTitle, Location, PayType, PayRate, Salary, Description, Status) " &
                                  "VALUES (@emp, @title, @loc, @ptype, @prate, @sal, @desc, 'Open')"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@emp", empID)
            cmd.Parameters.AddWithValue("@title", jobTitle)
            cmd.Parameters.AddWithValue("@loc", location)
            cmd.Parameters.AddWithValue("@ptype", payType)
            cmd.Parameters.AddWithValue("@prate", payRate)
            cmd.Parameters.AddWithValue("@sal", salary)
            cmd.Parameters.AddWithValue("@desc", description)

            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox("Error posting job: " & ex.Message, MsgBoxStyle.Critical)
            Return False
        Finally
            closeConn()
        End Try
    End Function

End Class