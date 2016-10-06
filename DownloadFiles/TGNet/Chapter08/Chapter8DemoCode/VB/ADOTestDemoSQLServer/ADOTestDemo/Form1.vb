Imports System.Data.sqlclient
'*************************************************************
'* Northwind Test. 
'* Verify that the expected number of records
'* in the Customers table matches the actual number of records.
'* Dependencies:
'* References: 
'*************************************************************** 


Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        
        Dim cn As New SqlConnection("Data Source=localhost;Database=Northwind;Trusted_Connection=Yes")
        Dim iRet As Int16
        Dim cmd As New SqlCommand("Select count(*) from customers", cn)
        Const iEXPECTED As Integer = 91 'set number of expected items
        cn.Open()
        iRet = cmd.ExecuteScalar
        If iRet = iEXPECTED Then
            MessageBox.Show("Test passed; Expected: " & iEXPECTED & " Actual: " & iRet)
        Else
            MessageBox.Show("Test failed; Expected: " + iEXPECTED + " Actual: " + iRet)
        End If
        cn.Close()

    End Sub
End Class
