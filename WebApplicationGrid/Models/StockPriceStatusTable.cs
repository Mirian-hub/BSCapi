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
    
    public partial class StockPriceStatusTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StockPriceStatusTable()
        {
            this.StockPriceTables = new HashSet<StockPriceTable>();
        }
    
        public int StockPriceStatusID { get; set; }
        public string StockPriceStatusKey { get; set; }
        public string StockPriceStatusName { get; set; }
        public string StockPriceStatusNote { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockPriceTable> StockPriceTables { get; set; }
    }
}
