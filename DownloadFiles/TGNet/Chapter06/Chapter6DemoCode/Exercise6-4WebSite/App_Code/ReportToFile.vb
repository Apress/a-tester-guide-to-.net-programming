Public Class ReportToFile
  '---- Declare Variables Section ----
  Private strTester As String
  Private strApplicationName As String
  Private strBuildNumber As String
  Private strDateReported As String
  Private strDescription As String
  Private strFileName As String
  Private strData As String

  '----The Properties Section ----
  Public Property Tester() As String
    Get
      Return strTester
    End Get
    Set(ByVal value As String)
      strTester = value
    End Set
  End Property
  Public Property ApplicationName() As String
    Get
      Return strApplicationName
    End Get
    Set(ByVal value As String)
      strApplicationName = value
    End Set
  End Property

  Public Property BuildNumber() As String
    Get
      Return strBuildNumber
    End Get
    Set(ByVal value As String)
      strBuildNumber = value
    End Set
  End Property

  Public Property DateReported() As String
    Get
      Return strDateReported
    End Get
    Set(ByVal value As String)
      strDateReported = value
    End Set
  End Property

  Public Property Description() As String
    Get
      Return strDescription
    End Get
    Set(ByVal value As String)
      strDescription = value
    End Set
  End Property

  Public Property FileName() As String
    Get
      Return strFileName
    End Get
    Set(ByVal value As String)
      strFileName = value
    End Set
  End Property

  Public Property Data() As String
    Get
      Return strData
    End Get
    Set(ByVal value As String)
      strData = value
    End Set
  End Property

  '---- The Constructor Section ----
  Public Sub New()
    Tester = ""
    ApplicationName = ""
    BuildNumber = ""
    DateReported = ""
    Description = ""
    FileName = ""
    Data = ""
  End Sub

  '----The Methods Section ----
  Public Function Save() As Boolean
    '---- Save Data to File Section ----
    'Create a Variables that will hold a Referance to a File
    Dim objWriter As System.IO.StreamWriter
    Dim blnCompleted As Boolean

    Try
      If (System.IO.File.Exists(FileName) = False) Then
        'Make a new file, open it, and have objWriter reference it
        objWriter = System.IO.File.CreateText(FileName)
      Else
        'Open an existing file, set "True" for Append, and have objWriter reference it
        objWriter = New System.IO.StreamWriter(FileName, True)
      End If
      objWriter.WriteLine(Data)
      objWriter.Close()
      objWriter = Nothing

      'if it made it this far without an error
      blnCompleted = True
    Catch ex As Exception
      'if it had an error 
      blnCompleted = False
    End Try
    Return blnCompleted
  End Function

  Public Sub FormatData()
    Data = Tester + ","
    Data += ApplicationName + ","
    Data += BuildNumber + ","
    Data += DateReported + ","
    Data += Description
  End Sub

End Class
