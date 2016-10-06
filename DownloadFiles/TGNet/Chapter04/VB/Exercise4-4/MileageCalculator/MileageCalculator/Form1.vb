Public Class Form1

  Private Sub btnGetMileage_Click _
  (ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetMileage.Click
    'Call the GetAnswer Method
    GetAnswer()
    MessageBox.Show("Done")
  End Sub

  'Create a Method to calculate Mileage
  Public Sub GetAnswer()

    'Create 3 variables to work with
    Dim Mileage, Distance, Gallons As Decimal

    Try 'Add this line to start Try-Catch Block
      ' Set values from the UI
      Distance = txtDistance.Text
      Gallons = txtGallons.Text

      'Check for zeros
      If Distance = 0 Then
        'Cause an Exception to be Thrown
        Throw New MyCustomException
      End If

      'Calculate the mileage
      Mileage = Distance / Gallons

    Catch ex As DivideByZeroException
      'Catch Divide by Zero errors and use the object from Microsoft's  
      'DivideByZeroException Class to show a Message 
      MessageBox.Show(ex.Message)

    Catch ex As MyCustomException
      'Catch all MyCustomException errors, 
      'Use the Object to show a Custom error Message
      MessageBox.Show(ex.Message)

    Catch
      'Catch any other type of Exception
      MessageBox.Show("There was an Error")

    Finally
      'Put code here that you want to always run
      MessageBox.Show("Inside Finally")
    End Try
    MessageBox.Show(Mileage.ToString, "Answer")

  End Sub

End Class