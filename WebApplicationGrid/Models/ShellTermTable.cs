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
    
    public partial class ShellTermTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ShellTermTable()
        {
            this.ShellTermNameTables = new HashSet<ShellTermNameTable>();
        }
    
        public int ShellTermID { get; set; }
        public string ShellTermKey { get; set; }
        public string ShellTermName { get; set; }
        public int ShellTermTypeID { get; set; }
        public int ShellTermStatusID { get; set; }
        public int ShellTermGroupID { get; set; }
        public int ShellTermSortID { get; set; }
        public string ShellTermFormat { get; set; }
    
        public virtual ShellTermGroupTable ShellTermGroupTable { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShellTermNameTable> ShellTermNameTables { get; set; }
        public virtual ShellTermStatusTable ShellTermStatusTable { get; set; }
        public virtual ShellTermTypeTable ShellTermTypeTable { get; set; }
    }
}
