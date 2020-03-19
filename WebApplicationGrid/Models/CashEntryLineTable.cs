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
    
    public partial class CashEntryLineTable
    {
        public long CashEntryLineID { get; set; }
        public int CashEntryLineSortID { get; set; }
        public int CashEntryID { get; set; }
        public string CashEntryLineKey { get; set; }
        public string CashEntryLineName { get; set; }
        public string CashEntryLineNote { get; set; }
        public int CashEntryLineTypeID { get; set; }
        public int CashEntryLineStatusID { get; set; }
        public int CashLocationID { get; set; }
        public Nullable<int> CashLocationID2 { get; set; }
        public int CashCompanyID { get; set; }
        public int CashItemID { get; set; }
        public double CashAmount { get; set; }
        public Nullable<int> CashPersonID { get; set; }
        public Nullable<System.DateTime> CashEntryLineDate { get; set; }
    
        public virtual CashEntryLineStatusTable CashEntryLineStatusTable { get; set; }
        public virtual CashEntryLineTypeTable CashEntryLineTypeTable { get; set; }
    }
}