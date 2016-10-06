using System;
using System.Collections.Generic;
using System.Text;

namespace Validations
{
  public class Strings
  {
      //This class is designed to validate string data

  public static bool TestForEmptyStrings(string strData)
  {
    //This function tests for a simple pattern
    string strPattern = "";
    if (strData == strPattern)
    {
      return true;
    }
    else
    {
      return false;
    }
  }//end of TestForEmptyStrings

  public static bool TestFileName(string strData)
  {
    //This function tests for a complex pattern
    string strTempString;

    //Convert to lowercase to make the RegEx simpler
    strTempString = strData.ToLower();

    string strPattern = @"^.+\.[c][s][v]$";
    /*
  The @ mean to take this string exactly as typed
  and is not part of the Regular Expression
  
  These are part of the Regular Expression
  @	This is for C# and is NOT part of the Regular Expression
  ^	Find a Match where the beginning of a line is...
  .	followed by any one character...
  +	and that character repeats one or more times...
  \.	then is followed by a literal dot...
  [c][s][v]	which is followed by "c", then a "s", then a "v"...
  $	and "v" is at the end of the string.     

   */
    if (System.Text.RegularExpressions.Regex.IsMatch(strTempString, strPattern))
    {
      return true;
    }
    else
    {
      return false;
    }
    } //end of TestFileName
      
  }
}
