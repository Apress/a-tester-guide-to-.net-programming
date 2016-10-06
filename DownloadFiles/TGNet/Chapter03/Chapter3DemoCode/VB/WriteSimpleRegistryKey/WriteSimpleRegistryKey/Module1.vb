Imports Microsoft.Win32
Module Module1

    Sub Main()
        ' Create a subkey named TestProject2005 under HKEY_CURRENT_USER.
        Dim TestProject As RegistryKey = _
            Registry.CurrentUser.CreateSubKey("TestProject2005")

        ' Create data for the TestProject subkey.
        TestProject.SetValue("Test Date", DateTime.Now)
        TestProject.SetValue("Level", "Priority 2")
        TestProject.SetValue("ID", 123)
        TestProject.Close()

    End Sub


End Module
