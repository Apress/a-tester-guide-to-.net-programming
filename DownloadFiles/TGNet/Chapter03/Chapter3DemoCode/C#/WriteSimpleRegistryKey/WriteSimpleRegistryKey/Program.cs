#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;

#endregion

namespace WriteSimpleRegistryKey
{
    class Program
    {
        static void Main(string[] args)
        {
            RegistryKey TestProject = 
                Registry.CurrentUser.CreateSubKey("TestProject2005");
            TestProject.SetValue("Test Date", DateTime.Now);
            TestProject.SetValue("Level", "Priority 2");
            TestProject.SetValue("ID", 123);
            TestProject.Close();
        }
    }
}
