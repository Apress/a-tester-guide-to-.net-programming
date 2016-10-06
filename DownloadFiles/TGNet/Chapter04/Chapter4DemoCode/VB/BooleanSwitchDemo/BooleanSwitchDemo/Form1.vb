Public Class Form1

  Private Sub Button1_Click _
     (ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles Button1.Click

    Dim BS1 As BooleanSwitch = New _
           BooleanSwitch("MySwitch", "Decription: Toggles Trace")
    Dim objTWFile As TextWriterTraceListener = New TextWriterTraceListener("c:\SwitchDemo.txt")
    Trace.Listeners.Add(objTWFile)
    Trace.AutoFlush = True
    Trace.WriteLineIf(BS1.Enabled = True, "MyMessage", "MyCatagory")
    MessageBox.Show("Now look in SwitchDemo.txt when switch is on")
    objTWFile.Close()
    Trace.Listeners.Clear()
  End Sub
End Class
