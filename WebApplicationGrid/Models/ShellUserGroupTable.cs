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
    
    public partial class ShellUserGroupTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ShellUserGroupTable()
        {
            this.ShellUserTables = new HashSet<ShellUserTable>();
            this.ShellUserGroupTable1 = new HashSet<ShellUserGroupTable>();
        }
    
        public int ShellUserGroupID { get; set; }
        public string ShellUserGroupKey { get; set; }
        public string ShellUserGroupName { get; set; }
        public int ShellUserGroupParentID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShellUserTable> ShellUserTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShellUserGroupTable> ShellUserGroupTable1 { get; set; }
        public virtual ShellUserGroupTable ShellUserGroupTable2 { get; set; }
    }
}
