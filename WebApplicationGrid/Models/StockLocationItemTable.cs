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
    
    public partial class StockLocationItemTable
    {
        public int StockLocationID { get; set; }
        public int StockItemID { get; set; }
        public double MinQuantity { get; set; }
        public double MaxQuantity { get; set; }
        public int StockDeliveryGraphID { get; set; }
        public double DMQuantity { get; set; }
        public double MinDays { get; set; }
        public double MaxDays { get; set; }
        public int StatisticDays { get; set; }
        public int StockLocationItemSortID { get; set; }
        public double SalesSpeed { get; set; }
        public double SalesFactor { get; set; }
        public int StockLocationItemStatusID { get; set; }
        public double OrderSpeed { get; set; }
        public int StockDeliveryTypeID { get; set; }
        public int StockUsageTypeID { get; set; }
        public Nullable<int> StockLocationID2 { get; set; }
        public double StockQLimitFactor { get; set; }
        public double OrderFactor { get; set; }
        public Nullable<int> StockSupplierID { get; set; }
        public double OrderDays { get; set; }
        public int StockRPTypeID { get; set; }
    
        public virtual StockDeliveryGraphTable StockDeliveryGraphTable { get; set; }
        public virtual StockDeliveryTypeTable StockDeliveryTypeTable { get; set; }
        public virtual StockItemTable StockItemTable { get; set; }
        public virtual StockLocationItemStatusTable StockLocationItemStatusTable { get; set; }
        public virtual StockLocationTable StockLocationTable { get; set; }
        public virtual StockUsageTypeTable StockUsageTypeTable { get; set; }
    }
}
