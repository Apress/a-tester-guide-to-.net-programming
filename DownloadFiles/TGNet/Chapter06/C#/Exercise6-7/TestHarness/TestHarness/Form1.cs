using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace TestHarness
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

   private void btnTest_Click(object sender, EventArgs e)
    {
      ReportMaker.ReportToFile  objReport = new ReportMaker.ReportToFile();
      objReport.Tester = "Joe tester";
      objReport.ApplicationName = "Test App";
      objReport.BuildNumber = "1.1";
      objReport.DateReported = System.DateTime.Today.ToShortDateString();
      objReport.Description = "This is a test Bug";
      objReport.FileName = txtFileName.Text;
      string strTempString;
      strTempString = txtFileName.Text.ToLower();
      string strXMLPattern = "^.+\\.[x][m][l]$";
      string strHTMLPattern = "^.+\\.[h][t][m][l]$";
      try
      {
        if ((Regex.IsMatch(strTempString, strXMLPattern)))
        {
          objReport.FormatData("xml");
        }
        else if ((Regex.IsMatch(strTempString, strHTMLPattern)))
        {
          objReport.FormatData("html");
        }
        else
        {
          objReport.FormatData();
        }
        objReport.Save();
        MessageBox.Show("Saved");
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.ToString());
      }
    }//end of btnTest_Click

  }
}