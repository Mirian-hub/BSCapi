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
    
    public partial class StockLocationShelfTypeTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StockLocationShelfTypeTable()
        {
            this.StockLocationShelfTables = new HashSet<StockLocationShelfTable>();
        }
    
        public int StockLocationShelfTypeID { get; set; }
        public string StockLocationShelfTypeKey { get; set; }
        public string StockLocationShelfTypeName { get; set; }
        public string StockLocationShelfTypeNote { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockLocationShelfTable> StockLocationShelfTables { get; set; }
    }
}
