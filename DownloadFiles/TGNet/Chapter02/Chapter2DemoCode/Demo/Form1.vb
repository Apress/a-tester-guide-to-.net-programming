Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = System.IO.Directory.GetCurrentDirectory
    End Sub
End Class
