#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

#endregion

namespace TextReadUtility
{
    partial class frmTextRead : Form
    {
        public frmTextRead()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string strFile;
            int MyPos = 1;
            Int16 iCount = 0;
            StreamReader reader = File.OpenText(txtFile.Text);
            strFile = reader.ReadToEnd();
            do
            {
                MyPos = strFile.IndexOf(txtFindString.Text, MyPos + 1);
                if (MyPos > 0)
                {
                    iCount += 1;
                }
            } while (!(MyPos == -1));
            lblResult.Text = "Number of times found: iCount = " + iCount;

        }
    }
}