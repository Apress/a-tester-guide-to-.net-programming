Imports System.Text.RegularExpressions
'Author: RROOT 
'Date: Oct 2005
'Desc: This application Uses XCOPY deployment to install testware from a Network share

Public Class SetUp

  Shared Sub Main(ByVal args() As String)
    '---- Required Variables Section----
    'Variables for general data  
    Dim strAppPathAndName = ""

    'Variables to collect Switches
    Dim strRunReport As String = "no" 'optional
    Dim strCheckReport As String = "no" 'optional
    Dim strUploadReport As String = "no"  'optional

    'Variable to collect Function Status
    Dim strReportStatus As String = ""
    Dim strRequirementsStatus As String = ""
    Dim strInstallStatus As String = ""
    Dim strReportUploadStatus As String = ""

    '---- Help Section ----
    If args(0) = "-?" Or args(0) = "/?" Then
      Console.WriteLine("Test Lab Setup Application Help")
      ShowHelp()
      Return
    End If


    '---- Get Arguments Section ---- 
    Try
      'Get required argument
      strAppPathAndName = args(0)
      'Get optional arguments
      If args.Length = 2 Then
        strRunReport = args(1)
      ElseIf args.Length = 3 Then
        strRunReport = args(1)
        strCheckReport = args(2)
      ElseIf args.Length = 4 Then
        strRunReport = args(1)
        strCheckReport = args(2)
        strUploadReport = args(3)
      End If
    Catch ex As Exception
      'If there was a problem with the arguments
      Console.WriteLine("Please Check Your Arguments And Try Again")
      ShowHelp()
      Return
    End Try

    'Debug.WriteLine(strRunReport + strCheckReport + strAppName + strUploadReport)

    '----Commands and Report Status Section ----

    '1)Run PCData Report
    If strRunReport.ToLower = "yes" Then
      strReportStatus = GetPCData(strRunReport)
    Else
      strReportStatus = "Skipped"
    End If

    '2) Check Requirements Report
    If strCheckReport.ToLower = "yes" Then
      strRequirementsStatus = CheckPCData(strCheckReport)
    Else
      strRequirementsStatus = "Skipped"
    End If

    '3) Download Testware
    strInstallStatus = DownloadAppFiles(strAppPathAndName)

    '4) Append Install Status and Upload to Report Share
    If strUploadReport.ToLower = "yes" Then
      strReportUploadStatus = ReportOnInstall("\\Lab1\Share\InstallReport.htm")
    Else
      strReportUploadStatus = "Skipped"
    End If

    '5) Print install Status to the Command Console
    ReportToUser(strReportStatus, strRequirementsStatus, strInstallStatus, strReportUploadStatus)
  End Sub

  Public Shared Sub ShowHelp()
    Const TAB As String = ChrW(9)
    Console.WriteLine("Please Provide All Information")
    Console.WriteLine("In The Following Order...")
    Console.WriteLine(" Testware Name =" + TAB + "(Path and Name of Testware Folder)")
    Console.WriteLine(" Run PC Report =" + TAB + "[Yes/No]")
    Console.WriteLine(" Check Report =" + TAB + TAB + "[Yes/No]")
    Console.WriteLine(" Upload Report =" + TAB + "[Yes/No]")
    Console.WriteLine(" Example: " + TAB + TAB + "TestLabSetup.exe \\Server1\ShareWithApp yes yes yes")
  End Sub

  Public Shared Function GetPCData(ByVal RunReport As String) As String
    Dim strStatus As String = ""
    Dim objProc As New System.Diagnostics.Process
    objProc.StartInfo.FileName = "C:\PCInfo\InspectPC.exe"
    objProc.StartInfo.CreateNoWindow = True
    objProc.StartInfo.ErrorDialog = True

    Try
      objProc.Start()
      strStatus = "Completed"
    Catch ex As Exception
      Console.WriteLine(ex.ToString + vbCrLf + "Press any key to continue...")
      Console.ReadLine()
      strStatus = "Failed"
    End Try
    Return strStatus
  End Function

  Public Shared Function CheckPCData(ByVal CheckReport As String) As String
    Dim strStatus As String = ""
    Dim objSR As System.IO.StreamReader
    Dim strReportData As String

    Try
      'Open file to read
      objSR = New System.IO.StreamReader("c:\PCInfo\PCInfo.csv")
      strReportData = objSR.ReadToEnd
      objSR.Close()

      'Check for the following requirements 
      '1) OS must = XP 
      If CheckForOS(strReportData) = True Then
        strStatus = "Completed"
      Else
        strStatus = "Failed"
      End If

    Catch ex As Exception
      Console.WriteLine(ex.ToString + vbCrLf + "Press any key to continue...")
      Console.ReadLine()
      strStatus = "Failed"
    End Try

    Return strStatus
  End Function

  Private Shared Function CheckForOS(ByVal ReportData As String) As Boolean
    'Note: If you want to make finding data easier then format your report differently.
    Dim r As Regex
    Dim m As Match

    r = New Regex("XP | 2003", RegexOptions.IgnoreCase Or RegexOptions.Compiled)
    m = r.Match(ReportData)
    If m.Success Then
      Return True
    Else
      Return False
    End If

  End Function

  Public Shared Function DownloadAppFiles(ByVal PathAndName As String) As String
    Dim strStatus As String = ""
    Dim strFileListing() As String
    Dim strFullFileName As String
    Dim strSimpleFileName As String
    Dim strAppName As String
    Dim intIndex As Int16
    intIndex = PathAndName.LastIndexOf("\")
    strAppName = PathAndName.Substring(intIndex + 1)


    Try
      'a) Create folder for your Testware
      Dim DI As New System.IO.DirectoryInfo("c:\" + strAppName)
      If Not DI.Exists Then
        DI.Create()
      End If

      'b) Go to Network share and copy application folder to local drive, overwrite as needed
      strFileListing = System.IO.Directory.GetFiles(PathAndName)
      For Each strFullFileName In strFileListing
        intIndex = strFullFileName.LastIndexOf("\")
        strSimpleFileName = strFullFileName.Substring(intIndex + 1)
        System.IO.File.Copy(strFullFileName, "c:\" + strAppName + "\" + strSimpleFileName, True)
      Next
      strStatus = "Completed"
    Catch ex As Exception
      Console.WriteLine(ex.ToString + vbCrLf + "Press any key to continue...")
      Console.ReadLine()
      strStatus = "Failed"
    End Try

    Return strStatus
  End Function

  Public Shared Function ReportOnInstall(ByVal ReportFileName) As String
    Dim strStatus As String = ""
    Dim objSR As System.IO.StreamReader
    Dim objSW As System.IO.StreamWriter
    Dim strReportData As String = ""
    Dim strComputer As String = My.Computer.Name

    Try
      'Open PCInfo.csv and Append the install info
      objSR = New System.IO.StreamReader("c:\PCInfo\PCInfo.csv")
      strReportData = "<b>*** " + strComputer + " = Done ***</b><p> "
      strReportData += objSR.ReadToEnd
      strReportData += "***" + strComputer + "***" + "<hr>"
      objSR.Close()

      objSW = New System.IO.StreamWriter(ReportFileName, True)
      objSW.Write(strReportData)
      objSW.Close()
      strStatus = "Completed"

    Catch ex As Exception
      Console.WriteLine(ex.ToString + vbCrLf + "Press any key to continue...")
      Console.ReadLine()
      strStatus = "Failed"
    End Try

    Return strStatus
  End Function

  Private Shared Sub ReportToUser _
( _
ByVal Report As String, _
ByVal Requirements As String, _
ByVal Install As String, _
ByVal Uploaded As String _
)
    Dim strStatusReport As String = ""

    strStatusReport = " *** Status Report ***" + vbCrLf
    strStatusReport += "Check Report: " + Report + vbCrLf
    strStatusReport += "Check Requirements: " + Requirements + vbCrLf
    strStatusReport += "Install Testware: " + Install + vbCrLf
    strStatusReport += "Install Report Uploaded: " + Uploaded + vbCrLf
    Console.WriteLine(strStatusReport)
  End Sub

End Class