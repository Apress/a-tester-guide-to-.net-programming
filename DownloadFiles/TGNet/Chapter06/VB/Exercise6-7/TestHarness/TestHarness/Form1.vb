Imports System.Text.RegularExpressions
Public Class Form1

  Private Sub btnTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTest.Click

    Dim objReport As New ReportMaker.ReportToFile

    objReport.Tester = "Joe tester"
    objReport.ApplicationName = "Test App"
    objReport.BuildNumber = "1.1"
    objReport.DateReported = Date.Today.ToShortDateString()
    objReport.Description = "This is a test Bug"
    objReport.FileName = txtFileName.Text

    Dim strTempString As String

    'Convert to lowercase to make the RegEx simpler
    strTempString = txtFileName.Text.ToLower()

    Dim strXMLPattern As String = "^.+\.[x][m][l]$"
    Dim strHTMLPattern As String = "^.+\.[h][t][m][l]$"

    Try

      If (Regex.IsMatch(strTempString, strXMLPattern)) Then
        objReport.FormatData("xml")
      ElseIf (Regex.IsMatch(strTempString, strHTMLPattern)) Then
        objReport.FormatData("html")
      Else
        objReport.FormatData()
      End If
      objReport.Save()
      MessageBox.Show("Saved")

    Catch ex As Exception
      MessageBox.Show(ex.ToString)
    End Try

  End Sub
End Class
