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
    
    public partial class StockWorkValuationTable
    {
        public int ShellUserID { get; set; }
        public int ShellOperationID { get; set; }
        public int ShellWorkPageID { get; set; }
        public int ShellWorkPageLineID { get; set; }
        public int ShellMessageID { get; set; }
        public Nullable<System.DateTime> ShellDateFrom { get; set; }
        public Nullable<System.DateTime> ShellDateTo { get; set; }
        public Nullable<int> StockLocationID { get; set; }
        public Nullable<int> StockItemID { get; set; }
        public double StockQuantity { get; set; }
        public double StockQuantity1 { get; set; }
        public double StockQuantity2 { get; set; }
        public double StockAmount { get; set; }
        public double StockAmount1 { get; set; }
        public double StockAmount2 { get; set; }
        public Nullable<System.DateTime> StockEntryDate { get; set; }
        public Nullable<int> StockEntryID { get; set; }
        public Nullable<int> StockEntryLineSortID { get; set; }
        public Nullable<int> StockEntryTypeID { get; set; }
        public string StockEntryKey { get; set; }
        public string StockEntryName { get; set; }
        public Nullable<long> StockEntryLineID { get; set; }
        public Nullable<int> StockEntryLineTypeID { get; set; }
        public double Amount { get; set; }
        public double TaxAmount { get; set; }
        public double FullAmount { get; set; }
        public double Price { get; set; }
        public Nullable<int> TaxCodeID { get; set; }
        public Nullable<int> StockEntryParentID { get; set; }
        public Nullable<long> StockEntryLineParentID { get; set; }
        public double StockPrice { get; set; }
        public double StockPrice1 { get; set; }
        public double StockPrice2 { get; set; }
        public int ShellWorkStatusID { get; set; }
    }
}
