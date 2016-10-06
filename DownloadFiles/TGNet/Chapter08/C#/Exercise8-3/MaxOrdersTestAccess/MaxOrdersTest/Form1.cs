using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace MaxOrdersTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdADO_Click(object sender, EventArgs e)
        {
            OleDbConnection cn = new OleDbConnection("Provider=Microsoft.jet.oledb.4.0;Data Source=Northwind.mdb");
            OleDbDataReader dr;
            Int16 intCount = 0;
            cn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "SELECT Orderid, Orderdate FROM Orders " +
                 "WHERE orderdate = (SELECT MAX(orderdate) FROM orders)";
            cmd.Connection = cn;
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    lstResults.Items.Add
                       (dr.GetInt32(dr.GetOrdinal("OrderID"))
                             + " " + dr.GetDateTime(dr.GetOrdinal("Orderdate")));
                    intCount += 1;
                }
                MessageBox.Show(intCount + " rows qualified");
            }
            else
            {
                MessageBox.Show("no rows returned");
            }
            dr.Close();
            cn.Close();

        }
    }
}