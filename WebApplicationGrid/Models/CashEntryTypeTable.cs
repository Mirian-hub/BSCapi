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
    
    public partial class CashEntryTypeTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CashEntryTypeTable()
        {
            this.CashEntryTables = new HashSet<CashEntryTable>();
        }
    
        public int CashEntryTypeID { get; set; }
        public string CashEntryTypeKey { get; set; }
        public string CashEntryTypeName { get; set; }
        public string CashEntryTypeNote { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CashEntryTable> CashEntryTables { get; set; }
    }
}
