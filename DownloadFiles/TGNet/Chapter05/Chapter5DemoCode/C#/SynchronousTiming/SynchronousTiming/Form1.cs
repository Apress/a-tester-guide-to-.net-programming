using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SynchronousTiming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime StartTime;
            DateTime EndTime;
            TimeSpan Interval;
            StartTime = DateTime.Now;
            Interaction.Shell
                ("C:\\Program Files\\Internet Explorer\\iexplore.exe", 
                AppWinStyle.NormalNoFocus, true, 5000);
           
            EndTime = DateTime.Now;
            Interval = EndTime - StartTime;
            MessageBox.Show(Interval.ToString());

        }
    }
}