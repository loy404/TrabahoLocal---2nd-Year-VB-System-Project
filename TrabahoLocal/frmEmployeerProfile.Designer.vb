<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEmployeerProfile
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
        Me.lblLocationTitle = New System.Windows.Forms.Label()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.lblContactTitle = New System.Windows.Forms.Label()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.lblCompanyTitle = New System.Windows.Forms.Label()
        Me.txtCompanyDetails = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.pnlBanner.SuspendLayout()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlBanner
        '
        Me.pnlBanner.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(70, Byte), Integer))
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
        Me.lblFullName.Size = New System.Drawing.Size(262, 45)
        Me.lblFullName.TabIndex = 0
        Me.lblFullName.Text = "Employer Name"
        '
        'lblVerificationStatus
        '
        Me.lblVerificationStatus.AutoSize = True
        Me.lblVerificationStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.lblVerificationStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblVerificationStatus.ForeColor = System.Drawing.Color.White
        Me.lblVerificationStatus.Location = New System.Drawing.Point(265, 125)
        Me.lblVerificationStatus.Name = "lblVerificationStatus"
        Me.lblVerificationStatus.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.lblVerificationStatus.Size = New System.Drawing.Size(121, 29)
        Me.lblVerificationStatus.TabIndex = 12
        Me.lblVerificationStatus.Text = "❌ Unverified"
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
        Me.btnUploadPic.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnUploadPic.FlatAppearance.BorderSize = 2
        Me.btnUploadPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUploadPic.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnUploadPic.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(70, Byte), Integer))
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
        Me.btnUploadID.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnUploadID.FlatAppearance.BorderSize = 2
        Me.btnUploadID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUploadID.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnUploadID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnUploadID.Location = New System.Drawing.Point(50, 340)
        Me.btnUploadID.Name = "btnUploadID"
        Me.btnUploadID.Size = New System.Drawing.Size(180, 40)
        Me.btnUploadID.TabIndex = 13
        Me.btnUploadID.Text = "ID VERIFICATION"
        Me.btnUploadID.UseVisualStyleBackColor = False
        '
        'lblLocationTitle
        '
        Me.lblLocationTitle.AutoSize = True
        Me.lblLocationTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblLocationTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.lblLocationTitle.Location = New System.Drawing.Point(265, 200)
        Me.lblLocationTitle.Name = "lblLocationTitle"
        Me.lblLocationTitle.Size = New System.Drawing.Size(123, 15)
        Me.lblLocationTitle.TabIndex = 21
        Me.lblLocationTitle.Text = "LOCATION"
        '
        'txtLocation
        '
        Me.txtLocation.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtLocation.Location = New System.Drawing.Point(265, 220)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(630, 27)
        Me.txtLocation.TabIndex = 22
        '
        'lblContactTitle
        '
        Me.lblContactTitle.AutoSize = True
        Me.lblContactTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblContactTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.lblContactTitle.Location = New System.Drawing.Point(265, 260)
        Me.lblContactTitle.Name = "lblContactTitle"
        Me.lblContactTitle.Size = New System.Drawing.Size(117, 15)
        Me.lblContactTitle.TabIndex = 23
        Me.lblContactTitle.Text = "CONTACT NUMBER"
        '
        'txtContact
        '
        Me.txtContact.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtContact.Location = New System.Drawing.Point(265, 280)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(630, 27)
        Me.txtContact.TabIndex = 24
        '
        'lblCompanyTitle
        '
        Me.lblCompanyTitle.AutoSize = True
        Me.lblCompanyTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCompanyTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.lblCompanyTitle.Location = New System.Drawing.Point(265, 320)
        Me.lblCompanyTitle.Name = "lblCompanyTitle"
        Me.lblCompanyTitle.Size = New System.Drawing.Size(262, 15)
        Me.lblCompanyTitle.TabIndex = 25
        Me.lblCompanyTitle.Text = "ABOUT THE COMPANY / EMPLOYER DETAILS"
        '
        'txtCompanyDetails
        '
        Me.txtCompanyDetails.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtCompanyDetails.Location = New System.Drawing.Point(265, 340)
        Me.txtCompanyDetails.Multiline = True
        Me.txtCompanyDetails.Name = "txtCompanyDetails"
        Me.txtCompanyDetails.Size = New System.Drawing.Size(630, 150)
        Me.txtCompanyDetails.TabIndex = 26
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(265, 520)
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
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnCancel.FlatAppearance.BorderSize = 1
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(685, 520)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(210, 45)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel / Close"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'frmEmployeerProfile
        '
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(950, 600)
        Me.Controls.Add(Me.picProfile)
        Me.Controls.Add(Me.pnlBanner)
        Me.Controls.Add(Me.btnUploadPic)
        Me.Controls.Add(Me.btnUploadID)
        Me.Controls.Add(Me.lblLocationTitle)
        Me.Controls.Add(Me.txtLocation)
        Me.Controls.Add(Me.lblContactTitle)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.lblCompanyTitle)
        Me.Controls.Add(Me.txtCompanyDetails)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEmployeerProfile"
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
    Friend WithEvents lblLocationTitle As Label
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents lblContactTitle As Label
    Friend WithEvents txtContact As TextBox
    Friend WithEvents lblCompanyTitle As Label
    Friend WithEvents txtCompanyDetails As TextBox
    Friend WithEvents btnUploadID As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
End Class