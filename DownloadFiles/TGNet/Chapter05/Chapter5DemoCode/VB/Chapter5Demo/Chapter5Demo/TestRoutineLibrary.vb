Imports System.Data.OleDb
Imports System.Diagnostics
Imports System.IO

Public Class TestRoutineLibrary
    Public Shared Logfile As String

    Public Shared Sub StartProgram(ByVal strAppname As String)
        'This routine will start a new process with normal focus.
        'Allow the user to choose the path of the application
        'It will log the starting time to the debug window.

        'TODO Report Platform Stats
        'Start App with app name and path.
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

