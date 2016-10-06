using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace ADODataReaderDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=localhost;Database=Northwind;Trusted_Connection=Yes");
            Int16 iRet;
            SqlCommand cmd = new SqlCommand("Select count(*) from customers", cn);
            const int iEXPECTED = 91;
            cn.Open();
            iRet = Convert.ToInt16 (cmd.ExecuteScalar());
            if (iRet == iEXPECTED)
            {
                MessageBox.Show("Test passed; Expected: " + iEXPECTED + " Actual: " + iRet);
            }
            else
            {
                MessageBox.Show("Test failed; Expected: " + iEXPECTED + " Actual: " + iRet);
            }
            cn.Close();

        }
    }
}