<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdminDashboard
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

    ' ==========================================
    ' PASTE THIS LINE HERE:
    Private components As System.ComponentModel.IContainer
    ' ==========================================

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        ' ... the rest of your code ...
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblLogo = New System.Windows.Forms.Label()
        Me.pnlCard = New System.Windows.Forms.Panel()
        Me.lblPendingCount = New System.Windows.Forms.Label()
        Me.lblTotalUsers = New System.Windows.Forms.Label()
        Me.lblTotalJobs = New System.Windows.Forms.Label()
        Me.lblTotalMoney = New System.Windows.Forms.Label()
        Me.cmbView = New System.Windows.Forms.ComboBox()
        Me.lblViewLabel = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()

        ' --- NEW SEARCH CONTROLS ---
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()

        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.pnlHeader.SuspendLayout()
        Me.pnlCard.SuspendLayout()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.btnLogout)
        Me.pnlHeader.Controls.Add(Me.lblLogo)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1000, 65)
        Me.pnlHeader.TabIndex = 1
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
        Me.lblLogo.Size = New System.Drawing.Size(306, 30)
        Me.lblLogo.TabIndex = 1
        Me.lblLogo.Text = "TrabahoLocal Master Control"
        '
        'pnlCard
        '
        Me.pnlCard.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlCard.BackColor = System.Drawing.Color.White
        Me.pnlCard.Controls.Add(Me.lblPendingCount)
        Me.pnlCard.Controls.Add(Me.lblTotalUsers)
        Me.pnlCard.Controls.Add(Me.lblTotalJobs)
        Me.pnlCard.Controls.Add(Me.lblTotalMoney)
        Me.pnlCard.Controls.Add(Me.cmbView)
        Me.pnlCard.Controls.Add(Me.lblViewLabel)
        Me.pnlCard.Controls.Add(Me.btnRefresh)
        Me.pnlCard.Controls.Add(Me.btnExport)
        Me.pnlCard.Controls.Add(Me.lblTitle)

        ' Add search controls to Card
        Me.pnlCard.Controls.Add(Me.lblSearch)
        Me.pnlCard.Controls.Add(Me.txtSearch)

        Me.pnlCard.Controls.Add(Me.dgvData)
        Me.pnlCard.Location = New System.Drawing.Point(50, 90)
        Me.pnlCard.Name = "pnlCard"
        Me.pnlCard.Size = New System.Drawing.Size(900, 580) ' Increased height slightly
        Me.pnlCard.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(30, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(220, 32)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "System Overview"
        '
        'cmbView
        '
        Me.cmbView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbView.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.cmbView.FormattingEnabled = True
        Me.cmbView.Items.AddRange(New Object() {"Pending Verifications", "All Users", "All Jobs", "Closed Projects (Financials)"})
        Me.cmbView.Location = New System.Drawing.Point(400, 25)
        Me.cmbView.Name = "cmbView"
        Me.cmbView.Size = New System.Drawing.Size(220, 28)
        Me.cmbView.TabIndex = 11
        '
        'lblViewLabel
        '
        Me.lblViewLabel.AutoSize = True
        Me.lblViewLabel.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblViewLabel.Location = New System.Drawing.Point(305, 29)
        Me.lblViewLabel.Name = "lblViewLabel"
        Me.lblViewLabel.Size = New System.Drawing.Size(89, 20)
        Me.lblViewLabel.TabIndex = 12
        Me.lblViewLabel.Text = "Select Data:"
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.FlatAppearance.BorderSize = 0
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Location = New System.Drawing.Point(640, 20)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(100, 35)
        Me.btnRefresh.TabIndex = 1
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnExport
        '
        Me.btnExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExport.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnExport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExport.FlatAppearance.BorderSize = 0
        Me.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExport.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnExport.ForeColor = System.Drawing.Color.White
        Me.btnExport.Location = New System.Drawing.Point(750, 20)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(120, 35)
        Me.btnExport.TabIndex = 13
        Me.btnExport.Text = "Export to CSV"
        Me.btnExport.UseVisualStyleBackColor = False
        '
        'lblPendingCount (Adjusted Y to 75)
        '
        Me.lblPendingCount.AutoSize = True
        Me.lblPendingCount.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblPendingCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.lblPendingCount.Location = New System.Drawing.Point(30, 75)
        Me.lblPendingCount.Name = "lblPendingCount"
        Me.lblPendingCount.Size = New System.Drawing.Size(186, 21)
        Me.lblPendingCount.TabIndex = 14
        Me.lblPendingCount.Text = "Pending Verifications: 0"
        '
        'lblTotalUsers
        '
        Me.lblTotalUsers.AutoSize = True
        Me.lblTotalUsers.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalUsers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTotalUsers.Location = New System.Drawing.Point(240, 75)
        Me.lblTotalUsers.Name = "lblTotalUsers"
        Me.lblTotalUsers.Size = New System.Drawing.Size(69, 21)
        Me.lblTotalUsers.TabIndex = 8
        Me.lblTotalUsers.Text = "Users: 0"
        '
        'lblTotalJobs
        '
        Me.lblTotalJobs.AutoSize = True
        Me.lblTotalJobs.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalJobs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.lblTotalJobs.Location = New System.Drawing.Point(340, 75)
        Me.lblTotalJobs.Name = "lblTotalJobs"
        Me.lblTotalJobs.Size = New System.Drawing.Size(119, 21)
        Me.lblTotalJobs.TabIndex = 9
        Me.lblTotalJobs.Text = "Jobs Posted: 0"
        '
        'lblTotalMoney
        '
        Me.lblTotalMoney.AutoSize = True
        Me.lblTotalMoney.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalMoney.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.lblTotalMoney.Location = New System.Drawing.Point(500, 75)
        Me.lblTotalMoney.Name = "lblTotalMoney"
        Me.lblTotalMoney.Size = New System.Drawing.Size(140, 21)
        Me.lblTotalMoney.TabIndex = 10
        Me.lblTotalMoney.Text = "Economy: ₱0.00"
        '
        ' --- NEW: lblSearch ---
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblSearch.Location = New System.Drawing.Point(30, 115)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(125, 20)
        Me.lblSearch.TabIndex = 15
        Me.lblSearch.Text = "🔍 Live Search:"
        '
        ' --- NEW: txtSearch ---
        '
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtSearch.Location = New System.Drawing.Point(160, 112)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(710, 27)
        Me.txtSearch.TabIndex = 16
        '
        'dgvData (Adjusted Y to 150)
        '
        Me.dgvData.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvData.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvData.BackgroundColor = System.Drawing.Color.White
        Me.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvData.ColumnHeadersHeight = 40
        Me.dgvData.EnableHeadersVisualStyles = False
        Me.dgvData.Location = New System.Drawing.Point(30, 155) ' Moved down for Search Box
        Me.dgvData.Name = "dgvData"
        Me.dgvData.ReadOnly = True
        Me.dgvData.RowHeadersVisible = False
        Me.dgvData.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.dgvData.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvData.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvData.RowTemplate.Height = 45
        Me.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvData.Size = New System.Drawing.Size(840, 400)
        Me.dgvData.TabIndex = 2
        '
        'frmAdminDashboard
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 700)
        Me.Controls.Add(Me.pnlCard)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAdminDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TrabahoLocal Admin"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlCard.ResumeLayout(False)
        Me.pnlCard.PerformLayout()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblLogo As System.Windows.Forms.Label
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents pnlCard As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents dgvData As System.Windows.Forms.DataGridView
    Friend WithEvents lblTotalUsers As System.Windows.Forms.Label
    Friend WithEvents lblTotalJobs As System.Windows.Forms.Label
    Friend WithEvents lblTotalMoney As System.Windows.Forms.Label
    Friend WithEvents lblPendingCount As System.Windows.Forms.Label
    Friend WithEvents cmbView As System.Windows.Forms.ComboBox
    Friend WithEvents lblViewLabel As System.Windows.Forms.Label
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
End Class