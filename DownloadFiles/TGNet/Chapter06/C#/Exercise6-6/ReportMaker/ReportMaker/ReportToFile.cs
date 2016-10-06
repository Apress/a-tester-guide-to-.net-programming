using System;
using System.Collections.Generic;
using System.Text;

namespace ReportMaker
{
  public class ReportToFile
  {
    //----Declare Fields Section ----
    private string strTester;
    private string strApplicationName;
    private string strBuildNumber;
    private string strDateReported;
    private string strDescription;
    private string strFileName;
    private string strData;

  //----Properties Section----
  public string Tester
  {
    get
    {
      return strTester;
    }
    set
    {
      strTester = value;
    }
  }

  public string ApplicationName
  {
    get
    {
      return strApplicationName;
    }
    set
    {
      strApplicationName = value;
    }
  }

  public string BuildNumber
  {
    get
    {
      return strBuildNumber;
    }
    set
    {
      strBuildNumber = value;
    }
  }

  public string DateReported
  {
    get
    {
      return strDateReported;
    }
    set
    { 
       strDateReported = value;
     }
  }

  public string Description
  {
    get
    {
      return strDescription;
    }
    set
    {
      //Test if Description was left blank.    
      bool blnIsEmpty;
      blnIsEmpty = Validations.Strings.TestForEmptyStrings(value);

      if (blnIsEmpty == true)
      {
        throw new Exception("Description cannot be empty");
      }
      else
      {
        strDescription = value;
      }
 
    }
  }

  public string FileName
  {
    get
    {
      return strFileName;
    }
    set
    {
        strFileName = value;
     }
  }

  public string Data
  {
    get
    {
      return strData;
    }
    set
    {
      strData = value;
    }
  }

  //---- The Constructor Section ----  
  public ReportToFile()
  {
    strTester = "";
    strApplicationName = "";
    strBuildNumber = "";
    strDateReported = "";
    strDescription = "";
    strFileName = "";
    strData = "" ;
  }//end constructor

public bool Save()
{
  //---- Save Data to File Section ----
  //Create a Variables that will hold a Referance to a File
  System.IO.StreamWriter objWriter;
  bool blnCompleted;

  try
  {
    if (System.IO.File.Exists(FileName) == false)
    {
      //Make a new file, open it, and have objWriter reference it
      objWriter = System.IO.File.CreateText(FileName);
    }
    else
    {
      //Open an existing file, set "True" for Append, and have objWriter reference it
      objWriter = new System.IO.StreamWriter(FileName, true);
    }

    objWriter.WriteLine(Data);
    objWriter.Close();
    objWriter = null;

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

public void FormatData()
{
  Data = Tester + ",";
  Data += ApplicationName + ",";
  Data += BuildNumber + ",";
  Data += DateReported + ",";
  Data += Description;
}

  }//end of class
}//end of namespace
