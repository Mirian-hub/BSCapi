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
    
    public partial class RSMessageTypeTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RSMessageTypeTable()
        {
            this.RSMessageTables = new HashSet<RSMessageTable>();
        }
    
        public int RSMessageTypeID { get; set; }
        public string RSMessageTypeKEY { get; set; }
        public string RSMessageTypeNAME { get; set; }
        public string RSMessageTypeNOTE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RSMessageTable> RSMessageTables { get; set; }
    }
}