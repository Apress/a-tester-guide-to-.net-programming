Imports Microsoft.Win32
Module Module1

    Sub Main()

        Dim iEntry As Byte
        ' Create a subkey named TestProject under HKEY_CURRENT_USER.
        Do While iEntry <> 9
            Console.WriteLine()
            Console.WriteLine("Enter 1 to Create a new key")
            Console.WriteLine("Enter 2 to add a setting to a key")
            Console.WriteLine("Enter 3 to delete a key")
            Console.WriteLine("Enter 4 to delete a setting")
            Console.WriteLine("Enter 5 to retrieve a setting value")
            Console.WriteLine("Enter 6 to report all subkeys under a key")
            Console.WriteLine("Enter 9 to quit")
            iEntry = Console.ReadLine()
            Dim TestProject As RegistryKey
            Select Case iEntry
                Case 1
                    Dim strNewKey As String
                    Console.WriteLine("Enter Name of Subkey to create.")
                    Console.WriteLine("(This will create a key under HKEY_CURRENT_USER)")
                    strNewKey = Console.ReadLine()
                    TestProject = Registry.CurrentUser.CreateSubKey(strNewKey)
                Case 2
                    Dim strKey, strSetting, strValue As String
                    Console.WriteLine("Enter the key")
                    strKey = Console.ReadLine()
                    TestProject = Registry.CurrentUser.OpenSubKey(strKey, True)
                    Console.WriteLine("Enter the setting")
                    strSetting = Console.ReadLine()
                    Console.WriteLine("Enter the value")
                    strValue = Console.ReadLine
                    TestProject.SetValue(strSetting, strValue)
                Case 3
                    'Enter code for menu option 3
                Case 4
                    Dim strKey, strSetting, strAns As String
                    Console.WriteLine("Enter the key")
                    strKey = Console.ReadLine()
                    TestProject = Registry.CurrentUser.OpenSubKey(strKey, True)
                    Console.WriteLine("Enter the setting")
                    strSetting = Console.ReadLine()
                    Console.WriteLine("Do you really mean to delete: " & strKey & "\" & strSetting & "?")
                    strAns = Console.ReadLine()
                    If strAns.ToUpper = "YES" Or strAns.ToUpper = "Y" Then
                        TestProject.DeleteValue(strSetting)
                        Console.WriteLine("Key setting " & strKey & "\" & strSetting & " deleted")
                    Else
                        Console.WriteLine("No deletion performed; key closed")
                        TestProject.Close()
                    End If
                Case 5
                    Dim strKey, strSetting As String
                    Console.WriteLine("Enter the key")
                    strKey = Console.ReadLine()
                    TestProject = Registry.CurrentUser.OpenSubKey(strKey)
                    Console.WriteLine("Enter the setting")
                    strSetting = Console.ReadLine()
                    Console.WriteLine("Value of " & TestProject.ToString & "\" & strSetting & " is: " & TestProject.GetValue(strSetting).ToString)
                Case 6
                    'Enter code here for menu option 6
                    
                Case 9
                    Console.WriteLine("Good bye!")
                Case Else
                    Console.WriteLine("Invalid Entry; please enter 1-5 (or 9 to quit)")


            End Select
        Loop
        
    End Sub

End Module
