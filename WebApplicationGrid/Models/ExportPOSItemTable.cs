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
    
    public partial class ExportPOSItemTable
    {
        public int StockItemID { get; set; }
        public string StockItemKey { get; set; }
        public string StockItemName { get; set; }
        public int StockItemSortID { get; set; }
        public int StockItemTypeID { get; set; }
        public int StockItemStatusID { get; set; }
        public int StockItemGroupID { get; set; }
        public int StockItemUnitID { get; set; }
        public int StockItemScaleID { get; set; }
        public double StockItemScaleFactor { get; set; }
        public Nullable<double> StockItemPrice { get; set; }
        public Nullable<int> StockItemPriceTaxID { get; set; }
        public Nullable<double> StockItemPriceTaxFactor { get; set; }
        public string ShellServerKey { get; set; }
    }
}
