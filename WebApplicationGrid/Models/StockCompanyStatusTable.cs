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
    
    public partial class StockCompanyStatusTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StockCompanyStatusTable()
        {
            this.StockCompanyTables = new HashSet<StockCompanyTable>();
        }
    
        public int StockCompanyStatusID { get; set; }
        public string StockCompanyStatusKey { get; set; }
        public string StockCompanyStatusName { get; set; }
        public string StockCompanyStatusNote { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockCompanyTable> StockCompanyTables { get; set; }
    }
}
