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
    
    public partial class StockUsageTypeTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StockUsageTypeTable()
        {
            this.StockLocationItemTables = new HashSet<StockLocationItemTable>();
        }
    
        public int StockUsageTypeID { get; set; }
        public string StockUsageTypeKey { get; set; }
        public string StockUsageTypeName { get; set; }
        public string StockUsageTypeNote { get; set; }
        public bool S1 { get; set; }
        public bool S2 { get; set; }
        public bool T1 { get; set; }
        public bool T2 { get; set; }
        public bool M1 { get; set; }
        public bool M2 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockLocationItemTable> StockLocationItemTables { get; set; }
    }
}