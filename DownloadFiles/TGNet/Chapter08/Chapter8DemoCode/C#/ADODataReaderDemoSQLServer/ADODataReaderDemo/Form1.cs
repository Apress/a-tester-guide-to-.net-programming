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
            SqlConnection cn = new SqlConnection
   ("Data Source=localhost;Database=Northwind;Trusted_Connection=Yes");
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand
               ("Select * from customers where ContactName like 'M%' ", cn);
            cn.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
                while (dr.Read()==true)
                {
                    Debug.WriteLine(dr.GetString(dr.GetOrdinal("ContactName")));
                }
            else
                MessageBox.Show("no rows returned");
            dr.Close();
            cn.Close();

        }
    }
}