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
    
    public partial class StockLocationShelfTable
    {
        public int StockLocationID { get; set; }
        public int StockLocationShelfSortID { get; set; }
        public string StockLocationShelfKey { get; set; }
        public string StockLocationShelfName { get; set; }
        public string StockLocationShelfNote { get; set; }
        public int StockLocationShelfStatusID { get; set; }
        public int StockLocationShelfID { get; set; }
        public int StockLocationShelfTypeID { get; set; }
    
        public virtual StockLocationShelfStatusTable StockLocationShelfStatusTable { get; set; }
        public virtual StockLocationShelfTypeTable StockLocationShelfTypeTable { get; set; }
        public virtual StockLocationTable StockLocationTable { get; set; }
    }
}
