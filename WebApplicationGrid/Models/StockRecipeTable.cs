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
    
    public partial class StockRecipeTable
    {
        public int StockRecipeID { get; set; }
        public string StockRecipeKey { get; set; }
        public string StockRecipeName { get; set; }
        public string StockRecipeNote { get; set; }
        public int StockRecipeTypeID { get; set; }
        public int StockRecipeStatusID { get; set; }
        public int StockItemID { get; set; }
        public double StockRecipeQuantity { get; set; }
        public int StockRecipeItemID { get; set; }
        public System.DateTime StockRecipeValidFrom { get; set; }
        public Nullable<System.DateTime> StockRecipeValidTo { get; set; }
        public int StockRecipeSortID { get; set; }
        public int StockLocationID { get; set; }
        public double StockItemProtein { get; set; }
        public double StockItemFat { get; set; }
        public double StockItemCarbohydrate { get; set; }
        public double StockItemCalorie { get; set; }
    
        public virtual StockRecipeStatusTable StockRecipeStatusTable { get; set; }
    }
}