<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEmployeerDashboard
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.btnNotifications = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblLogo = New System.Windows.Forms.Label()
        Me.pnlNav = New System.Windows.Forms.Panel()
        Me.btnViewPostJob = New System.Windows.Forms.Button()
        Me.btnMyPosts = New System.Windows.Forms.Button()
        Me.btnViewApplicants = New System.Windows.Forms.Button()
        Me.btnViewPayroll = New System.Windows.Forms.Button()
        Me.btnMyProfile = New System.Windows.Forms.Button()
        Me.btnGlobalInbox = New System.Windows.Forms.Button()
        Me.pnlCard = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblJobTitle = New System.Windows.Forms.Label()
        Me.txtJobTitle = New System.Windows.Forms.TextBox()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.cmbCity = New System.Windows.Forms.ComboBox()
        Me.lblBarangay = New System.Windows.Forms.Label()
        Me.cmbBarangay = New System.Windows.Forms.ComboBox()
        Me.lblPayType = New System.Windows.Forms.Label()
        Me.cmbPayType = New System.Windows.Forms.ComboBox()
        Me.lblSalary = New System.Windows.Forms.Label()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.btnPostJob = New System.Windows.Forms.Button()
        Me.btnRefreshApplicants = New System.Windows.Forms.Button()
        Me.dgvApplicants = New System.Windows.Forms.DataGridView()
        Me.dgvPayroll = New System.Windows.Forms.DataGridView()
        Me.dgvMyPosts = New System.Windows.Forms.DataGridView()
        Me.btnCloseJob = New System.Windows.Forms.Button()
        Me.btnAccept = New System.Windows.Forms.Button()
        Me.btnReject = New System.Windows.Forms.Button()
        Me.btnConfirmJobDone = New System.Windows.Forms.Button()
        Me.btnViewProfile = New System.Windows.Forms.Button()
        Me.btnChatWorker = New System.Windows.Forms.Button()
        Me.btnPayWorker = New System.Windows.Forms.Button()
        Me.lblActiveHires = New System.Windows.Forms.Label()
        Me.lblTotalSpent = New System.Windows.Forms.Label()
        Me.notifTimer = New System.Windows.Forms.Timer(Me.components)
        Me.pnlHeader.SuspendLayout()
        Me.pnlNav.SuspendLayout()
        Me.pnlCard.SuspendLayout()
        CType(Me.dgvApplicants, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPayroll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMyPosts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.btnNotifications)
        Me.pnlHeader.Controls.Add(Me.btnLogout)
        Me.pnlHeader.Controls.Add(Me.lblLogo)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1000, 65)
        Me.pnlHeader.TabIndex = 1
        '
        'btnNotifications
        '
        Me.btnNotifications.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNotifications.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNotifications.FlatAppearance.BorderSize = 0
        Me.btnNotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotifications.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnNotifications.ForeColor = System.Drawing.Color.White
        Me.btnNotifications.Location = New System.Drawing.Point(750, 15)
        Me.btnNotifications.Name = "btnNotifications"
        Me.btnNotifications.Size = New System.Drawing.Size(120, 35)
        Me.btnNotifications.TabIndex = 3
        Me.btnNotifications.Text = "🔔 Alerts (0)"
        Me.btnNotifications.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(880, 15)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(100, 35)
        Me.btnLogout.TabIndex = 0
        Me.btnLogout.Text = "Log Out"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'lblLogo
        '
        Me.lblLogo.AutoSize = True
        Me.lblLogo.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblLogo.ForeColor = System.Drawing.Color.White
        Me.lblLogo.Location = New System.Drawing.Point(20, 15)
        Me.lblLogo.Name = "lblLogo"
        Me.lblLogo.Size = New System.Drawing.Size(325, 30)
        Me.lblLogo.TabIndex = 1
        Me.lblLogo.Text = "TrabahoLocal Employer Portal"
        '
        'pnlNav
        '
        Me.pnlNav.BackColor = System.Drawing.Color.White
        Me.pnlNav.Controls.Add(Me.btnViewPostJob)
        Me.pnlNav.Controls.Add(Me.btnMyPosts)
        Me.pnlNav.Controls.Add(Me.btnViewApplicants)
        Me.pnlNav.Controls.Add(Me.btnViewPayroll)
        Me.pnlNav.Controls.Add(Me.btnMyProfile)
        Me.pnlNav.Controls.Add(Me.btnGlobalInbox)
        Me.pnlNav.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlNav.Location = New System.Drawing.Point(0, 65)
        Me.pnlNav.Name = "pnlNav"
        Me.pnlNav.Size = New System.Drawing.Size(1000, 50)
        Me.pnlNav.TabIndex = 2
        '
        'btnViewPostJob
        '
        Me.btnViewPostJob.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnViewPostJob.FlatAppearance.BorderSize = 0
        Me.btnViewPostJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewPostJob.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnViewPostJob.ForeColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnViewPostJob.Location = New System.Drawing.Point(10, 0)
        Me.btnViewPostJob.Name = "btnViewPostJob"
        Me.btnViewPostJob.Size = New System.Drawing.Size(120, 50)
        Me.btnViewPostJob.TabIndex = 0
        Me.btnViewPostJob.Text = "➕ Post Job"
        Me.btnViewPostJob.UseVisualStyleBackColor = True
        '
        'btnMyPosts
        '
        Me.btnMyPosts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMyPosts.FlatAppearance.BorderSize = 0
        Me.btnMyPosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMyPosts.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnMyPosts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnMyPosts.Location = New System.Drawing.Point(130, 0)
        Me.btnMyPosts.Name = "btnMyPosts"
        Me.btnMyPosts.Size = New System.Drawing.Size(120, 50)
        Me.btnMyPosts.TabIndex = 5
        Me.btnMyPosts.Text = "📋 My Posts"
        Me.btnMyPosts.UseVisualStyleBackColor = True
        '
        'btnViewApplicants
        '
        Me.btnViewApplicants.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnViewApplicants.FlatAppearance.BorderSize = 0
        Me.btnViewApplicants.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewApplicants.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnViewApplicants.ForeColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnViewApplicants.Location = New System.Drawing.Point(250, 0)
        Me.btnViewApplicants.Name = "btnViewApplicants"
        Me.btnViewApplicants.Size = New System.Drawing.Size(130, 50)
        Me.btnViewApplicants.TabIndex = 1
        Me.btnViewApplicants.Text = "👥 Applicants"
        Me.btnViewApplicants.UseVisualStyleBackColor = True
        '
        'btnViewPayroll
        '
        Me.btnViewPayroll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnViewPayroll.FlatAppearance.BorderSize = 0
        Me.btnViewPayroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewPayroll.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnViewPayroll.ForeColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnViewPayroll.Location = New System.Drawing.Point(380, 0)
        Me.btnViewPayroll.Name = "btnViewPayroll"
        Me.btnViewPayroll.Size = New System.Drawing.Size(150, 50)
        Me.btnViewPayroll.TabIndex = 2
        Me.btnViewPayroll.Text = "💳 Pending Payroll"
        Me.btnViewPayroll.UseVisualStyleBackColor = True
        '
        'btnMyProfile
        '
        Me.btnMyProfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMyProfile.FlatAppearance.BorderSize = 0
        Me.btnMyProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMyProfile.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnMyProfile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnMyProfile.Location = New System.Drawing.Point(530, 0)
        Me.btnMyProfile.Name = "btnMyProfile"
        Me.btnMyProfile.Size = New System.Drawing.Size(160, 50)
        Me.btnMyProfile.TabIndex = 3
        Me.btnMyProfile.Text = "🏢 Edit Profile"
        Me.btnMyProfile.UseVisualStyleBackColor = True
        '
        'btnGlobalInbox
        '
        Me.btnGlobalInbox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGlobalInbox.FlatAppearance.BorderSize = 0
        Me.btnGlobalInbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGlobalInbox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnGlobalInbox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnGlobalInbox.Location = New System.Drawing.Point(690, 0)
        Me.btnGlobalInbox.Name = "btnGlobalInbox"
        Me.btnGlobalInbox.Size = New System.Drawing.Size(130, 50)
        Me.btnGlobalInbox.TabIndex = 4
        Me.btnGlobalInbox.Text = "💬 Messages"
        Me.btnGlobalInbox.UseVisualStyleBackColor = True
        '
        'pnlCard
        '
        Me.pnlCard.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlCard.BackColor = System.Drawing.Color.White
        Me.pnlCard.Controls.Add(Me.lblTitle)
        Me.pnlCard.Controls.Add(Me.lblJobTitle)
        Me.pnlCard.Controls.Add(Me.txtJobTitle)
        Me.pnlCard.Controls.Add(Me.lblCity)
        Me.pnlCard.Controls.Add(Me.cmbCity)
        Me.pnlCard.Controls.Add(Me.lblBarangay)
        Me.pnlCard.Controls.Add(Me.cmbBarangay)
        Me.pnlCard.Controls.Add(Me.lblPayType)
        Me.pnlCard.Controls.Add(Me.cmbPayType)
        Me.pnlCard.Controls.Add(Me.lblSalary)
        Me.pnlCard.Controls.Add(Me.txtSalary)
        Me.pnlCard.Controls.Add(Me.lblDesc)
        Me.pnlCard.Controls.Add(Me.txtDescription)
        Me.pnlCard.Controls.Add(Me.btnPostJob)
        Me.pnlCard.Controls.Add(Me.btnRefreshApplicants)
        Me.pnlCard.Controls.Add(Me.dgvApplicants)
        Me.pnlCard.Controls.Add(Me.dgvPayroll)
        Me.pnlCard.Controls.Add(Me.dgvMyPosts)
        Me.pnlCard.Controls.Add(Me.btnCloseJob)
        Me.pnlCard.Controls.Add(Me.btnAccept)
        Me.pnlCard.Controls.Add(Me.btnReject)
        Me.pnlCard.Controls.Add(Me.btnConfirmJobDone)
        Me.pnlCard.Controls.Add(Me.btnViewProfile)
        Me.pnlCard.Controls.Add(Me.btnChatWorker)
        Me.pnlCard.Controls.Add(Me.btnPayWorker)
        Me.pnlCard.Controls.Add(Me.lblActiveHires)
        Me.pnlCard.Controls.Add(Me.lblTotalSpent)
        Me.pnlCard.Location = New System.Drawing.Point(50, 140)
        Me.pnlCard.Name = "pnlCard"
        Me.pnlCard.Size = New System.Drawing.Size(900, 560)
        Me.pnlCard.TabIndex = 3
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(43, 25)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(380, 37)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Post a New Job Opportunity"
        '
        'lblJobTitle
        '
        Me.lblJobTitle.AutoSize = True
        Me.lblJobTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblJobTitle.Location = New System.Drawing.Point(46, 85)
        Me.lblJobTitle.Name = "lblJobTitle"
        Me.lblJobTitle.Size = New System.Drawing.Size(286, 19)
        Me.lblJobTitle.TabIndex = 1
        Me.lblJobTitle.Text = "Job Title (e.g. Delivery Driver, Carpenter)"
        '
        'txtJobTitle
        '
        Me.txtJobTitle.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtJobTitle.Location = New System.Drawing.Point(50, 110)
        Me.txtJobTitle.Name = "txtJobTitle"
        Me.txtJobTitle.Size = New System.Drawing.Size(800, 27)
        Me.txtJobTitle.TabIndex = 2
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblCity.Location = New System.Drawing.Point(46, 155)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(133, 19)
        Me.lblCity.TabIndex = 3
        Me.lblCity.Text = "City / Municipality"
        '
        'cmbCity
        '
        Me.cmbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCity.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.cmbCity.FormattingEnabled = True
        Me.cmbCity.Location = New System.Drawing.Point(50, 180)
        Me.cmbCity.Name = "cmbCity"
        Me.cmbCity.Size = New System.Drawing.Size(390, 28)
        Me.cmbCity.TabIndex = 4
        '
        'lblBarangay
        '
        Me.lblBarangay.AutoSize = True
        Me.lblBarangay.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblBarangay.Location = New System.Drawing.Point(456, 155)
        Me.lblBarangay.Name = "lblBarangay"
        Me.lblBarangay.Size = New System.Drawing.Size(71, 19)
        Me.lblBarangay.TabIndex = 5
        Me.lblBarangay.Text = "Barangay"
        '
        'cmbBarangay
        '
        Me.cmbBarangay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBarangay.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.cmbBarangay.FormattingEnabled = True
        Me.cmbBarangay.Location = New System.Drawing.Point(460, 180)
        Me.cmbBarangay.Name = "cmbBarangay"
        Me.cmbBarangay.Size = New System.Drawing.Size(390, 28)
        Me.cmbBarangay.TabIndex = 6
        '
        'lblPayType
        '
        Me.lblPayType.AutoSize = True
        Me.lblPayType.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblPayType.Location = New System.Drawing.Point(46, 225)
        Me.lblPayType.Name = "lblPayType"
        Me.lblPayType.Size = New System.Drawing.Size(182, 19)
        Me.lblPayType.TabIndex = 7
        Me.lblPayType.Text = "Payment Structure / Type"
        '
        'cmbPayType
        '
        Me.cmbPayType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPayType.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.cmbPayType.FormattingEnabled = True
        Me.cmbPayType.Location = New System.Drawing.Point(50, 250)
        Me.cmbPayType.Name = "cmbPayType"
        Me.cmbPayType.Size = New System.Drawing.Size(390, 28)
        Me.cmbPayType.TabIndex = 8
        '
        'lblSalary
        '
        Me.lblSalary.AutoSize = True
        Me.lblSalary.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblSalary.Location = New System.Drawing.Point(456, 225)
        Me.lblSalary.Name = "lblSalary"
        Me.lblSalary.Size = New System.Drawing.Size(193, 19)
        Me.lblSalary.TabIndex = 9
        Me.lblSalary.Text = "Rate Amount (₱) - Pure No."
        '
        'txtSalary
        '
        Me.txtSalary.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtSalary.Location = New System.Drawing.Point(460, 250)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(390, 27)
        Me.txtSalary.TabIndex = 10
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblDesc.Location = New System.Drawing.Point(46, 295)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(219, 19)
        Me.lblDesc.TabIndex = 11
        Me.lblDesc.Text = "Job Description / Requirements"
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtDescription.Location = New System.Drawing.Point(50, 320)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(800, 130)
        Me.txtDescription.TabIndex = 12
        '
        'btnPostJob
        '
        Me.btnPostJob.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnPostJob.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPostJob.FlatAppearance.BorderSize = 0
        Me.btnPostJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPostJob.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnPostJob.ForeColor = System.Drawing.Color.White
        Me.btnPostJob.Location = New System.Drawing.Point(50, 480)
        Me.btnPostJob.Name = "btnPostJob"
        Me.btnPostJob.Size = New System.Drawing.Size(800, 45)
        Me.btnPostJob.TabIndex = 13
        Me.btnPostJob.Text = "Publish Job to Community"
        Me.btnPostJob.UseVisualStyleBackColor = False
        '
        'btnRefreshApplicants
        '
        Me.btnRefreshApplicants.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefreshApplicants.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btnRefreshApplicants.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefreshApplicants.FlatAppearance.BorderSize = 0
        Me.btnRefreshApplicants.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefreshApplicants.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnRefreshApplicants.ForeColor = System.Drawing.Color.White
        Me.btnRefreshApplicants.Location = New System.Drawing.Point(740, 25)
        Me.btnRefreshApplicants.Name = "btnRefreshApplicants"
        Me.btnRefreshApplicants.Size = New System.Drawing.Size(110, 35)
        Me.btnRefreshApplicants.TabIndex = 14
        Me.btnRefreshApplicants.Text = "Refresh Data"
        Me.btnRefreshApplicants.UseVisualStyleBackColor = False
        Me.btnRefreshApplicants.Visible = False
        '
        'dgvApplicants
        '
        Me.dgvApplicants.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvApplicants.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvApplicants.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvApplicants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvApplicants.BackgroundColor = System.Drawing.Color.White
        Me.dgvApplicants.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvApplicants.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvApplicants.ColumnHeadersHeight = 40
        Me.dgvApplicants.EnableHeadersVisualStyles = False
        Me.dgvApplicants.Location = New System.Drawing.Point(40, 84)
        Me.dgvApplicants.Name = "dgvApplicants"
        Me.dgvApplicants.ReadOnly = True
        Me.dgvApplicants.RowHeadersVisible = False
        Me.dgvApplicants.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.dgvApplicants.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvApplicants.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvApplicants.RowTemplate.Height = 45
        Me.dgvApplicants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvApplicants.Size = New System.Drawing.Size(810, 390)
        Me.dgvApplicants.TabIndex = 10
        Me.dgvApplicants.Visible = False
        '
        'dgvPayroll
        '
        Me.dgvPayroll.AllowUserToAddRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvPayroll.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvPayroll.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPayroll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPayroll.BackgroundColor = System.Drawing.Color.White
        Me.dgvPayroll.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvPayroll.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvPayroll.ColumnHeadersHeight = 40
        Me.dgvPayroll.EnableHeadersVisualStyles = False
        Me.dgvPayroll.Location = New System.Drawing.Point(40, 84)
        Me.dgvPayroll.Name = "dgvPayroll"
        Me.dgvPayroll.ReadOnly = True
        Me.dgvPayroll.RowHeadersVisible = False
        Me.dgvPayroll.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.dgvPayroll.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvPayroll.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvPayroll.RowTemplate.Height = 45
        Me.dgvPayroll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPayroll.Size = New System.Drawing.Size(810, 390)
        Me.dgvPayroll.TabIndex = 22
        Me.dgvPayroll.Visible = False
        '
        'dgvMyPosts
        '
        Me.dgvMyPosts.AllowUserToAddRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvMyPosts.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvMyPosts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMyPosts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMyPosts.BackgroundColor = System.Drawing.Color.White
        Me.dgvMyPosts.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvMyPosts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvMyPosts.ColumnHeadersHeight = 40
        Me.dgvMyPosts.EnableHeadersVisualStyles = False
        Me.dgvMyPosts.Location = New System.Drawing.Point(40, 84)
        Me.dgvMyPosts.Name = "dgvMyPosts"
        Me.dgvMyPosts.ReadOnly = True
        Me.dgvMyPosts.RowHeadersVisible = False
        Me.dgvMyPosts.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.dgvMyPosts.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvMyPosts.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvMyPosts.RowTemplate.Height = 45
        Me.dgvMyPosts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMyPosts.Size = New System.Drawing.Size(810, 390)
        Me.dgvMyPosts.TabIndex = 23
        Me.dgvMyPosts.Visible = False
        '
        'btnCloseJob
        '
        Me.btnCloseJob.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCloseJob.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnCloseJob.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCloseJob.FlatAppearance.BorderSize = 0
        Me.btnCloseJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCloseJob.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCloseJob.ForeColor = System.Drawing.Color.White
        Me.btnCloseJob.Location = New System.Drawing.Point(40, 495)
        Me.btnCloseJob.Name = "btnCloseJob"
        Me.btnCloseJob.Size = New System.Drawing.Size(180, 40)
        Me.btnCloseJob.TabIndex = 24
        Me.btnCloseJob.Text = "🚫 Close Job Posting"
        Me.btnCloseJob.UseVisualStyleBackColor = False
        Me.btnCloseJob.Visible = False
        '
        'btnAccept
        '
        Me.btnAccept.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAccept.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnAccept.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAccept.FlatAppearance.BorderSize = 0
        Me.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccept.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnAccept.ForeColor = System.Drawing.Color.White
        Me.btnAccept.Location = New System.Drawing.Point(40, 495)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(130, 40)
        Me.btnAccept.TabIndex = 11
        Me.btnAccept.Text = "Accept Worker"
        Me.btnAccept.UseVisualStyleBackColor = False
        Me.btnAccept.Visible = False
        '
        'btnReject
        '
        Me.btnReject.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnReject.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnReject.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReject.FlatAppearance.BorderSize = 0
        Me.btnReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReject.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnReject.ForeColor = System.Drawing.Color.White
        Me.btnReject.Location = New System.Drawing.Point(180, 495)
        Me.btnReject.Name = "btnReject"
        Me.btnReject.Size = New System.Drawing.Size(130, 40)
        Me.btnReject.TabIndex = 12
        Me.btnReject.Text = "Reject Applicant"
        Me.btnReject.UseVisualStyleBackColor = False
        Me.btnReject.Visible = False
        '
        'btnConfirmJobDone
        '
        Me.btnConfirmJobDone.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfirmJobDone.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnConfirmJobDone.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfirmJobDone.FlatAppearance.BorderSize = 0
        Me.btnConfirmJobDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmJobDone.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnConfirmJobDone.ForeColor = System.Drawing.Color.White
        Me.btnConfirmJobDone.Location = New System.Drawing.Point(320, 495)
        Me.btnConfirmJobDone.Name = "btnConfirmJobDone"
        Me.btnConfirmJobDone.Size = New System.Drawing.Size(150, 40)
        Me.btnConfirmJobDone.TabIndex = 16
        Me.btnConfirmJobDone.Text = "Review && Finalize"
        Me.btnConfirmJobDone.UseVisualStyleBackColor = False
        Me.btnConfirmJobDone.Visible = False
        '
        'btnViewProfile
        '
        Me.btnViewProfile.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnViewProfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btnViewProfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnViewProfile.FlatAppearance.BorderSize = 0
        Me.btnViewProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewProfile.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnViewProfile.ForeColor = System.Drawing.Color.White
        Me.btnViewProfile.Location = New System.Drawing.Point(480, 495)
        Me.btnViewProfile.Name = "btnViewProfile"
        Me.btnViewProfile.Size = New System.Drawing.Size(120, 40)
        Me.btnViewProfile.TabIndex = 19
        Me.btnViewProfile.Text = "Read Application"
        Me.btnViewProfile.UseVisualStyleBackColor = False
        Me.btnViewProfile.Visible = False
        '
        'btnChatWorker
        '
        Me.btnChatWorker.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnChatWorker.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.btnChatWorker.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChatWorker.FlatAppearance.BorderSize = 0
        Me.btnChatWorker.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChatWorker.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnChatWorker.ForeColor = System.Drawing.Color.White
        Me.btnChatWorker.Location = New System.Drawing.Point(610, 495)
        Me.btnChatWorker.Name = "btnChatWorker"
        Me.btnChatWorker.Size = New System.Drawing.Size(130, 40)
        Me.btnChatWorker.TabIndex = 20
        Me.btnChatWorker.Text = "Message Worker"
        Me.btnChatWorker.UseVisualStyleBackColor = False
        Me.btnChatWorker.Visible = False
        '
        'btnPayWorker
        '
        Me.btnPayWorker.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPayWorker.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnPayWorker.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPayWorker.FlatAppearance.BorderSize = 0
        Me.btnPayWorker.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPayWorker.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnPayWorker.ForeColor = System.Drawing.Color.White
        Me.btnPayWorker.Location = New System.Drawing.Point(460, 495)
        Me.btnPayWorker.Name = "btnPayWorker"
        Me.btnPayWorker.Size = New System.Drawing.Size(140, 40)
        Me.btnPayWorker.TabIndex = 21
        Me.btnPayWorker.Text = "Issue Payment"
        Me.btnPayWorker.UseVisualStyleBackColor = False
        Me.btnPayWorker.Visible = False
        '
        'lblActiveHires
        '
        Me.lblActiveHires.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblActiveHires.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblActiveHires.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.lblActiveHires.Location = New System.Drawing.Point(610, 20)
        Me.lblActiveHires.Name = "lblActiveHires"
        Me.lblActiveHires.Size = New System.Drawing.Size(120, 40)
        Me.lblActiveHires.TabIndex = 18
        Me.lblActiveHires.Text = "Active Hires: 0"
        Me.lblActiveHires.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblActiveHires.Visible = False
        '
        'lblTotalSpent
        '
        Me.lblTotalSpent.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalSpent.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalSpent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.lblTotalSpent.Location = New System.Drawing.Point(400, 20)
        Me.lblTotalSpent.Name = "lblTotalSpent"
        Me.lblTotalSpent.Size = New System.Drawing.Size(200, 40)
        Me.lblTotalSpent.TabIndex = 17
        Me.lblTotalSpent.Text = "Total Spent: ₱0.00"
        Me.lblTotalSpent.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTotalSpent.Visible = False
        '
        'notifTimer
        '
        Me.notifTimer.Enabled = True
        Me.notifTimer.Interval = 5000
        '
        'frmEmployeerDashboard
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 750)
        Me.Controls.Add(Me.pnlCard)
        Me.Controls.Add(Me.pnlNav)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEmployeerDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlNav.ResumeLayout(False)
        Me.pnlCard.ResumeLayout(False)
        Me.pnlCard.PerformLayout()
        CType(Me.dgvApplicants, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPayroll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMyPosts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblLogo As System.Windows.Forms.Label
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnNotifications As System.Windows.Forms.Button
    Friend WithEvents pnlNav As System.Windows.Forms.Panel
    Friend WithEvents btnViewPostJob As System.Windows.Forms.Button
    Friend WithEvents btnMyPosts As System.Windows.Forms.Button
    Friend WithEvents btnViewApplicants As System.Windows.Forms.Button
    Friend WithEvents btnViewPayroll As System.Windows.Forms.Button
    Friend WithEvents btnMyProfile As System.Windows.Forms.Button
    Friend WithEvents btnGlobalInbox As System.Windows.Forms.Button
    Friend WithEvents pnlCard As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblJobTitle As System.Windows.Forms.Label
    Friend WithEvents txtJobTitle As System.Windows.Forms.TextBox
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents cmbCity As System.Windows.Forms.ComboBox
    Friend WithEvents lblBarangay As System.Windows.Forms.Label
    Friend WithEvents cmbBarangay As System.Windows.Forms.ComboBox
    Friend WithEvents lblPayType As System.Windows.Forms.Label
    Friend WithEvents cmbPayType As System.Windows.Forms.ComboBox
    Friend WithEvents lblSalary As System.Windows.Forms.Label
    Friend WithEvents txtSalary As System.Windows.Forms.TextBox
    Friend WithEvents lblDesc As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents btnPostJob As System.Windows.Forms.Button
    Friend WithEvents dgvApplicants As System.Windows.Forms.DataGridView
    Friend WithEvents btnAccept As System.Windows.Forms.Button
    Friend WithEvents btnReject As System.Windows.Forms.Button
    Friend WithEvents btnConfirmJobDone As System.Windows.Forms.Button
    Friend WithEvents btnViewProfile As System.Windows.Forms.Button
    Friend WithEvents btnChatWorker As System.Windows.Forms.Button
    Friend WithEvents btnRefreshApplicants As System.Windows.Forms.Button
    Friend WithEvents lblActiveHires As System.Windows.Forms.Label
    Friend WithEvents lblTotalSpent As System.Windows.Forms.Label
    Friend WithEvents dgvPayroll As System.Windows.Forms.DataGridView
    Friend WithEvents dgvMyPosts As System.Windows.Forms.DataGridView
    Friend WithEvents btnCloseJob As System.Windows.Forms.Button
    Friend WithEvents btnPayWorker As System.Windows.Forms.Button
    Friend WithEvents notifTimer As System.Windows.Forms.Timer
End Class