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
    
    public partial class ShellSchedulerGroupTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ShellSchedulerGroupTable()
        {
            this.ShellSchedulerTables = new HashSet<ShellSchedulerTable>();
            this.ShellSchedulerGroupTable1 = new HashSet<ShellSchedulerGroupTable>();
        }
    
        public int ShellSchedulerGroupID { get; set; }
        public string ShellSchedulerGroupKEY { get; set; }
        public string ShellSchedulerGroupNAME { get; set; }
        public string ShellSchedulerGroupNOTE { get; set; }
        public int ShellSchedulerGroupSORT { get; set; }
        public int ShellSchedulerGroupParentID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShellSchedulerTable> ShellSchedulerTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShellSchedulerGroupTable> ShellSchedulerGroupTable1 { get; set; }
        public virtual ShellSchedulerGroupTable ShellSchedulerGroupTable2 { get; set; }
    }
}