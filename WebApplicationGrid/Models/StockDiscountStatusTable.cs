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
    
    public partial class StockDiscountStatusTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StockDiscountStatusTable()
        {
            this.StockDiscountTables = new HashSet<StockDiscountTable>();
        }
    
        public int StockDiscountStatusID { get; set; }
        public string StockDiscountStatusKey { get; set; }
        public string StockDiscountStatusName { get; set; }
        public string StockDiscountStatusNote { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockDiscountTable> StockDiscountTables { get; set; }
    }
}
