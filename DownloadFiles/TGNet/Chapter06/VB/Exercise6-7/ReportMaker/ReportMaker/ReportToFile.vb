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
      'Test if Description was left blank.   
      Dim blnIsEmpty As Boolean
      blnIsEmpty = Validations.Strings.TestForEmptyStrings(value)
      If blnIsEmpty = True Then
        Throw New Exception("Description cannot be empty")
      Else
        strDescription = value
      End If
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
    strTester = ""
    strApplicationName = ""
    strBuildNumber = ""
    strDateReported = ""
    strDescription = ""
    strFileName = ""
    strData = ""
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

  Public Sub FormatData(ByVal FileType As String)
    'To keep the code simple our XML and 
    'HTML files will only have one report each
    If (System.IO.File.Exists(FileName) = True) Then
      System.IO.File.Delete(FileName)
    End If

    Select Case FileType
      Case "xml"
        'Pull data out of the variables above and put it into a string
        'Notice we are using "" to escape the dbl-quote in the xml attributes
        strData = "<?xml version=""1.0"" encoding=""utf-8"" ?>"
        strData += "<root>"
        strData += vbCrLf
        strData += "<Tester>" + Tester + "</Tester>"
        strData += vbCrLf
        strData += "<ApplicationName>" + ApplicationName + "</ApplicationName>"
        strData += vbCrLf
        strData += "<BuildNumber>" + BuildNumber + "</BuildNumber>"
        strData += vbCrLf
        strData += "<DateReported>" + DateReported + "</DateReported>"
        strData += vbCrLf
        strData += "</root>"

      Case "html"
        strData = "<html><head>"
        strData += "<title>" + Description.Substring(1, 5) + "...</title>"
        strData += "</head><body>"
        strData += "<hr />"
        strData += "<b>Testers Name: </b>" + Tester
        strData += "<br />"
        strData += "<b>ApplicationName:</b>" + ApplicationName
        strData += "<br />"
        strData += "<b>BuildNumber:</b>" + BuildNumber
        strData += "<br />"
        strData += "<b>DateReported:</b>" + DateReported
        strData += "<hr />"
        strData += "</body></html>"

      Case Else
        FormatData() 'call the original version
    End Select
  End Sub

End Class
