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
    
    public partial class CashEntryLineTypeTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CashEntryLineTypeTable()
        {
            this.CashEntryLineTables = new HashSet<CashEntryLineTable>();
        }
    
        public int CashEntryLineTypeID { get; set; }
        public string CashEntryLineTypeKey { get; set; }
        public string CashEntryLineTypeName { get; set; }
        public string CashEntryLineTypeNote { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CashEntryLineTable> CashEntryLineTables { get; set; }
    }
}
