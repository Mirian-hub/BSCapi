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
    
    public partial class StockEntrySP9Edit2
    {
        public int ShellUserID { get; set; }
        public int ShellOperationID { get; set; }
        public int ShellMessageID_R { get; set; }
        public int ShellWorkPageID { get; set; }
        public int ShellWorkPageLineID_R { get; set; }
        public string TransItemKey_R { get; set; }
        public string TransItemName_R { get; set; }
        public string TransItemUnitName_R { get; set; }
        public double TransQuantity_R { get; set; }
        public string StockItemKey_R { get; set; }
        public string StockItemName_R { get; set; }
        public string StockItemUnitName_R { get; set; }
        public double StockItemBOMFactor_R { get; set; }
        public double TransQuantityFactor_R { get; set; }
        public double StockQuantity_R { get; set; }
        public int StockLocationID_CR { get; set; }
    }
}