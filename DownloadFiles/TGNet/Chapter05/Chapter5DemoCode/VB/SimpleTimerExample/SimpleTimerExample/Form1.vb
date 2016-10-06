Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Enabled = True
        Timer1.Interval = 5000 '1000 milliseconds = 1 second
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If My.Computer.Network.Ping("198.01.01.01") Then
            MessageBox.Show("Server pinged successfully.")
        Else
            MessageBox.Show("Ping request timed out.")
        End If
    End Sub
End Class
