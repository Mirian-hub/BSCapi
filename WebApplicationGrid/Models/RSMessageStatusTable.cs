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
    
    public partial class RSMessageStatusTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RSMessageStatusTable()
        {
            this.RSMessageTables = new HashSet<RSMessageTable>();
        }
    
        public int RSMessageStatusID { get; set; }
        public string RSMessageStatusKEY { get; set; }
        public string RSMessageStatusNAME { get; set; }
        public string RSMessageStatusNOTE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RSMessageTable> RSMessageTables { get; set; }
    }
}