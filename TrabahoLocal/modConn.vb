Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Module modConn
    Public conn As New MySqlConnection
    Public CurrentUserID As Integer
    Public CurrentRole As String

    Public Sub openConn()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.ConnectionString = "server=localhost;userid=root;password=;database=db_trabaholocal"
                conn.Open()
            End If
        Catch ex As Exception
            MsgBox("Connection Error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub closeConn()
        Try
            If conn.State = ConnectionState.Open Then conn.Close()
        Catch ex As Exception
        End Try
    End Sub

    Friend Function ConnectionString() As String
        Throw New NotImplementedException()
    End Function
End Module