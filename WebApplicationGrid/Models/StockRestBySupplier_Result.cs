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
    
    public partial class StockRestBySupplier_Result
    {
        public int StockSupplierID { get; set; }
        public string StockSupplierKey { get; set; }
        public string StockSupplierName { get; set; }
        public Nullable<double> StockPurchaseAmount { get; set; }
        public Nullable<double> StockPurchaseTaxAmount { get; set; }
        public Nullable<double> StockPurchaseBaseAmount { get; set; }
        public Nullable<double> StockSupplierOutstandingAmount { get; set; }
        public Nullable<double> StockSupplierPayableAmount { get; set; }
    }
}
