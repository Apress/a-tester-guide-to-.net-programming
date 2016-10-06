#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

#endregion

namespace BugReporter
{
  partial class BugReporterForm : Form
  {
    public BugReporterForm()
    {
      InitializeComponent();
    }

    
    private void btnSubmitBug_Click(object sender, EventArgs e)
    {
      ReportMaker.ReportToFile objReport = new ReportMaker.ReportToFile();
    
      try
      {
        //---- Get Data Section ----
        objReport.Tester = txtTester.Text;
        objReport.ApplicationName = txtAppName.Text;
        objReport.BuildNumber = txtBuildNumber.Text;
        objReport.DateReported = txtDateReported.Text;
        objReport.Description = txtDescription.Text;
        objReport.FileName = txtFileName.Text;
      }
      catch(Exception ex)
      {
        MessageBox.Show(ex.ToString());
      }
      objReport.FormatData();
   
    // Call the Save method
  if (objReport.Save() == true) 
  {
    MessageBox.Show("Bug recorded");
    txtDescription.Text = "";
  }
  else
  {
    MessageBox.Show("There was an error");
  }
    
    }//end of btnSubmitBug_Click()
    

  }//end of BugReporterForm class

}