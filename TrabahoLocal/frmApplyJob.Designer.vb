<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmApplyJob
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblJobTitle = New System.Windows.Forms.Label()
        Me.lblEmployerName = New System.Windows.Forms.Label()
        Me.pnlStats = New System.Windows.Forms.Panel()
        Me.lblSalaryTitle = New System.Windows.Forms.Label()
        Me.lblSalary = New System.Windows.Forms.Label()
        Me.lblLocationTitle = New System.Windows.Forms.Label()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.pnlForm = New System.Windows.Forms.Panel()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.pnlWarning = New System.Windows.Forms.Panel()
        Me.lblWarning = New System.Windows.Forms.Label()
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.btnSendEmail = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.pnlHeader.SuspendLayout()
        Me.pnlStats.SuspendLayout()
        Me.pnlForm.SuspendLayout()
        Me.pnlWarning.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblJobTitle)
        Me.pnlHeader.Controls.Add(Me.lblEmployerName)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(850, 160)
        Me.pnlHeader.TabIndex = 0
        '
        'lblJobTitle
        '
        Me.lblJobTitle.AutoSize = True
        Me.lblJobTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblJobTitle.ForeColor = System.Drawing.Color.White
        Me.lblJobTitle.Location = New System.Drawing.Point(50, 40)
        Me.lblJobTitle.Name = "lblJobTitle"
        Me.lblJobTitle.Size = New System.Drawing.Size(117, 32)
        Me.lblJobTitle.TabIndex = 0
        Me.lblJobTitle.Text = "Job Title"
        '
        'lblEmployerName
        '
        Me.lblEmployerName.AutoSize = True
        Me.lblEmployerName.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblEmployerName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblEmployerName.Location = New System.Drawing.Point(52, 75)
        Me.lblEmployerName.Name = "lblEmployerName"
        Me.lblEmployerName.Size = New System.Drawing.Size(124, 21)
        Me.lblEmployerName.TabIndex = 1
        Me.lblEmployerName.Text = "Employer Name"
        '
        'pnlStats
        '
        Me.pnlStats.BackColor = System.Drawing.Color.White
        Me.pnlStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlStats.Controls.Add(Me.lblSalaryTitle)
        Me.pnlStats.Controls.Add(Me.lblSalary)
        Me.pnlStats.Controls.Add(Me.lblLocationTitle)
        Me.pnlStats.Controls.Add(Me.lblLocation)
        Me.pnlStats.Location = New System.Drawing.Point(50, 120)
        Me.pnlStats.Name = "pnlStats"
        Me.pnlStats.Size = New System.Drawing.Size(750, 80)
        Me.pnlStats.TabIndex = 1
        '
        'lblSalaryTitle
        '
        Me.lblSalaryTitle.AutoSize = True
        Me.lblSalaryTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSalaryTitle.ForeColor = System.Drawing.Color.Gray
        Me.lblSalaryTitle.Location = New System.Drawing.Point(50, 20)
        Me.lblSalaryTitle.Name = "lblSalaryTitle"
        Me.lblSalaryTitle.Size = New System.Drawing.Size(51, 15)
        Me.lblSalaryTitle.TabIndex = 0
        Me.lblSalaryTitle.Text = "SALARY"
        '
        'lblSalary
        '
        Me.lblSalary.AutoSize = True
        Me.lblSalary.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblSalary.Location = New System.Drawing.Point(50, 40)
        Me.lblSalary.Name = "lblSalary"
        Me.lblSalary.Size = New System.Drawing.Size(56, 21)
        Me.lblSalary.TabIndex = 1
        Me.lblSalary.Text = "₱0.00"
        '
        'lblLocationTitle
        '
        Me.lblLocationTitle.AutoSize = True
        Me.lblLocationTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblLocationTitle.ForeColor = System.Drawing.Color.Gray
        Me.lblLocationTitle.Location = New System.Drawing.Point(350, 20)
        Me.lblLocationTitle.Name = "lblLocationTitle"
        Me.lblLocationTitle.Size = New System.Drawing.Size(66, 15)
        Me.lblLocationTitle.TabIndex = 2
        Me.lblLocationTitle.Text = "LOCATION"
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblLocation.Location = New System.Drawing.Point(350, 40)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(69, 21)
        Me.lblLocation.TabIndex = 3
        Me.lblLocation.Text = "Location"
        '
        'pnlForm
        '
        Me.pnlForm.BackColor = System.Drawing.Color.White
        Me.pnlForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlForm.Controls.Add(Me.lblFormTitle)
        Me.pnlForm.Controls.Add(Me.pnlWarning)
        Me.pnlForm.Controls.Add(Me.lblSubject)
        Me.pnlForm.Controls.Add(Me.txtSubject)
        Me.pnlForm.Controls.Add(Me.lblMessage)
        Me.pnlForm.Controls.Add(Me.txtMessage)
        Me.pnlForm.Controls.Add(Me.btnSendEmail)
        Me.pnlForm.Controls.Add(Me.btnCancel)
        Me.pnlForm.Location = New System.Drawing.Point(50, 220)
        Me.pnlForm.Name = "pnlForm"
        Me.pnlForm.Size = New System.Drawing.Size(750, 520)
        Me.pnlForm.TabIndex = 2
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular)
        Me.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.lblFormTitle.Location = New System.Drawing.Point(30, 20)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(161, 30)
        Me.lblFormTitle.TabIndex = 0
        Me.lblFormTitle.Text = "Job Application"
        '
        'pnlWarning
        '
        Me.pnlWarning.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.pnlWarning.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlWarning.Controls.Add(Me.lblWarning)
        Me.pnlWarning.Location = New System.Drawing.Point(35, 70)
        Me.pnlWarning.Name = "pnlWarning"
        Me.pnlWarning.Size = New System.Drawing.Size(680, 45)
        Me.pnlWarning.TabIndex = 1
        '
        'lblWarning
        '
        Me.lblWarning.AutoSize = True
        Me.lblWarning.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblWarning.ForeColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.lblWarning.Location = New System.Drawing.Point(15, 14)
        Me.lblWarning.Name = "lblWarning"
        Me.lblWarning.Size = New System.Drawing.Size(593, 15)
        Me.lblWarning.TabIndex = 0
        Me.lblWarning.Text = "Mass applying for jobs is not effective. Read the job post and follow instructions carefully to stand out."
        '
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular)
        Me.lblSubject.ForeColor = System.Drawing.Color.DimGray
        Me.lblSubject.Location = New System.Drawing.Point(35, 140)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(64, 15)
        Me.lblSubject.TabIndex = 2
        Me.lblSubject.Text = "SUBJECT *"
        '
        'txtSubject
        '
        Me.txtSubject.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.txtSubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSubject.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtSubject.Location = New System.Drawing.Point(35, 160)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(680, 27)
        Me.txtSubject.TabIndex = 3
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular)
        Me.lblMessage.ForeColor = System.Drawing.Color.DimGray
        Me.lblMessage.Location = New System.Drawing.Point(35, 210)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(262, 15)
        Me.lblMessage.TabIndex = 4
        Me.lblMessage.Text = "COVER LETTER / MESSAGE TO EMPLOYER *"
        '
        'txtMessage
        '
        Me.txtMessage.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMessage.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtMessage.Location = New System.Drawing.Point(35, 230)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(680, 180)
        Me.txtMessage.TabIndex = 5
        '
        'btnSendEmail
        '
        Me.btnSendEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnSendEmail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSendEmail.FlatAppearance.BorderSize = 0
        Me.btnSendEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSendEmail.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnSendEmail.ForeColor = System.Drawing.Color.White
        Me.btnSendEmail.Location = New System.Drawing.Point(35, 440)
        Me.btnSendEmail.Name = "btnSendEmail"
        Me.btnSendEmail.Size = New System.Drawing.Size(200, 45)
        Me.btnSendEmail.TabIndex = 6
        Me.btnSendEmail.Text = "✉ SEND APPLICATION"
        Me.btnSendEmail.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Underline)
        Me.btnCancel.ForeColor = System.Drawing.Color.Gray
        Me.btnCancel.Location = New System.Drawing.Point(250, 440)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 45)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'frmApplyJob
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(850, 780)
        Me.Controls.Add(Me.pnlStats)
        Me.Controls.Add(Me.pnlForm)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Name = "frmApplyJob"
        Me.Text = "Submit Application"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlStats.ResumeLayout(False)
        Me.pnlStats.PerformLayout()
        Me.pnlForm.ResumeLayout(False)
        Me.pnlForm.PerformLayout()
        Me.pnlWarning.ResumeLayout(False)
        Me.pnlWarning.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblJobTitle As Label
    Friend WithEvents lblEmployerName As Label
    Friend WithEvents pnlStats As Panel
    Friend WithEvents lblSalaryTitle As Label
    Friend WithEvents lblSalary As Label
    Friend WithEvents lblLocationTitle As Label
    Friend WithEvents lblLocation As Label
    Friend WithEvents pnlForm As Panel
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents pnlWarning As Panel
    Friend WithEvents lblWarning As Label
    Friend WithEvents lblSubject As Label
    Friend WithEvents txtSubject As TextBox
    Friend WithEvents lblMessage As Label
    Friend WithEvents txtMessage As TextBox
    Friend WithEvents btnSendEmail As Button
    Friend WithEvents btnCancel As Button
End Class