Imports System.Diagnostics
Imports System.IO

Public Class TestLib
    Public Shared Logfile As String = "c:\logfile.txt"

    Public Shared Sub StartProgram(ByVal strAppname As String)
        'This routine will start a new process 
        'It will log the starting time 

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


End Class

