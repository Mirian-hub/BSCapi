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
    
    public partial class ShellDataGroupTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ShellDataGroupTable()
        {
            this.ShellDataTables = new HashSet<ShellDataTable>();
            this.ShellDataGroupTable1 = new HashSet<ShellDataGroupTable>();
        }
    
        public int ShellDataGroupID { get; set; }
        public string ShellDataGroupKey { get; set; }
        public string ShellDataGroupName { get; set; }
        public int ShellDataGroupParentID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShellDataTable> ShellDataTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShellDataGroupTable> ShellDataGroupTable1 { get; set; }
        public virtual ShellDataGroupTable ShellDataGroupTable2 { get; set; }
    }
}