using System;
using System.Text.RegularExpressions; 
using Microsoft.VisualBasic.Devices;  

//Author: RROOT 
//Date: Oct 2005
//Desc: This application Uses XCOPY deployment to install testware from a Network share


public class SetUp 
{ 
 static Computer mc;

 static void Main(string[] args) 
 {
   //---- Required Variables Section ----
   //Variables for general data  
   mc = new Computer();
   string strAppPathAndName = ""; 
   
   //Variables to collect Switches
   string strRunReport = "no"; 
   string strCheckReport = "no"; 
   string strUploadReport = "no"; 
  
   //Variable to collect Function Status
   string strReportStatus = ""; 
   string strRequirementsStatus = ""; 
   string strInstallStatus = ""; 
   string strReportUploadStatus = ""; 

   //---- Help Section ----
   if (args[0] == "-?" | args[0] == "/?") { 
     Console.WriteLine("Test Lab Setup Application Help"); 
     ShowHelp(); 
     return; 
   } 
   
   //---- Get Arguments Section ----
   try 
   { 
    //Get required argument
     strAppPathAndName = args[0]; 
    
     //Get optional arguments
     if (args.Length == 2) 
     { 
       strRunReport = args[1]; 
     } 
     else if (args.Length == 3) 
     { 
       strRunReport = args[1]; 
       strCheckReport = args[2]; 
     } 
     else if (args.Length == 4) 
     { 
       strRunReport = args[1]; 
       strCheckReport = args[2]; 
       strUploadReport = args[3]; 
     } 
   } 
   catch (Exception ex)
   { 
     //If there was a problem with the arguments
     Console.WriteLine("Please Check Your Arguments And Try Again"); 
     ShowHelp(); 
     return; 
   }

   //----Commands and Report Status Section ----
   //1)Get PC Data Report
   if (strRunReport.ToLower() == "yes") { 
     strReportStatus = GetPCData(strRunReport); 
   } 
   else 
   { 
     strReportStatus = "Skipped"; 
   } 
   
   //2) Check Requirements Report
   if (strCheckReport.ToLower() == "yes") { 
     strRequirementsStatus = CheckPCData(strCheckReport); 
   } 
   else 
   { 
     strRequirementsStatus = "Skipped"; 
   } 
  
   //3) Download Testware
   strInstallStatus = DownloadAppFiles(strAppPathAndName);
  
   //4) Append Install Status and Upload to Report Share
   if (strUploadReport.ToLower() == "yes") { 
     strReportUploadStatus = ReportOnInstall("\\\\Lab1\\Share\\InstallReportCSharp.htm"); 
   } 
     else 
   { 
     strReportUploadStatus = "Skipped"; 
   } 
  
   //5) Print install Status to the Command Console
   ReportToUser(strReportStatus, strRequirementsStatus, strInstallStatus, strReportUploadStatus); 
 } 

 public static void ShowHelp() 
 {
   const string TAB = "\t";
   Console.WriteLine("Please Provide All Information"); 
   Console.WriteLine("In The Following Order..."); 
   Console.WriteLine(" Testware Name =" + TAB + "(Path and Name of Testware Folder)"); 
   Console.WriteLine(" Run PC Report =" + TAB + "[Yes/No]"); 
   Console.WriteLine(" Check Report =" + TAB + TAB + "[Yes/No]"); 
   Console.WriteLine(" Upload Report =" + TAB + "[Yes/No]"); 
   Console.WriteLine(" Example: " + TAB + TAB + "TestLabSetup.exe \\\\Server1\\ShareWithApp yes yes yes"); 
 } 

 public static string GetPCData(string RunReport) 
 { 
   string strStatus = ""; 
   System.Diagnostics.Process objProc = new System.Diagnostics.Process(); 
   objProc.StartInfo.FileName = "C:\\PCInfo\\InspectPC.exe"; 
   objProc.StartInfo.Arguments = "y"; 
   objProc.StartInfo.CreateNoWindow = true; 
   objProc.StartInfo.ErrorDialog = true; 
   try { 
     objProc.Start(); 
     strStatus = "Completed"; 
   } catch (Exception ex) { 
     Console.WriteLine(ex.ToString() + "\r\n" + "Press any key to continue..."); 
     strStatus = "Failed"; 
   } 
   return strStatus; 
 } 

