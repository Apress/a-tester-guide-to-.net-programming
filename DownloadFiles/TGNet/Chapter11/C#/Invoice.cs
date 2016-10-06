using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceLib
{
    public class Invoice
    {
        private Int32 _InvoiceNumber;
        private System.DateTime _InvoiceDate;
        private Int32 _CustomerID;
        private static Int32 LastInvoice;

        public Invoice(Int32 CustID)
        {
            _CustomerID = CustID;
            _InvoiceNumber = NewInvoiceNumber();
        }

        public Int32 InvoiceNumber
        {
            get
            {
                return _InvoiceNumber;
            }
        }

        public System.DateTime InvoiceDate
        {
            get
            {
                return _InvoiceDate;
            }
            set
            {
                _InvoiceDate = value;
            }
        }

        public Int32 CustomerID
        {
            get
            {
                return _CustomerID;
            }
            set
            {
                _CustomerID = value;
            }
        }

        public decimal CalculateInvoiceTotal()
        {
            
        }

        public Int32 NewInvoiceNumber()
        {
            LastInvoice += 1;
            return LastInvoice;
        }
    }
}
