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
    
    public partial class StockDeliveryTypeTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StockDeliveryTypeTable()
        {
            this.StockLocationItemTables = new HashSet<StockLocationItemTable>();
        }
    
        public int StockDeliveryTypeID { get; set; }
        public string StockDeliveryTypeKey { get; set; }
        public string StockDeliveryTypeName { get; set; }
        public string StockDeliveryTypeNote { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockLocationItemTable> StockLocationItemTables { get; set; }
    }
}
