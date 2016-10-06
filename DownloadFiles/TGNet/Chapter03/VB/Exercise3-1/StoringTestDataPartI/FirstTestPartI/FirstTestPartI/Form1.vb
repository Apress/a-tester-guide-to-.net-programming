Imports System.IO
Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim Writer As StreamWriter
        Writer = File.CreateText("TestResults.log")
        Writer.WriteLine("Test Results for Test Run XYZ; " & DateTime.Now)

        If File.Exists(TextBox1.Text) Then
            Writer.WriteLine("File Exists: Test Passed")
        Else
            Writer.WriteLine("File Exists: Test Failed")
        End If

        Writer.WriteLine("Test Completed for Test Run XYZ; " & DateTime.Now)
        Writer.Close()

    End Sub
End Class
