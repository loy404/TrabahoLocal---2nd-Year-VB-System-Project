<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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

    ' Fix for the memory cleanup error
    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblLogoHeader = New System.Windows.Forms.Label()
        Me.btnGoRegister = New System.Windows.Forms.Button()
        Me.btnGoHome = New System.Windows.Forms.Button()
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.picHero = New System.Windows.Forms.PictureBox()
        Me.pnlLoginArea = New System.Windows.Forms.Panel()
        Me.pnlCard = New System.Windows.Forms.Panel()
        Me.lblLogo = New System.Windows.Forms.Label()
        Me.lblSubtext = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblForgot = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.pnlHeader.SuspendLayout()
        Me.pnlSidebar.SuspendLayout()
        CType(Me.picHero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLoginArea.SuspendLayout()
        Me.pnlCard.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.White
        Me.pnlHeader.Controls.Add(Me.lblLogoHeader)
        Me.pnlHeader.Controls.Add(Me.btnGoHome)
        Me.pnlHeader.Controls.Add(Me.btnGoRegister)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1200, 70)
        Me.pnlHeader.TabIndex = 0
        '
        'lblLogoHeader
        '
        Me.lblLogoHeader.AutoSize = True
        Me.lblLogoHeader.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblLogoHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblLogoHeader.Location = New System.Drawing.Point(30, 18)
        Me.lblLogoHeader.Name = "lblLogoHeader"
        Me.lblLogoHeader.Size = New System.Drawing.Size(168, 32)
        Me.lblLogoHeader.TabIndex = 0
        Me.lblLogoHeader.Text = "TrabahoLocal"
        '
        'btnGoHome
        '
        Me.btnGoHome.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGoHome.BackColor = System.Drawing.Color.White
        Me.btnGoHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGoHome.FlatAppearance.BorderSize = 0
        Me.btnGoHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGoHome.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnGoHome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnGoHome.Location = New System.Drawing.Point(920, 15)
        Me.btnGoHome.Name = "btnGoHome"
        Me.btnGoHome.Size = New System.Drawing.Size(110, 40)
        Me.btnGoHome.TabIndex = 1
        Me.btnGoHome.Text = "← Home"
        Me.btnGoHome.UseVisualStyleBackColor = False
        '
        'btnGoRegister
        '
        Me.btnGoRegister.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGoRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnGoRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGoRegister.FlatAppearance.BorderSize = 0
        Me.btnGoRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGoRegister.Font = New System.Drawing.Font("Segoe UI Bold", 10.0!)
        Me.btnGoRegister.ForeColor = System.Drawing.Color.White
        Me.btnGoRegister.Location = New System.Drawing.Point(1050, 15)
        Me.btnGoRegister.Name = "btnGoRegister"
        Me.btnGoRegister.Size = New System.Drawing.Size(120, 40)
        Me.btnGoRegister.TabIndex = 2
        Me.btnGoRegister.Text = "Register"
        Me.btnGoRegister.UseVisualStyleBackColor = False
        '
        'pnlSidebar
        '
        Me.pnlSidebar.Controls.Add(Me.picHero)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 70)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(540, 730)
        Me.pnlSidebar.TabIndex = 1
        '
        'picHero
        '
        Me.picHero.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picHero.Image = Global.TrabahoLocal.My.Resources.Resources.login_hero
        Me.picHero.Location = New System.Drawing.Point(0, 0)
        Me.picHero.Name = "picHero"
        Me.picHero.Size = New System.Drawing.Size(540, 730)
        Me.picHero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picHero.TabIndex = 0
        Me.picHero.TabStop = False
        '
        'pnlLoginArea
        '
        Me.pnlLoginArea.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.pnlLoginArea.Controls.Add(Me.pnlCard)
        Me.pnlLoginArea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlLoginArea.Location = New System.Drawing.Point(540, 70)
        Me.pnlLoginArea.Name = "pnlLoginArea"
        Me.pnlLoginArea.Size = New System.Drawing.Size(660, 730)
        Me.pnlLoginArea.TabIndex = 2
        '
        'pnlCard
        '
        Me.pnlCard.BackColor = System.Drawing.Color.White
        Me.pnlCard.Controls.Add(Me.lblLogo)
        Me.pnlCard.Controls.Add(Me.lblSubtext)
        Me.pnlCard.Controls.Add(Me.lblUser)
        Me.pnlCard.Controls.Add(Me.txtUsername)
        Me.pnlCard.Controls.Add(Me.lblPass)
        Me.pnlCard.Controls.Add(Me.txtPassword)
        Me.pnlCard.Controls.Add(Me.lblForgot)
        Me.pnlCard.Controls.Add(Me.btnLogin)
        Me.pnlCard.Location = New System.Drawing.Point(100, 100)
        Me.pnlCard.Name = "pnlCard"
        Me.pnlCard.Size = New System.Drawing.Size(450, 520)
        Me.pnlCard.TabIndex = 0
        '
        'lblLogo
        '
        Me.lblLogo.AutoSize = True
        Me.lblLogo.Font = New System.Drawing.Font("Segoe UI", 32.0!, System.Drawing.FontStyle.Bold)
        Me.lblLogo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.lblLogo.Location = New System.Drawing.Point(35, 40)
        Me.lblLogo.Name = "lblLogo"
        Me.lblLogo.Size = New System.Drawing.Size(325, 59)
        Me.lblLogo.Text = "Welcome Back"
        '
        'lblSubtext
        '
        Me.lblSubtext.AutoSize = True
        Me.lblSubtext.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lblSubtext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.lblSubtext.Location = New System.Drawing.Point(40, 105)
        Me.lblSubtext.Name = "lblSubtext"
        Me.lblSubtext.Size = New System.Drawing.Size(296, 20)
        Me.lblSubtext.Text = "Enter your credentials to access your portal."
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.lblUser.Location = New System.Drawing.Point(40, 160)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(71, 19)
        Me.lblUser.Text = "Username"
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtUsername.Location = New System.Drawing.Point(44, 185)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(360, 29)
        Me.txtUsername.TabIndex = 1
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.lblPass.Location = New System.Drawing.Point(40, 240)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(67, 19)
        Me.lblPass.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtPassword.Location = New System.Drawing.Point(44, 265)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(360, 29)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'lblForgot
        '
        Me.lblForgot.AutoSize = True
        Me.lblForgot.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblForgot.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblForgot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblForgot.Location = New System.Drawing.Point(300, 305)
        Me.lblForgot.Name = "lblForgot"
        Me.lblForgot.Size = New System.Drawing.Size(104, 15)
        Me.lblForgot.TabIndex = 6
        Me.lblForgot.Text = "Forgot Password?"
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(44, 370)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(360, 50)
        Me.btnLogin.TabIndex = 7
        Me.btnLogin.Text = "Sign In to TrabahoLocal"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'frmLogin
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1200, 800)
        Me.Controls.Add(Me.pnlLoginArea)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TrabahoLocal - Sign In"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlSidebar.ResumeLayout(False)
        CType(Me.picHero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLoginArea.ResumeLayout(False)
        Me.pnlCard.ResumeLayout(False)
        Me.pnlCard.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblLogoHeader As System.Windows.Forms.Label
    Friend WithEvents btnGoRegister As System.Windows.Forms.Button
    Friend WithEvents btnGoHome As System.Windows.Forms.Button
    Friend WithEvents pnlSidebar As System.Windows.Forms.Panel
    Friend WithEvents picHero As System.Windows.Forms.PictureBox
    Friend WithEvents pnlLoginArea As System.Windows.Forms.Panel
    Friend WithEvents pnlCard As System.Windows.Forms.Panel
    Friend WithEvents lblLogo As System.Windows.Forms.Label
    Friend WithEvents lblSubtext As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblPass As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents lblForgot As System.Windows.Forms.Label
End Class