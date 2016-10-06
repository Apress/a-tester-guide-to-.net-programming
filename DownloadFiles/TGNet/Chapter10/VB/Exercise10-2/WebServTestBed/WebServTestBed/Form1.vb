Public Class Form1

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblArea.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim AreaServ As New CalculateArea.Service
        Dim sngLength As Single
        Dim sngWidth As Single
        Dim sngArea As Single

        sngLength = Convert.ToSingle(txtLength.Text)
        sngWidth = Convert.ToSingle(txtWidth.Text)
        sngArea = AreaServ.RectangleArea(sngLength, sngWidth)

        lblArea.Text = sngArea.ToString

    End Sub
End Class
