// To use this program, use your browser to navigate to any website and then
// retrieve the source code for that site. To do this using IE, just click the View=>Source
// menu item. Copy and paste the source code into the text box on this application
// as it runs.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SimpleTiming
{
    public partial class Form1 : Form
    {
        // Note the following form
        // properties were set:
        // AcceptButton = button1
        // Also the following properties for the Textbox:
        // Anchor = top, left, bottom, right
        // Multiline = true
        public Form1()
        {
            InitializeComponent();
        }

        public Int16 FindHref(string strSource)
        {
            Regex r;
            Match m;
            Int16 iCount = 0;
            r = new Regex("href\\s*=\\s*(?:\"(?<1>[^\"]*)\"|(?<1>\\S+))", RegexOptions.IgnoreCase | RegexOptions.Compiled);
            m = r.Match(strSource);
            while (m.Success)
            {
                iCount += 1;
                m = m.NextMatch();
            }
            return iCount;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime StartTime;
            DateTime EndTime;
            TimeSpan Interval;
            Int16 numHrefs;
            StartTime = DateTime.Now;
            numHrefs = FindHref(txtSource.Text);
            EndTime = DateTime.Now;
            lblHrefs.Text = numHrefs.ToString();
            Interval = EndTime - StartTime;
            lblTime.Text = Interval.ToString();
            
        }

    }
}