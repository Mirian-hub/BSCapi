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
    
    public partial class StockEntryPrintReportTable
    {
        public string MyCompanyName { get; set; }
        public string MyCompanyAddress { get; set; }
        public string MyCompanyPhone { get; set; }
        public int ShellComputerID { get; set; }
        public int StockPrintProcessID { get; set; }
        public int StockEntryTypeID { get; set; }
        public int StockPrintLocationID { get; set; }
        public string PrintLocationKey { get; set; }
        public string PrintLocationName { get; set; }
        public int StockEntryID { get; set; }
        public string StockLocationKey { get; set; }
        public string StockLocationName { get; set; }
        public string StockEntryDateInitial { get; set; }
        public string StockLocationShelfKey { get; set; }
        public string StockLocationShelfName { get; set; }
        public double StockPersonQuantity { get; set; }
        public string ShellUserName { get; set; }
        public string StockItemGroupKey { get; set; }
        public string StockItemGroupName { get; set; }
        public string StockItemKey { get; set; }
        public string StockItemName { get; set; }
        public Nullable<double> StockQuantity { get; set; }
        public string StockPayMethodKey { get; set; }
        public string StockPayMethodName { get; set; }
        public Nullable<double> TransAmount { get; set; }
    }
}