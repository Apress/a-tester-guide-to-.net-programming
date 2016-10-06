

Friend Class frmSendKeys
	Inherits System.Windows.Forms.Form
	
	Private Sub cmdSendKeys_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSendKeys.Click
        Dim ProcessID As Integer
        ProcessID = Shell("notepad.exe", 1) ' Run Notepad.

        System.Threading.Thread.Sleep(1000) 'Give Notepad a chance to launch
        AppActivate(ProcessID) ' Give focus to the Notepad.

        System.Threading.Thread.Sleep(1000)

        SendKeys.SendWait("Hello there!")
        System.Threading.Thread.Sleep(1000)

        SendKeys.Send("%{F4}") ' Send ALT+F4 to close Notepad.
        SendKeys.Send("{tab}")
        SendKeys.Send("{enter}")

	End Sub
	
	
	
End Class