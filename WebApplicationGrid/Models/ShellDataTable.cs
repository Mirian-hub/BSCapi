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
    
    public partial class ShellDataTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ShellDataTable()
        {
            this.ShellDataRightTables = new HashSet<ShellDataRightTable>();
            this.ShellDataSearchTables = new HashSet<ShellDataSearchTable>();
            this.ShellDataSortTables = new HashSet<ShellDataSortTable>();
        }
    
        public int ShellDataID { get; set; }
        public string ShellDataKey { get; set; }
        public string ShellDataName { get; set; }
        public int ShellDataTypeID { get; set; }
        public int ShellDataStatusID { get; set; }
        public int ShellDataGroupID { get; set; }
        public int ShellDataSortID { get; set; }
        public int ShellDataValueID { get; set; }
        public int ShellDataValueGroupID { get; set; }
        public bool ShellDataFlag_HasHierarchy { get; set; }
        public bool ShellDataFlag_HasGroup { get; set; }
        public bool ShellDataFlag_HasGroupHierarchy { get; set; }
        public bool ShellDataFlag_IsReadOnly { get; set; }
        public bool ShellDataFlag_IsGroupReadOnly { get; set; }
    
        public virtual ShellDataGroupTable ShellDataGroupTable { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShellDataRightTable> ShellDataRightTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShellDataSearchTable> ShellDataSearchTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShellDataSortTable> ShellDataSortTables { get; set; }
        public virtual ShellDataStatusTable ShellDataStatusTable { get; set; }
        public virtual ShellDataTypeTable ShellDataTypeTable { get; set; }
    }
}