Imports System.Data
Imports System.Data.OleDb
Imports System.Data.Common

Public Class Model

    Private dbConString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\FunRun\FunRunDB.accdb;"

    Private Shared dbCon As DbConnection

    Public Sub New()
        Debug.Print("hello")
        dbCon = New OleDbConnection(dbConString)
        If dbCon.State = ConnectionState.Closed Then
            dbCon = New OleDbConnection(dbConString)
            dbCon.Open()
        End If
    End Sub

    Public Function query(ByVal sqlString As String) As OleDbDataReader
        Dim dbCmd As OleDbCommand = New OleDbCommand(sqlString, dbCon)
        Return dbCmd.ExecuteReader()
    End Function

    Public Function update(sqlString As String) As Integer
        Dim dbCmd As OleDbCommand = New OleDbCommand(sqlString, dbCon)
        Return dbCmd.ExecuteNonQuery()
    End Function

End Class
