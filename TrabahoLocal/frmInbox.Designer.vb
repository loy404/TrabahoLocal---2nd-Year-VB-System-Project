<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInbox
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
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.dgvConversations = New System.Windows.Forms.DataGridView()
        Me.lblInboxTitle = New System.Windows.Forms.Label()
        Me.pnlChatArea = New System.Windows.Forms.Panel()
        Me.rtbChatHistory = New System.Windows.Forms.RichTextBox()
        Me.pnlType = New System.Windows.Forms.Panel()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.pnlChatHeader = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblChatJobTitle = New System.Windows.Forms.Label()
        Me.lblChatName = New System.Windows.Forms.Label()
        Me.tmrRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.pnlSidebar.SuspendLayout()
        CType(Me.dgvConversations, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlChatArea.SuspendLayout()
        Me.pnlType.SuspendLayout()
        Me.pnlChatHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.pnlSidebar.Controls.Add(Me.dgvConversations)
        Me.pnlSidebar.Controls.Add(Me.lblInboxTitle)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(300, 650)
        Me.pnlSidebar.TabIndex = 0
        '
        'dgvConversations
        '
        Me.dgvConversations.AllowUserToAddRows = False
        Me.dgvConversations.AllowUserToDeleteRows = False
        Me.dgvConversations.AllowUserToResizeColumns = False
        Me.dgvConversations.AllowUserToResizeRows = False
        Me.dgvConversations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvConversations.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.dgvConversations.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvConversations.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvConversations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConversations.ColumnHeadersVisible = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(212, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvConversations.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvConversations.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvConversations.Location = New System.Drawing.Point(0, 70)
        Me.dgvConversations.MultiSelect = False
        Me.dgvConversations.Name = "dgvConversations"
        Me.dgvConversations.ReadOnly = True
        Me.dgvConversations.RowHeadersVisible = False
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(10)
        Me.dgvConversations.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvConversations.RowTemplate.Height = 60
        Me.dgvConversations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvConversations.Size = New System.Drawing.Size(300, 580)
        Me.dgvConversations.TabIndex = 1
        '
        'lblInboxTitle
        '
        Me.lblInboxTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblInboxTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblInboxTitle.ForeColor = System.Drawing.Color.White
        Me.lblInboxTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblInboxTitle.Name = "lblInboxTitle"
        Me.lblInboxTitle.Size = New System.Drawing.Size(300, 70)
        Me.lblInboxTitle.TabIndex = 0
        Me.lblInboxTitle.Text = "💬 Conversations"
        Me.lblInboxTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlChatArea
        '
        Me.pnlChatArea.Controls.Add(Me.rtbChatHistory)
        Me.pnlChatArea.Controls.Add(Me.pnlType)
        Me.pnlChatArea.Controls.Add(Me.pnlChatHeader)
        Me.pnlChatArea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlChatArea.Location = New System.Drawing.Point(300, 0)
        Me.pnlChatArea.Name = "pnlChatArea"
        Me.pnlChatArea.Size = New System.Drawing.Size(650, 650)
        Me.pnlChatArea.TabIndex = 1
        '
        'rtbChatHistory
        '
        Me.rtbChatHistory.BackColor = System.Drawing.Color.White
        Me.rtbChatHistory.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbChatHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbChatHistory.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.rtbChatHistory.Location = New System.Drawing.Point(0, 70)
        Me.rtbChatHistory.Name = "rtbChatHistory"
        Me.rtbChatHistory.ReadOnly = True
        Me.rtbChatHistory.Size = New System.Drawing.Size(650, 480)
        Me.rtbChatHistory.TabIndex = 3
        Me.rtbChatHistory.Text = ""
        '
        'pnlType
        '
        Me.pnlType.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.pnlType.Controls.Add(Me.txtMessage)
        Me.pnlType.Controls.Add(Me.btnSend)
        Me.pnlType.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlType.Location = New System.Drawing.Point(0, 550)
        Me.pnlType.Name = "pnlType"
        Me.pnlType.Size = New System.Drawing.Size(650, 100)
        Me.pnlType.TabIndex = 4
        '
        'txtMessage
        '
        Me.txtMessage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMessage.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtMessage.Location = New System.Drawing.Point(20, 20)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(490, 60)
        Me.txtMessage.TabIndex = 0
        '
        'btnSend
        '
        Me.btnSend.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSend.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnSend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSend.FlatAppearance.BorderSize = 0
        Me.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSend.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnSend.ForeColor = System.Drawing.Color.White
        Me.btnSend.Location = New System.Drawing.Point(520, 20)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(110, 60)
        Me.btnSend.TabIndex = 1
        Me.btnSend.Text = "SEND ▶"
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'pnlChatHeader
        '
        Me.pnlChatHeader.BackColor = System.Drawing.Color.White
        Me.pnlChatHeader.Controls.Add(Me.btnCancel)
        Me.pnlChatHeader.Controls.Add(Me.lblChatJobTitle)
        Me.pnlChatHeader.Controls.Add(Me.lblChatName)
        Me.pnlChatHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlChatHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlChatHeader.Name = "pnlChatHeader"
        Me.pnlChatHeader.Size = New System.Drawing.Size(650, 70)
        Me.pnlChatHeader.TabIndex = 2
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.Gray
        Me.btnCancel.Location = New System.Drawing.Point(590, 15)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(40, 40)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "X"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblChatJobTitle
        '
        Me.lblChatJobTitle.AutoSize = True
        Me.lblChatJobTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblChatJobTitle.ForeColor = System.Drawing.Color.Gray
        Me.lblChatJobTitle.Location = New System.Drawing.Point(20, 40)
        Me.lblChatJobTitle.Name = "lblChatJobTitle"
        Me.lblChatJobTitle.Size = New System.Drawing.Size(185, 19)
        Me.lblChatJobTitle.TabIndex = 2
        Me.lblChatJobTitle.Text = "Project: Select a conversation"
        '
        'lblChatName
        '
        Me.lblChatName.AutoSize = True
        Me.lblChatName.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblChatName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.lblChatName.Location = New System.Drawing.Point(18, 10)
        Me.lblChatName.Name = "lblChatName"
        Me.lblChatName.Size = New System.Drawing.Size(227, 30)
        Me.lblChatName.TabIndex = 1
        Me.lblChatName.Text = "No Active Chat Open"
        '
        'tmrRefresh
        '
        Me.tmrRefresh.Interval = 3000
        '
        'frmInbox
        '
        Me.ClientSize = New System.Drawing.Size(950, 650)
        Me.Controls.Add(Me.pnlChatArea)
        Me.Controls.Add(Me.pnlSidebar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Name = "frmInbox"
        Me.pnlSidebar.ResumeLayout(False)
        CType(Me.dgvConversations, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlChatArea.ResumeLayout(False)
        Me.pnlType.ResumeLayout(False)
        Me.pnlType.PerformLayout()
        Me.pnlChatHeader.ResumeLayout(False)
        Me.pnlChatHeader.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents lblInboxTitle As Label
    Friend WithEvents dgvConversations As DataGridView
    Friend WithEvents pnlChatArea As Panel
    Friend WithEvents pnlChatHeader As Panel
    Friend WithEvents lblChatName As Label
    Friend WithEvents lblChatJobTitle As Label
    Friend WithEvents rtbChatHistory As RichTextBox
    Friend WithEvents pnlType As Panel
    Friend WithEvents txtMessage As TextBox
    Friend WithEvents btnSend As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents tmrRefresh As Timer
End Class