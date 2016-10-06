using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WebServTestBed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            CalculateArea.Service AreaServ = new CalculateArea.Service();
            float sngLength;
            float sngWidth;
            float sngArea;
            sngLength = Convert.ToSingle(txtLength.Text);
            sngWidth = Convert.ToSingle(txtWidth.Text);
            sngArea = AreaServ.RectangleArea(sngLength, sngWidth);
            lblArea.Text = sngArea.ToString();

        }
    }
}