Public Class Form1

  Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    Dim x As New Class2
    x.Name = "Joe"
    MessageBox.Show(x.ShowName())
  End Sub
End Class

Public Class Class1
  Private strName As String

  Public Property Name() As String
    Get
      Return strName
    End Get
    Set(ByVal value As String)
      strName = value
    End Set
  End Property

  Public Function ShowName() As String
    Return "This is the name: " + Name
  End Function
End Class

Public Class Class2
  Inherits Class1

  Private strPhoneNumber As String

  Public Property PhoneNumber() As String
    Get
      Return strPhoneNumber
    End Get
    Set(ByVal value As String)
      strPhoneNumber = value
    End Set
  End Property

  'This is an overload because it has different parameters as the parent
  Public Function ShowName(ByVal message As String) As String
    Return "message: " + Name
  End Function

  'This is an Override because it has the same parameters as the parent
  Public Function ShowName() As String
    Return Name + ": " + PhoneNumber
  End Function


End Class
