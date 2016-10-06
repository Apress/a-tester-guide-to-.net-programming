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
    private string strTester;
    private string strApplicationName;
    private string strBuildNumber;
    private string strDateReported;
    private string strDescription;
    private string strFileName;
    private string strData;
    
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
    if (Save() == true)
    {
      MessageBox.Show("Bug reported!");
    }
    else 
    {
      MessageBox.Show("There was an error!");
    }

    }//end of btnSubmitBug_Click()

    public bool Save()
    {
      //---- Save Data to File Section ----
      //Create a Variables that will hold a Referance to a File
      System.IO.StreamWriter objWriter;
      bool blnCompleted;
      try
      {
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
        
        //if it made it this far without an error
        blnCompleted = true; 
      }
      catch 
      {
        // if it had an error
        blnCompleted = false; 
      }
      return blnCompleted;
  }//end of Save()

  }//end of BugReporterForm class

}