using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class BugViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
      System.Data.OleDb.OleDbConnectionStringBuilder objBuilder;
      System.Data.OleDb.OleDbConnection objCon;
      System.Data.OleDb.OleDbCommand objComm;
      string strSelect = "";

      //Create a connection to the database
      objBuilder = new System.Data.OleDb.OleDbConnectionStringBuilder();
      objBuilder.ConnectionString = "Data Source= C:\\BugData.mdb";
      objBuilder.Add("Provider", "Microsoft.Jet.Oledb.4.0");
      objBuilder.Add("Jet OLEDB:Database Password", "");
      objBuilder.Add("Jet OLEDB:Database Locking Mode", 1);
      objCon = new System.Data.OleDb.OleDbConnection(objBuilder.ConnectionString);

      //Build the SQL Select command 
      //Note the Spaces are important!
      strSelect = " Select ";
      strSelect += " Tester, AppName, Build, DateReported, Description ";
      strSelect += " From ReportedBugs";

      //Build a Command object to send your command
      objComm = new System.Data.OleDb.OleDbCommand();
      objComm.Connection = objCon;
      objComm.CommandType = System.Data.CommandType.Text;
      objComm.CommandText = strSelect;
      //Response.Write(objComm.CommandText.ToString)

      //Create a DataReader variable to referance the results 
      //we get back from the database.
      System.Data.OleDb.OleDbDataReader objDR;

      //Open the connection and run the command
      try
      {
        objCon.Open();
        objDR = objComm.ExecuteReader();

        //Print out the results
        Response.Write("<table border='1'>");
        Response.Write("<tr>");
        Response.Write("<th>Tester</th>");
        Response.Write("<th>App Name</th>");
        Response.Write("<th>Build</th>");
        Response.Write("<th>DateReported</th>");
        Response.Write("<th>Description</th>");
        Response.Write("</tr>");

        while (objDR.Read() == true)
        {
          Response.Write("<tr>");
          Response.Write("<td>" + objDR["Tester"] + "</td>");
          Response.Write("<td>" + objDR["AppName"] + "</td>");
          Response.Write("<td>" + objDR["Build"] + "</td>");
          Response.Write("<td>" + objDR["DateReported"] + "</td>");
          Response.Write("<td>" + objDR["Description"] + "</td>");
          Response.Write("</tr>");
        }

        Response.Write("</table>");
        objDR.Close();
      }
      catch (Exception ex)
      {
        Response.Write(ex.ToString());
      }
      finally
      {
        if (objCon.State == System.Data.ConnectionState.Open)
        {
          objCon.Close();
        }
      } 

    }
}
