Imports System.Data.OleDb

Public Class CategoryDAO
    Private model As New Model()
    Function getCategoryList()
        Dim categories As New Dictionary(Of String, Category)
        Dim reader As OleDbDataReader
        reader = model.query("SELECT * FROM CATEGORY")
        If reader.HasRows Then
            Dim lastIndex As Integer = 0
            While reader.Read
                Dim category As New Category
                category.CATEGORY_DISTANCE = reader("CATEGORY_DISTANCE")
                category.CATEGORY_MIN_MINUTES = reader("CATEGORY_MIN_MINUTES")
                category.CATEGORY_NAME = reader("CATEGORY_NAME").ToString
                category.CATEGORY_START_TIME = reader("CATEGORY_START_TIME").ToString
                category.TEXT = reader("CATEGORY_NAME").ToString
                categories.Add(reader("CATEGORY_NAME"), category)
            End While
        End If

        Return categories
    End Function

    Function update(category As Category)

        Dim sql As String = "UPDATE CATEGORY SET"

        sql &= " CATEGORY_DISTANCE='" & category.CATEGORY_DISTANCE & "'"
        sql &= ", CATEGORY_MIN_MINUTES='" & category.CATEGORY_MIN_MINUTES & "'"
        sql &= ", CATEGORY_START_TIME='" & category.CATEGORY_START_TIME & "'"
        sql &= " WHERE CATEGORY_DISTANCE = " & category.CATEGORY_DISTANCE
        sql &= " AND CATEGORY_NAME='" & category.CATEGORY_NAME & "'"
        Return model.update(sql)
    End Function

    Function reset()
        Dim sql As String = "UPDATE CATEGORY SET"
        sql &= " CATEGORY_START_TIME=''"
        Return model.update(sql)
    End Function
End Class
