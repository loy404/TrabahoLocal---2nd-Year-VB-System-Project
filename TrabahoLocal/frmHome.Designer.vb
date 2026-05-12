<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHome
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
        Me.picCoverPhoto = New System.Windows.Forms.PictureBox()
        Me.pnlSearch = New System.Windows.Forms.Panel()
        Me.txtSearchJob = New System.Windows.Forms.TextBox()
        Me.pnlDivider = New System.Windows.Forms.Panel()
        Me.txtSearchLoc = New System.Windows.Forms.TextBox()
        Me.btnFindJobs = New System.Windows.Forms.Button()
        Me.lblInstruction = New System.Windows.Forms.Label()
        Me.btnGetStarted = New System.Windows.Forms.Button()
        Me.btnSignIn = New System.Windows.Forms.Button()
        Me.btnPostJob = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblLogoHeader = New System.Windows.Forms.Label()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        CType(Me.picCoverPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSearch.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'picCoverPhoto
        '
        Me.picCoverPhoto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picCoverPhoto.Image = Global.TrabahoLocal.My.Resources.Resources.workers_cover
        Me.picCoverPhoto.Location = New System.Drawing.Point(0, 0)
        Me.picCoverPhoto.Name = "picCoverPhoto"
        Me.picCoverPhoto.Size = New System.Drawing.Size(1280, 800)
        Me.picCoverPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCoverPhoto.TabIndex = 1
        Me.picCoverPhoto.TabStop = False
        '
        'pnlSearch
        '
        Me.pnlSearch.BackColor = System.Drawing.Color.White
        Me.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSearch.Controls.Add(Me.txtSearchJob)
        Me.pnlSearch.Controls.Add(Me.pnlDivider)
        Me.pnlSearch.Controls.Add(Me.txtSearchLoc)
        Me.pnlSearch.Controls.Add(Me.btnFindJobs)
        Me.pnlSearch.Location = New System.Drawing.Point(290, 350)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Size = New System.Drawing.Size(700, 60)
        Me.pnlSearch.TabIndex = 2
        '
        'txtSearchJob
        '
        Me.txtSearchJob.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearchJob.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtSearchJob.ForeColor = System.Drawing.Color.Gray
        Me.txtSearchJob.Location = New System.Drawing.Point(20, 18)
        Me.txtSearchJob.Name = "txtSearchJob"
        Me.txtSearchJob.Size = New System.Drawing.Size(250, 22)
        Me.txtSearchJob.TabIndex = 0
        Me.txtSearchJob.Text = "Job title, keywords, or company"
        '
        'pnlDivider
        '
        Me.pnlDivider.BackColor = System.Drawing.Color.LightGray
        Me.pnlDivider.Location = New System.Drawing.Point(290, 10)
        Me.pnlDivider.Name = "pnlDivider"
        Me.pnlDivider.Size = New System.Drawing.Size(1, 40)
        Me.pnlDivider.TabIndex = 1
        '
        'txtSearchLoc
        '
        Me.txtSearchLoc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearchLoc.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtSearchLoc.ForeColor = System.Drawing.Color.Gray
        Me.txtSearchLoc.Location = New System.Drawing.Point(310, 18)
        Me.txtSearchLoc.Name = "txtSearchLoc"
        Me.txtSearchLoc.Size = New System.Drawing.Size(240, 22)
        Me.txtSearchLoc.TabIndex = 2
        Me.txtSearchLoc.Text = "Your Location"
        '
        'btnFindJobs
        '
        Me.btnFindJobs.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnFindJobs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFindJobs.FlatAppearance.BorderSize = 0
        Me.btnFindJobs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFindJobs.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnFindJobs.ForeColor = System.Drawing.Color.White
        Me.btnFindJobs.Location = New System.Drawing.Point(570, 8)
        Me.btnFindJobs.Name = "btnFindJobs"
        Me.btnFindJobs.Size = New System.Drawing.Size(120, 42)
        Me.btnFindJobs.TabIndex = 3
        Me.btnFindJobs.Text = "Find jobs"
        Me.btnFindJobs.UseVisualStyleBackColor = False
        '
        'lblInstruction
        '
        Me.lblInstruction.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblInstruction.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblInstruction.ForeColor = System.Drawing.Color.White
        Me.lblInstruction.Location = New System.Drawing.Point(320, 450)
        Me.lblInstruction.Name = "lblInstruction"
        Me.lblInstruction.Size = New System.Drawing.Size(640, 40)
        Me.lblInstruction.TabIndex = 3
        Me.lblInstruction.Text = "Create an account or sign in to see your personalized local job recommendations."
        Me.lblInstruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGetStarted
        '
        Me.btnGetStarted.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnGetStarted.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGetStarted.FlatAppearance.BorderSize = 0
        Me.btnGetStarted.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGetStarted.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnGetStarted.ForeColor = System.Drawing.Color.White
        Me.btnGetStarted.Location = New System.Drawing.Point(550, 500)
        Me.btnGetStarted.Name = "btnGetStarted"
        Me.btnGetStarted.Size = New System.Drawing.Size(180, 45)
        Me.btnGetStarted.TabIndex = 4
        Me.btnGetStarted.Text = "Get Started →"
        Me.btnGetStarted.UseVisualStyleBackColor = False
        '
        'btnSignIn
        '
        Me.btnSignIn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSignIn.BackColor = System.Drawing.Color.Transparent
        Me.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSignIn.FlatAppearance.BorderSize = 0
        Me.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSignIn.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSignIn.ForeColor = System.Drawing.Color.White
        Me.btnSignIn.Location = New System.Drawing.Point(1130, 15)
        Me.btnSignIn.Name = "btnSignIn"
        Me.btnSignIn.Size = New System.Drawing.Size(90, 35)
        Me.btnSignIn.TabIndex = 3
        Me.btnSignIn.Text = "Sign in"
        Me.btnSignIn.UseVisualStyleBackColor = False
        '
        'btnPostJob
        '
        Me.btnPostJob.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPostJob.BackColor = System.Drawing.Color.Transparent
        Me.btnPostJob.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPostJob.FlatAppearance.BorderSize = 0
        Me.btnPostJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPostJob.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnPostJob.ForeColor = System.Drawing.Color.White
        Me.btnPostJob.Location = New System.Drawing.Point(950, 15)
        Me.btnPostJob.Name = "btnPostJob"
        Me.btnPostJob.Size = New System.Drawing.Size(170, 35)
        Me.btnPostJob.TabIndex = 4
        Me.btnPostJob.Text = "Employers / Post Job"
        Me.btnPostJob.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(1230, 15)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(40, 35)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "X"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblLogoHeader
        '
        Me.lblLogoHeader.AutoSize = True
        Me.lblLogoHeader.BackColor = System.Drawing.Color.Transparent
        Me.lblLogoHeader.Font = New System.Drawing.Font("Segoe UI", 28.0!, System.Drawing.FontStyle.Bold)
        Me.lblLogoHeader.ForeColor = System.Drawing.Color.White
        Me.lblLogoHeader.Location = New System.Drawing.Point(20, 6)
        Me.lblLogoHeader.Name = "lblLogoHeader"
        Me.lblLogoHeader.Size = New System.Drawing.Size(257, 51)
        Me.lblLogoHeader.TabIndex = 0
        Me.lblLogoHeader.Text = "TrabahoLocal"
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblLogoHeader)
        Me.pnlHeader.Controls.Add(Me.btnExit)
        Me.pnlHeader.Controls.Add(Me.btnPostJob)
        Me.pnlHeader.Controls.Add(Me.btnSignIn)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1280, 62)
        Me.pnlHeader.TabIndex = 0
        '
        'frmHome
        '
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1280, 800)
        Me.Controls.Add(Me.btnGetStarted)
        Me.Controls.Add(Me.lblInstruction)
        Me.Controls.Add(Me.pnlSearch)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.picCoverPhoto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TrabahoLocal - Local Jobs Cebu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picCoverPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSearch.ResumeLayout(False)
        Me.pnlSearch.PerformLayout()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picCoverPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents pnlSearch As System.Windows.Forms.Panel
    Friend WithEvents txtSearchJob As System.Windows.Forms.TextBox
    Friend WithEvents pnlDivider As System.Windows.Forms.Panel
    Friend WithEvents txtSearchLoc As System.Windows.Forms.TextBox
    Friend WithEvents btnFindJobs As System.Windows.Forms.Button
    Friend WithEvents lblInstruction As System.Windows.Forms.Label
    Friend WithEvents btnGetStarted As System.Windows.Forms.Button
    Friend WithEvents btnSignIn As Button
    Friend WithEvents btnPostJob As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblLogoHeader As Label
    Friend WithEvents pnlHeader As Panel
End Class