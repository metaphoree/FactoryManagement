using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Enums
{


    public enum TransactionPurpose { 
    SalesReturnPayment,
    PurchaseReturnPayment,
        SalesPayment,
        PurchasePayment


    }

    public enum PayablePurpose
    {
        StaffPaymentDue,
        PurchaseDue,
        PurchaseReturnDue,
        SalesReturnDue
    }

    public enum StatusItem
    {
        GOOD,
        BAD,
        DEFECTED
    }
    public enum StockInSource
    {
        Purchase,
        Production
    }
    public enum MonthFormat
    {
        MMMM
    }
    public enum TypeIncome
    {
        Sales,
        ClientPaymentRecieved
    }
    public enum TypeExpense
    {
        Purchase,
        StaffPayment,
        SupplierPayment
    }
    public enum TypeInvoice
    {
        StaffPayment,
        ClientPayment,
        SupplierPayment,
        Purchase,
        Sales,
        StaffProduction,
        SalesReturn,
        PurchaseReturn
    }
}
