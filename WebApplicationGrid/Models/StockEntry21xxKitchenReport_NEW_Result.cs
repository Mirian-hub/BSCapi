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
    
    public partial class StockEntry21xxKitchenReport_NEW_Result
    {
        public int StockEntryID { get; set; }
        public long SortID { get; set; }
        public int StockEntryLineSortID { get; set; }
        public long StockEntryLineParentID { get; set; }
        public string StockEntryKey { get; set; }
        public int StockEntryStatusID { get; set; }
        public string StockEntryStatusName { get; set; }
        public string MyStockCompanyName { get; set; }
        public string MyStockCompanyAddress { get; set; }
        public string MyStockCompanyTaxNumber { get; set; }
        public System.DateTime StockEntryDate { get; set; }
        public string TransItemName { get; set; }
        public string StockItemName { get; set; }
        public Nullable<double> TransQuantity { get; set; }
        public double TransPrice { get; set; }
        public double TransAmount { get; set; }
        public double TransItemUnitFactor { get; set; }
        public double TransQuantityFactor { get; set; }
        public string TransQuantityFactorMark { get; set; }
        public int StockEntryLineTypeID { get; set; }
    }
}
