<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmForgotPassword
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
        Me.pnlCard = New System.Windows.Forms.Panel()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.pnlStep1 = New System.Windows.Forms.Panel()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.btnSendOTP = New System.Windows.Forms.Button()
        Me.pnlStep2 = New System.Windows.Forms.Panel()
        Me.lblOTP = New System.Windows.Forms.Label()
        Me.txtInputOTP = New System.Windows.Forms.TextBox()
        Me.btnVerifyOTP = New System.Windows.Forms.Button()
        Me.pnlStep3 = New System.Windows.Forms.Panel()
        Me.lblNewPass = New System.Windows.Forms.Label()
        Me.txtNewPass = New System.Windows.Forms.TextBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.pnlCard.SuspendLayout()
        Me.pnlStep1.SuspendLayout()
        Me.pnlStep2.SuspendLayout()
        Me.pnlStep3.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlCard
        '
        Me.pnlCard.BackColor = System.Drawing.Color.White
        Me.pnlCard.Controls.Add(Me.btnBack)
        Me.pnlCard.Controls.Add(Me.lblHeader)
        Me.pnlCard.Controls.Add(Me.pnlStep1)
        Me.pnlCard.Controls.Add(Me.pnlStep2)
        Me.pnlCard.Controls.Add(Me.pnlStep3)
        Me.pnlCard.Location = New System.Drawing.Point(275, 100)
        Me.pnlCard.Name = "pnlCard"
        Me.pnlCard.Size = New System.Drawing.Size(450, 520)
        Me.pnlCard.TabIndex = 0
        '
        'lblHeader
        '
        Me.lblHeader.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeader.ForeColor = System.Drawing.Color.FromArgb(0, 82, 204)
        Me.lblHeader.Location = New System.Drawing.Point(0, 20)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(450, 45)
        Me.lblHeader.Text = "Reset Password"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlStep1 (Email Entry)
        '
        Me.pnlStep1.Controls.Add(Me.lblEmail)
        Me.pnlStep1.Controls.Add(Me.txtEmail)
        Me.pnlStep1.Controls.Add(Me.btnSendOTP)
        Me.pnlStep1.Location = New System.Drawing.Point(25, 80)
        Me.pnlStep1.Size = New System.Drawing.Size(400, 130)
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblEmail.Location = New System.Drawing.Point(10, 5)
        Me.lblEmail.Text = "Registered Email Address"
        '
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtEmail.Location = New System.Drawing.Point(10, 30)
        Me.txtEmail.Size = New System.Drawing.Size(380, 29)
        '
        Me.btnSendOTP.BackColor = System.Drawing.Color.FromArgb(0, 82, 204)
        Me.btnSendOTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSendOTP.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSendOTP.ForeColor = System.Drawing.Color.White
        Me.btnSendOTP.Location = New System.Drawing.Point(10, 75)
        Me.btnSendOTP.Size = New System.Drawing.Size(380, 40)
        Me.btnSendOTP.Text = "Send Verification Code"
        Me.btnSendOTP.UseVisualStyleBackColor = False
        '
        'pnlStep2 (OTP Verification)
        '
        Me.pnlStep2.Controls.Add(Me.lblOTP)
        Me.pnlStep2.Controls.Add(Me.txtInputOTP)
        Me.pnlStep2.Controls.Add(Me.btnVerifyOTP)
        Me.pnlStep2.Location = New System.Drawing.Point(25, 220)
        Me.pnlStep2.Size = New System.Drawing.Size(400, 130)
        Me.pnlStep2.Visible = False
        '
        Me.lblOTP.AutoSize = True
        Me.lblOTP.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblOTP.Location = New System.Drawing.Point(10, 5)
        Me.lblOTP.Text = "Enter 6-Digit OTP"
        '
        Me.txtInputOTP.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtInputOTP.Location = New System.Drawing.Point(10, 30)
        Me.txtInputOTP.Size = New System.Drawing.Size(380, 29)
        '
        Me.btnVerifyOTP.BackColor = System.Drawing.Color.FromArgb(108, 117, 125)
        Me.btnVerifyOTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerifyOTP.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnVerifyOTP.ForeColor = System.Drawing.Color.White
        Me.btnVerifyOTP.Location = New System.Drawing.Point(10, 75)
        Me.btnVerifyOTP.Size = New System.Drawing.Size(380, 40)
        Me.btnVerifyOTP.Text = "Verify Code"
        Me.btnVerifyOTP.UseVisualStyleBackColor = False
        '
        'pnlStep3 (New Password)
        '
        Me.pnlStep3.Controls.Add(Me.lblNewPass)
        Me.pnlStep3.Controls.Add(Me.txtNewPass)
        Me.pnlStep3.Controls.Add(Me.btnReset)
        Me.pnlStep3.Location = New System.Drawing.Point(25, 360)
        Me.pnlStep3.Size = New System.Drawing.Size(400, 130)
        Me.pnlStep3.Visible = False
        '
        Me.lblNewPass.AutoSize = True
        Me.lblNewPass.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblNewPass.Location = New System.Drawing.Point(10, 5)
        Me.lblNewPass.Text = "New Password"
        '
        Me.txtNewPass.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtNewPass.Location = New System.Drawing.Point(10, 30)
        Me.txtNewPass.Size = New System.Drawing.Size(380, 29)
        Me.txtNewPass.UseSystemPasswordChar = True
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(40, 167, 69)
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(10, 75)
        Me.btnReset.Size = New System.Drawing.Size(380, 40)
        Me.btnReset.Text = "Update Password"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Underline)
        Me.btnBack.ForeColor = System.Drawing.Color.Gray
        Me.btnBack.Location = New System.Drawing.Point(165, 485)
        Me.btnBack.Size = New System.Drawing.Size(120, 30)
        Me.btnBack.Text = "Back to Login"
        '
        'frmForgotPassword
        '
        Me.BackColor = System.Drawing.Color.FromArgb(245, 246, 248)
        Me.ClientSize = New System.Drawing.Size(1000, 700)
        Me.Controls.Add(Me.pnlCard)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmForgotPassword"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlCard.ResumeLayout(False)
        Me.pnlStep1.ResumeLayout(False)
        Me.pnlStep1.PerformLayout()
        Me.pnlStep2.ResumeLayout(False)
        Me.pnlStep2.PerformLayout()
        Me.pnlStep3.ResumeLayout(False)
        Me.pnlStep3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlCard As System.Windows.Forms.Panel
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents pnlStep1 As System.Windows.Forms.Panel
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents btnSendOTP As System.Windows.Forms.Button
    Friend WithEvents pnlStep2 As System.Windows.Forms.Panel
    Friend WithEvents lblOTP As System.Windows.Forms.Label
    Friend WithEvents txtInputOTP As System.Windows.Forms.TextBox
    Friend WithEvents btnVerifyOTP As System.Windows.Forms.Button
    Friend WithEvents pnlStep3 As System.Windows.Forms.Panel
    Friend WithEvents lblNewPass As System.Windows.Forms.Label
    Friend WithEvents txtNewPass As System.Windows.Forms.TextBox
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
End Class