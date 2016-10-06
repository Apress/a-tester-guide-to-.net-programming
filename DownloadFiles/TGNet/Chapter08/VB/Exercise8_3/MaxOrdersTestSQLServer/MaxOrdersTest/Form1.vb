Imports System.Data.SqlClient
Public Class Form1

    Private Sub cmdADO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdADO.Click
        Dim cn As New SqlConnection("Data Source=localhost;Database=Northwind;Trusted_Connection=Yes")
        Dim dr As SqlDataReader
        Dim iRet As Int16
        Dim iCount As Int16 = 0

        cn.Open()
        Dim cmd As New SqlCommand
        cmd.CommandText = _
        "SELECT Orderid, Orderdate FROM Orders" & _
          "WHERE orderdate=(SELECT MAX(orderdate) FROM orders)"
        cmd.Connection = cn
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            Do While dr.Read
                lstResults.Items.Add(dr.Item("OrderID").ToString + " " + _
                    dr.Item("Orderdate").ToString)
                iCount += 1
            Loop
            MessageBox.Show(iCount.ToString & " rows qualified")
        Else
            MessageBox.Show("no rows returned")
        End If
        dr.Close()
        cn.Close()


        'Const iEXPECTED As Integer = 91 'set number of expected items
        cn.Open()
        iRet = cmd.ExecuteScalar
    End Sub
End Class
