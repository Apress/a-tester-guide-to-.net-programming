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
        public void StartProgram(string strAppname)
        {
            Process.Start(strAppname);
        }


        private void btnStartApp_Click(object sender, EventArgs e)
        {
            try
            {
                StartProgram(txtAppName.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

      }
    }
