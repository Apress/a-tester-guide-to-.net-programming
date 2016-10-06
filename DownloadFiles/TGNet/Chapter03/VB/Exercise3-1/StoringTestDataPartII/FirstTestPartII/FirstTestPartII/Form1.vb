Imports System.IO
Public Class Form1
    Private Writer As StreamWriter
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Static iCount As Int16 = 1
        Dim strCount As String

        If iCount = 1 Then
            Writer = File.CreateText("TestResults.log")
            Writer.WriteLine("Test Results for Test Run XYZ; " & DateTime.Now)
        Else
            Writer = File.AppendText("TestResults.log")
        End If

        strCount = Convert.ToString(iCount)
        If File.Exists(TextBox1.Text) Then
            Writer.WriteLine(strCount & " File " & TextBox1.Text & " Exists: Test Passed")
            Label1.Text = "File " & TextBox1.Text & " Exists: Test Passed"
        Else
            Writer.WriteLine(strCount & " File " & TextBox1.Text & " doesn't exist: Test Failed")
            Label1.Text = "File " & TextBox1.Text & " doesn't exist: Test Failed"
        End If

        iCount += 1
        Writer.Close()

    End Sub

   
    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Writer = File.AppendText("Testresults.log")
        Writer.WriteLine("Test Completed for Test Run XYZ; " & DateTime.Now)
        Writer.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        System.Diagnostics.Process.Start("Notepad.exe", "TestResults.log")
    End Sub
End Class
