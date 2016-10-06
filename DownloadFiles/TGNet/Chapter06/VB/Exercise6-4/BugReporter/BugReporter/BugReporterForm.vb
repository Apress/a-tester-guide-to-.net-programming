Public Class BugReporterForm

  Private Sub btnSubmitBug_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmitBug.Click
    'Create a new object from the ReportToFile class
    Dim objReport As New ReportToFile

    'Create string variables and get the data from the User
    objReport.Tester = txtTester.Text
    objReport.ApplicationName = txtAppName.Text
    objReport.BuildNumber = txtBuildNumber.Text
    objReport.DateReported = txtDateReported.Text
    objReport.Description = txtDescription.Text
    objReport.FileName = txtFileName.Text

    'Call the FormatData method
    objReport.FormatData()

    'Call the Save method
    If objReport.Save() = True Then
      MessageBox.Show("Bug reported!")
      txtDescription.Text = ""
    Else
      MessageBox.Show("There was an error!")
    End If
  End Sub

End Class

