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
    
    public partial class StockBOMPlanTypeTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StockBOMPlanTypeTable()
        {
            this.StockBOMPlanTables = new HashSet<StockBOMPlanTable>();
        }
    
        public int StockBOMPlanTypeID { get; set; }
        public string StockBOMPlanTypeKey { get; set; }
        public string StockBOMPlanTypeName { get; set; }
        public string StockBOMPlanTypeNote { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockBOMPlanTable> StockBOMPlanTables { get; set; }
    }
}
