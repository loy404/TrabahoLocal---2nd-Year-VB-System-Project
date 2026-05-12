<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmWorkerProfile
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
        Me.pnlBanner = New System.Windows.Forms.Panel()
        Me.lblVerificationStatus = New System.Windows.Forms.Label()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.picProfile = New System.Windows.Forms.PictureBox()
        Me.btnUploadPic = New System.Windows.Forms.Button()
        Me.btnUploadID = New System.Windows.Forms.Button()
        Me.btnUploadResume = New System.Windows.Forms.Button()
        Me.lblFileName = New System.Windows.Forms.Label()
        Me.lblHeadlineTitle = New System.Windows.Forms.Label()
        Me.txtHeadline = New System.Windows.Forms.TextBox()
        Me.lblSalaryTitle = New System.Windows.Forms.Label()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.lblEducationTitle = New System.Windows.Forms.Label()
        Me.txtEducation = New System.Windows.Forms.TextBox()
        Me.lblSkills = New System.Windows.Forms.Label()
        Me.txtSkills = New System.Windows.Forms.TextBox()
        Me.lblExperience = New System.Windows.Forms.Label()
        Me.txtExperience = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlBanner.SuspendLayout()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlBanner
        '
        Me.pnlBanner.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.pnlBanner.Controls.Add(Me.lblVerificationStatus)
        Me.pnlBanner.Controls.Add(Me.lblFullName)
        Me.pnlBanner.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlBanner.Location = New System.Drawing.Point(0, 0)
        Me.pnlBanner.Name = "pnlBanner"
        Me.pnlBanner.Size = New System.Drawing.Size(950, 180)
        Me.pnlBanner.TabIndex = 0
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lblFullName.ForeColor = System.Drawing.Color.White
        Me.lblFullName.Location = New System.Drawing.Point(260, 70)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(437, 45)
        Me.lblFullName.TabIndex = 0
        Me.lblFullName.Text = "Julio Sofio Villafuerte Tare"
        '
        'lblVerificationStatus
        '
        Me.lblVerificationStatus.AutoSize = True
        Me.lblVerificationStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.lblVerificationStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblVerificationStatus.ForeColor = System.Drawing.Color.White
        Me.lblVerificationStatus.Location = New System.Drawing.Point(265, 125)
        Me.lblVerificationStatus.Name = "lblVerificationStatus"
        Me.lblVerificationStatus.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.lblVerificationStatus.Size = New System.Drawing.Size(110, 29)
        Me.lblVerificationStatus.TabIndex = 12
        Me.lblVerificationStatus.Text = "✔ Verified"
        Me.lblVerificationStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picProfile
        '
        Me.picProfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.picProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picProfile.Location = New System.Drawing.Point(50, 90)
        Me.picProfile.Name = "picProfile"
        Me.picProfile.Size = New System.Drawing.Size(180, 180)
        Me.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picProfile.TabIndex = 10
        Me.picProfile.TabStop = False
        '
        'btnUploadPic
        '
        Me.btnUploadPic.BackColor = System.Drawing.Color.White
        Me.btnUploadPic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUploadPic.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnUploadPic.FlatAppearance.BorderSize = 2
        Me.btnUploadPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUploadPic.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnUploadPic.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnUploadPic.Location = New System.Drawing.Point(50, 290)
        Me.btnUploadPic.Name = "btnUploadPic"
        Me.btnUploadPic.Size = New System.Drawing.Size(180, 40)
        Me.btnUploadPic.TabIndex = 11
        Me.btnUploadPic.Text = "EDIT PROFILE PHOTO"
        Me.btnUploadPic.UseVisualStyleBackColor = False
        '
        'btnUploadID
        '
        Me.btnUploadID.BackColor = System.Drawing.Color.White
        Me.btnUploadID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUploadID.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnUploadID.FlatAppearance.BorderSize = 2
        Me.btnUploadID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUploadID.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnUploadID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnUploadID.Location = New System.Drawing.Point(50, 340)
        Me.btnUploadID.Name = "btnUploadID"
        Me.btnUploadID.Size = New System.Drawing.Size(180, 40)
        Me.btnUploadID.TabIndex = 13
        Me.btnUploadID.Text = "ID VERIFICATION"
        Me.btnUploadID.UseVisualStyleBackColor = False
        '
        'btnUploadResume
        '
        Me.btnUploadResume.BackColor = System.Drawing.Color.White
        Me.btnUploadResume.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUploadResume.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnUploadResume.FlatAppearance.BorderSize = 2
        Me.btnUploadResume.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUploadResume.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnUploadResume.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnUploadResume.Location = New System.Drawing.Point(50, 390)
        Me.btnUploadResume.Name = "btnUploadResume"
        Me.btnUploadResume.Size = New System.Drawing.Size(180, 40)
        Me.btnUploadResume.TabIndex = 6
        Me.btnUploadResume.Text = "UPLOAD RESUME"
        Me.btnUploadResume.UseVisualStyleBackColor = False
        '
        'lblFileName
        '
        Me.lblFileName.AutoSize = True
        Me.lblFileName.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Italic)
        Me.lblFileName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.lblFileName.Location = New System.Drawing.Point(50, 435)
        Me.lblFileName.Name = "lblFileName"
        Me.lblFileName.Size = New System.Drawing.Size(81, 13)
        Me.lblFileName.TabIndex = 7
        Me.lblFileName.Text = "No file selected."
        '
        'lblHeadlineTitle
        '
        Me.lblHeadlineTitle.AutoSize = True
        Me.lblHeadlineTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeadlineTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lblHeadlineTitle.Location = New System.Drawing.Point(265, 200)
        Me.lblHeadlineTitle.Name = "lblHeadlineTitle"
        Me.lblHeadlineTitle.Size = New System.Drawing.Size(135, 15)
        Me.lblHeadlineTitle.TabIndex = 21
        Me.lblHeadlineTitle.Text = "PROFESSIONAL TITLE"
        '
        'txtHeadline
        '
        Me.txtHeadline.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtHeadline.Location = New System.Drawing.Point(265, 220)
        Me.txtHeadline.Name = "txtHeadline"
        Me.txtHeadline.Size = New System.Drawing.Size(630, 27)
        Me.txtHeadline.TabIndex = 22
        '
        'lblSalaryTitle
        '
        Me.lblSalaryTitle.AutoSize = True
        Me.lblSalaryTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSalaryTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lblSalaryTitle.Location = New System.Drawing.Point(265, 260)
        Me.lblSalaryTitle.Name = "lblSalaryTitle"
        Me.lblSalaryTitle.Size = New System.Drawing.Size(51, 15)
        Me.lblSalaryTitle.TabIndex = 23
        Me.lblSalaryTitle.Text = "SALARY"
        '
        'txtSalary
        '
        Me.txtSalary.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtSalary.Location = New System.Drawing.Point(265, 280)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(630, 27)
        Me.txtSalary.TabIndex = 24
        '
        'lblEducationTitle
        '
        Me.lblEducationTitle.AutoSize = True
        Me.lblEducationTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblEducationTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lblEducationTitle.Location = New System.Drawing.Point(265, 320)
        Me.lblEducationTitle.Name = "lblEducationTitle"
        Me.lblEducationTitle.Size = New System.Drawing.Size(75, 15)
        Me.lblEducationTitle.TabIndex = 25
        Me.lblEducationTitle.Text = "EDUCATION"
        '
        'txtEducation
        '
        Me.txtEducation.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtEducation.Location = New System.Drawing.Point(265, 340)
        Me.txtEducation.Name = "txtEducation"
        Me.txtEducation.Size = New System.Drawing.Size(630, 27)
        Me.txtEducation.TabIndex = 26
        '
        'lblSkills
        '
        Me.lblSkills.AutoSize = True
        Me.lblSkills.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSkills.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lblSkills.Location = New System.Drawing.Point(265, 380)
        Me.lblSkills.Name = "lblSkills"
        Me.lblSkills.Size = New System.Drawing.Size(71, 15)
        Me.lblSkills.TabIndex = 1
        Me.lblSkills.Text = "TOP SKILLS"
        '
        'txtSkills
        '
        Me.txtSkills.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.txtSkills.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtSkills.Location = New System.Drawing.Point(265, 400)
        Me.txtSkills.Name = "txtSkills"
        Me.txtSkills.Size = New System.Drawing.Size(630, 25)
        Me.txtSkills.TabIndex = 2
        '
        'lblExperience
        '
        Me.lblExperience.AutoSize = True
        Me.lblExperience.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblExperience.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lblExperience.Location = New System.Drawing.Point(265, 440)
        Me.lblExperience.Name = "lblExperience"
        Me.lblExperience.Size = New System.Drawing.Size(114, 15)
        Me.lblExperience.TabIndex = 3
        Me.lblExperience.Text = "WORK EXPERIENCE"
        '
        'txtExperience
        '
        Me.txtExperience.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtExperience.Location = New System.Drawing.Point(265, 460)
        Me.txtExperience.Multiline = True
        Me.txtExperience.Name = "txtExperience"
        Me.txtExperience.Size = New System.Drawing.Size(630, 100)
        Me.txtExperience.TabIndex = 4
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(265, 590)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(400, 45)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Save Profile Details"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnCancel.FlatAppearance.BorderSize = 1
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(685, 590)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(210, 45)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel / Close"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(100, 23)
        Me.lblTitle.TabIndex = 0
        '
        'frmWorkerProfile
        '
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(950, 680)
        Me.Controls.Add(Me.picProfile)
        Me.Controls.Add(Me.pnlBanner)
        Me.Controls.Add(Me.btnUploadPic)
        Me.Controls.Add(Me.btnUploadID)
        Me.Controls.Add(Me.btnUploadResume)
        Me.Controls.Add(Me.lblFileName)
        Me.Controls.Add(Me.lblHeadlineTitle)
        Me.Controls.Add(Me.txtHeadline)
        Me.Controls.Add(Me.lblSalaryTitle)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.lblEducationTitle)
        Me.Controls.Add(Me.txtEducation)
        Me.Controls.Add(Me.lblSkills)
        Me.Controls.Add(Me.txtSkills)
        Me.Controls.Add(Me.lblExperience)
        Me.Controls.Add(Me.txtExperience)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmWorkerProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.pnlBanner.ResumeLayout(False)
        Me.pnlBanner.PerformLayout()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlBanner As Panel
    Friend WithEvents lblFullName As Label
    Friend WithEvents picProfile As PictureBox
    Friend WithEvents btnUploadPic As Button
    Friend WithEvents lblVerificationStatus As Label
    Friend WithEvents lblHeadlineTitle As Label
    Friend WithEvents txtHeadline As TextBox
    Friend WithEvents lblSalaryTitle As Label
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents lblEducationTitle As Label
    Friend WithEvents txtEducation As TextBox
    Friend WithEvents lblSkills As Label
    Friend WithEvents txtSkills As TextBox
    Friend WithEvents lblExperience As Label
    Friend WithEvents txtExperience As TextBox
    Friend WithEvents lblResume As Label
    Friend WithEvents btnUploadResume As Button
    Friend WithEvents lblFileName As Label
    Friend WithEvents btnUploadID As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblTitle As Label
End Class