 public static string CheckPCData(string CheckReport) 
 { 
   string strStatus = ""; 
   System.IO.StreamReader objSR; 
   string strReportData; 
   try { 
    
     //--- Gather System Data Section --
     objSR = new System.IO.StreamReader("c:\\PCInfo\\PCInfo.csv"); 
     strReportData = objSR.ReadToEnd(); 
     objSR.Close(); 
     
     // ---- Call The Verification Methods --- 
     // This demo inlcudes only one
     if (CheckForOS(strReportData) == true) { 
       strStatus = "Completed"; 
     } 
     else 
     { 
       strStatus = "Failed"; 
     } 
   } 
   catch (Exception ex) 
   { 
     Console.WriteLine(ex.ToString() + "\r\n" + "Press any key to continue..."); 
     Console.ReadLine(); //Pauses console until someone hit Enter
     strStatus = "Failed"; 
   } 
   return strStatus; 
 } 

 private static bool CheckForOS(string ReportData) 
 { 
   Regex r; 
   Match m; 
   r = new Regex("XP | 2003", RegexOptions.IgnoreCase | RegexOptions.Compiled); 
   m = r.Match(ReportData); 
   if (m.Success) { 
     return true; 
   } else { 
     return false; 
   } 
 } 

 public static string DownloadAppFiles(string PathAndName) 
 { 
   string strStatus = ""; 
   string[] strFileListing; 
   string strSimpleFileName; 
   string strAppName; 
   Int32 intIndex; 
   intIndex = PathAndName.LastIndexOf("\\"); 
   strAppName = PathAndName.Substring(intIndex + 1); 
   try { 
     System.IO.DirectoryInfo DI = new System.IO.DirectoryInfo("c:\\" + strAppName); 
     if (!(DI.Exists)) { 
       DI.Create(); 
     } 
     strFileListing = System.IO.Directory.GetFiles(PathAndName); 
     foreach (string strFullFileName in strFileListing) { 
       intIndex = strFullFileName.LastIndexOf("\\"); 
       strSimpleFileName = strFullFileName.Substring(intIndex + 1); 
       System.IO.File.Copy(strFullFileName, "c:\\" + strAppName + "\\" + strSimpleFileName, true); 
     } 
     strStatus = "Completed"; 
   } catch (Exception ex) { 
     Console.WriteLine(ex.ToString() + "\r\n" + "Press any key to continue..."); 
     Console.ReadLine(); 
     strStatus = "Failed"; 
   } 
   return strStatus; 
 } 

 public static string ReportOnInstall(string ReportFileName) 
 { 
   string strStatus = ""; 
   System.IO.StreamReader objSR; 
   System.IO.StreamWriter objSW; 
   string strReportData = ""; 
   string strComputer = mc.Name; 
   try { 
     objSR = new System.IO.StreamReader("c:\\PCInfo\\PCInfo.csv"); 
     strReportData = "<b>*** " + strComputer + " = Done ***</b><p> "; 
     strReportData += objSR.ReadToEnd(); 
     strReportData += "<hr>"; 
     objSR.Close(); 
     objSW = new System.IO.StreamWriter(ReportFileName, true); 
     objSW.Write(strReportData); 
     objSW.Close(); 
     strStatus = "Completed"; 
   } catch (Exception ex) { 
     Console.WriteLine(ex.ToString() + "\r\n" + "Press any key to continue..."); 
     Console.ReadLine(); 
     strStatus = "Failed"; 
   } 
   return strStatus; 
 }

  private static void ReportToUser(string Report, string Requirements, string Install, string Uploaded)
  {
    string strStatusReport = "";
    strStatusReport = " *** Status Report ***" + "\r\n";
    strStatusReport += "Check Report: " + Report + "\r\n";
    strStatusReport += "Check Requirements: " + Requirements + "\r\n";
    strStatusReport += "Install Testware: " + Install + "\r\n";
    strStatusReport += "Install Report Uploaded: " + Uploaded + "\r\n";
    Console.WriteLine(strStatusReport);
  } 

}