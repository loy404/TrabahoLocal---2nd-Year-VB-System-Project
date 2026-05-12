<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReviewWorker
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblWorkerName = New System.Windows.Forms.Label()
        Me.lblRating = New System.Windows.Forms.Label()
        Me.cmbRating = New System.Windows.Forms.ComboBox()
        Me.lblComments = New System.Windows.Forms.Label()
        Me.txtComments = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(500, 70)
        Me.pnlHeader.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(20, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(268, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Review & Finalize Project"
        '
        'lblWorkerName
        '
        Me.lblWorkerName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblWorkerName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblWorkerName.Location = New System.Drawing.Point(30, 90)
        Me.lblWorkerName.Name = "lblWorkerName"
        Me.lblWorkerName.Size = New System.Drawing.Size(440, 30)
        Me.lblWorkerName.TabIndex = 1
        Me.lblWorkerName.Text = "Leave Feedback for: [Worker Name]"
        Me.lblWorkerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRating
        '
        Me.lblRating.AutoSize = True
        Me.lblRating.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblRating.Location = New System.Drawing.Point(30, 140)
        Me.lblRating.Name = "lblRating"
        Me.lblRating.Size = New System.Drawing.Size(126, 19)
        Me.lblRating.TabIndex = 2
        Me.lblRating.Text = "Overall Star Rating"
        '
        'cmbRating
        '
        Me.cmbRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRating.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmbRating.FormattingEnabled = True
        Me.cmbRating.Items.AddRange(New Object() {"5 - ⭐⭐⭐⭐⭐ (Excellent)", "4 - ⭐⭐⭐⭐ (Very Good)", "3 - ⭐⭐⭐ (Average)", "2 - ⭐⭐ (Poor)", "1 - ⭐ (Terrible)"})
        Me.cmbRating.Location = New System.Drawing.Point(30, 165)
        Me.cmbRating.Name = "cmbRating"
        Me.cmbRating.Size = New System.Drawing.Size(440, 29)
        Me.cmbRating.TabIndex = 3
        '
        'lblComments
        '
        Me.lblComments.AutoSize = True
        Me.lblComments.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblComments.Location = New System.Drawing.Point(30, 215)
        Me.lblComments.Name = "lblComments"
        Me.lblComments.Size = New System.Drawing.Size(262, 19)
        Me.lblComments.TabIndex = 4
        Me.lblComments.Text = "Public Feedback (Visible on their Profile)"
        '
        'txtComments
        '
        Me.txtComments.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.txtComments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtComments.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtComments.Location = New System.Drawing.Point(30, 240)
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(440, 120)
        Me.txtComments.TabIndex = 5
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubmit.FlatAppearance.BorderSize = 0
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(30, 390)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(440, 45)
        Me.btnSubmit.TabIndex = 6
        Me.btnSubmit.Text = "✔ Submit Review && Close Contract"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Underline)
        Me.btnCancel.ForeColor = System.Drawing.Color.Gray
        Me.btnCancel.Location = New System.Drawing.Point(200, 445)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 35)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmReviewWorker
        '
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(500, 500)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtComments)
        Me.Controls.Add(Me.lblComments)
        Me.Controls.Add(Me.cmbRating)
        Me.Controls.Add(Me.lblRating)
        Me.Controls.Add(Me.lblWorkerName)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Name = "frmReviewWorker"
        Me.Text = "Review Worker"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblWorkerName As Label
    Friend WithEvents lblRating As Label
    Friend WithEvents cmbRating As ComboBox
    Friend WithEvents lblComments As Label
    Friend WithEvents txtComments As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnCancel As Button
End Class