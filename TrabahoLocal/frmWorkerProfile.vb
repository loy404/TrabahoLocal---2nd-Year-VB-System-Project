Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Drawing

Public Class frmWorkerProfile
    Private selectedResumePath As String = ""
    Private selectedPicPath As String = ""

    ' ==========================================
    ' View-Only Mode Properties for Employer
    ' ==========================================
    Public IsViewOnly As Boolean = False
    Public ViewOnlyUserID As Integer = 0

    Private WithEvents fadeTimer As New Timer()

    ' --- LOAD EVENT ---
    Private Sub frmWorkerProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        ' Fade-In setup
        Me.Opacity = 0
        fadeTimer.Interval = 15
        fadeTimer.Start()

        ' ==========================================
        ' ERP SECURITY: If opened by an Employer, lock it down
        ' ==========================================
        If IsViewOnly Then
            btnSave.Visible = False
            btnUploadPic.Visible = False
            btnUploadID.Visible = False ' Hide ID upload from Employer

            txtHeadline.ReadOnly = True
            txtSalary.ReadOnly = True
            txtEducation.ReadOnly = True
            txtSkills.ReadOnly = True
            txtExperience.ReadOnly = True
            btnCancel.Text = "Close Profile"

            ' Repurpose the upload button to open the document instead
            btnUploadResume.Text = "📄 OPEN RESUME DOCUMENT"
            btnUploadResume.BackColor = Color.FromArgb(0, 123, 255)
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

    ' --- DATABASE LOGIC: Load Everything ---
    Private Sub LoadProfileData()
        Try
            openConn()
            Dim targetUID As Integer = If(IsViewOnly, ViewOnlyUserID, CurrentUserID)

            ' Join with tblusers to get the Full Name and WorkerID for analytics
            Dim query As String = "SELECT u.FullName, w.WorkerID, w.Skills, w.Experience, w.ResumePath, w.ProfilePicPath, w.IDImagePath, w.IsVerified, w.Headline, w.ExpectedSalary, w.Education " &
                                  "FROM tblworkers w JOIN tblusers u ON w.UserID = u.UserID WHERE w.UserID = @uid"

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@uid", targetUID)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                Dim workerID As Integer = Convert.ToInt32(reader("WorkerID"))

                ' Set Banner Name
                lblFullName.Text = If(IsDBNull(reader("FullName")), "Unknown User", reader("FullName").ToString())

                ' Load Text Fields
                txtHeadline.Text = If(IsDBNull(reader("Headline")), "", reader("Headline").ToString())
                txtSalary.Text = If(IsDBNull(reader("ExpectedSalary")), "", reader("ExpectedSalary").ToString())
                txtEducation.Text = If(IsDBNull(reader("Education")), "", reader("Education").ToString())
                txtSkills.Text = If(IsDBNull(reader("Skills")), "", reader("Skills").ToString())
                txtExperience.Text = If(IsDBNull(reader("Experience")), "", reader("Experience").ToString())

                ' Load Verification Status
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

                ' Load Resume Path
                selectedResumePath = If(IsDBNull(reader("ResumePath")), "", reader("ResumePath").ToString())
                If selectedResumePath <> "" AndAlso Not IsViewOnly Then
                    lblFileName.Text = Path.GetFileName(selectedResumePath)
                End If

                ' Load Profile Picture safely
                selectedPicPath = If(IsDBNull(reader("ProfilePicPath")), "", reader("ProfilePicPath").ToString())
                If selectedPicPath <> "" AndAlso IO.File.Exists(selectedPicPath) Then
                    Using fs As New IO.FileStream(selectedPicPath, IO.FileMode.Open, IO.FileAccess.Read)
                        picProfile.Image = Image.FromStream(fs)
                    End Using
                End If

                reader.Close() ' CLOSE READER BEFORE CALLING NEXT QUERY

                ' ERP HR MODULE: Load Star Rating Reputation
                LoadReputation(workerID)
            End If
        Catch ex As Exception
            MsgBox("Error loading profile: " & ex.Message)
        Finally
            closeConn()
        End Try
    End Sub

    ' ==========================================
    ' ERP MODULE: HR PERFORMANCE ANALYTICS
    ' ==========================================
    Private Sub LoadReputation(workerID As Integer)
        Try
            ' Query to get average rating and total jobs completed from the Review table
            Dim query As String = "SELECT AVG(r.Rating) as AvgRating, COUNT(r.ReviewID) as TotalReviews " &
                                  "FROM tblReviews r " &
                                  "JOIN tblApplications a ON r.ApplicationID = a.ApplicationID " &
                                  "WHERE a.WorkerID = @wid"

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@wid", workerID)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() AndAlso Not IsDBNull(reader("AvgRating")) Then
                Dim avgRating As Double = Convert.ToDouble(reader("AvgRating"))
                Dim count As Integer = Convert.ToInt32(reader("TotalReviews"))

                ' Append the rating to the verification label
                lblVerificationStatus.Text &= "  |  ⭐ " & avgRating.ToString("0.0") & " (" & count & " Reviews)"
            End If
            reader.Close()
        Catch ex As Exception
            ' Silently handle if no reviews exist yet
        End Try
    End Sub

    ' --- WORKER LOGIC: Upload Government ID ---
    Private Sub btnUploadID_Click(sender As Object, e As EventArgs) Handles btnUploadID.Click
        Dim ofd As New OpenFileDialog()
        ofd.Title = "Select Government ID Image"
        ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png"

        If ofd.ShowDialog() = DialogResult.OK Then
            Try
                Dim uploadFolder As String = Application.StartupPath & "\ID_Uploads\"
                If Not IO.Directory.Exists(uploadFolder) Then IO.Directory.CreateDirectory(uploadFolder)

                Dim fileExt As String = IO.Path.GetExtension(ofd.FileName)
                Dim newFileName As String = "ID_Worker_" & CurrentUserID & fileExt
                Dim savePath As String = uploadFolder & newFileName

                IO.File.Copy(ofd.FileName, savePath, True)

                openConn()
                Dim query As String = "UPDATE tblworkers SET IDImagePath = @path WHERE UserID = @uid"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@path", savePath)
                cmd.Parameters.AddWithValue("@uid", CurrentUserID)
                cmd.ExecuteNonQuery()

                MsgBox("ID Uploaded successfully! Please wait for an Admin to review it.", MsgBoxStyle.Information)
                lblVerificationStatus.Text = "⏳ Pending Review"
                lblVerificationStatus.BackColor = Color.DarkOrange

            Catch ex As Exception
                MsgBox("Error saving ID: " & ex.Message)
            Finally
                closeConn()
            End Try
        End If
    End Sub

    ' --- PROFILE PIC LOGIC ---
    Private Sub btnUploadPic_Click(sender As Object, e As EventArgs) Handles btnUploadPic.Click
        Dim fd As New OpenFileDialog()
        fd.Title = "Select Profile Picture"
        fd.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png"
        If fd.ShowDialog() = DialogResult.OK Then
            selectedPicPath = fd.FileName
            Using fs As New IO.FileStream(selectedPicPath, IO.FileMode.Open, IO.FileAccess.Read)
                picProfile.Image = Image.FromStream(fs)
            End Using
        End If
    End Sub

    ' --- RESUME LOGIC (UPLOADING OR VIEWING) ---
    Private Sub btnUploadResume_Click(sender As Object, e As EventArgs) Handles btnUploadResume.Click
        If IsViewOnly Then
            ' VIEW MODE: Open the file for the Employer
            If selectedResumePath <> "" AndAlso IO.File.Exists(selectedResumePath) Then
                Try
                    Process.Start(selectedResumePath)
                Catch ex As Exception
                    MsgBox("Could not open file. Ensure you have a PDF viewer.", MsgBoxStyle.Exclamation)
                End Try
            Else
                MsgBox("This applicant has not uploaded a resume.", MsgBoxStyle.Information)
            End If
            Exit Sub
        End If

        ' EDIT MODE: Let the worker pick a new file
        Dim fd As New OpenFileDialog()
        fd.Title = "Select your Resume or CV"
        fd.Filter = "PDF Files (*.pdf)|*.pdf|Word Documents (*.docx)|*.docx"
        If fd.ShowDialog() = DialogResult.OK Then
            selectedResumePath = fd.FileName
            lblFileName.Text = IO.Path.GetFileName(selectedResumePath)
            lblFileName.ForeColor = Color.Green
        End If
    End Sub

    ' --- SAVE ALL CHANGES ---
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim resumeFolder As String = Application.StartupPath & "\Resumes"
            Dim picFolder As String = Application.StartupPath & "\ProfilePics"
            If Not IO.Directory.Exists(resumeFolder) Then IO.Directory.CreateDirectory(resumeFolder)
            If Not IO.Directory.Exists(picFolder) Then IO.Directory.CreateDirectory(picFolder)

            Dim finalResumePath As String = selectedResumePath
            Dim finalPicPath As String = selectedPicPath

            ' Handle File Copying
            If selectedResumePath <> "" AndAlso Not selectedResumePath.Contains(Application.StartupPath) Then
                Dim ext As String = IO.Path.GetExtension(selectedResumePath)
                finalResumePath = resumeFolder & "\Resume_User_" & CurrentUserID & ext
                IO.File.Copy(selectedResumePath, finalResumePath, True)
            End If

            If selectedPicPath <> "" AndAlso Not selectedPicPath.Contains(Application.StartupPath) Then
                Dim ext As String = IO.Path.GetExtension(selectedPicPath)
                finalPicPath = picFolder & "\Pic_User_" & CurrentUserID & "_" & DateTime.Now.Ticks & ext
                IO.File.Copy(selectedPicPath, finalPicPath, True)
            End If

            openConn()
            Dim query As String = "UPDATE tblworkers SET Skills = @skills, Experience = @exp, ResumePath = @res, ProfilePicPath = @pic, Headline = @head, ExpectedSalary = @sal, Education = @edu WHERE UserID = @uid"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@skills", txtSkills.Text)
            cmd.Parameters.AddWithValue("@exp", txtExperience.Text)
            cmd.Parameters.AddWithValue("@res", finalResumePath)
            cmd.Parameters.AddWithValue("@pic", finalPicPath)
            cmd.Parameters.AddWithValue("@head", txtHeadline.Text)
            cmd.Parameters.AddWithValue("@sal", txtSalary.Text)
            cmd.Parameters.AddWithValue("@edu", txtEducation.Text)
            cmd.Parameters.AddWithValue("@uid", CurrentUserID)
            cmd.ExecuteNonQuery()

            MsgBox("Profile successfully updated!", MsgBoxStyle.Information)
            Me.Close()
        Catch ex As Exception
            MsgBox("Error saving profile: " & ex.Message)
        Finally
            closeConn()
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class