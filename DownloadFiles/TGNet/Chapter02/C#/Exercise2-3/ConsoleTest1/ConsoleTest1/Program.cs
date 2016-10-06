#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

#endregion

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Enter the file to find or enter 'Q' to Quit");
            string strInput = "";

            while (strInput != "Q") {
                strInput = Console.ReadLine();
                if (File.Exists(strInput))
                    Console.WriteLine("File Exists: Test passed");
                else
                    Console.WriteLine("File doesn't Exist: Test failure");
                Console.WriteLine("Enter the file to find or enter 'Q' to Quit");
                }      
          }
      }
}

