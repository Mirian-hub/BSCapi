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
    
    public partial class StockDiscountLineTable
    {
        public long StockDiscountLineID { get; set; }
        public string StockDiscountLineKey { get; set; }
        public string StockDiscountLineName { get; set; }
        public int StockDiscountLineSortID { get; set; }
        public int StockDiscountLineTypeID { get; set; }
        public int StockDiscountLineStatusID { get; set; }
        public System.DateTime StockDiscountLineValidFrom { get; set; }
        public System.DateTime StockDiscountLineValidTo { get; set; }
        public int StockDiscountID { get; set; }
        public int StockItemID { get; set; }
        public double StockDiscountLineFactor { get; set; }
        public double StockDisccountLineQuantityInitial { get; set; }
        public double StockDisccountLineQuantity { get; set; }
    }
}
