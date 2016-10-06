Imports System.Data.Oledb
Public Class Form1

    Private Sub cmdADO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdADO.Click
        Dim cn As New OleDbConnection _
             ("Provider=Microsoft.jet.oledb.4.0;Data Source=Northwind.mdb")
        Dim dr As OleDbDataReader
        Dim intCount As Int16 = 0

        cn.Open()
        Dim cmd As New OleDbCommand
        cmd.CommandText = _
         "SELECT Orderid, Orderdate FROM Orders " & _
                  "WHERE orderdate=(SELECT MAX(orderdate) FROM orders)"
        cmd.Connection = cn
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            Do While dr.Read
                lstResults.Items.Add(dr.Item("OrderID").ToString + " " + _
                    dr.Item("Orderdate").ToString)
                intCount += 1
            Loop
            MessageBox.Show(intCount.ToString & " rows qualified")
        Else
            MessageBox.Show("no rows returned")
        End If
        dr.Close()
        cn.Close()

    End Sub
End Class
