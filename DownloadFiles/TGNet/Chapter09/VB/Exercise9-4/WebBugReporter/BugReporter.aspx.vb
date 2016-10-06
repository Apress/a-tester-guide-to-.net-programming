
Partial Class BugReporter
    Inherits System.Web.UI.Page

  Dim strProblem As String

  Protected Function IsComplete(ByRef Data As TextBox) As Boolean
    If Validations.Strings.TestForEmptyStrings(Data.Text) = True Then
      strProblem = "is empty."
      Return False
    Else
      Return (True)
    End If
  End Function

  Protected Sub btnSubmitBug_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSubmitBug.Click
    '---- Server Side Validation Section ----
    Select Case False
      Case IsComplete(txtTester)
        lblErrorMessage.Text = "*Testers Name " + strProblem
        Return
      Case IsComplete(txtAppName)
        lblErrorMessage.Text = "*Application Name " + strProblem
        Return
      Case IsComplete(txtBuildNumber)
        lblErrorMessage.Text = "*Build Number " + strProblem
        Return
      Case IsComplete(txtDateReported)
        lblErrorMessage.Text = "*Date " + strProblem
        Return
      Case IsComplete(txtDescription)
        lblErrorMessage.Text = "*Description " + strProblem
        Return
    End Select

    '---- Get Data Section ----
    'Create string variables and get the data from the User
    Dim strTester As String = txtTester.Text
    Dim strApplicationName As String = txtAppName.Text
    Dim strBuildNumber As String = txtBuildNumber.Text
    Dim strDateReported As String = txtDateReported.Text
    Dim strDescription As String = txtDescription.Text

    'Pull data out of the variables above and put it into a string
    Dim strData As String = ""
    strData += "'" + strTester + "',"
    strData += "'" + strApplicationName + "',"
    strData += "'" + strBuildNumber + "',"
    strData += "'" + strDateReported + "',"
    strData += "'" + strDescription + "'"

    '---- Save Data to Database Section ----
    AddBug(strData)
  End Sub

  Protected Sub AddBug(ByVal BugData As String)
    Dim objBuilder As System.Data.OleDb.OleDbConnectionStringBuilder
    Dim objCon As System.Data.OleDb.OleDbConnection
    Dim objComm As System.Data.OleDb.OleDbCommand
    Dim strInsert As String = ""

    'Create a connection to the database
    objBuilder = New System.Data.OleDb.OleDbConnectionStringBuilder
    objBuilder.ConnectionString = "Data Source= C:\BugData.mdb"
    objBuilder.Add("Provider", "Microsoft.Jet.Oledb.4.0")
    objBuilder.Add("Jet OLEDB:Database Password", "")
    ' Set up row-level locking.
    objBuilder.Add("Jet OLEDB:Database Locking Mode", 1)

    objCon = New System.Data.OleDb.OleDbConnection(objBuilder.ConnectionString)

    'Build the insert SQL command(
    'Note the Spaces are important!
    strInsert = " Insert Into ReportedBugs "
    strInsert += " (Tester, AppName, Build, DateReported, Description) "
    strInsert += " Values( " + BugData + " ) "

    'Build a Command object to send your command
    objComm = New System.Data.OleDb.OleDbCommand()
    objComm.Connection = objCon
    objComm.CommandType = Data.CommandType.Text
    objComm.CommandText = strInsert
    'Response.Write(objComm.CommandText.ToString)

    'Open the connection and run the command
    Try
      objCon.Open()
      objComm.ExecuteNonQuery()
      objCon.Close()
      Response.Redirect("Default.aspx")

    Catch ex As Exception
      Response.Write(ex.ToString)
    End Try
  End Sub

End Class
