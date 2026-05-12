<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReceipt
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
        Me.pnlReceipt = New System.Windows.Forms.Panel()
        Me.lblLogo = New System.Windows.Forms.Label()
        Me.lblDivider1 = New System.Windows.Forms.Label()
        Me.lblDateLabel = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTransIDLabel = New System.Windows.Forms.Label()
        Me.lblTransID = New System.Windows.Forms.Label()
        Me.lblJobTitleLabel = New System.Windows.Forms.Label()
        Me.lblJobTitle = New System.Windows.Forms.Label()
        Me.lblEmployerLabel = New System.Windows.Forms.Label()
        Me.lblEmployer = New System.Windows.Forms.Label()
        Me.lblWorkerLabel = New System.Windows.Forms.Label()
        Me.lblWorker = New System.Windows.Forms.Label()
        Me.lblDivider2 = New System.Windows.Forms.Label()
        Me.lblTotalLabel = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblFooter = New System.Windows.Forms.Label()
        Me.btnDownload = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.pnlReceipt.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlReceipt
        '
        Me.pnlReceipt.BackColor = System.Drawing.Color.White
        Me.pnlReceipt.Controls.Add(Me.lblLogo)
        Me.pnlReceipt.Controls.Add(Me.lblDivider1)
        Me.pnlReceipt.Controls.Add(Me.lblDateLabel)
        Me.pnlReceipt.Controls.Add(Me.lblDate)
        Me.pnlReceipt.Controls.Add(Me.lblTransIDLabel)
        Me.pnlReceipt.Controls.Add(Me.lblTransID)
        Me.pnlReceipt.Controls.Add(Me.lblJobTitleLabel)
        Me.pnlReceipt.Controls.Add(Me.lblJobTitle)
        Me.pnlReceipt.Controls.Add(Me.lblEmployerLabel)
        Me.pnlReceipt.Controls.Add(Me.lblEmployer)
        Me.pnlReceipt.Controls.Add(Me.lblWorkerLabel)
        Me.pnlReceipt.Controls.Add(Me.lblWorker)
        Me.pnlReceipt.Controls.Add(Me.lblDivider2)
        Me.pnlReceipt.Controls.Add(Me.lblTotalLabel)
        Me.pnlReceipt.Controls.Add(Me.lblTotal)
        Me.pnlReceipt.Controls.Add(Me.lblFooter)
        Me.pnlReceipt.Location = New System.Drawing.Point(50, 30)
        Me.pnlReceipt.Name = "pnlReceipt"
        Me.pnlReceipt.Size = New System.Drawing.Size(400, 520)
        Me.pnlReceipt.TabIndex = 0
        '
        'lblLogo
        '
        Me.lblLogo.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblLogo.Location = New System.Drawing.Point(0, 20)
        Me.lblLogo.Name = "lblLogo"
        Me.lblLogo.Size = New System.Drawing.Size(400, 30)
        Me.lblLogo.TabIndex = 0
        Me.lblLogo.Text = "TRABAHOLOCAL"
        Me.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDivider1
        '
        Me.lblDivider1.Font = New System.Drawing.Font("Courier New", 12.0!)
        Me.lblDivider1.Location = New System.Drawing.Point(0, 60)
        Me.lblDivider1.Name = "lblDivider1"
        Me.lblDivider1.Size = New System.Drawing.Size(400, 20)
        Me.lblDivider1.TabIndex = 1
        Me.lblDivider1.Text = "----------------------------------"
        Me.lblDivider1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDateLabel
        '
        Me.lblDateLabel.AutoSize = True
        Me.lblDateLabel.Font = New System.Drawing.Font("Courier New", 12.0!)
        Me.lblDateLabel.Location = New System.Drawing.Point(30, 100)
        Me.lblDateLabel.Name = "lblDateLabel"
        Me.lblDateLabel.Size = New System.Drawing.Size(68, 18)
        Me.lblDateLabel.Text = "Date:"
        '
        'lblDate
        '
        Me.lblDate.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblDate.Location = New System.Drawing.Point(120, 100)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(250, 18)
        Me.lblDate.Text = "2026-05-11 14:30"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTransIDLabel
        '
        Me.lblTransIDLabel.AutoSize = True
        Me.lblTransIDLabel.Font = New System.Drawing.Font("Courier New", 12.0!)
        Me.lblTransIDLabel.Location = New System.Drawing.Point(30, 140)
        Me.lblTransIDLabel.Name = "lblTransIDLabel"
        Me.lblTransIDLabel.Size = New System.Drawing.Size(128, 18)
        Me.lblTransIDLabel.Text = "Receipt No:"
        '
        'lblTransID
        '
        Me.lblTransID.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTransID.Location = New System.Drawing.Point(160, 140)
        Me.lblTransID.Name = "lblTransID"
        Me.lblTransID.Size = New System.Drawing.Size(210, 18)
        Me.lblTransID.Text = "TXN-0001"
        Me.lblTransID.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblJobTitleLabel
        '
        Me.lblJobTitleLabel.AutoSize = True
        Me.lblJobTitleLabel.Font = New System.Drawing.Font("Courier New", 12.0!)
        Me.lblJobTitleLabel.Location = New System.Drawing.Point(30, 180)
        Me.lblJobTitleLabel.Name = "lblJobTitleLabel"
        Me.lblJobTitleLabel.Size = New System.Drawing.Size(118, 18)
        Me.lblJobTitleLabel.Text = "Job Title:"
        '
        'lblJobTitle
        '
        Me.lblJobTitle.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblJobTitle.Location = New System.Drawing.Point(30, 210)
        Me.lblJobTitle.Name = "lblJobTitle"
        Me.lblJobTitle.Size = New System.Drawing.Size(340, 40)
        Me.lblJobTitle.Text = "House Painter (Interior)"
        '
        'lblEmployerLabel
        '
        Me.lblEmployerLabel.AutoSize = True
        Me.lblEmployerLabel.Font = New System.Drawing.Font("Courier New", 12.0!)
        Me.lblEmployerLabel.Location = New System.Drawing.Point(30, 260)
        Me.lblEmployerLabel.Name = "lblEmployerLabel"
        Me.lblEmployerLabel.Size = New System.Drawing.Size(98, 18)
        Me.lblEmployerLabel.Text = "Paid By:"
        '
        'lblEmployer
        '
        Me.lblEmployer.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblEmployer.Location = New System.Drawing.Point(130, 260)
        Me.lblEmployer.Name = "lblEmployer"
        Me.lblEmployer.Size = New System.Drawing.Size(240, 18)
        Me.lblEmployer.Text = "Employer Name"
        Me.lblEmployer.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblWorkerLabel
        '
        Me.lblWorkerLabel.AutoSize = True
        Me.lblWorkerLabel.Font = New System.Drawing.Font("Courier New", 12.0!)
        Me.lblWorkerLabel.Location = New System.Drawing.Point(30, 300)
        Me.lblWorkerLabel.Name = "lblWorkerLabel"
        Me.lblWorkerLabel.Size = New System.Drawing.Size(98, 18)
        Me.lblWorkerLabel.Text = "Paid To:"
        '
        'lblWorker
        '
        Me.lblWorker.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblWorker.Location = New System.Drawing.Point(130, 300)
        Me.lblWorker.Name = "lblWorker"
        Me.lblWorker.Size = New System.Drawing.Size(240, 18)
        Me.lblWorker.Text = "Worker Name"
        Me.lblWorker.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblDivider2
        '
        Me.lblDivider2.Font = New System.Drawing.Font("Courier New", 12.0!)
        Me.lblDivider2.Location = New System.Drawing.Point(0, 340)
        Me.lblDivider2.Name = "lblDivider2"
        Me.lblDivider2.Size = New System.Drawing.Size(400, 20)
        Me.lblDivider2.TabIndex = 12
        Me.lblDivider2.Text = "----------------------------------"
        Me.lblDivider2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalLabel
        '
        Me.lblTotalLabel.AutoSize = True
        Me.lblTotalLabel.Font = New System.Drawing.Font("Courier New", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalLabel.Location = New System.Drawing.Point(30, 380)
        Me.lblTotalLabel.Name = "lblTotalLabel"
        Me.lblTotalLabel.Size = New System.Drawing.Size(90, 25)
        Me.lblTotalLabel.Text = "TOTAL:"
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotal.Location = New System.Drawing.Point(130, 378)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(240, 30)
        Me.lblTotal.Text = "₱ 0.00"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblFooter
        '
        Me.lblFooter.Font = New System.Drawing.Font("Courier New", 10.0!)
        Me.lblFooter.Location = New System.Drawing.Point(0, 460)
        Me.lblFooter.Name = "lblFooter"
        Me.lblFooter.Size = New System.Drawing.Size(400, 40)
        Me.lblFooter.TabIndex = 15
        Me.lblFooter.Text = "This serves as official proof of payment within the TrabahoLocal Ecosystem."
        Me.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDownload
        '
        Me.btnDownload.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnDownload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDownload.FlatAppearance.BorderSize = 0
        Me.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDownload.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnDownload.ForeColor = System.Drawing.Color.White
        Me.btnDownload.Location = New System.Drawing.Point(50, 580)
        Me.btnDownload.Name = "btnDownload"
        Me.btnDownload.Size = New System.Drawing.Size(250, 45)
        Me.btnDownload.TabIndex = 1
        Me.btnDownload.Text = "💾 Download Receipt"
        Me.btnDownload.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(310, 580)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(140, 45)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'frmReceipt
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(500, 660)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDownload)
        Me.Controls.Add(Me.pnlReceipt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmReceipt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlReceipt.ResumeLayout(False)
        Me.pnlReceipt.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlReceipt As Panel
    Friend WithEvents lblLogo As Label
    Friend WithEvents lblDivider1 As Label
    Friend WithEvents lblDateLabel As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblTransIDLabel As Label
    Friend WithEvents lblTransID As Label
    Friend WithEvents lblJobTitleLabel As Label
    Friend WithEvents lblJobTitle As Label
    Friend WithEvents lblEmployerLabel As Label
    Friend WithEvents lblEmployer As Label
    Friend WithEvents lblWorkerLabel As Label
    Friend WithEvents lblWorker As Label
    Friend WithEvents lblDivider2 As Label
    Friend WithEvents lblTotalLabel As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblFooter As Label
    Friend WithEvents btnDownload As Button
    Friend WithEvents btnClose As Button
End Class