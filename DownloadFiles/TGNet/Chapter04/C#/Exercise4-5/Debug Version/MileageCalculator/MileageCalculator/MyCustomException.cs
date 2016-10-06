using System;
using System.Collections.Generic;
using System.Text;

namespace MileageCalculator
{
  class MyCustomException: System.Exception 
  {
    //This Class demos how to make a simple Customer Exception Class
    public new string Message = "Your Friendly Message here";
  }
}
