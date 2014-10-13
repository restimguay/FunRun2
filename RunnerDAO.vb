Imports System.Data.OleDb

Public Class RunnerDAO
    Private model As New Model()

    Public Function getRunnersList() As Dictionary(Of String, Runner)
        Dim runners As New Dictionary(Of String, Runner)
        Dim reader As OleDbDataReader
        reader = model.query("SELECT * FROM RUNNER")
        If reader.HasRows Then
            Dim lastIndex As Integer = 0
            While reader.Read
                Dim runner As New Runner
                runner.RUNNER_RFID_NUMBER = reader("RUNNER_RFID_NUMBER").ToString
                runner.RUNNER_BIB_NUMBER = reader("RUNNER_BIB_NUMBER").ToString
                runner.RUNNER_NAME = reader("RUNNER_NAME").ToString
                runner.RUNNER_FINISH_TIME = reader("RUNNER_FINISH_TIME").ToString
                runner.RUNNER_GENDER = reader("RUNNER_GENDER").ToString
                runner.RUNNER_RANK = reader("RUNNER_RANK").ToString
                runner.RUNNER_START_TIME = reader("RUNNER_START_TIME").ToString
                runner.RUNNER_CHIP_TIME = reader("RUNNER_CHIP_TIME").ToString
                runner.RUNNER_GUN_TIME = reader("RUNNER_GUN_TIME").ToString
                runner.RUNNER_CATEGORY = reader("RUNNER_CATEGORY").ToString
                runners.Add(reader("RUNNER_RFID_NUMBER"), runner)
            End While
        End If

        Return runners
    End Function
    Function insert(runner As Runner)
        Dim sql As String = "INSERT INTO RUNNER "
        Dim fields As String = "(RUNNER_RFID_NUMBER,RUNNER_NAME,RUNNER_GENDER,RUNNER_AGE,RUNNER_START_TIME,RUNNER_FINISH_TIME,RUNNER_GUN_TIME,RUNNER_CHIP_TIME,RUNNER_RANK,RUNNER_CATEGORY,RUNNER_BIB_NUMBER) "
        Dim values As String = "VALUES('" & runner.RUNNER_RFID_NUMBER & "','" & runner.RUNNER_NAME & "','" & runner.RUNNER_GENDER & "','" & runner.RUNNER_AGE & "','" & runner.RUNNER_START_TIME & "','" & runner.RUNNER_FINISH_TIME & "','" & runner.RUNNER_GUN_TIME & "','" & runner.RUNNER_CHIP_TIME & "','" & runner.RUNNER_RANK & "','" & runner.RUNNER_CATEGORY & "','" & runner.RUNNER_BIB_NUMBER & "')"
        Return model.update(sql & fields & values)
    End Function
    Function update(runner As Runner) As Integer
        Dim sql As String = "UPDATE RUNNER SET"

        sql &= " RUNNER_RFID_NUMBER='" & runner.RUNNER_RFID_NUMBER & "'"
        sql &= ", RUNNER_NAME='" & runner.RUNNER_NAME & "'"
        sql &= ", RUNNER_GENDER='" & runner.RUNNER_GENDER & "'"
        sql &= ", RUNNER_AGE='" & runner.RUNNER_AGE & "'"
        sql &= ", RUNNER_START_TIME ='" & runner.RUNNER_START_TIME & "'"
        sql &= ", RUNNER_FINISH_TIME ='" & runner.RUNNER_FINISH_TIME & "'"
        sql &= ", RUNNER_GUN_TIME= '" & runner.RUNNER_GUN_TIME & "'"
        sql &= ", RUNNER_CHIP_TIME= '" & runner.RUNNER_CHIP_TIME & "'"
        sql &= ", RUNNER_RANK= '" & runner.RUNNER_RANK & "'"
        sql &= ", RUNNER_CATEGORY= '" & runner.RUNNER_CATEGORY & "'"
        sql &= " WHERE RUNNER_BIB_NUMBER = '" & runner.RUNNER_BIB_NUMBER & "'"
        Return model.update(sql)
    End Function
    Function resetRunners()
        Dim sql As String = "UPDATE RUNNER SET RUNNER_START_TIME='', RUNNER_FINISH_TIME='', RUNNER_GUN_TIME='',RUNNER_CHIP_TIME='', RUNNER_RANK=''"
        Return model.update(sql)
    End Function
End Class
