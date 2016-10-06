

Friend Class frmTestCalc
	Inherits System.Windows.Forms.Form
    ''**************************************
    '*  Name:       CalcTest
    '*  Purpose:    This application contains code to
    '*              test the calculator accessory addition capability.  
    '*   
    '*              It is the answer for the Chapter 5-4 Exercise.
    '*              
    '*  Author:     M. Sweeney
    '*  Date Created: 6/15/2005
    '*  Inputs:     
    '*  Expected Result: That the calculator
    '*  Modification History:
    '*  Name:       Date:       Purpose:
    '*
    '**************************************

	Private Sub cmdLog_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdLog.Click
        TestLib.Readlog()
	End Sub
	
	Private Sub cmdTest_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdTest.Click
        Dim StartTime As DateTime
        Dim Interval As TimeSpan
        Dim strTotal As String
        Dim CalcProcessID As Integer
		Dim I As Short

        TestLib.Logfile = "c:\Calclog.txt"
        CalcProcessID = TestLib.StartProgram("Calc.exe") ' Run Calculator.
        System.Threading.Thread.Sleep(1000)  'give calc a chance to start before proceeding

        StartTime = DateTime.Now 'capture current seconds
        AppActivate(CalcProcessID)
		For I = 1 To 100 ' Set up counting loop.
            SendKeys.SendWait(I & "{+}") ' Send keystrokes to Calculator
		Next I ' to add each value of I.
        SendKeys.SendWait("=") ' Get grand total.
        SendKeys.SendWait("^c") 'copy result to the clipboard
        strTotal = Clipboard.GetData(DataFormats.Text).ToString() 'retrieve info to the clipboard

        If Convert.ToInt32(strTotal) = 10100 Then
            TestLib.LogtoFile("Test Passed Expected: 10100 Actual : " & strTotal)
        Else
            TestLib.LogtoFile("Test Failed Expected: 10100 Actual : " & strTotal)
        End If

        Interval = DateTime.Now - StartTime 'find elapsed time
        lblTime.Text = Interval.TotalSeconds.ToString 'report to test bed
        TestLib.LogtoFile("Total Elapsed time: " & lblTime.Text) 'report to file


        TestLib.CloseProgram("calc") 'close the calculator program


        cmdLog.Enabled = True 'enable the View Report button
	End Sub
	
	
	Private Sub frmTestCalc_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        'don't allow access to View Report button until test runs at least once
		cmdLog.Enabled = False
	End Sub
End Class