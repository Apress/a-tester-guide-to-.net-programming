' To use this program, use your browser to navigate to any website and then
' retrieve the source code for that site. To do this using IE, just click the View=>Source
' menu item. Copy and paste the source code into the text box on this application
' as it runs.

Imports System.Text.RegularExpressions
Public Class Form1
    ' Note the following form properties were set:
    ' AcceptButton = button1
    ' Also the following properties for the Textbox:
    ' Anchor = top, left, bottom, right
    ' Multiline = true
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim StartTime As DateTime
        Dim EndTime As DateTime
        Dim Interval As TimeSpan
        Dim numHrefs As Int16

        StartTime = DateTime.Now 'capture current seconds

        numHrefs = FindHref(txtSource.text)

        EndTime = DateTime.Now

        lblHrefs.Text = numHrefs.ToString
        Interval = EndTime - StartTime
        lblTime.Text = Interval.ToString()
    End Sub

    Public Function FindHref(ByVal strSource As String) As Integer
        Dim r As Regex
        Dim m As Match
        Dim i As Integer

        r = New Regex("href\s*=\s*(?:""(?<1>[^""]*)""|(?<1>\S+))", _
            RegexOptions.IgnoreCase Or RegexOptions.Compiled)

        m = r.Match(strSource)
        While m.Success
            i += 1
            m = m.NextMatch()
        End While
        Return i
    End Function
End Class
