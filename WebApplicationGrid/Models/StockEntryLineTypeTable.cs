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
    
    public partial class StockEntryLineTypeTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StockEntryLineTypeTable()
        {
            this.StockEntryLineTables = new HashSet<StockEntryLineTable>();
        }
    
        public int StockEntryLineTypeID { get; set; }
        public string StockEntryLineTypeKey { get; set; }
        public string StockEntryLineTypeName { get; set; }
        public string StockEntryLineTypeNote { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockEntryLineTable> StockEntryLineTables { get; set; }
    }
}
