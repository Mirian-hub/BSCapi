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
    
    public partial class StockBOMPlanList
    {
        public int StockBOMPlanID { get; set; }
        public string StockBOMPlanKey { get; set; }
        public string StockBOMPlanName { get; set; }
        public System.DateTime StockBOMPlanDate { get; set; }
        public int StockBOMPlanStatusID { get; set; }
        public int StockBOMPlanGroupID { get; set; }
        public Nullable<int> StockBOMPlanCopyProcess { get; set; }
        public int StockLocationID { get; set; }
    }
}