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
    
    public partial class StockLocationGroupTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StockLocationGroupTable()
        {
            this.StockLocationTables = new HashSet<StockLocationTable>();
            this.StockLocationGroupTable1 = new HashSet<StockLocationGroupTable>();
        }
    
        public int StockLocationGroupID { get; set; }
        public string StockLocationGroupKey { get; set; }
        public string StockLocationGroupName { get; set; }
        public string StockLocationGroupNote { get; set; }
        public Nullable<int> StockLocationGroupParentID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockLocationTable> StockLocationTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockLocationGroupTable> StockLocationGroupTable1 { get; set; }
        public virtual StockLocationGroupTable StockLocationGroupTable2 { get; set; }
    }
}