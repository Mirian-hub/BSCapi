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
    
    public partial class StockBalance10Edit1
    {
        public int ShellUserID { get; set; }
        public int ShellOperationID { get; set; }
        public int ShellWorkPageID { get; set; }
        public int ShellWorkPageLineID_R { get; set; }
        public int ShellMessageID_R { get; set; }
        public int ShellDataPageLinkID { get; set; }
        public int ShellDataPageLineLinkID { get; set; }
        public Nullable<System.DateTime> StockEntryDate_R { get; set; }
        public double StockQuantity_I { get; set; }
        public double StockQuantity_O { get; set; }
        public Nullable<int> cmdNextColumn1 { get; set; }
        public Nullable<double> StockQuantity_XD { get; set; }
        public Nullable<double> StockQuantity_XC { get; set; }
        public Nullable<int> cmdNextColumn2 { get; set; }
        public Nullable<int> StockItemID_CR { get; set; }
        public Nullable<int> StockLocationID_AR { get; set; }
        public Nullable<int> StockCompanyID_CR { get; set; }
        public Nullable<int> StockEntryLineTypeID_CR { get; set; }
        public Nullable<int> StockEntryID_R { get; set; }
        public string StockEntryKey { get; set; }
        public string StockEntryName { get; set; }
        public double StockAmount { get; set; }
    }
}
