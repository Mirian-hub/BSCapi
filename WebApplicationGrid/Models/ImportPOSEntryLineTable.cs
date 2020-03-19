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
    
    public partial class ImportPOSEntryLineTable
    {
        public int ExportPOSEntryID { get; set; }
        public int ExportPOSEntryID2 { get; set; }
        public long ExportPOSEntryLineID { get; set; }
        public long ExportPOSEntryLineID2 { get; set; }
        public long ExportPOSEntryLineParentID { get; set; }
        public long ExportPOSEntryLineParentID2 { get; set; }
        public string StockEntryLineKey { get; set; }
        public string StockEntryLineName { get; set; }
        public int StockEntryLineSortID { get; set; }
        public int StockEntryLineTypeID { get; set; }
        public int StockEntryLineStatusID { get; set; }
        public System.DateTime StockEntryLineDate { get; set; }
        public int StockLocationID { get; set; }
        public int StockItemID { get; set; }
        public double StockQuantity { get; set; }
        public double StockAmount { get; set; }
        public int TransItemID { get; set; }
        public int TransItemUnitID { get; set; }
        public double TransItemUnitFactor { get; set; }
        public double TransQuantityInitial { get; set; }
        public double TransQuantity { get; set; }
        public double TransPrice { get; set; }
        public int TransPriceTaxID { get; set; }
        public double TransPriceTaxFactor { get; set; }
        public double TransAmount { get; set; }
        public double TransTaxAmount { get; set; }
        public double TransBaseAmount { get; set; }
        public int TransDiscountID { get; set; }
        public double TransDiscountFactor { get; set; }
        public double TransDiscountAmount { get; set; }
        public double TransDiscountTaxAmount { get; set; }
        public double TransDiscountBaseAmount { get; set; }
        public double TransTotalAmount { get; set; }
        public double TransTotalTaxAmount { get; set; }
        public double TransTotalBaseAmount { get; set; }
        public System.DateTime ShellSyncDate { get; set; }
        public int ShellSyncProcessID { get; set; }
    }
}