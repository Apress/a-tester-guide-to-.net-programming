Imports System.Data.Oledb
Public Class frmTestBed

    Sub TestLog(ByVal tid As Integer, _
      ByVal testdate As Date, ByVal reqmt As String, _
      ByVal Tester As String, ByVal result As Boolean)
        Dim cnTestResults As New OleDbConnection( _
        "Provider=Microsoft.jet.oledb.4.0;Data Source=TestResultsDB.mdb")
        Dim iRet As Integer
        cnTestResults.Open()
        Dim cmd As New OleDbCommand( _
         "Insert into TestResults (TestID, TestDate, Reqmt, Tester, Result)" & _
           "Values (" & tid & ", '" & testdate & "', '" & _
             reqmt & "', '" & Tester & "', " & result & ")", _
          cnTestResults)
        iRet = cmd.ExecuteNonQuery
        cnTestResults.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cn As New OleDbConnection( _
            "Provider=Microsoft.jet.oledb.4.0;Data Source=TestResultsDB.mdb")
        Dim iRet1, iret2 As Integer
        cn.Open()
        'note: contactList is a query in the database; not a table
        'however, Access is okay with that and the following query is legit:
        Dim cmd As New OleDbCommand("select count(*) from contactList", cn)
        iRet1 = cmd.ExecuteScalar
        cmd.CommandText = "select count(*) from customers"
        iret2 = cmd.ExecuteScalar

        If iRet1 = iret2 Then
            TestLog(100, DateTime.Now, "XYZ122", "Sweeney, M.", True)
            MessageBox.Show("Test pass reported to database")
        Else
            TestLog(100, DateTime.Now, "XYZ122", "Sweeney, M.", False)
            MessageBox.Show("Test failure reported to database")
        End If
        cn.Close()


    End Sub
End Class

