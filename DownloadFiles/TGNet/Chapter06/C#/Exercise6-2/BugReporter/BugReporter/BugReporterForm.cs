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

    //---- Declare Variables Section ----
    string strTester;
    string strApplicationName;
    string strBuildNumber;
    string strDateReported;
    string strDescription;
    string strFileName;
    string strData;
    
    private void btnSubmitBug_Click(object sender, EventArgs e)
    {
      //---- Get Data Section ----
      //Create string variables and get the data from the User
       strTester = txtTester.Text;
       strApplicationName = txtAppName.Text;
       strBuildNumber = txtBuildNumber.Text;
       strDateReported = txtDateReported.Text;
       strDescription = txtDescription.Text;
       strFileName = txtFileName.Text;
    
      //Pull data out of the variables above and put it into a string
    strData = strTester + ",";
    strData += strApplicationName + ",";
    strData += strBuildNumber + ",";
    strData += strDateReported + ",";
    strData += strDescription;
    
    // Call the Save method
    Save();
    }//end of btnSubmitBug_Click()

    public void Save()
    {
      //---- Save Data to File Section ----
      //Create a Variables that will hold a Referance to a File
      System.IO.StreamWriter objWriter;
      
      if (System.IO.File.Exists(strFileName) == false)
      {
        //Make a new file, open it, and have objWriter reference it
        objWriter = System.IO.File.CreateText(strFileName);
      }
      else
      {
        //Open an existing file, set "True" for Append, and have objWriter reference it
        objWriter = new System.IO.StreamWriter(strFileName, true);
      }
      objWriter.WriteLine(strData);
      objWriter.Close();
      objWriter = null;
      txtDescription.Clear();
  }//end of Save()

  }//end of BugReporterForm class

}