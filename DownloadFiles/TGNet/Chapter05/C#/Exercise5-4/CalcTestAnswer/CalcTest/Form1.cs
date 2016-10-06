using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace CalcTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
 //   ''**************************************
 //   '*  Name:       CalcTest
 //   '*  Purpose:    This application contains code to
 //   '*              test the calculator accessory addition capability.  
 //   '*   
 //   '*              It is the answer for the Chapter 5-4 Exercise.
 //   '*              
 //   '*  Author:     M. Sweeney
 //   '*  Date Created: 6/15/2005
 //   '*  Inputs:     
 //   '*  Expected Result: That the calculator
 //   '*  Modification History:
 //   '*  Name:       Date:       Purpose:
 //   '*
 //   '**************************************
        private void cmdTest_Click(object sender, EventArgs e)
        {
            DateTime StartTime;
            TimeSpan Interval;
            String strTotal = "";
            Int32 CalcProcessID;
            Int16 I;

            TestLib.Logfile = "c:\\Calclog.txt";
            CalcProcessID = TestLib.StartProgram("Calc.exe");
            System.Threading.Thread.Sleep(1000);

            StartTime = DateTime.Now;
            Interaction.AppActivate(CalcProcessID);
            for (I = 1; I <= 100; I++)
            {
                SendKeys.SendWait(I + "{+}");
            }
            SendKeys.SendWait("=");
            SendKeys.SendWait("^c");
            strTotal = Clipboard.GetData(DataFormats.Text).ToString();
                        
            // if statement
            if (Convert.ToInt32(strTotal) == 10100)
            {
                TestLib.LogtoFile("Test Passed Expected: 10100 Actual : " + strTotal);
            }
            else
            {
                TestLib.LogtoFile("Test Failed Expected: 10100 Actual : " + strTotal);
            }
            Interval = DateTime.Now - StartTime;

            lblTime.Text = Interval.TotalSeconds.ToString();
            TestLib.LogtoFile("Total Elapsed time: " + lblTime.Text);

            TestLib.CloseProgram("calc");
            cmdLog.Enabled = true;
        }

        private void cmdLog_Click(object sender, EventArgs e)
        {
            TestLib.Readlog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        //don't allow access to View Report button until test runs at least once
            cmdLog.Enabled = false;
        }
    }
}