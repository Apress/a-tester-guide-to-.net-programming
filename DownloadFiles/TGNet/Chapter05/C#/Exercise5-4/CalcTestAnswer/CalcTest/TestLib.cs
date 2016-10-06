using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.IO;


    static class TestLib
    {
        public static string Logfile = "c:\\logfile.txt";
        
        public static int StartProgram(string strAppName)
        {
            if (!(File.Exists(Logfile)))
            {
                CreateLog("Starting Log file " + DateTime.Now);
            }
            Process myProcess = Process.Start(strAppName);
            LogtoFile("Application " + strAppName + " Started at: " + DateTime.Now);
            return (myProcess.Id);
        }

        private static void CreateLog(string strHeader)
        {
            StreamWriter Writer;
            Writer = File.CreateText(Logfile);
            Writer.WriteLine(strHeader);
            Writer.Close();
        }

        public static void LogtoFile(string strLog)
        {
            StreamWriter Writer;
            Writer = File.AppendText(Logfile);
            Writer.WriteLine(strLog);
            Writer.Close();
        }

        public static void Readlog()
        {
            Process myProcess = Process.Start("Notepad", Logfile);
        }

        public static void CloseProgram(string App)
        {
            System.Windows.Forms.SendKeys.SendWait("%{F4}");
            LogtoFile(App + " Ended at " + DateTime.Now);
        }

    }

