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
    
    public partial class StockItemUnitTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StockItemUnitTable()
        {
            this.StockItemTables = new HashSet<StockItemTable>();
        }
    
        public int StockItemUnitID { get; set; }
        public string StockItemUnitKey { get; set; }
        public string StockItemUnitName { get; set; }
        public int StockItemUnitTypeID { get; set; }
        public int StockItemUnitStatusID { get; set; }
        public int StockItemUnitGroupID { get; set; }
        public int StockItemUnitSortID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockItemTable> StockItemTables { get; set; }
        public virtual StockItemUnitGroupTable StockItemUnitGroupTable { get; set; }
        public virtual StockItemUnitStatusTable StockItemUnitStatusTable { get; set; }
        public virtual StockItemUnitTypeTable StockItemUnitTypeTable { get; set; }
    }
}
