#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;

#endregion

namespace DatabaseTest1
{
    partial class frmTestBed : Form
    {
        void TestLog(int tid, System.DateTime testdate, string reqmt, string Tester, bool result)
        {
            OleDbConnection cnTestResults = new OleDbConnection("Provider=Microsoft.jet.oledb.4.0;Data Source=TestResultsDB.mdb");
            int iRet;
            cnTestResults.Open();

            OleDbCommand cmd = new OleDbCommand(
                 "Insert into TestResults (TestID, TestDate, Reqmt, Tester, Result) " + 
                 "Values (" + tid + ", '" + testdate + "', '" + reqmt + "', '" + Tester + "', " + result + ")", 
                  cnTestResults);
            iRet = cmd.ExecuteNonQuery();
            cnTestResults.Close();
        }
        public frmTestBed()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection cn = new OleDbConnection("Provider=Microsoft.jet.oledb.4.0;Data Source=TestResultsDB.mdb");
            int iRet1;
            int iret2;
            cn.Open();
            //Note that contactList is not a table in the database but is a query
            //Access is OK with letting you execute a query this way to determine rowcount!

            OleDbCommand cmd = new OleDbCommand("select count(*) from contactList", cn);
            iRet1 = Convert.ToInt16(cmd.ExecuteScalar());
            cmd.CommandText = "select count(*) from customers";
            iret2 = Convert.ToInt16(cmd.ExecuteScalar());

            if (iRet1 == iret2)
            {
                TestLog(100, DateTime.Now, "XYZ122", "Sweeney, M.", true);
                MessageBox.Show("Test pass reported to database");
            }
            else
            {
                TestLog(100, DateTime.Now, "XYZ122", "Sweeney, M.", false);
                MessageBox.Show("Test failure reported to database");
            }
            cn.Close();

        }
    }
}