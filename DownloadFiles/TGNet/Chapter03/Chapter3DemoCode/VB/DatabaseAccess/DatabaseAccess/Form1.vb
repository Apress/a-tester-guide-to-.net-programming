
Imports System.Data.OleDb
Public Class Form1
    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cn As New OleDbConnection _
      ("Provider=Microsoft.jet.oledb.4.0;Data Source=TestResultsDB.mdb")
        Dim iRet As Integer
        cn.Open()
        Dim cmd As New OleDbCommand( _
            "Insert into TestResults (TestID, TestDate, Reqmt, Tester, Result)" & _
             "Values (3, '01-Jan-2006', 'Test Reqmt ABC', 'M. Sweeney', 1)", cn)
        iRet = cmd.ExecuteNonQuery
        cn.Close()
    End Sub

End Class
