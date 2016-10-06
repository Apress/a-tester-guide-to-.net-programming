Imports System.Data.SqlClient

Public Class Form1
    'this code presumes SQL Server is installed locally and started and that the Northwind
    'database is available in the installation
    'This code logs into the SQL server with Window authentication
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cn As New SqlConnection("Data Source=localhost;Database=Northwind;Trusted_Connection=Yes")
        Dim dr As SqlDataReader
        Dim cmd As New SqlCommand("Select * from customers where ContactName like 'M%' ", cn)

        cn.Open()
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            Do While dr.Read
                Debug.WriteLine(dr.Item("ContactName"))
            Loop
            MessageBox.Show("To see answer: open the Immediate window!")
        Else
            Debug.WriteLine("no rows returned")
        End If
        dr.Close()
        cn.Close()

    End Sub
End Class
