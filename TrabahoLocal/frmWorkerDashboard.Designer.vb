<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmWorkerDashboard
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
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.btnNotifications = New System.Windows.Forms.Button()
        Me.lblTotalEarnings = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblLogo = New System.Windows.Forms.Label()
        Me.pnlNav = New System.Windows.Forms.Panel()
        Me.btnFindJobs = New System.Windows.Forms.Button()
        Me.btnActiveJobs = New System.Windows.Forms.Button()
        Me.btnMyApplications = New System.Windows.Forms.Button()
        Me.btnMyProfile = New System.Windows.Forms.Button()
        Me.btnGlobalInbox = New System.Windows.Forms.Button()
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.flpJobs = New System.Windows.Forms.FlowLayoutPanel()
        Me.dgvMyApplications = New System.Windows.Forms.DataGridView()
        Me.btnMarkDone = New System.Windows.Forms.Button()
        Me.btnChatEmployer = New System.Windows.Forms.Button()
        Me.btnViewReceipt = New System.Windows.Forms.Button()
        Me.notifTimer = New System.Windows.Forms.Timer(Me.components)
        Me.pnlHeader.SuspendLayout()
        Me.pnlNav.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        CType(Me.dgvMyApplications, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.btnNotifications)
        Me.pnlHeader.Controls.Add(Me.lblTotalEarnings)
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
        'lblTotalEarnings
        '
        Me.lblTotalEarnings.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalEarnings.BackColor = System.Drawing.Color.White
        Me.lblTotalEarnings.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalEarnings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.lblTotalEarnings.Location = New System.Drawing.Point(490, 15)
        Me.lblTotalEarnings.Name = "lblTotalEarnings"
        Me.lblTotalEarnings.Size = New System.Drawing.Size(250, 35)
        Me.lblTotalEarnings.TabIndex = 2
        Me.lblTotalEarnings.Text = "Total Earnings: ₱0.00"
        Me.lblTotalEarnings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.lblLogo.Size = New System.Drawing.Size(288, 30)
        Me.lblLogo.TabIndex = 1
        Me.lblLogo.Text = "TrabahoLocal Talent Portal"
        '
        'pnlNav
        '
        Me.pnlNav.BackColor = System.Drawing.Color.White
        Me.pnlNav.Controls.Add(Me.btnFindJobs)
        Me.pnlNav.Controls.Add(Me.btnActiveJobs)
        Me.pnlNav.Controls.Add(Me.btnMyApplications)
        Me.pnlNav.Controls.Add(Me.btnMyProfile)
        Me.pnlNav.Controls.Add(Me.btnGlobalInbox)
        Me.pnlNav.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlNav.Location = New System.Drawing.Point(0, 65)
        Me.pnlNav.Name = "pnlNav"
        Me.pnlNav.Size = New System.Drawing.Size(1000, 50)
        Me.pnlNav.TabIndex = 2
        '
        'btnFindJobs
        '
        Me.btnFindJobs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFindJobs.FlatAppearance.BorderSize = 0
        Me.btnFindJobs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFindJobs.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnFindJobs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnFindJobs.Location = New System.Drawing.Point(20, 0)
        Me.btnFindJobs.Name = "btnFindJobs"
        Me.btnFindJobs.Size = New System.Drawing.Size(140, 50)
        Me.btnFindJobs.TabIndex = 0
        Me.btnFindJobs.Text = "🔍 Find Jobs"
        Me.btnFindJobs.UseVisualStyleBackColor = True
        '
        'btnActiveJobs
        '
        Me.btnActiveJobs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActiveJobs.FlatAppearance.BorderSize = 0
        Me.btnActiveJobs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActiveJobs.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnActiveJobs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnActiveJobs.Location = New System.Drawing.Point(160, 0)
        Me.btnActiveJobs.Name = "btnActiveJobs"
        Me.btnActiveJobs.Size = New System.Drawing.Size(160, 50)
        Me.btnActiveJobs.TabIndex = 1
        Me.btnActiveJobs.Text = "💼 Current Work"
        Me.btnActiveJobs.UseVisualStyleBackColor = True
        '
        'btnMyApplications
        '
        Me.btnMyApplications.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMyApplications.FlatAppearance.BorderSize = 0
        Me.btnMyApplications.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMyApplications.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnMyApplications.ForeColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnMyApplications.Location = New System.Drawing.Point(320, 0)
        Me.btnMyApplications.Name = "btnMyApplications"
        Me.btnMyApplications.Size = New System.Drawing.Size(170, 50)
        Me.btnMyApplications.TabIndex = 2
        Me.btnMyApplications.Text = "📄 My Applications"
        Me.btnMyApplications.UseVisualStyleBackColor = True
        '
        'btnMyProfile
        '
        Me.btnMyProfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMyProfile.FlatAppearance.BorderSize = 0
        Me.btnMyProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMyProfile.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnMyProfile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnMyProfile.Location = New System.Drawing.Point(490, 0)
        Me.btnMyProfile.Name = "btnMyProfile"
        Me.btnMyProfile.Size = New System.Drawing.Size(160, 50)
        Me.btnMyProfile.TabIndex = 3
        Me.btnMyProfile.Text = "👤 Edit Profile"
        Me.btnMyProfile.UseVisualStyleBackColor = True
        '
        'btnGlobalInbox
        '
        Me.btnGlobalInbox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGlobalInbox.FlatAppearance.BorderSize = 0
        Me.btnGlobalInbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGlobalInbox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnGlobalInbox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnGlobalInbox.Location = New System.Drawing.Point(650, 0)
        Me.btnGlobalInbox.Name = "btnGlobalInbox"
        Me.btnGlobalInbox.Size = New System.Drawing.Size(140, 50)
        Me.btnGlobalInbox.TabIndex = 4
        Me.btnGlobalInbox.Text = "💬 Messages"
        Me.btnGlobalInbox.UseVisualStyleBackColor = True
        '
        'pnlContent
        '
        Me.pnlContent.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlContent.BackColor = System.Drawing.Color.Transparent
        Me.pnlContent.Controls.Add(Me.lblTitle)
        Me.pnlContent.Controls.Add(Me.lblSearch)
        Me.pnlContent.Controls.Add(Me.txtSearch)
        Me.pnlContent.Controls.Add(Me.btnRefresh)
        Me.pnlContent.Controls.Add(Me.flpJobs)
        Me.pnlContent.Controls.Add(Me.dgvMyApplications)
        Me.pnlContent.Controls.Add(Me.btnMarkDone)
        Me.pnlContent.Controls.Add(Me.btnChatEmployer)
        Me.pnlContent.Controls.Add(Me.btnViewReceipt)
        Me.pnlContent.Location = New System.Drawing.Point(40, 140)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(920, 560)
        Me.pnlContent.TabIndex = 3
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(5, 5)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(275, 37)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Available Local Jobs"
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblSearch.Location = New System.Drawing.Point(5, 50)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(267, 20)
        Me.lblSearch.TabIndex = 14
        Me.lblSearch.Text = "🔍 Search Jobs (e.g. Plumber, Cebu):"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtSearch.Location = New System.Drawing.Point(275, 47)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(400, 29)
        Me.txtSearch.TabIndex = 15
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.FlatAppearance.BorderSize = 0
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Location = New System.Drawing.Point(800, 10)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(110, 35)
        Me.btnRefresh.TabIndex = 13
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'flpJobs
        '
        Me.flpJobs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flpJobs.AutoScroll = True
        Me.flpJobs.Location = New System.Drawing.Point(10, 90)
        Me.flpJobs.Name = "flpJobs"
        Me.flpJobs.Size = New System.Drawing.Size(900, 460)
        Me.flpJobs.TabIndex = 4
        '
        'dgvMyApplications
        '
        Me.dgvMyApplications.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvMyApplications.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMyApplications.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMyApplications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMyApplications.BackgroundColor = System.Drawing.Color.White
        Me.dgvMyApplications.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvMyApplications.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvMyApplications.ColumnHeadersHeight = 40
        Me.dgvMyApplications.EnableHeadersVisualStyles = False
        Me.dgvMyApplications.Location = New System.Drawing.Point(10, 60)
        Me.dgvMyApplications.Name = "dgvMyApplications"
        Me.dgvMyApplications.ReadOnly = True
        Me.dgvMyApplications.RowHeadersVisible = False
        Me.dgvMyApplications.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.dgvMyApplications.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvMyApplications.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvMyApplications.RowTemplate.Height = 45
        Me.dgvMyApplications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMyApplications.Size = New System.Drawing.Size(900, 430)
        Me.dgvMyApplications.TabIndex = 10
        Me.dgvMyApplications.Visible = False
        '
        'btnMarkDone
        '
        Me.btnMarkDone.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnMarkDone.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnMarkDone.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMarkDone.FlatAppearance.BorderSize = 0
        Me.btnMarkDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMarkDone.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnMarkDone.ForeColor = System.Drawing.Color.White
        Me.btnMarkDone.Location = New System.Drawing.Point(10, 505)
        Me.btnMarkDone.Name = "btnMarkDone"
        Me.btnMarkDone.Size = New System.Drawing.Size(180, 40)
        Me.btnMarkDone.TabIndex = 11
        Me.btnMarkDone.Text = "✔ Mark Job Completed"
        Me.btnMarkDone.UseVisualStyleBackColor = False
        Me.btnMarkDone.Visible = False
        '
        'btnChatEmployer
        '
        Me.btnChatEmployer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnChatEmployer.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.btnChatEmployer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChatEmployer.FlatAppearance.BorderSize = 0
        Me.btnChatEmployer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChatEmployer.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnChatEmployer.ForeColor = System.Drawing.Color.White
        Me.btnChatEmployer.Location = New System.Drawing.Point(200, 505)
        Me.btnChatEmployer.Name = "btnChatEmployer"
        Me.btnChatEmployer.Size = New System.Drawing.Size(160, 40)
        Me.btnChatEmployer.TabIndex = 20
        Me.btnChatEmployer.Text = "💬 Message Employer"
        Me.btnChatEmployer.UseVisualStyleBackColor = False
        Me.btnChatEmployer.Visible = False
        '
        'btnViewReceipt
        '
        Me.btnViewReceipt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnViewReceipt.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btnViewReceipt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnViewReceipt.FlatAppearance.BorderSize = 0
        Me.btnViewReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewReceipt.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnViewReceipt.ForeColor = System.Drawing.Color.White
        Me.btnViewReceipt.Location = New System.Drawing.Point(370, 505)
        Me.btnViewReceipt.Name = "btnViewReceipt"
        Me.btnViewReceipt.Size = New System.Drawing.Size(160, 40)
        Me.btnViewReceipt.TabIndex = 21
        Me.btnViewReceipt.Text = "🧾 View Receipt"
        Me.btnViewReceipt.UseVisualStyleBackColor = False
        Me.btnViewReceipt.Visible = False
        '
        'notifTimer
        '
        Me.notifTimer.Enabled = True
        Me.notifTimer.Interval = 5000
        '
        'frmWorkerDashboard
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 750)
        Me.Controls.Add(Me.pnlContent)
        Me.Controls.Add(Me.pnlNav)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmWorkerDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlNav.ResumeLayout(False)
        Me.pnlContent.ResumeLayout(False)
        Me.pnlContent.PerformLayout()
        CType(Me.dgvMyApplications, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblLogo As System.Windows.Forms.Label
    Friend WithEvents lblTotalEarnings As System.Windows.Forms.Label
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnNotifications As System.Windows.Forms.Button
    Friend WithEvents pnlNav As System.Windows.Forms.Panel
    Friend WithEvents btnFindJobs As System.Windows.Forms.Button
    Friend WithEvents btnActiveJobs As System.Windows.Forms.Button
    Friend WithEvents btnMyApplications As System.Windows.Forms.Button
    Friend WithEvents btnMyProfile As System.Windows.Forms.Button
    Friend WithEvents btnGlobalInbox As System.Windows.Forms.Button
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents flpJobs As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents dgvMyApplications As System.Windows.Forms.DataGridView
    Friend WithEvents btnMarkDone As System.Windows.Forms.Button
    Friend WithEvents btnChatEmployer As System.Windows.Forms.Button
    Friend WithEvents btnViewReceipt As System.Windows.Forms.Button
    Friend WithEvents notifTimer As System.Windows.Forms.Timer
End Class