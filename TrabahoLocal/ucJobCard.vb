Imports System.Drawing
Imports System.Windows.Forms

Public Class ucJobCard
    Inherits UserControl

    ' UI Components
    Private pnlBackground As New Panel()
    Private lblTitle As New Label()
    Private lblLocation As New Label()
    Private lblSalary As New Label()
    Private lblDesc As New Label()
    Private WithEvents btnApply As New Button()

    ' Job Data
    Public Property JobID As Integer

    ' Event to tell the main dashboard when this specific card is clicked
    Public Event ApplyClicked(ByVal id As Integer, ByVal title As String)

    Public Sub New()
        ' Card Container Settings (Taller to stack text properly)
        Me.Size = New Size(830, 160)
        Me.BackColor = Color.FromArgb(245, 246, 248)
        Me.Padding = New Padding(5)
        Me.Margin = New Padding(0, 0, 0, 10)

        ' White Background Panel 
        pnlBackground.Dock = DockStyle.Fill
        pnlBackground.BackColor = Color.White
        pnlBackground.BorderStyle = BorderStyle.FixedSingle
        Me.Controls.Add(pnlBackground)

        ' Job Title (Top Left)
        lblTitle.Font = New Font("Segoe UI", 14, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(33, 37, 41)
        lblTitle.Location = New Point(20, 15)
        lblTitle.MaximumSize = New Size(630, 30) ' Prevent pushing into the button
        lblTitle.AutoEllipsis = True
        lblTitle.AutoSize = True
        pnlBackground.Controls.Add(lblTitle)

        ' Location (Under Title)
        lblLocation.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        lblLocation.ForeColor = Color.FromArgb(0, 123, 255) ' Blue
        lblLocation.Location = New Point(20, 45)
        lblLocation.AutoSize = True
        pnlBackground.Controls.Add(lblLocation)

        ' Salary (Under Location)
        lblSalary.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        lblSalary.ForeColor = Color.FromArgb(40, 167, 69) ' Green
        lblSalary.Location = New Point(20, 70)
        lblSalary.AutoSize = True
        pnlBackground.Controls.Add(lblSalary)

        ' Description (Under Salary, spanning the width)
        lblDesc.Font = New Font("Segoe UI", 10, FontStyle.Regular)
        lblDesc.ForeColor = Color.FromArgb(108, 117, 125) ' Gray
        lblDesc.Location = New Point(20, 100)
        lblDesc.Size = New Size(630, 40) ' Strict boundaries
        lblDesc.AutoEllipsis = True      ' Adds "..." if it overflows!
        pnlBackground.Controls.Add(lblDesc)

        ' Apply Button (Centered on the Right Side)
        btnApply.Text = "Apply Now"
        btnApply.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        btnApply.BackColor = Color.FromArgb(0, 82, 204)
        btnApply.ForeColor = Color.White
        btnApply.FlatStyle = FlatStyle.Flat
        btnApply.FlatAppearance.BorderSize = 0
        btnApply.Size = New Size(120, 45)
        btnApply.Location = New Point(680, 50)
        btnApply.Cursor = Cursors.Hand
        pnlBackground.Controls.Add(btnApply)
    End Sub

    ' Method to populate the data from the database
    Public Sub SetJobData(id As Integer, title As String, loc As String, sal As String, desc As String)
        JobID = id
        lblTitle.Text = title
        lblLocation.Text = "📍 " & loc
        ' The "₱" sign is now handled before it gets here
        lblSalary.Text = sal
        lblDesc.Text = desc
    End Sub

    ' Handle Button Click inside the card
    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        RaiseEvent ApplyClicked(JobID, lblTitle.Text)
    End Sub

    Private Sub btnApply_MouseEnter(sender As Object, e As EventArgs) Handles btnApply.MouseEnter
        btnApply.BackColor = Color.FromArgb(51, 133, 255)
    End Sub
    Private Sub btnApply_MouseLeave(sender As Object, e As EventArgs) Handles btnApply.MouseLeave
        btnApply.BackColor = Color.FromArgb(0, 82, 204)
    End Sub
End Class