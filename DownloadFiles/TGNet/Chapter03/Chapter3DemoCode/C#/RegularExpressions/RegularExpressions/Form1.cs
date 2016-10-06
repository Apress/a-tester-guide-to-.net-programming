#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions; 

#endregion

namespace RegularExpressions
{
    partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex r;
            Match m;
            int i;
            i = 0;
            r = new Regex("href\\s*=\\s*(?:\"(?<1>[^\"]*)\"|(?<1>\\S+))", 
                RegexOptions.IgnoreCase | RegexOptions.Compiled);
            m = r.Match(textBox1.Text);
            while (m.Success)
            {
                i += 1;
                listBox1.Items.Add("Found href " + m.Value + " at " + m.Index.ToString());
                m = m.NextMatch();
            }
            label1.Text = (i + " Total Href's found");

        }
    }
}