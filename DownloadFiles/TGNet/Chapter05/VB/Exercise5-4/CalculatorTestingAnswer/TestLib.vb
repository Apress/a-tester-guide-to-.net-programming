
Imports System.Diagnostics
Imports System.IO

Public Class TestLib
    Public Shared Logfile As String = "c:\Logfile.log" 'default filename that can be overwritten

    Public Shared Function StartProgram(ByVal strAppname As String) As Integer
        'This routine will start a new process 
        'If a log file does not exist it will create one

        If Not File.Exists(Logfile) Then
            CreateLog("Starting Log file " & DateTime.Now)
        End If

        Dim myProcess As Process = Process.Start(strAppname)
        LogtoFile("Application " & strAppname & " Started at: " & DateTime.Now)
        Return myProcess.Id
    End Function
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
    Public Shared Sub Readlog()
        'Now we open another process in order to launch Notepad and
        'read our test log file
        Dim myProcess As Process = Process.Start("Notepad", Logfile)
    End Sub

    Public Shared Sub CloseProgram(ByRef App As String)
        'the following issues an alt-F4 to close a program
        'the App argument accepted is used for logging to
        'the Immediate window and to the logging file
        'You could also use Process.Kill but this is pretty simple

        System.Windows.Forms.SendKeys.SendWait("%{F4}") ' Send ALT+F4 to close a window

        LogtoFile(App & " Ended at " & Now)
    End Sub
    

End Class
