Public Class Form1

  Private Sub btnEmptyString_Click _
  (ByVal sender As System.Object, ByVal e As System.EventArgs) _
  Handles btnEmptyString.Click

    If Validations.Strings.TestForEmptyStrings(TextBox1.Text) = True Then
      MessageBox.Show("it was empty")
    Else
      MessageBox.Show("it was not empty")
    End If

  End Sub
End Class
