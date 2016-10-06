#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

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
        Decimal Mileage = 0, Distance = 0, Gallons = 0;

        try
        {
          //Add code to set these values from the UI
          Distance = Convert.ToDecimal(txtDistance.Text);
          Gallons = Convert.ToDecimal(txtGallons.Text);

          //Check for zeros
          if (Distance == 0)
          {
            //Cause an Exception to be Thrown
            throw new MyCustomException();
          }

          Mileage = Distance / Gallons;

        }
        catch (DivideByZeroException ex)
        {
          //Catch Divide by Zero errors and use the object from Microsoft's  
          //DivideByZeroException Class to show a Message 
          MessageBox.Show(ex.Message); 
        }
catch (MyCustomException ex)
{
  //Catch all MyCustomException errors, 
  //Use the Object to show a Custom error Message
  //MessageBox.Show(ex.Message); <-- This line is no longer needed

  //Step 1: Create the TraceListener Objects
  TextWriterTraceListener objTWCon = new TextWriterTraceListener(Console.Out);
  TextWriterTraceListener objTWFile = new TextWriterTraceListener("c:\\Trace.log");
  EventLogTraceListener objEL = new EventLogTraceListener("Mileage Calculator");

  //Step 2: Add the Objects to the Listeners collection
  Debug.Listeners.Add(objTWFile);
  Debug.Listeners.Add(objTWCon);
  Debug.Listeners.Add(objEL);

  //Step 3: Set the system to automatic mode
  Debug.AutoFlush = true;

  //Step 4: Set the message you want to send
  string strMessage;
  strMessage = "======( Trace Info: " + DateTime.Now + " )======" + "\n";
  strMessage += ex.Message + "\n";
  strMessage += ex.ToString();

  //Step 5: Send the message to all of the listeners, including the default
  Debug.WriteLine(strMessage);

  //Step 6: Close the file in the file version and clear all the Listeners 
  objTWFile.Close();
  Debug.Listeners.Clear();

}
        catch
        {
          //Catch any other type of Exception
          MessageBox.Show("There was an Error");
        }
        finally
        {
          //Put code here that you want to always run 
          MessageBox.Show("Inside Finally");
        } //End Try-Catch Block

        MessageBox.Show(Mileage.ToString(), "Answer");

       }//end of GetAnswer

  } //End of Class
}