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
    
    public partial class StockEntryLineStatusTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StockEntryLineStatusTable()
        {
            this.StockEntryLineTables = new HashSet<StockEntryLineTable>();
        }
    
        public int StockEntryLineStatusID { get; set; }
        public string StockEntryLineStatusKey { get; set; }
        public string StockEntryLineStatusName { get; set; }
        public string StockEntryLineStatusNote { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockEntryLineTable> StockEntryLineTables { get; set; }
    }
}
