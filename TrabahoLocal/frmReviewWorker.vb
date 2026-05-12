Public Class frmReviewWorker
    ' The Employer Dashboard passes these values before opening the form
    Public SelectedAppID As Integer
    Public WorkerName As String

    Private Sub frmReviewWorker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWorkerName.Text = "Leave Feedback for: " & WorkerName
        cmbRating.SelectedIndex = 0 ' Default to 5 Stars
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' 1. Validation
        If txtComments.Text.Trim() = "" Then
            MsgBox("Please write a short review or feedback comment for the worker.", MsgBoxStyle.Exclamation)
            txtComments.Focus()
            Exit Sub
        End If

        ' 2. Extract the actual Number (1-5) from the Dropdown selection
        ' e.g., "5 - ⭐⭐⭐⭐⭐ (Excellent)" -> grabs just the "5"
        Dim rawRatingString As String = cmbRating.SelectedItem.ToString()
        Dim numericRating As Integer = Convert.ToInt32(rawRatingString.Substring(0, 1))

        ' 3. Call the ERP JobManager to Finalize!
        If JobManager.FinalizeAndPay(SelectedAppID, numericRating, txtComments.Text.Trim()) Then
            MsgBox("Review submitted successfully! The contract is now officially closed.", MsgBoxStyle.Information, "Project Finalized")

            ' Tell the Employer Dashboard that it was successful so it can refresh the UI
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    ' Hover effect for the submit button
    Private Sub btnSubmit_MouseEnter(sender As Object, e As EventArgs) Handles btnSubmit.MouseEnter
        btnSubmit.BackColor = Drawing.Color.FromArgb(33, 136, 56)
    End Sub
    Private Sub btnSubmit_MouseLeave(sender As Object, e As EventArgs) Handles btnSubmit.MouseLeave
        btnSubmit.BackColor = Drawing.Color.FromArgb(40, 167, 69)
    End Sub

End Class