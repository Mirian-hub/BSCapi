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
    
    public partial class StockItemBOMRecursive_Result
    {
        public Nullable<int> TransItemID { get; set; }
        public Nullable<int> TransItemUnitID { get; set; }
        public string TransItemKey { get; set; }
        public string TransItemName { get; set; }
        public string TransItemUnitName { get; set; }
        public Nullable<int> InertmediateItemID { get; set; }
        public Nullable<int> StockItemID { get; set; }
        public Nullable<int> StockItemUnitID { get; set; }
        public string StockItemKey { get; set; }
        public string StockItemName { get; set; }
        public string StockItemUnitName { get; set; }
        public Nullable<double> StockItemBOMFactor { get; set; }
        public Nullable<long> StockItemBOMSortID { get; set; }
        public Nullable<int> StockItemBOMLevelID { get; set; }
    }
}