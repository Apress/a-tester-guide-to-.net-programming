using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;


namespace ComTestBedx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp = new Excel.Application();
            double loanpayment;
            double dblInterest;
            double dblMonths;
            double dblprincipal;
            dblprincipal = Convert.ToDouble(txtPrincipal.Text);
            dblMonths = Convert.ToDouble(txtMonths.Text);
            dblInterest = Convert.ToDouble(txtInterest.Text);
            loanpayment = xlApp.WorksheetFunction.Pmt(dblInterest / 12, dblMonths, dblprincipal, 0, 0);
            MessageBox.Show("the monthly payment is: " + Convert.ToString(Math.Abs(loanpayment)), "Mortgage");
        
            /* begin test of PMT formula: */
            double myPayment; 
            myPayment = Convert.ToDouble(dblprincipal) * -((dblInterest / 12) / (1 - Math.Pow((1 + (dblInterest / 12)), (-Convert.ToDouble(dblMonths)))));

            if (Math.Round(loanpayment, 5) == Math.Round(myPayment, 5))
            {
                Debug.WriteLine("Test passed: formula correct");
                MessageBox.Show("Test passed: formula correct");
            }
            else
            {
                Debug.WriteLine("Test failed: incorrect formula result");
                MessageBox.Show("Test failed: incorrect formula result");
            }

        }
    }
}