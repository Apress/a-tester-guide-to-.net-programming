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

public partial class BugReporter : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
  protected void btnSubmitBug_Click(object sender, EventArgs e)
  {
    //---- Get Data Section ----
    //Create string variables and get the data from the User
    string strTester = txtTester.Text;
    string strApplicationName = txtAppName.Text;
    string strBuildNumber = txtBuildNumber.Text;
    string strDateReported = txtDateReported.Text;
    string strDescription = txtDescription.Text;

    //Pull data out of the variables above and put it into a string
    string strData = "";
    strData += "'" + strTester + "',";
    strData += "'" + strApplicationName + "',";
    strData += "'" + strBuildNumber + "',";
    strData += "'" + strDateReported + "',";
    strData += "'" + strDescription + "'";

    //---- Save Data to Database Section ----
    AddBug(strData);
  }

  protected void AddBug(string BugData)
  {
    System.Data.OleDb.OleDbConnectionStringBuilder objBuilder;
    System.Data.OleDb.OleDbConnection objCon;
    System.Data.OleDb.OleDbCommand objComm;
    string strInsert = "";

    objBuilder = new System.Data.OleDb.OleDbConnectionStringBuilder();
    objBuilder.ConnectionString = "Data Source= C:\\BugData.mdb";
    objBuilder.Add("Provider", "Microsoft.Jet.Oledb.4.0");
    objBuilder.Add("Jet OLEDB:Database Password", "");
    objBuilder.Add("Jet OLEDB:Database Locking Mode", 1);
    objCon = new System.Data.OleDb.OleDbConnection(objBuilder.ConnectionString);

    strInsert = " Insert Into ReportedBugs ";
    strInsert += " (Tester, AppName, Build, DateReported, Description) ";
    strInsert += " Values( " + BugData + " ) ";
    objComm = new System.Data.OleDb.OleDbCommand();
    objComm.Connection = objCon;
    objComm.CommandType = System.Data.CommandType.Text;
    objComm.CommandText = strInsert;

    try
    {
      objCon.Open();
      objComm.ExecuteNonQuery();
      objCon.Close();
      Response.Redirect("Default.aspx");
    }
    catch (Exception ex)
    {
      Response.Write(ex.ToString());
    }
  }

}
