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
    
    public partial class StockLocationTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StockLocationTable()
        {
            this.ShellComputerTables = new HashSet<ShellComputerTable>();
            this.StockEntryLineTables = new HashSet<StockEntryLineTable>();
            this.StockLocationAddressTables = new HashSet<StockLocationAddressTable>();
            this.StockLocationItemTables = new HashSet<StockLocationItemTable>();
            this.StockLocationRightTables = new HashSet<StockLocationRightTable>();
            this.StockLocationShelfTables = new HashSet<StockLocationShelfTable>();
        }
    
        public int StockLocationID { get; set; }
        public string StockLocationKey { get; set; }
        public string StockLocationName { get; set; }
        public int StockLocationTypeID { get; set; }
        public int StockLocationStatusID { get; set; }
        public Nullable<System.DateTime> StockLocationValidFrom { get; set; }
        public Nullable<System.DateTime> StockLocationValidTo { get; set; }
        public int StockLocationGroupID { get; set; }
        public string StockLocationAddress { get; set; }
        public Nullable<int> PersonID { get; set; }
        public Nullable<int> PersonID2 { get; set; }
        public Nullable<int> PersonID3 { get; set; }
        public Nullable<int> StockCustomerID { get; set; }
        public Nullable<int> StockLocationID2 { get; set; }
        public string ExactCostCenter { get; set; }
        public string StockPrinterName { get; set; }
        public string StockLocationName_EN { get; set; }
        public Nullable<int> StockLocationID3 { get; set; }
        public string StockLocationName_RU { get; set; }
        public Nullable<int> ExactID { get; set; }
        public int StockLocationSortID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShellComputerTable> ShellComputerTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockEntryLineTable> StockEntryLineTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockLocationAddressTable> StockLocationAddressTables { get; set; }
        public virtual StockLocationGroupTable StockLocationGroupTable { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockLocationItemTable> StockLocationItemTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockLocationRightTable> StockLocationRightTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockLocationShelfTable> StockLocationShelfTables { get; set; }
        public virtual StockLocationStatusTable StockLocationStatusTable { get; set; }
        public virtual StockLocationTypeTable StockLocationTypeTable { get; set; }
    }
}
