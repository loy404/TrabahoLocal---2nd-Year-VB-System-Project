Imports System.Drawing

Public Class frmLogin

    Private WithEvents fadeTimer As New Timer()

    ' --- LOAD EVENT ---
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        ' Layering Fix: Force Header to top
        pnlHeader.BringToFront()

        Me.Opacity = 0
        fadeTimer.Interval = 15
        fadeTimer.Start()
    End Sub

    ' --- FADE TIMER ---
    Private Sub fadeTimer_Tick(sender As Object, e As EventArgs) Handles fadeTimer.Tick
        If Me.Opacity < 1.0 Then
            Me.Opacity += 0.05
        Else
            fadeTimer.Stop()
        End If
    End Sub

    ' --- RESIZE EVENT (Split Screen Positioning) ---
    Private Sub frmLogin_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If pnlSidebar Is Nothing OrElse pnlLoginArea Is Nothing Then Exit Sub

        ' 1. Sidebar takes 45% of width
        pnlSidebar.Width = CInt(Me.Width * 0.45)

        ' 2. Center the Login Card in the right half area
        If pnlCard IsNot Nothing Then
            pnlCard.Left = CInt((pnlLoginArea.Width - pnlCard.Width) / 2)
            pnlCard.Top = CInt((pnlLoginArea.Height - pnlCard.Height) / 2.2)
        End If

        ' 3. Fix Button Positions in Header
        If btnGoRegister IsNot Nothing AndAlso btnGoHome IsNot Nothing Then
            btnGoRegister.Location = New Point(Me.Width - btnGoRegister.Width - 30, 15)
            btnGoHome.Location = New Point(btnGoRegister.Left - btnGoHome.Width - 15, 15)

            btnGoRegister.BringToFront()
            btnGoHome.BringToFront()
        End If
    End Sub

    ' --- HOVER EFFECTS ---
    Private Sub MainButtons_MouseEnter(sender As Object, e As EventArgs) Handles btnLogin.MouseEnter, btnGoRegister.MouseEnter
        Dim btn As Button = CType(sender, Button)
        btn.BackColor = Color.FromArgb(51, 133, 255)
    End Sub

    Private Sub MainButtons_MouseLeave(sender As Object, e As EventArgs) Handles btnLogin.MouseLeave, btnGoRegister.MouseLeave
        Dim btn As Button = CType(sender, Button)
        btn.BackColor = Color.FromArgb(0, 82, 204)
    End Sub

    Private Sub btnGoHome_MouseEnter(sender As Object, e As EventArgs) Handles btnGoHome.MouseEnter
        btnGoHome.BackColor = Color.FromArgb(240, 242, 245)
        btnGoHome.ForeColor = Color.FromArgb(0, 82, 204)
    End Sub

    Private Sub btnGoHome_MouseLeave(sender As Object, e As EventArgs) Handles btnGoHome.MouseLeave
        btnGoHome.BackColor = Color.White
        btnGoHome.ForeColor = Color.Gray
    End Sub

    ' --- LOGIC ---
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If String.IsNullOrWhiteSpace(txtUsername.Text) Or String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MsgBox("Please enter your credentials.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim userRole As String = AuthManager.LoginUser(txtUsername.Text.Trim(), txtPassword.Text)

        Select Case userRole
            Case "Worker"
                Dim workerDash As New frmWorkerDashboard()
                workerDash.Show()
                Me.Hide()
            Case "Employer", "Employeer"
                Dim empDash As New frmEmployeerDashboard()
                empDash.Show()
                Me.Hide()
            Case "Admin"
                Dim adminDash As New frmAdminDashboard()
                adminDash.Show()
                Me.Hide()
            Case Else
                MsgBox("Invalid login. Try again.", MsgBoxStyle.Critical)
        End Select
    End Sub

    Private Sub btnGoHome_Click(sender As Object, e As EventArgs) Handles btnGoHome.Click
        Dim home As New frmHome()
        home.Show()
        Me.Close()
    End Sub

    Private Sub btnGoRegister_Click(sender As Object, e As EventArgs) Handles btnGoRegister.Click
        Dim reg As New frmRegister()
        reg.Show()
        Me.Hide()
    End Sub
End Class