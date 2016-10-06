Public Class Strings
  'This class is designed to validate strings

  Public Shared Function TestForEmptyStrings(ByVal strData As String) As Boolean
    'This function tests for a simple pattern
    Dim strPattern As String = ""
    If (strData = strPattern) Then
      Return True
    Else
      Return False
    End If
  End Function

  Public Shared Function TestFileName(ByVal strData As String) As Boolean
    'This function tests for a complex pattern
    Dim strTempString As String

    'Convert to lowercase to make the RegEx simpler
    strTempString = strData.ToLower()

    Dim strPattern As String = "^.+\.[c][s][v]$"

    '^	Find a Match where the beginning of a line is...
    '.	followed by any one character...
    '+	and that character repeats one or more times...
    '\.	then is followed by a literal dot...
    '[c][s][v]	which is followed by "c", then a "s", then a "v"...
    '$	and "v" is at the end of the string.   

    If (System.Text.RegularExpressions.Regex.IsMatch(strTempString, strPattern)) Then
      Return True
    Else
      Return False
    End If
  End Function

End Class
