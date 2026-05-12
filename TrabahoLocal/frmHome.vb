Imports System.Drawing

Public Class frmHome

    ' ==========================================
    ' Timer for Smooth Fade-In Transition
    ' ==========================================
    Private WithEvents fadeTimer As New Timer()

    ' --- LOAD EVENT: Setup Full Screen and Fade ---
    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. Form Configuration
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        ' 2. Setup Fade Transition
        Me.Opacity = 0
        fadeTimer.Interval = 15
        fadeTimer.Start()

        ' 3. Layering: Ensure interactive elements float ABOVE the photo
        pnlHeader.BringToFront()
        pnlSearch.BringToFront()
        btnGetStarted.BringToFront()
        lblInstruction.BringToFront()
    End Sub

    ' --- FADE TIMER TICK ---
    Private Sub fadeTimer_Tick(sender As Object, e As EventArgs) Handles fadeTimer.Tick
        If Me.Opacity < 1.0 Then
            Me.Opacity += 0.05
        Else
            fadeTimer.Stop()
        End If
    End Sub

    ' --- RESIZE EVENT: Advanced Centering for Full-Screen Layout ---
    Private Sub frmHome_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ' Safety check for designer initialization
        If lblLogoHeader Is Nothing Then Exit Sub

        ' 1. Position Header Buttons (Right-aligned)
        btnExit.Left = Me.Width - btnExit.Width - 15
        btnSignIn.Left = btnExit.Left - btnSignIn.Width - 10
        btnPostJob.Left = btnSignIn.Left - btnPostJob.Width - 10

        ' 2. Center and Position the Search Panel (The visual anchor)
        If pnlSearch IsNot Nothing Then
            ' Perfectly center horizontally
            pnlSearch.Left = CInt((Me.Width - pnlSearch.Width) / 2)

            ' Position it exactly in the middle of the screen vertically
            pnlSearch.Top = CInt((Me.Height - pnlSearch.Height) / 2)
        End If

        ' 3. Position the Call-to-Action (Instruction and Register Button)
        If lblInstruction IsNot Nothing AndAlso btnGetStarted IsNot Nothing Then
            ' Center Instruction below the search bar
            lblInstruction.Left = CInt((Me.Width - lblInstruction.Width) / 2)
            lblInstruction.Top = pnlSearch.Bottom + 40

            ' Center "Get Started" button below the instruction
            btnGetStarted.Left = CInt((Me.Width - btnGetStarted.Width) / 2)
            btnGetStarted.Top = lblInstruction.Bottom + 20
        End If
    End Sub

    ' ==========================================
    ' MODERN INTERACTIVE HOVER EFFECTS
    ' ==========================================

    ' Main Buttons (Blue buttons)
    Private Sub MainButtons_MouseEnter(sender As Object, e As EventArgs) Handles btnGetStarted.MouseEnter, btnFindJobs.MouseEnter
        Dim btn As Button = CType(sender, Button)
        btn.BackColor = Color.FromArgb(51, 133, 255) ' Lighter Blue
    End Sub

    Private Sub MainButtons_MouseLeave(sender As Object, e As EventArgs) Handles btnGetStarted.MouseLeave, btnFindJobs.MouseLeave
        Dim btn As Button = CType(sender, Button)
        btn.BackColor = Color.FromArgb(0, 82, 204) ' Standard Blue
    End Sub

    ' Header Navigation (White text on Blue background)
    Private Sub HeaderButtons_MouseEnter(sender As Object, e As EventArgs) Handles btnSignIn.MouseEnter, btnPostJob.MouseEnter
        Dim btn As Button = CType(sender, Button)
        ' Provide a subtle background when hovering over the blue header
        btn.BackColor = Color.FromArgb(40, 255, 255, 255)
    End Sub

    Private Sub HeaderButtons_MouseLeave(sender As Object, e As EventArgs) Handles btnSignIn.MouseLeave, btnPostJob.MouseLeave
        Dim btn As Button = CType(sender, Button)
        btn.BackColor = Color.Transparent
    End Sub

    ' Exit Button
    Private Sub btnExit_MouseEnter(sender As Object, e As EventArgs) Handles btnExit.MouseEnter
        btnExit.BackColor = Color.FromArgb(220, 53, 69) ' Professional Red
    End Sub

    Private Sub btnExit_MouseLeave(sender As Object, e As EventArgs) Handles btnExit.MouseLeave
        btnExit.BackColor = Color.Transparent
    End Sub

    ' ==========================================
    ' NAVIGATION LOGIC
    ' ==========================================
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click, btnPostJob.Click
        Dim login As New frmLogin()
        login.Show()
        Me.Hide()
    End Sub

    Private Sub btnGetStarted_Click(sender As Object, e As EventArgs) Handles btnGetStarted.Click
        Dim register As New frmRegister()
        register.Show()
        Me.Hide()
    End Sub

    ' ==========================================
    ' SEARCH ENGINE LOGIC
    ' ==========================================
    Private Sub btnFindJobs_Click(sender As Object, e As EventArgs) Handles btnFindJobs.Click
        Dim searchPage As New frmSearchResults()

        ' Ignore placeholder text during search
        searchPage.SearchKeyword = If(txtSearchJob.Text = "Job title, keywords, or company", "", txtSearchJob.Text)
        searchPage.SearchLocation = If(txtSearchLoc.Text = "Your Location", "", txtSearchLoc.Text)

        searchPage.ShowDialog()
    End Sub

    ' Placeholder Text Magic (Job Input)
    Private Sub txtSearchJob_Enter(sender As Object, e As EventArgs) Handles txtSearchJob.Enter
        If txtSearchJob.Text = "Job title, keywords, or company" Then
            txtSearchJob.Text = ""
            txtSearchJob.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtSearchJob_Leave(sender As Object, e As EventArgs) Handles txtSearchJob.Leave
        If String.IsNullOrWhiteSpace(txtSearchJob.Text) Then
            txtSearchJob.Text = "Job title, keywords, or company"
            txtSearchJob.ForeColor = Color.Gray
        End If
    End Sub

    ' Placeholder Text Magic (Location Input)
    Private Sub txtSearchLoc_Enter(sender As Object, e As EventArgs) Handles txtSearchLoc.Enter
        If txtSearchLoc.Text = "Your Location" Then
            txtSearchLoc.Text = ""
            txtSearchLoc.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtSearchLoc_Leave(sender As Object, e As EventArgs) Handles txtSearchLoc.Leave
        If String.IsNullOrWhiteSpace(txtSearchLoc.Text) Then
            txtSearchLoc.Text = "Your Location"
            txtSearchLoc.ForeColor = Color.Gray
        End If
    End Sub

End Class