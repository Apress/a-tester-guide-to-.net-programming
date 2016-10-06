Imports System.IO
Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If File.Exists(TextBox1.Text) Then
            MessageBox.Show("File Exists: Test passed")
        Else
            MessageBox.Show("File doesn't Exist: Test failure")
        End If

    End Sub
End Class
