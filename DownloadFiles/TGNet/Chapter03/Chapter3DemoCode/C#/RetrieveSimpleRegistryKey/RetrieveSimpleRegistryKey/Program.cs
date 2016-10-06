#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;

#endregion

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;  /* dummy line for reading the response */
            string strMyKey = "control panel\\international\\";
            RegistryKey aKey;
            aKey = Registry.CurrentUser.OpenSubKey(strMyKey);
            Console.WriteLine("Value of the international key setting is: " + aKey.GetValue("sCountry"));
            Console.WriteLine("Press any key to quit");
            line = Console.ReadLine();

        }
    }
}
