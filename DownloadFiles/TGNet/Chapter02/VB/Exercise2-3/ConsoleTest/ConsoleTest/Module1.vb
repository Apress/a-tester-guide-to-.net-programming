Imports System.IO
Module Module1

    Sub Main()
        Dim strInput As String = ""

        Console.WriteLine()
        Console.WriteLine("Enter the file to find or enter 'Q' to Quit")
        Do Until strInput = "Q"
            strInput = UCase(Console.ReadLine())
            If File.Exists(strInput) Then
                Console.WriteLine("File Exists: Test passed")
            Else
                Console.WriteLine("File doesn't Exist: Test failure")
            End If
            Console.WriteLine("Enter the file to find or enter 'Q' to Quit")
        Loop
    End Sub

End Module
