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
    
    public partial class StockItemEdit2
    {
        public long StockPriceLineID { get; set; }
        public int StockPriceID { get; set; }
        public int StockPriceLineSortID { get; set; }
        public Nullable<int> StockCustomerID_C { get; set; }
        public int StockItemID { get; set; }
        public double StockPriceItemUnitFactor { get; set; }
        public int StockPriceItemUnitID_B { get; set; }
        public double FCPrice { get; set; }
        public int TaxCodeID_C { get; set; }
        public int StockAllowChange_C { get; set; }
        public int StockPriceLineStatusID_C { get; set; }
        public System.DateTime StockPriceLineValidFrom { get; set; }
        public Nullable<System.DateTime> StockPriceLineValidTo { get; set; }
        public string StockPriceLineKey { get; set; }
        public string StockPriceLineName { get; set; }
        public System.DateTime ShellCreationDate { get; set; }
    }
}
