
Partial Class BugViewer
    Inherits System.Web.UI.Page

  Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    Dim objBuilder As System.Data.OleDb.OleDbConnectionStringBuilder
    Dim objCon As System.Data.OleDb.OleDbConnection
    Dim objComm As System.Data.OleDb.OleDbCommand
    Dim strSelect As String = ""

    'Create a connection to the System.Database
    objBuilder = New System.Data.OleDb.OleDbConnectionStringBuilder
    objBuilder.ConnectionString = "Data Source= C:\BugData.mdb"
    objBuilder.Add("Provider", "Microsoft.Jet.Oledb.4.0")
    objBuilder.Add("Jet OLEDB:Database Password", "")
    ' Set up row-level locking.
    objBuilder.Add("Jet OLEDB:Database Locking Mode", 1)
    objCon = New System.Data.OleDb.OleDbConnection(objBuilder.ConnectionString)

    'Build the SQL Select command 
    'Note the Spaces are important!
    strSelect = " Select "
    strSelect += " Tester, AppName, Build, DateReported, Description "
    strSelect += " From ReportedBugs"

    'Build a Command object to send your command
    objComm = New System.Data.OleDb.OleDbCommand()
    objComm.Connection = objCon
    objComm.CommandType = System.Data.CommandType.Text
    objComm.CommandText = strSelect
    'Response.Write(objComm.CommandText.ToString)

    'Create a System.DataReader variable to referance the results 
    'we get back from the System.Database.
    Dim objDR As System.Data.OleDb.OleDbDataReader
    'Open the connection and run the command
    Try
      objCon.Open()
      objDR = objComm.ExecuteReader()

      Response.Write("<table border='1'>")
      Response.Write("<tr>")
      Response.Write("<th>Tester</th>")
      Response.Write("<th>App Name</th>")
      Response.Write("<th>Build</th>")
      Response.Write("<th>DateReported</th>")
      Response.Write("<th>Description</th>")
      Response.Write("</tr>")

      'Print out the results
      While objDR.Read = True
        Response.Write("<tr>")
        Response.Write("<td>" & objDR("Tester") & "</td>")
        Response.Write("<td>" & objDR("AppName") & "</td>")
        Response.Write("<td>" & objDR("Build") & "</td>")
        Response.Write("<td>" & objDR("DateReported") & "</td>")
        Response.Write("<td>" & objDR("Description") & "</td>")
        Response.Write("</tr>")
      End While

      Response.Write("</table>")
      objDR.Close()

    Catch ex As Exception
      Response.Write(ex.ToString)
    Finally
      If objCon.State = System.Data.ConnectionState.Open Then
        objCon.Close()
      End If
    End Try

  End Sub
End Class
