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
    
    public partial class StockLocationRightTable
    {
        public int StockLocationID { get; set; }
        public int ShellUserID { get; set; }
        public int StockLocationRightID { get; set; }
        public int StockLocationRightStatusID { get; set; }
    
        public virtual StockLocationTable StockLocationTable { get; set; }
    }
}
