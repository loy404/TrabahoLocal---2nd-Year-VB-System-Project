<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmViewApplication
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
        Me.lblApplicantName = New System.Windows.Forms.Label()
        Me.lblJobTitle = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.lblCoverLetterTitle = New System.Windows.Forms.Label()
        Me.txtCoverLetter = New System.Windows.Forms.TextBox()
        Me.btnViewProfile = New System.Windows.Forms.Button()
        Me.btnAccept = New System.Windows.Forms.Button()
        Me.btnReject = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.pnlHeader.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblDate)
        Me.pnlHeader.Controls.Add(Me.lblApplicantName)
        Me.pnlHeader.Controls.Add(Me.lblJobTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(800, 120)
        Me.pnlHeader.TabIndex = 0
        '
        'lblApplicantName
        '
        Me.lblApplicantName.AutoSize = True
        Me.lblApplicantName.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblApplicantName.ForeColor = System.Drawing.Color.White
        Me.lblApplicantName.Location = New System.Drawing.Point(40, 30)
        Me.lblApplicantName.Name = "lblApplicantName"
        Me.lblApplicantName.Size = New System.Drawing.Size(223, 37)
        Me.lblApplicantName.TabIndex = 0
        Me.lblApplicantName.Text = "Applicant Name"
        '
        'lblJobTitle
        '
        Me.lblJobTitle.AutoSize = True
        Me.lblJobTitle.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lblJobTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblJobTitle.Location = New System.Drawing.Point(43, 70)
        Me.lblJobTitle.Name = "lblJobTitle"
        Me.lblJobTitle.Size = New System.Drawing.Size(126, 20)
        Me.lblJobTitle.TabIndex = 1
        Me.lblJobTitle.Text = "Applied for: [Job]"
        '
        'lblDate
        '
        Me.lblDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblDate.ForeColor = System.Drawing.Color.Silver
        Me.lblDate.Location = New System.Drawing.Point(580, 40)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(180, 25)
        Me.lblDate.TabIndex = 2
        Me.lblDate.Text = "Date Applied"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlContent
        '
        Me.pnlContent.BackColor = System.Drawing.Color.White
        Me.pnlContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlContent.Controls.Add(Me.lblCoverLetterTitle)
        Me.pnlContent.Controls.Add(Me.txtCoverLetter)
        Me.pnlContent.Location = New System.Drawing.Point(45, 150)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(710, 320)
        Me.pnlContent.TabIndex = 1
        '
        'lblCoverLetterTitle
        '
        Me.lblCoverLetterTitle.AutoSize = True
        Me.lblCoverLetterTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblCoverLetterTitle.ForeColor = System.Drawing.Color.Gray
        Me.lblCoverLetterTitle.Location = New System.Drawing.Point(25, 20)
        Me.lblCoverLetterTitle.Name = "lblCoverLetterTitle"
        Me.lblCoverLetterTitle.Size = New System.Drawing.Size(117, 19)
        Me.lblCoverLetterTitle.TabIndex = 0
        Me.lblCoverLetterTitle.Text = "COVER LETTER / MESSAGE"
        '
        'txtCoverLetter
        '
        Me.txtCoverLetter.BackColor = System.Drawing.Color.White
        Me.txtCoverLetter.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCoverLetter.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtCoverLetter.Location = New System.Drawing.Point(30, 50)
        Me.txtCoverLetter.Multiline = True
        Me.txtCoverLetter.Name = "txtCoverLetter"
        Me.txtCoverLetter.ReadOnly = True
        Me.txtCoverLetter.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCoverLetter.Size = New System.Drawing.Size(650, 250)
        Me.txtCoverLetter.TabIndex = 1
        '
        'btnViewProfile
        '
        Me.btnViewProfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btnViewProfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnViewProfile.FlatAppearance.BorderSize = 0
        Me.btnViewProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewProfile.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnViewProfile.ForeColor = System.Drawing.Color.White
        Me.btnViewProfile.Location = New System.Drawing.Point(45, 500)
        Me.btnViewProfile.Name = "btnViewProfile"
        Me.btnViewProfile.Size = New System.Drawing.Size(180, 45)
        Me.btnViewProfile.TabIndex = 2
        Me.btnViewProfile.Text = "👤 View Full Profile"
        Me.btnViewProfile.UseVisualStyleBackColor = False
        '
        'btnAccept
        '
        Me.btnAccept.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnAccept.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAccept.FlatAppearance.BorderSize = 0
        Me.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccept.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnAccept.ForeColor = System.Drawing.Color.White
        Me.btnAccept.Location = New System.Drawing.Point(395, 500)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(170, 45)
        Me.btnAccept.TabIndex = 3
        Me.btnAccept.Text = "✔ Hire Applicant"
        Me.btnAccept.UseVisualStyleBackColor = False
        '
        'btnReject
        '
        Me.btnReject.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnReject.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReject.FlatAppearance.BorderSize = 0
        Me.btnReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReject.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnReject.ForeColor = System.Drawing.Color.White
        Me.btnReject.Location = New System.Drawing.Point(585, 500)
        Me.btnReject.Name = "btnReject"
        Me.btnReject.Size = New System.Drawing.Size(170, 45)
        Me.btnReject.TabIndex = 4
        Me.btnReject.Text = "❌ Reject Applicant"
        Me.btnReject.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Underline)
        Me.btnCancel.ForeColor = System.Drawing.Color.Gray
        Me.btnCancel.Location = New System.Drawing.Point(350, 560)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 35)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Close Viewer"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmViewApplication
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 620)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnReject)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.btnViewProfile)
        Me.Controls.Add(Me.pnlContent)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Name = "frmViewApplication"
        Me.Text = "Review Application"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlContent.ResumeLayout(False)
        Me.pnlContent.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblApplicantName As Label
    Friend WithEvents lblJobTitle As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents pnlContent As Panel
    Friend WithEvents lblCoverLetterTitle As Label
    Friend WithEvents txtCoverLetter As TextBox
    Friend WithEvents btnViewProfile As Button
    Friend WithEvents btnAccept As Button
    Friend WithEvents btnReject As Button
    Friend WithEvents btnCancel As Button
End Class