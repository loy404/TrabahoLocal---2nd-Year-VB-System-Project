<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmChat
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
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblChatName = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.rtbChatHistory = New System.Windows.Forms.RichTextBox()
        Me.pnlType = New System.Windows.Forms.Panel()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.tmrRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.pnlHeader.SuspendLayout()
        Me.pnlType.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblChatName)
        Me.pnlHeader.Controls.Add(Me.btnCancel)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(600, 70)
        Me.pnlHeader.TabIndex = 0
        '
        'lblChatName
        '
        Me.lblChatName.AutoSize = True
        Me.lblChatName.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblChatName.ForeColor = System.Drawing.Color.White
        Me.lblChatName.Location = New System.Drawing.Point(20, 20)
        Me.lblChatName.Name = "lblChatName"
        Me.lblChatName.Size = New System.Drawing.Size(147, 30)
        Me.lblChatName.TabIndex = 0
        Me.lblChatName.Text = "Chatting with"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(540, 15)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(40, 40)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "X"
        Me.btnCancel.UseVisualStyleBackColor = True
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
        Me.rtbChatHistory.Size = New System.Drawing.Size(600, 530)
        Me.rtbChatHistory.TabIndex = 1
        Me.rtbChatHistory.Text = ""
        '
        'pnlType
        '
        Me.pnlType.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.pnlType.Controls.Add(Me.txtMessage)
        Me.pnlType.Controls.Add(Me.btnSend)
        Me.pnlType.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlType.Location = New System.Drawing.Point(0, 600)
        Me.pnlType.Name = "pnlType"
        Me.pnlType.Size = New System.Drawing.Size(600, 100)
        Me.pnlType.TabIndex = 2
        '
        'txtMessage
        '
        Me.txtMessage.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtMessage.Location = New System.Drawing.Point(20, 20)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(440, 60)
        Me.txtMessage.TabIndex = 0
        '
        'btnSend
        '
        Me.btnSend.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnSend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSend.FlatAppearance.BorderSize = 0
        Me.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSend.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnSend.ForeColor = System.Drawing.Color.White
        Me.btnSend.Location = New System.Drawing.Point(470, 20)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(110, 60)
        Me.btnSend.TabIndex = 1
        Me.btnSend.Text = "SEND ▶"
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'tmrRefresh
        '
        Me.tmrRefresh.Interval = 3000
        '
        'frmChat
        '
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(600, 700)
        Me.Controls.Add(Me.rtbChatHistory)
        Me.Controls.Add(Me.pnlType)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Name = "frmChat"
        Me.Text = "Messenger"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlType.ResumeLayout(False)
        Me.pnlType.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblChatName As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents rtbChatHistory As RichTextBox
    Friend WithEvents pnlType As Panel
    Friend WithEvents txtMessage As TextBox
    Friend WithEvents btnSend As Button
    Friend WithEvents tmrRefresh As Timer
End Class