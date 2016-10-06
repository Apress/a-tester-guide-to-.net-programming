Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim xlApp As New Excel.Application

        Dim loanpayment As Decimal
        Dim dblInterest, dblMonths, dblprincipal As Double

        dblprincipal = Convert.ToDouble(txtPrincipal.Text)
        dblMonths = Convert.ToDouble(txtMonths.Text)
        dblInterest = Convert.ToDouble(txtInterest.Text)

        loanpayment = xlApp.WorksheetFunction.Pmt _
           (dblInterest / 12, dblMonths, dblprincipal)
        MessageBox.Show("the monthly payment is: " & _
              Format(Math.Abs(loanpayment), "$#.##"), "Mortgage")

        '***** Begin Test of PMT formula:
        Dim myPayment As Decimal
        myPayment = Convert.ToDouble(dblprincipal) * -((dblInterest / 12) / _
           (1 - (1 + (dblInterest / 12)) ^ (-Convert.ToDouble(dblMonths))))

        If Math.Round(loanpayment, 5) = Math.Round(myPayment, 5) Then
            Debug.WriteLine("Test passed: formula correct")
            MessageBox.Show("Test passed: formula correct")
        Else
            Debug.WriteLine("Test failed: incorrect formula result")
            MessageBox.Show("Test failed: incorrect formula result")
        End If


    End Sub
End Class
