Imports System.Data.OleDb
Imports System.Diagnostics
Imports System.IO

Public Class TestRoutineLibrary
    Public Shared Logfile As String

    Public Shared Sub StartProgram(ByVal strAppname As String)
       
        If Not File.Exists(Logfile) Then
            CreateLog("Starting Log file " & DateTime.Now)
        End If
        Process.Start(strAppname)
        LogtoFile("Application " & strAppname & " Started at: " & DateTime.Now)
    End Sub
    Public Shared Sub CreateLog(ByVal strHeader As String)
        Dim Writer As StreamWriter
        Writer = File.CreateText(Logfile)
        Writer.WriteLine(strHeader)
        Writer.Close()
    End Sub
    Public Shared Sub LogtoFile(ByVal strLog As String)
        Dim Writer As StreamWriter
        Writer = File.AppendText(Logfile)
        Writer.WriteLine(strLog)
        Writer.Close()
    End Sub

    Public Shared Sub TestLog(ByVal tid As Integer, ByVal testdate As Date, ByVal reqmt As String, _
     ByVal Tester As String, ByVal result As Boolean)
        Dim cnTestResults As New OleDbConnection( _
            "Provider=Microsoft.jet.oledb.4.0;Data Source=TestResultsDB.mdb")
        Dim iRet As Integer
        cnTestResults.Open()
        Dim cmd As New OleDbCommand( _
             "Insert into TestResults (TestID, TestDate, Reqmt, Tester, Result)  Values (" & _
              tid & ", '" & testdate & "', '" & reqmt & "', '" & Tester & "', " & result & ")", cnTestResults)
        iRet = cmd.ExecuteNonQuery
        cnTestResults.Close()
    End Sub

End Class

