#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace DatabaseAccess
{
    partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection cn = new OleDbConnection("Provider=Microsoft.jet.oledb.4.0;Data Source=TestResultsDB.mdb");
            int iRet;
            cn.Open();
            OleDbCommand cmd = new OleDbCommand("Insert into TestResults (TestID, TestDate, Reqmt, Tester, Result)" + 
                "Values (4, '01-Jan-2006', 'Test Reqmt ABC', 'M. Sweeney', 1)", cn);
            iRet = cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}