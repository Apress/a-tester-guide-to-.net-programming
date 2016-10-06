

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim StartTime As DateTime
        Dim EndTime As DateTime
        Dim Interval As TimeSpan

        StartTime = DateTime.Now 'capture current seconds
        Shell("C:\Program Files\Internet Explorer\iexplore.exe", AppWinStyle.NormalFocus, True)
        EndTime = DateTime.Now

        Interval = EndTime - StartTime
        MessageBox.Show(Interval.ToString())
    End Sub
End Class
