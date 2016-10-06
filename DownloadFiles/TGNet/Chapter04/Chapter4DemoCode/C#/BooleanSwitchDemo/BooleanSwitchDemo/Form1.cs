using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace BooleanSwitchDemo
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      //make sure to add using System.Diagnostics; at the top of the code file
      BooleanSwitch BS1 = new BooleanSwitch("MySwitch", "Decription: Toggles Trace");
      TextWriterTraceListener objTWFile = new TextWriterTraceListener("c:\\SwitchDemo.txt");
      Trace.Listeners.Add(objTWFile);
      Trace.AutoFlush = true ;
      
      Trace.WriteLineIf(BS1.Enabled == true, "MyMessage", "MyCatagory");
      MessageBox.Show("Now look in SwitchDemo.txt when switch is on");
      objTWFile.Close();
      Trace.Listeners.Clear();
    }
  }
}