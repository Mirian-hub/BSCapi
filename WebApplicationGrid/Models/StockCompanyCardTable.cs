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
    
    public partial class StockCompanyCardTable
    {
        public int StockCompanyCardID { get; set; }
        public int StockCompanyCardStatusID { get; set; }
        public string StockCompanyCardKey { get; set; }
        public string StockCompanyCardName { get; set; }
        public string StockCompanyCardNote { get; set; }
        public System.DateTime StockCompanyCardValidFrom { get; set; }
        public System.DateTime StockCompanyCardValidTo { get; set; }
        public int StockCompanyID { get; set; }
        public int StockCompanyCardTypeID { get; set; }
        public int StockCompanyCardGroupID { get; set; }
        public int StockItemID { get; set; }
        public double StockQuantity { get; set; }
        public double StockAmountLimit { get; set; }
        public double StockAmountBalance { get; set; }
    }
}