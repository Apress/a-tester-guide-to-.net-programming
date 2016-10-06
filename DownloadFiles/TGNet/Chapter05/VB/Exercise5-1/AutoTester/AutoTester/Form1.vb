Public Class Form1
    Public Sub StartProgram(ByVal strAppname As String)
        'This routine will start a new process with the name and 
        'path contained in strAppname.        
        'TODO If a log file does not exist it will create one

        Process.Start(strAppname)

        'TODO Add code to log start time.
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartApp.Click
        Try
            StartProgram(txtAppname.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

End Class
