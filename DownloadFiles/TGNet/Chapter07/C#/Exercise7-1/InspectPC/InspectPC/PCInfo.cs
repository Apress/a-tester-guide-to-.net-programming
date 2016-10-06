using System;
using Microsoft.VisualBasic.Devices;
class PCInfo
{
  const Int64 MEGABYTES = 1024000;
  static Computer mc;

  static void Main(string[] args)
  {
    if (args.Length == 0)
    {
      Console.WriteLine("You must pass in a arugment of Y or N ");
    }

    mc = new Microsoft.VisualBasic.Devices.Computer();

    string strData = "";
    strData += "PC Information" + "\r\n";
    strData += GetPCInfo() + "\r\n";
    strData += "Drive Information" + "\r\n";
    strData += GetDriveInfo() + "\r\n";
    strData += "Memory Information" + "\r\n";
    strData += GetMemoryInfo() + "\r\n";
    try
    {
      if (args[0] == "y")
      {
        System.IO.DirectoryInfo DI = new System.IO.DirectoryInfo("c:\\PCInfo");
        if (!(DI.Exists))
        {
          DI.Create();
        }
        WriteReport(strData);
      }
      else if (args[0] == "n")
      {
        Console.WriteLine(strData);
      }
      else
      {
        Console.WriteLine("You must chose to write to file or not.");
        Console.WriteLine("y or n after the program name");
      }
    }
    catch (Exception ex)
    {
      Console.WriteLine(ex.ToString());
    }

  }

  private static string GetPCInfo()
  {
    string strPCInfo = "";
    string strHeading = "";
    strHeading += "Computer Name, ";
    strHeading += "Operating System, ";
    strHeading += "Operating System Version, ";
    strHeading += "UI Culture, ";
    strHeading += "Time on PC";

    strPCInfo += strHeading + "\r\n";
    strPCInfo += mc.Name + ", ";
    strPCInfo += mc.Info.OSFullName + ", ";
    strPCInfo += mc.Info.OSVersion + ", ";
    strPCInfo += mc.Info.InstalledUICulture.EnglishName + ", ";
    strPCInfo += mc.Clock.LocalTime;
    strPCInfo += "\r\n";
    return strPCInfo;
  }

  private static string GetDriveInfo()
  {
    string strHDInfo = "";
    string strHeading = "";

    //Make column headings 
    strHeading += "Drive Letter, ";
    strHeading += "File Format, ";
    strHeading += "Free Space, ";
    strHeading += "Drive Type";
    strHDInfo += strHeading + "\r\n";

    //Get Drive Info
    // System.IO.DriveInfo objDI;
    string strDL;
    foreach (System.IO.DriveInfo objDI in System.IO.DriveInfo.GetDrives())
    {
      strDL = objDI.Name.Substring(0, 1);
      strHDInfo += strDL + ":, ";
      if (objDI.DriveType == System.IO.DriveType.Fixed)
      {
        strHDInfo += objDI.DriveFormat + ", ";
        strHDInfo += (objDI.AvailableFreeSpace / MEGABYTES).ToString() + " MB, ";
        strHDInfo += objDI.DriveType.ToString();
      }
      else if (objDI.DriveType == System.IO.DriveType.CDRom)
      {
        strHDInfo += "NA,";
        strHDInfo += "NA,";
        strHDInfo += objDI.DriveType.ToString();
      }
      else if (objDI.DriveType == System.IO.DriveType.Removable)
      {
        strHDInfo += "NA,";
        strHDInfo += "NA,";
        strHDInfo += objDI.DriveType.ToString();
      }
      else if (objDI.DriveType == System.IO.DriveType.Network)
      {
        strHDInfo += objDI.DriveFormat + ", ";
        strHDInfo += (objDI.AvailableFreeSpace / MEGABYTES).ToString() + " MB, ";
        strHDInfo += objDI.DriveType.ToString();
      }
      strHDInfo += "\r\n";
    }
    return strHDInfo;

  }

  private static string GetMemoryInfo()
  {
    string strMemoryInfo = "";
    string strHeading = "";
    strHeading += "Total Phyical Memory, ";
    strHeading += "Total Virtual Memory, ";
    strHeading += "Available Phyical Memory, ";
    strHeading += "Available Virtual Memory ";
    strMemoryInfo += strHeading + "\r\n";
    UInt64 intTPhysicalMem = mc.Info.TotalPhysicalMemory;
    UInt64 intTVirtualMem = mc.Info.TotalVirtualMemory;
    UInt64 intAPhysicalMem = mc.Info.AvailablePhysicalMemory;
    UInt64 intAVirtualMem = mc.Info.AvailableVirtualMemory;
    strMemoryInfo += (intTPhysicalMem / MEGABYTES).ToString() + " MB , ";
    strMemoryInfo += (intTVirtualMem / MEGABYTES).ToString() + "MB , ";
    strMemoryInfo += (intAPhysicalMem / MEGABYTES).ToString() + " MB , ";
    strMemoryInfo += (intAVirtualMem / MEGABYTES).ToString() + "MB ";
    strMemoryInfo += "\r\n";
    return strMemoryInfo;
  }

  private static void WriteReport(string Data)
  {
    System.IO.StreamWriter objSW;
    try
    {
      objSW = new System.IO.StreamWriter("c:\\PCInfo\\PCInfo.csv", false);
      objSW.Write(Data);
      objSW.Close();
    }
    catch (Exception ex)
    {
      ex.ToString();
    }
  }

}
