//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplicationGrid.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class POSinTouch_WorkList2110
    {
        public int UserID { get; set; }
        public int OperationID { get; set; }
        public int TypeID { get; set; }
        public int LineID { get; set; }
        public int MessageID { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double Quantity { get; set; }
        public double ProductPrice { get; set; }
        public int StatusID { get; set; }
        public int QuantityIsDivisable { get; set; }
        public int MethodID { get; set; }
        public double CashAmount { get; set; }
        public double CashRenting { get; set; }
        public double BankAmount { get; set; }
        public double InvoiceAmount { get; set; }
        public double OtherAmount { get; set; }
        public double TotalAmount { get; set; }
        public string PrinerKey { get; set; }
        public string InvoiceDescription { get; set; }
        public double TotalPrice { get; set; }
        public double TransTotalAmount { get; set; }
        public double TransTotalTaxAmount { get; set; }
        public int TransTaxMethodID { get; set; }
        public Nullable<int> StockEntryID { get; set; }
        public int DebitorID { get; set; }
        public int ShellCustomerID { get; set; }
        public double DiscountFactor { get; set; }
        public int SortID { get; set; }
    }
}
