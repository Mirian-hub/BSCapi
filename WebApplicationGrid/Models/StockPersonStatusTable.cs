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
    
    public partial class StockPersonStatusTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StockPersonStatusTable()
        {
            this.StockPersonTables = new HashSet<StockPersonTable>();
        }
    
        public int StockPersonStatusID { get; set; }
        public string StockPersonStatusKey { get; set; }
        public string StockPersonStatusName { get; set; }
        public string StockPersonStatusNote { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockPersonTable> StockPersonTables { get; set; }
    }
}
