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
    
    public partial class ShellSettingStatusTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ShellSettingStatusTable()
        {
            this.ShellSettingTables = new HashSet<ShellSettingTable>();
        }
    
        public int ShellSettingStatusID { get; set; }
        public string ShellSettingStatusKey { get; set; }
        public string ShellSettingStatusName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShellSettingTable> ShellSettingTables { get; set; }
    }
}