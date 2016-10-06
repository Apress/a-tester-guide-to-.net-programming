Public Class Invoice
    Private _InvoiceNumber As Int32
    Private _InvoiceDate As Date
    Private _CustomerID As Int32
    Private _TotalSales As Decimal
    Private Shared LastInvoice As Int32

    Public Sub New(ByVal CustID As Int32)
        _CustomerID = CustID
        _InvoiceNumber = NewInvoiceNumber()
    End Sub

    Public ReadOnly Property InvoiceNumber() As Int32
        Get
            Return _InvoiceNumber
        End Get
    End Property
    Public Property InvoiceDate() As Date
        Get
            Return _InvoiceDate
        End Get
        Set(ByVal value As Date)
            _InvoiceDate = value
        End Set
    End Property
    Public Property CustomerID() As Int32
        Get
            Return _CustomerID
        End Get
        Set(ByVal value As Int32)
            _CustomerID = value
        End Set
    End Property

    Public Function CalculateInvoiceTotal(ByVal Sale As Decimal) As Decimal      
        
    End Function

    Public Function NewInvoiceNumber() As Int32
        'open a database and retrieve highest invoice number
        LastInvoice += 1
        Return LastInvoice
    End Function
End Class
