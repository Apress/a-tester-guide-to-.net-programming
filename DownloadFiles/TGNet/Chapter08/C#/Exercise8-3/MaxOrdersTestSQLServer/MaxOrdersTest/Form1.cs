using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;

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
            SqlConnection cn = new SqlConnection("Data Source=localhost;Database=Northwind;Trusted_Connection=Yes");
            SqlDataReader dr;
            Int16 iCount = 0;
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT Orderid, Orderdate FROM Orders " + 
                "WHERE orderdate = (SELECT MAX(orderdate) FROM orders)";
            cmd.Connection = cn;
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    lstResults.Items.Add
                        (dr.GetInt32 (dr.GetOrdinal("OrderID"))
                           + " " + dr.GetDateTime(dr.GetOrdinal ("Orderdate")));
                    iCount += 1;
                }
                MessageBox.Show(iCount + " rows qualified");
            }
            else
            {              MessageBox.Show("no rows returned");
            }
            dr.Close();
            cn.Close();
        }
    }
}