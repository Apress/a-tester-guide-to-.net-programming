using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SendkeysExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ProcessID;
            ProcessID = Interaction.Shell("notepad.exe", AppWinStyle.NormalFocus, true, 5000);
            System.Threading.Thread.Sleep(1000);
            Interaction.AppActivate(ProcessID);
            System.Threading.Thread.Sleep(1000);
            SendKeys.SendWait("Hello there!");
            System.Threading.Thread.Sleep(1000);
            SendKeys.Send("%{F4}");
            SendKeys.Send("{tab}");
            SendKeys.Send("{enter}");

        }
    }
}