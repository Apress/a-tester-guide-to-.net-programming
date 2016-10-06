#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
#endregion

namespace FirstTest
{
    partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        
        StreamWriter Writer;
        Int16 iCount = 1;

        private void button1_Click(object sender, EventArgs e)
        {
            string strCount;
            if (iCount == 1)
            {
                Writer = File.CreateText("TestResults.log");
                Writer.WriteLine("Test Results for Test Run XYZ; " + DateTime.Now);
            }
            else
            {
                Writer = File.AppendText("TestResults.log");
            }
            strCount = Convert.ToString(iCount);
            if (File.Exists(textBox1.Text))
            {
                Writer.WriteLine(strCount + " File " + textBox1.Text + " Exists: Test Passed");
                label1.Text = "File " + textBox1.Text + " Exists: Test Passed";
            }
            else
            {
                Writer.WriteLine(strCount + " File " + textBox1.Text + " doesn't exist: Test Failed");
                label1.Text = "File " + textBox1.Text + " doesn't exist: Test Failed";
            }
            iCount += 1;
            Writer.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Notepad.exe","TestResults.log");

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Writer = File.AppendText("Testresults.log");
            Writer.WriteLine("Test Completed for Test Run XYZ; " + DateTime.Now);
            Writer.Close();

        }

        
    }
}
