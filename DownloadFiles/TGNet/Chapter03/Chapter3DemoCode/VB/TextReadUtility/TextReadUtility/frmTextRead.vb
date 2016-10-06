Imports System.IO

Public Class frmTextRead

    Private Sub btnRead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRead.Click
        Dim strFile As String
        Dim MyPos As Integer = 1
        Dim iCount As Int16 = 0

        ' Open the stream and read it back.
        Dim reader As StreamReader = File.OpenText(txtFile.Text)
        strFile = reader.ReadToEnd()

        Do
            MyPos = strFile.IndexOf(txtFindString.Text, MyPos + 1)
            If MyPos > 0 Then iCount += 1
        Loop Until (MyPos = -1)

        lblResult.Text = "Number of times found: iCount = " & iCount


    End Sub

End Class
