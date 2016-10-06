
Imports System.Text.RegularExpressions
Public Class Form1
    Function IsValidEmail(ByVal strIn As String) As Boolean
        ' Return true if strIn is in valid e-mail format.
        Return Regex.IsMatch(strIn, _
        ("^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
    End Function

    ' C#   bool IsValidEmail(string strIn) 
    '{ 
    ' return Regex.IsMatch(strIn, ("^([\\w-\\.]+)@((\\[[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([\\w-]+\\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\\]?)$")); 
    '}

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MessageBox.Show(IsValidEmail(TextBox2.Text))
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim r As Regex
        Dim m As Match
        Dim i As Integer

        r = New Regex("href\s*=\s*(?:""(?<1>[^""]*)""|(?<1>\S+))", _
            RegexOptions.IgnoreCase Or RegexOptions.Compiled)

        m = r.Match(TextBox1.Text)
        While m.Success
            i += 1
            ListBox1.Items.Add("Found href " & m.Value & " at " & m.Index.ToString())
            m = m.NextMatch()
        End While
        label1.text = (i & " Total Href's found")
    End Sub
End Class


