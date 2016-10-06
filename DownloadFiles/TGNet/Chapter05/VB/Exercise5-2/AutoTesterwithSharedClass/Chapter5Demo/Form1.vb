Public Class Form1
    

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartApp.Click
        Try
            TestLib.Logfile = "c:\testlog.log"
            TestLib.StartProgram(txtAppname.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub
End Class
