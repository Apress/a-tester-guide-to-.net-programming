using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InheritanceDemoCS
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Class2 x = new Class2();
      x.Name = "Joe";
      MessageBox.Show(x.ShowName()); 
    }
  }

  public class Class1
  {
    private string strName;

    public string Name
    {
      get
      {
        return strName;
      }
      set
      {
        strName = value;
      }
    }

    public string ShowName()
    {
      return "This is the name: " + Name;
    }
  }
  public class Class2 : Class1
  {
    private string strPhoneNumber;

    public string PhoneNumber
    {
      get
      {
        return strPhoneNumber;
      }
      set
      {
        strPhoneNumber = value;
      }
    }

    //This is an overload because it has different parameters as the parent
    public string ShowName(string message)
    {
      return "message: " + Name;
    }
    //This is an Override because it has the same parameters as the parent
    public string ShowName()
    {
      return Name + ": " + PhoneNumber;
    }

  }


}