Imports MySql.Data.MySqlClient

Public Class frmSearchResults

    ' Variables passed from the Homepage
    Public SearchKeyword As String = ""
    Public SearchLocation As String = ""

    Private Sub frmSearchResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub LoadData()
        Try
            openConn()
            ' Advanced query looking for matches in Title, Description, OR Location
            Dim query As String = "SELECT JobTitle AS 'Job Role', Location, Salary, Description FROM tbljobs " &
                                 "WHERE (JobTitle LIKE @key OR Description LIKE @key) " &
                                 "AND Location LIKE @loc ORDER BY DatePosted DESC"

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@key", "%" & SearchKeyword & "%")
            cmd.Parameters.AddWithValue("@loc", "%" & SearchLocation & "%")

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            dgvResults.DataSource = table

            If table.Rows.Count = 0 Then
                MsgBox("No local jobs found matching your search. Try different keywords!", MsgBoxStyle.Information, "No Matches")
            End If

        Catch ex As Exception
            MsgBox("Error loading jobs: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            closeConn()
        End Try
    End Sub

End Class