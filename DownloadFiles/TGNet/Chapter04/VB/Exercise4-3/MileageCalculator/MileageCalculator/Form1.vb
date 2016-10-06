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

    'Add code to set these values from the UI
    Distance = Convert.ToDecimal(txtDistance.Text)
    Gallons = Convert.ToDecimal(txtGallons.Text)
    Mileage = Distance / Gallons

    MessageBox.Show(Mileage.ToString, "Answer")
  End Sub

End Class