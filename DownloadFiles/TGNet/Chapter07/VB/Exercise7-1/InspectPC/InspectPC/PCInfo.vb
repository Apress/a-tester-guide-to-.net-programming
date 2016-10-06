Imports System
Public Class PCInfo
  Const MEGABYTES As Int32 = 1024000

  Shared Sub Main(ByVal args() As String)
    If args.Length = 0 Then
      Console.WriteLine("You must pass in a arugment of Y or N ")
    End If

    Dim strData As String = ""

    'a) Check PC Hardware and OS info
    strData += "PC Information" + vbCrLf
    strData += GetPCInfo() + vbCrLf

    strData += "Drive Information" + vbCrLf
    strData += GetDriveInfo() + vbCrLf

    strData += "Memory Information" + vbCrLf
    strData += GetMemoryInfo() + vbCrLf

    Try
      'Get user arguments
      'y = save to file.
      'n = do not save to file.

      If args(0) = "y" Then
        'b) Create folder and store setup info 
        'in a csv for easy import to a database.
        Dim DI As New System.IO.DirectoryInfo("c:\PCInfo")
        If Not DI.Exists Then
          DI.Create()
        End If

        WriteReport(strData)
      ElseIf args(0) = "n" Then
        Console.WriteLine(strData)
      Else
        Console.WriteLine("You must chose to write to file or not.")
        Console.WriteLine("Add y or n after the program name")
      End If
    Catch ex As Exception
      Console.WriteLine(ex.ToString)
    End Try
  End Sub

  Private Shared Function GetPCInfo() As String
    Dim strPCInfo As String = ""
    Dim strHeading As String = ""

    'Make column heading 
    strHeading += "Computer Name,  "
    strHeading += "Operating System,  "
    strHeading += "Operating System Version,  "
    strHeading += "UI Culture,  "
    strHeading += "Time on PC"
    strPCInfo += strHeading + vbCrLf

    'Get column data
    strPCInfo += My.Computer.Name + ", "
    strPCInfo += My.Computer.Info.OSFullName + ", "
    strPCInfo += My.Computer.Info.OSVersion + ", "
    strPCInfo += My.Computer.Info.InstalledUICulture.EnglishName + ", "
    strPCInfo += My.Computer.Clock.LocalTime
    strPCInfo += vbCrLf
    Return strPCInfo

  End Function

  Private Shared Function GetDriveInfo() As String
    Dim strHDInfo As String = ""
    'Dim objDI As New System.IO.DriveInfo()
    Dim strHeading As String = ""

    'Make column headings 
    strHeading += "Drive Letter,  "
    strHeading += "File Format,  "
    strHeading += "Free Space,  "
    strHeading += "Drive Type"
    strHDInfo += strHeading + vbCrLf

    'Get Drive Info
    Dim objDI As System.IO.DriveInfo
    Dim strDL As String
    For Each objDI In System.IO.DriveInfo.GetDrives()
      strDL = objDI.Name.Substring(0, 1)
      strHDInfo += strDL + ":, "

      If objDI.DriveType = IO.DriveType.Fixed Then
        strHDInfo += objDI.DriveFormat + ", "
        strHDInfo += (objDI.AvailableFreeSpace / MEGABYTES).ToString + " MB, "
        strHDInfo += objDI.DriveType.ToString()

      ElseIf objDI.DriveType = IO.DriveType.CDRom Then
        strHDInfo += "NA,"
        strHDInfo += "NA,"
        strHDInfo += objDI.DriveType.ToString()

      ElseIf objDI.DriveType = IO.DriveType.Removable Then
        strHDInfo += "NA,"
        strHDInfo += "NA,"
        strHDInfo += objDI.DriveType.ToString()

      ElseIf objDI.DriveType = IO.DriveType.Network Then
        strHDInfo += objDI.DriveFormat + ", "
        strHDInfo += (objDI.AvailableFreeSpace / MEGABYTES).ToString + " MB, "
        strHDInfo += objDI.DriveType.ToString()
      End If
      strHDInfo += vbCrLf
    Next
    Return strHDInfo
  End Function

  Private Shared Function GetMemoryInfo() As String
    'Get Memory info
    Dim strMemoryInfo As String = ""
    Dim strHeading As String = ""

    'Make column heading 
    strHeading += "Total Phyical Memory,  "
    strHeading += "Total Virtual Memory,  "
    strHeading += "Available Phyical Memory,  "
    strHeading += "Available Virtual Memory  "
    strMemoryInfo += strHeading + vbCrLf

    Dim intTPhysicalMem As UInt64 = My.Computer.Info.TotalPhysicalMemory
    Dim intTVirtualMem As UInt64 = My.Computer.Info.TotalVirtualMemory
    Dim intAPhysicalMem As UInt64 = My.Computer.Info.AvailablePhysicalMemory
    Dim intAVirtualMem As UInt64 = My.Computer.Info.AvailableVirtualMemory

    strMemoryInfo += (intTPhysicalMem / MEGABYTES).ToString + " MB , "
    strMemoryInfo += (intTVirtualMem / MEGABYTES).ToString + "MB , "
    strMemoryInfo += (intAPhysicalMem / MEGABYTES).ToString + " MB , "
    strMemoryInfo += (intAVirtualMem / MEGABYTES).ToString + "MB "
    strMemoryInfo += vbCrLf
    Return strMemoryInfo
  End Function

  Private Shared Sub WriteReport(ByVal Data As String)
    Dim objSW As System.IO.StreamWriter
    Try
      objSW = New System.IO.StreamWriter("c:\PCInfo\PCInfo.csv", False)
      objSW.Write(Data)
      objSW.Close()
    Catch ex As Exception
      ex.ToString()
    End Try
  End Sub

End Class
