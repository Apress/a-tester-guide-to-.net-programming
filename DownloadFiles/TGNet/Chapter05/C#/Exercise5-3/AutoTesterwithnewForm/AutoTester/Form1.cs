using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace AutoTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void btnStartApp_Click(object sender, EventArgs e)
        {
        
            try
            {
                TestLib.Logfile = "c:\\testlog.log";
                TestLib.StartProgram(txtAppName.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aForm = new AboutBox1();
            aForm.ShowDialog();
        }

        private void startApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnStartApp.PerformClick();
        }

      }
    }
