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

        private void button1_Click(object sender, EventArgs e)
        {

            StreamWriter Writer;
            Writer = File.CreateText("TestResults.log");
            Writer.WriteLine("Test Results for Test Run XYZ; " + DateTime.Now);
            if (File.Exists(textBox1.Text))
            {
                Writer.WriteLine("File Exists: Test Passed");
            }
            else
            {
                Writer.WriteLine("File Exists: Test Failed");
            }
            Writer.WriteLine("Test Completed for Test Run XYZ; " + DateTime.Now);
            Writer.Close();
        }
    }
}
