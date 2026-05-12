<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSearchResults
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()

        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.dgvResults = New System.Windows.Forms.DataGridView()

        Me.pnlHeader.SuspendLayout()
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        ' --- HEADER PANEL ---
        Me.pnlHeader.BackColor = System.Drawing.Color.White
        Me.pnlHeader.Controls.Add(Me.btnClose)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Height = 65

        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(0, 82, 204)
        Me.lblTitle.Location = New System.Drawing.Point(20, 15)
        Me.lblTitle.Text = "Job Search Results"

        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnClose.ForeColor = System.Drawing.Color.Red
        Me.btnClose.Location = New System.Drawing.Point(680, 15)
        Me.btnClose.Size = New System.Drawing.Size(100, 35)
        Me.btnClose.Text = "Close"
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand

        ' --- BEAUTIFUL DATA GRID (TABLE) ---
        Me.dgvResults.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvResults.BackgroundColor = System.Drawing.Color.FromArgb(245, 246, 248)
        Me.dgvResults.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvResults.ReadOnly = True
        Me.dgvResults.AllowUserToAddRows = False
        Me.dgvResults.RowHeadersVisible = False
        Me.dgvResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect

        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(204, 228, 255)
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvResults.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1

        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvResults.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvResults.ColumnHeadersHeight = 40
        Me.dgvResults.EnableHeadersVisualStyles = False

        Me.dgvResults.RowTemplate.Height = 45
        Me.dgvResults.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.dgvResults.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(204, 228, 255)
        Me.dgvResults.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black

        ' --- FORM SETUP ---
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.BackColor = System.Drawing.Color.FromArgb(245, 246, 248)
        Me.Controls.Add(Me.dgvResults)
        Me.Controls.Add(Me.pnlHeader)
        Me.Name = "frmSearchResults"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search Results"
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False

        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents dgvResults As System.Windows.Forms.DataGridView
End Class