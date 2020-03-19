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
    
    public partial class StockPayPeriodTable
    {
        public int ShellComputerID { get; set; }
        public int StockPayPeriodID { get; set; }
        public string StockPayPeriodKey { get; set; }
        public string StockPayPeriodName { get; set; }
        public Nullable<System.DateTime> StockPayPeriodValidFrom { get; set; }
        public Nullable<System.DateTime> StockPayPeriodValidTo { get; set; }
        public int StockPayPeriodStatusID { get; set; }
        public Nullable<System.DateTime> ShellSyncDate { get; set; }
        public int ShellUserID { get; set; }
        public Nullable<int> StockLocationID { get; set; }
        public Nullable<int> StockCustomerID { get; set; }
        public double StockPayPeriodOpenAmount { get; set; }
        public double StockPayPeriodInAmount { get; set; }
        public double StockPayPeriodOutAmount { get; set; }
        public double StockPayPeriodCashAmount { get; set; }
        public double StockPayPeriodDifferenceAmount { get; set; }
        public double StockPayPeriodCloseAmount { get; set; }
        public double TransPayCashAmount { get; set; }
        public double TransPayCashChangeAmount { get; set; }
        public double TransPayBankAmount { get; set; }
        public double TransPayInvoiceAmount { get; set; }
        public double TransPayOtherAmount { get; set; }
    }
}