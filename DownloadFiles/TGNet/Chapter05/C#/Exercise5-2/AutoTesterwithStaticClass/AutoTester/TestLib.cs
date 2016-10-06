using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.IO;


    static class TestLib
    {
        public static string Logfile = "c:\\logfile.txt";
        
        public static void StartProgram(string strAppName)
        {
            if (!(File.Exists(Logfile)))
            {
                CreateLog("Starting Log file " + DateTime.Now);
            }
            Process.Start(strAppName);
            LogtoFile("Application " + strAppName + " Started at: " + DateTime.Now);
        }

        private static void CreateLog(string strHeader)
        {
            StreamWriter Writer;
            Writer = File.CreateText(Logfile);
            Writer.WriteLine(strHeader);
            Writer.Close();
        }

        private static void LogtoFile(string strLog)
        {
            StreamWriter Writer;
            Writer = File.AppendText(Logfile);
            Writer.WriteLine(strLog);
            Writer.Close();
        }
    }

