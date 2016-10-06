#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;

#endregion

namespace RegistryUtility
{
    class Program
    {
        static void Main(string[] args)
        {
            byte iEntry = 0;
            while (iEntry != 9)
            {
                Console.WriteLine();
                Console.WriteLine("Enter 1 to Create a new key");
                Console.WriteLine("Enter 2 to add a setting to a key");
                Console.WriteLine("Enter 3 to delete a key");
                Console.WriteLine("Enter 4 to delete a setting");
                Console.WriteLine("Enter 5 to retrieve a setting value");
                Console.WriteLine("Enter 6 to report all subkeys under a key");
                Console.WriteLine("Enter 9 to quit");
                iEntry = Convert.ToByte(Console.ReadLine());
               
                RegistryKey TestProject;
                if (iEntry == 1)
                {
                    string strNewKey;
                    Console.WriteLine("Enter Name of Subkey to create.");
                    Console.WriteLine("(This will create a key under HKEY_CURRENT_USER)");
                    strNewKey = Console.ReadLine();
                    TestProject = Registry.CurrentUser.CreateSubKey(strNewKey);
                }
                else if (iEntry == 2)
                {
                    string strKey;
                    string strSetting;
                    string strValue;
                    Console.WriteLine("Enter the key");
                    strKey = Console.ReadLine();
                    TestProject = Registry.CurrentUser.OpenSubKey(strKey, true);
                    Console.WriteLine("Enter the setting");
                    strSetting = Console.ReadLine();
                    Console.WriteLine("Enter the value");
                    strValue = Console.ReadLine();
                    TestProject.SetValue(strSetting, strValue);
                }
                else if (iEntry == 3)
                {
                    string strKey;
                    string strAns;
                    Console.WriteLine("Enter the key under HKEY_CURRENT_USER to delete");
                    strKey = Console.ReadLine();
                    Console.WriteLine("Do you really mean to delete: " + strKey + " and its settings?");
                    strAns = Console.ReadLine();
                    strAns = strAns.ToUpper();
                    if (strAns == "YES" | strAns == "Y")
                    {
                        Registry.CurrentUser.DeleteSubKeyTree(strKey);
                        Console.WriteLine("Key " + strKey + " deleted");
                    }
                    else
                    {
                        Console.WriteLine("No deletion performed");
                    }
                }
                else if (iEntry == 4)
                {
                    string strKey;
                    string strSetting;
                    string strAns;
                    Console.WriteLine("Enter the key");
                    strKey = Console.ReadLine();
                    TestProject = Registry.CurrentUser.OpenSubKey(strKey, true);
                    Console.WriteLine("Enter the setting");
                    strSetting = Console.ReadLine();
                    Console.WriteLine("Do you really mean to delete: " + strKey + "\\" + strSetting + "?");
                    strAns = Console.ReadLine();
                    strAns = strAns.ToUpper();
        
                    if (strAns == "Y" | strAns == "YES")
                    {
                        TestProject.DeleteValue(strSetting);
                        Console.WriteLine("Key setting " + strKey + "\\" + strSetting + " deleted");
                    }
                    else
                    {
                        Console.WriteLine("No deletion performed; key closed");
                        TestProject.Close();
                    }
                }
                else if (iEntry == 5)
                {
                    string strKey;
                    string strSetting;
                    Console.WriteLine("Enter the key");
                    strKey = Console.ReadLine();
                    TestProject = Registry.CurrentUser.OpenSubKey(strKey);
                    Console.WriteLine("Enter the setting");
                    strSetting = Console.ReadLine();
                    Console.WriteLine("Value of " + strKey + "\\" + strSetting + " is: " );
                    Console.WriteLine(Convert.ToString(TestProject.GetValue(strSetting)));
                }
                else if (iEntry == 6)
                {
                    string strKey;
                    string strHive;
                    Console.WriteLine("Select the hive you want to start with: ");
                    Console.WriteLine("Enter 'L' for HKEY_LOCAL_MACHINE or 'C' for HKEY_CURRENT_USER");
                    strHive = Console.ReadLine();
                    Console.WriteLine("Enter the key");
                    strKey = Console.ReadLine();
                    if (strHive == "L" | strHive == "l")
                    {
                        TestProject = Registry.LocalMachine.OpenSubKey(strKey);
                        Console.WriteLine("HKEY_LOCAL_MACHINE selected");
                    }
                    else
                    {
                        TestProject = Registry.CurrentUser.OpenSubKey(strKey);
                        Console.WriteLine("HKEY_CURRENT_USER selected");
                    }
                    foreach (string subKeyName in TestProject.GetSubKeyNames())
                    {
                        Console.WriteLine(subKeyName);
                    }
                    TestProject.Close();
                }
                else if (iEntry == 9)
                {
                    Console.WriteLine("Good bye!");
                }
                else
                {
                    Console.WriteLine("Invalid Entry; please enter 1-5 (or 9 to quit)");
                }
            }
        }
    }
}
