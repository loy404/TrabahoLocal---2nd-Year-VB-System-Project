Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Drawing

Public Class frmEmployeerProfile
    Private selectedPicPath As String = ""

    Public IsViewOnly As Boolean = False
    Public ViewOnlyUserID As Integer = 0

    Private WithEvents fadeTimer As New Timer()

    Private Sub frmEmployeerProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Me.Opacity = 0
        fadeTimer.Interval = 15
        fadeTimer.Start()

        If IsViewOnly Then
            btnSave.Visible = False
            btnUploadPic.Visible = False
            btnUploadID.Visible = False
            txtLocation.ReadOnly = True
            txtContact.ReadOnly = True
            txtCompanyDetails.ReadOnly = True
            btnCancel.Text = "Close Profile"
        End If

        LoadProfileData()
    End Sub

    Private Sub fadeTimer_Tick(sender As Object, e As EventArgs) Handles fadeTimer.Tick
        If Me.Opacity < 1.0 Then
            Me.Opacity += 0.05
        Else
            fadeTimer.Stop()
        End If
    End Sub

    Private Sub LoadProfileData()
        Try
            openConn()
            Dim targetUID As Integer = If(IsViewOnly, ViewOnlyUserID, CurrentUserID)

            Dim query As String = "SELECT e.FullName, e.ContactNumber, e.CompanyDetails, e.Location, e.ProfilePicPath, e.IDImagePath, e.IsVerified " &
                                  "FROM tblemployeers e WHERE e.UserID = @uid"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@uid", targetUID)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                lblFullName.Text = If(IsDBNull(reader("FullName")), "Unknown Employer", reader("FullName").ToString())
                txtLocation.Text = If(IsDBNull(reader("Location")), "", reader("Location").ToString())
                txtContact.Text = If(IsDBNull(reader("ContactNumber")), "", reader("ContactNumber").ToString())
                txtCompanyDetails.Text = If(IsDBNull(reader("CompanyDetails")), "", reader("CompanyDetails").ToString())

                Dim isVerified As Boolean = Convert.ToBoolean(If(IsDBNull(reader("IsVerified")), False, reader("IsVerified")))
                Dim idPath As String = If(IsDBNull(reader("IDImagePath")), "", reader("IDImagePath").ToString())

                If isVerified Then
                    lblVerificationStatus.Text = "✔ Verified"
                    lblVerificationStatus.BackColor = Color.FromArgb(40, 167, 69)
                    btnUploadID.Visible = False
                ElseIf idPath <> "" Then
                    lblVerificationStatus.Text = "⏳ Pending Review"
                    lblVerificationStatus.BackColor = Color.DarkOrange
                Else
                    lblVerificationStatus.Text = "❌ Unverified"
                    lblVerificationStatus.BackColor = Color.FromArgb(220, 53, 69)
                End If

                selectedPicPath = If(IsDBNull(reader("ProfilePicPath")), "", reader("ProfilePicPath").ToString())
                If selectedPicPath <> "" AndAlso IO.File.Exists(selectedPicPath) Then
                    Using fs As New IO.FileStream(selectedPicPath, IO.FileMode.Open, IO.FileAccess.Read)
                        picProfile.Image = Image.FromStream(fs)
                    End Using
                End If
            End If
        Catch ex As Exception
            MsgBox("Error loading employer profile: " & ex.Message)
        Finally
            closeConn()
        End Try
    End Sub

    Private Sub btnUploadPic_Click(sender As Object, e As EventArgs) Handles btnUploadPic.Click
        Dim fd As New OpenFileDialog()
        fd.Title = "Select Profile/Company Picture"
        fd.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png"
        If fd.ShowDialog() = DialogResult.OK Then
            selectedPicPath = fd.FileName
            Using fs As New IO.FileStream(selectedPicPath, IO.FileMode.Open, IO.FileAccess.Read)
                picProfile.Image = Image.FromStream(fs)
            End Using
        End If
    End Sub

    Private Sub btnUploadID_Click(sender As Object, e As EventArgs) Handles btnUploadID.Click
        Dim ofd As New OpenFileDialog()
        ofd.Title = "Select Government ID or Business Permit Image"
        ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png"

        If ofd.ShowDialog() = DialogResult.OK Then
            Try
                Dim uploadFolder As String = Application.StartupPath & "\ID_Uploads\"
                If Not IO.Directory.Exists(uploadFolder) Then
                    IO.Directory.CreateDirectory(uploadFolder)
                End If

                Dim fileExt As String = IO.Path.GetExtension(ofd.FileName)
                Dim newFileName As String = "ID_Employer_" & CurrentUserID & fileExt
                Dim savePath As String = uploadFolder & newFileName

                IO.File.Copy(ofd.FileName, savePath, True)

                openConn()
                Dim query As String = "UPDATE tblemployeers SET IDImagePath = @path WHERE UserID = @uid"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@path", savePath)
                cmd.Parameters.AddWithValue("@uid", CurrentUserID)
                cmd.ExecuteNonQuery()

                MsgBox("ID Uploaded successfully! Please wait for an Admin to review it.", MsgBoxStyle.Information)
                lblVerificationStatus.Text = "⏳ Pending Review"
                lblVerificationStatus.BackColor = Color.DarkOrange
            Catch ex As Exception
                MsgBox("Error saving ID: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                closeConn()
            End Try
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim picFolder As String = Application.StartupPath & "\ProfilePics"
            If Not IO.Directory.Exists(picFolder) Then IO.Directory.CreateDirectory(picFolder)

            Dim finalPicPath As String = selectedPicPath

            If selectedPicPath <> "" AndAlso Not selectedPicPath.Contains(Application.StartupPath) Then
                Dim ext As String = IO.Path.GetExtension(selectedPicPath)
                finalPicPath = picFolder & "\Pic_Employer_" & CurrentUserID & "_" & DateTime.Now.Ticks & ext
                IO.File.Copy(selectedPicPath, finalPicPath, True)
            End If

            openConn()
            Dim query As String = "UPDATE tblemployeers SET Location = @loc, ContactNumber = @contact, CompanyDetails = @details, ProfilePicPath = @pic WHERE UserID = @uid"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@loc", txtLocation.Text)
            cmd.Parameters.AddWithValue("@contact", txtContact.Text)
            cmd.Parameters.AddWithValue("@details", txtCompanyDetails.Text)
            cmd.Parameters.AddWithValue("@pic", finalPicPath)
            cmd.Parameters.AddWithValue("@uid", CurrentUserID)
            cmd.ExecuteNonQuery()

            MsgBox("Employer Profile successfully updated!", MsgBoxStyle.Information, "Success")
            Me.Close()
        Catch ex As Exception
            MsgBox("Error saving profile: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            closeConn()
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class