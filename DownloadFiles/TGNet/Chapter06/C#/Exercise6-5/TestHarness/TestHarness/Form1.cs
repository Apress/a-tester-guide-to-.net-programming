using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TestHarness
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnEmptyString_Click(object sender, System.EventArgs e)
    {
      if (Validations.Strings.TestForEmptyStrings(textBox1.Text) == true)
      {
        MessageBox.Show("it was empty");
      }
      else
      {
        MessageBox.Show("it was not empty");
      }
    }
  }
}