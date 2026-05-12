Imports System.Drawing
Imports System.Drawing.Imaging
Imports MySql.Data.MySqlClient

Public Class frmReceipt
    ' This is passed from the Dashboard when the form opens
    Public Property TargetApplicationID As Integer

    Private Sub frmReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            openConn()

            ' ERP FINANCE: Pull the complete audit trail for this specific job
            Dim query As String = "SELECT t.TransactionID, t.TransactionDate, t.AmountPaid, " &
                                  "j.JobTitle, uE.FullName AS 'Employer', uW.FullName AS 'Worker' " &
                                  "FROM tblTransactions t " &
                                  "JOIN tblApplications a ON t.ApplicationID = a.ApplicationID " &
                                  "JOIN tbljobs j ON a.JobID = j.JobID " &
                                  "JOIN tblemployeers emp ON t.EmployerID = emp.EmployeerID " &
                                  "JOIN tblusers uE ON emp.UserID = uE.UserID " &
                                  "JOIN tblworkers wrk ON t.WorkerID = wrk.WorkerID " &
                                  "JOIN tblusers uW ON wrk.UserID = uW.UserID " &
                                  "WHERE t.ApplicationID = @appID"

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@appID", TargetApplicationID)

            Using reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    ' Populate the visual receipt
                    lblDate.Text = Convert.ToDateTime(reader("TransactionDate")).ToString("yyyy-MM-dd HH:mm")
                    lblTransID.Text = "TXN-" & reader("TransactionID").ToString().PadLeft(6, "0"c)
                    lblJobTitle.Text = reader("JobTitle").ToString()
                    lblEmployer.Text = reader("Employer").ToString()
                    lblWorker.Text = reader("Worker").ToString()

                    Dim amount As Decimal = Convert.ToDecimal(reader("AmountPaid"))
                    lblTotal.Text = "₱ " & amount.ToString("N2")
                Else
                    MsgBox("Error: Could not find a finalized financial transaction for this job. Make sure the employer has clicked 'Issue Payment' first.", MsgBoxStyle.Exclamation)
                    Me.Close()
                End If
            End Using
        Catch ex As Exception
            MsgBox("Receipt Generation Error: " & ex.Message)
            Me.Close()
        Finally
            closeConn()
        End Try
    End Sub

    ' --- ACTION: Take a Screenshot of the Panel and Save as PNG ---
    Private Sub btnDownload_Click(sender As Object, e As EventArgs) Handles btnDownload.Click
        Try
            ' 1. Create a blank image exactly the size of our paper panel
            Dim receiptBitmap As New Bitmap(pnlReceipt.Width, pnlReceipt.Height)

            ' 2. Draw the panel onto the image
            pnlReceipt.DrawToBitmap(receiptBitmap, New Rectangle(0, 0, receiptBitmap.Width, receiptBitmap.Height))

            ' 3. Ask the user where they want to save it
            Dim sfd As New SaveFileDialog()
            sfd.Filter = "PNG Image (*.png)|*.png"
            sfd.FileName = "TrabahoLocal_" & lblTransID.Text & ".png"

            If sfd.ShowDialog() = DialogResult.OK Then
                receiptBitmap.Save(sfd.FileName, ImageFormat.Png)
                MsgBox("Receipt downloaded successfully!", MsgBoxStyle.Information, "Saved")
            End If

            receiptBitmap.Dispose()
        Catch ex As Exception
            MsgBox("Error saving receipt: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class