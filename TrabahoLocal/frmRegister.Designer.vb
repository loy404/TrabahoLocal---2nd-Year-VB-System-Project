
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRegister
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
        Me.lblLogoHeader = New System.Windows.Forms.Label()
        Me.btnGoLogin = New System.Windows.Forms.Button()
        Me.btnGoHome = New System.Windows.Forms.Button()
        Me.pnlCard = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblConfirm = New System.Windows.Forms.Label()
        Me.txtConfirm = New System.Windows.Forms.TextBox()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.rbWorker = New System.Windows.Forms.RadioButton()
        Me.rbEmployer = New System.Windows.Forms.RadioButton()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.cmbCity = New System.Windows.Forms.ComboBox()
        Me.lblBarangay = New System.Windows.Forms.Label()
        Me.cmbBarangay = New System.Windows.Forms.ComboBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.btnRegister = New System.Windows.Forms.Button()

        Me.pnlHeader.SuspendLayout()
        Me.pnlCard.SuspendLayout()
        Me.SuspendLayout()

        ' --- HEADER PANEL ---
        Me.pnlHeader.BackColor = System.Drawing.Color.White
        Me.pnlHeader.Controls.Add(Me.lblLogoHeader)
        Me.pnlHeader.Controls.Add(Me.btnGoHome)
        Me.pnlHeader.Controls.Add(Me.btnGoLogin)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Height = 65

        Me.lblLogoHeader.AutoSize = True
        Me.lblLogoHeader.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblLogoHeader.ForeColor = System.Drawing.Color.FromArgb(0, 82, 204)
        Me.lblLogoHeader.Location = New System.Drawing.Point(20, 15)
        Me.lblLogoHeader.Text = "TrabahoLocal"

        Me.btnGoHome.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGoHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGoHome.FlatAppearance.BorderSize = 0
        Me.btnGoHome.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnGoHome.ForeColor = System.Drawing.Color.Gray
        Me.btnGoHome.Location = New System.Drawing.Point(680, 15)
        Me.btnGoHome.Size = New System.Drawing.Size(120, 35)
        Me.btnGoHome.Text = "← Home"
        Me.btnGoHome.Cursor = System.Windows.Forms.Cursors.Hand

        Me.btnGoLogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGoLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGoLogin.FlatAppearance.BorderSize = 0
        Me.btnGoLogin.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnGoLogin.ForeColor = System.Drawing.Color.FromArgb(0, 82, 204)
        Me.btnGoLogin.Location = New System.Drawing.Point(820, 15)
        Me.btnGoLogin.Size = New System.Drawing.Size(150, 35)
        Me.btnGoLogin.Text = "Sign In Instead"
        Me.btnGoLogin.Cursor = System.Windows.Forms.Cursors.Hand

        ' --- MAIN CARD ---
        Me.pnlCard.BackColor = System.Drawing.Color.White
        Me.pnlCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCard.Controls.Add(Me.lblTitle)
        Me.pnlCard.Controls.Add(Me.lblFirstName)
        Me.pnlCard.Controls.Add(Me.txtFirstName)
        Me.pnlCard.Controls.Add(Me.lblLastName)
        Me.pnlCard.Controls.Add(Me.txtLastName)
        Me.pnlCard.Controls.Add(Me.lblUser)
        Me.pnlCard.Controls.Add(Me.txtUsername)
        Me.pnlCard.Controls.Add(Me.lblPass)
        Me.pnlCard.Controls.Add(Me.txtPassword)
        Me.pnlCard.Controls.Add(Me.lblConfirm)
        Me.pnlCard.Controls.Add(Me.txtConfirm)
        Me.pnlCard.Controls.Add(Me.lblRole)
        Me.pnlCard.Controls.Add(Me.rbWorker)
        Me.pnlCard.Controls.Add(Me.rbEmployer)
        Me.pnlCard.Controls.Add(Me.lblCity)
        Me.pnlCard.Controls.Add(Me.cmbCity)
        Me.pnlCard.Controls.Add(Me.lblBarangay)
        Me.pnlCard.Controls.Add(Me.cmbBarangay)
        Me.pnlCard.Controls.Add(Me.lblEmail)
        Me.pnlCard.Controls.Add(Me.txtEmail)
        Me.pnlCard.Controls.Add(Me.btnRegister)
        Me.pnlCard.Location = New System.Drawing.Point(270, 80)
        Me.pnlCard.Size = New System.Drawing.Size(460, 750)

        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(34, 15)
        Me.lblTitle.Text = "Create your secure account"

        ' --- FIRST NAME (LEFT) ---
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblFirstName.Location = New System.Drawing.Point(37, 65)
        Me.lblFirstName.Text = "First Name"
        Me.txtFirstName.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtFirstName.Location = New System.Drawing.Point(40, 85)
        Me.txtFirstName.Size = New System.Drawing.Size(180, 29)

        ' --- LAST NAME (RIGHT) ---
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblLastName.Location = New System.Drawing.Point(227, 65)
        Me.lblLastName.Text = "Last Name"
        Me.txtLastName.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtLastName.Location = New System.Drawing.Point(230, 85)
        Me.txtLastName.Size = New System.Drawing.Size(180, 29)

        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblUser.Location = New System.Drawing.Point(37, 125)
        Me.lblUser.Text = "Username (Auto-Generated)"
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtUsername.Location = New System.Drawing.Point(40, 145)
        Me.txtUsername.Size = New System.Drawing.Size(370, 29)

        Me.lblPass.AutoSize = True
        Me.lblPass.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblPass.Location = New System.Drawing.Point(37, 185)
        Me.lblPass.Text = "Password"
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtPassword.Location = New System.Drawing.Point(40, 205)
        Me.txtPassword.Size = New System.Drawing.Size(370, 29)
        Me.txtPassword.UseSystemPasswordChar = True

        Me.lblConfirm.AutoSize = True
        Me.lblConfirm.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblConfirm.Location = New System.Drawing.Point(37, 245)
        Me.lblConfirm.Text = "Confirm Password"
        Me.txtConfirm.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtConfirm.Location = New System.Drawing.Point(40, 265)
        Me.txtConfirm.Size = New System.Drawing.Size(370, 29)
        Me.txtConfirm.UseSystemPasswordChar = True

        ' --- ROLE SELECTION (RadioButtons) ---
        Me.lblRole.AutoSize = True
        Me.lblRole.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblRole.Location = New System.Drawing.Point(37, 305)
        Me.lblRole.Text = "I am looking to..."

        Me.rbWorker.AutoSize = True
        Me.rbWorker.Checked = True
        Me.rbWorker.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.rbWorker.Location = New System.Drawing.Point(40, 325)
        Me.rbWorker.Size = New System.Drawing.Size(120, 23)
        Me.rbWorker.Text = "I want a Job"

        Me.rbEmployer.AutoSize = True
        Me.rbEmployer.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.rbEmployer.Location = New System.Drawing.Point(200, 325)
        Me.rbEmployer.Size = New System.Drawing.Size(130, 23)
        Me.rbEmployer.Text = "I want to Hire"

        ' --- LOCATION & EMAIL ---
        Me.lblCity.AutoSize = True
        Me.lblCity.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCity.Location = New System.Drawing.Point(37, 365)
        Me.lblCity.Text = "City / Municipality"
        Me.cmbCity.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCity.Location = New System.Drawing.Point(40, 385)
        Me.cmbCity.Size = New System.Drawing.Size(370, 29)

        Me.lblBarangay.AutoSize = True
        Me.lblBarangay.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblBarangay.Location = New System.Drawing.Point(37, 425)
        Me.lblBarangay.Text = "Barangay"
        Me.cmbBarangay.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmbBarangay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBarangay.Location = New System.Drawing.Point(40, 445)
        Me.cmbBarangay.Size = New System.Drawing.Size(370, 29)

        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblEmail.Location = New System.Drawing.Point(37, 485)
        Me.lblEmail.Text = "Active Email Address (For OTP Verification)"
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtEmail.Location = New System.Drawing.Point(40, 505)
        Me.txtEmail.Size = New System.Drawing.Size(370, 29)

        Me.btnRegister.BackColor = Color.FromArgb(0, 82, 204)
        Me.btnRegister.ForeColor = Color.White
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnRegister.Location = New System.Drawing.Point(40, 560)
        Me.btnRegister.Size = New System.Drawing.Size(370, 45)
        Me.btnRegister.Text = "Send Email OTP & Register"
        Me.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand

        ' --- FORM SETUP ---
        Me.ClientSize = New System.Drawing.Size(1000, 850)
        Me.BackColor = System.Drawing.Color.FromArgb(245, 246, 248)
        Me.Controls.Add(Me.pnlCard)
        Me.Controls.Add(Me.pnlHeader)
        Me.Name = "frmRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TrabahoLocal - Secure Registration"
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlCard.ResumeLayout(False)
        Me.pnlCard.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblLogoHeader As System.Windows.Forms.Label
    Friend WithEvents btnGoLogin As System.Windows.Forms.Button
    Friend WithEvents btnGoHome As System.Windows.Forms.Button
    Friend WithEvents pnlCard As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblPass As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblConfirm As System.Windows.Forms.Label
    Friend WithEvents txtConfirm As System.Windows.Forms.TextBox
    Friend WithEvents lblRole As System.Windows.Forms.Label
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents cmbCity As System.Windows.Forms.ComboBox
    Friend WithEvents lblBarangay As System.Windows.Forms.Label
    Friend WithEvents cmbBarangay As System.Windows.Forms.ComboBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents rbWorker As System.Windows.Forms.RadioButton
    Friend WithEvents rbEmployer As System.Windows.Forms.RadioButton
End Class