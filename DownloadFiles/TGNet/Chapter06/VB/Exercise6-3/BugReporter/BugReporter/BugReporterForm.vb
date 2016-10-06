Public Class BugReporterForm

  '---- Declare Variables Section ----
  Private strTester As String
  Private strApplicationName As String
  Private strBuildNumber As String
  Private strDateReported As String
  Private strDescription As String
  Private strFileName As String
  Private strData As String

  Private Sub btnSubmitBug_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmitBug.Click
    '---- Get Data Section ----
    'Create string variables and get the data from the User
    strTester = txtTester.Text
    strApplicationName = txtAppName.Text
    strBuildNumber = txtBuildNumber.Text
    strDateReported = txtDateReported.Text
    strDescription = txtDescription.Text
    strFileName = txtFileName.Text

    'Pull data out of the variables above and put it into a string
    strData = strTester + ","
    strData += strApplicationName + ","
    strData += strBuildNumber + ","
    strData += strDateReported + ","
    strData += strDescription

    'Call the Save method
    If Save() = True Then
      MessageBox.Show("Bug reported!")
    Else
      MessageBox.Show("There was an error!")
    End If

  End Sub

  Public Function Save() As Boolean
    '---- Save Data to File Section ----
    'Create a Variables that will hold a Referance to a File
    Dim objWriter As System.IO.StreamWriter
    Dim blnCompleted As Boolean

    Try
      If (System.IO.File.Exists(strFileName) = False) Then
        'Make a new file, open it, and have objWriter reference it
        objWriter = System.IO.File.CreateText(strFileName)
      Else
        'Open an existing file, set "True" for Append, and have objWriter reference it
        objWriter = New System.IO.StreamWriter(strFileName, True)
      End If
      objWriter.WriteLine(strData)
      objWriter.Close()
      objWriter = Nothing
      txtDescription.Clear()
      'if it made it this far without an error
      blnCompleted = True
    Catch ex As Exception
      'if it had an error 
      blnCompleted = False
    End Try
    Return blnCompleted

  End Function

End Class

