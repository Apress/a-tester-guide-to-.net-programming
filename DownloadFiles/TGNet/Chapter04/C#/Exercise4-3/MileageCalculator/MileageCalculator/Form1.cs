#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace MileageCalculator
{
    partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetMileage_Click(object sender, EventArgs e)
        {
            GetAnswer();
            MessageBox.Show("Done");
        }
    
       //Create a Method to calculate Mileage
       public void  GetAnswer()
        {
            //Create 3 variables to work with
            Decimal Mileage, Distance, Gallons;
            //Add code to set these values from the UI
            Distance = Convert.ToDecimal(txtDistance.Text);
            Gallons = Convert.ToDecimal(txtGallons.Text);
            Mileage = Distance / Gallons;

            MessageBox.Show(Mileage.ToString(), "Answer");
         }
    } //End of Class
}