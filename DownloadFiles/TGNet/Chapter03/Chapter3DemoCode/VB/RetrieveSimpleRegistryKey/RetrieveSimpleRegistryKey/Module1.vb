Imports Microsoft.Win32
Module Module1

    Sub Main()
        Dim line As String
        Dim strMyKey As String = "control panel\international\"
        Dim aKey As RegistryKey
        aKey = Registry.CurrentUser.OpenSubKey(strMyKey)
        Console.WriteLine("Value of the international key setting is: " + aKey.GetValue("sCountry"))
        Console.WriteLine("Press any key to quit")
        line = Console.ReadLine
    End Sub

End Module
