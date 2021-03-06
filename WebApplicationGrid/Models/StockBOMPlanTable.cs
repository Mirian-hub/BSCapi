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
    
    public partial class StockBOMPlanTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StockBOMPlanTable()
        {
            this.StockBOMPlanLineTables = new HashSet<StockBOMPlanLineTable>();
        }
    
        public int StockBOMPlanID { get; set; }
        public string StockBOMPlanKey { get; set; }
        public string StockBOMPlanName { get; set; }
        public string StockBOMPlanNote { get; set; }
        public int StockBOMPlanTypeID { get; set; }
        public int StockBOMPlanStatusID { get; set; }
        public int StockBOMPlanGroupID { get; set; }
        public System.DateTime StockBOMPlanDate { get; set; }
        public int StockItemID { get; set; }
        public int StockLocationID { get; set; }
        public int StockCompanyID { get; set; }
        public int StockCompanyID2 { get; set; }
    
        public virtual StockBOMPlanGroupTable StockBOMPlanGroupTable { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockBOMPlanLineTable> StockBOMPlanLineTables { get; set; }
        public virtual StockBOMPlanStatusTable StockBOMPlanStatusTable { get; set; }
        public virtual StockBOMPlanTypeTable StockBOMPlanTypeTable { get; set; }
        public virtual StockItemTable StockItemTable { get; set; }
    }
}
