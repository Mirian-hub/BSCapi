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
    
    public partial class StockReportEntryI00_Result
    {
        public int StockEntryStatusID { get; set; }
        public int StockEntryID { get; set; }
        public System.DateTime StockEntryDate { get; set; }
        public int StockLocationID { get; set; }
        public string StockLocationKey { get; set; }
        public string StockLocationName { get; set; }
        public string StockLocationAddress { get; set; }
        public int StockEntrySortID { get; set; }
        public string StockEntrySortName { get; set; }
        public long StockEntryLineID { get; set; }
        public int StockEntryLineSortID { get; set; }
        public string StockEntryLineName { get; set; }
        public string StockItemKey { get; set; }
        public string StockItemName { get; set; }
        public double TransPrice { get; set; }
        public double TransQuantityInitial { get; set; }
        public double TransQuantity { get; set; }
        public Nullable<double> StockQuantity { get; set; }
        public Nullable<double> TransAmount { get; set; }
        public Nullable<double> TransTaxAmount { get; set; }
        public Nullable<double> TransBaseAmount { get; set; }
        public int StockItemGroupID { get; set; }
        public string StockItemGroupKey { get; set; }
        public string StockItemGroupName { get; set; }
    }
}
