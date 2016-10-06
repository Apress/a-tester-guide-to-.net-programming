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

            if (File.Exists(textBox1.Text))
                MessageBox.Show("File Exists: Test passed");
            else
                MessageBox.Show("File doesn’t Exist: Test failure");
        }
    }
}
