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
    
    public partial class RSWaybillWorkTable
    {
        public int ShellUserID { get; set; }
        public int ShellOperationID { get; set; }
        public int ShellWorkPageID { get; set; }
        public int ShellWorkPageLineID { get; set; }
        public Nullable<int> ShellWorkPageParentID { get; set; }
        public string ShellWorkPageLineParentID { get; set; }
        public double ShellWorkPageSign { get; set; }
        public int ShellWorkPageAuto { get; set; }
        public int ShellMessageID { get; set; }
        public int ShellWorkStatusID { get; set; }
        public Nullable<long> RsWaybillID { get; set; }
        public string RsWaybillKEY { get; set; }
        public string RSWaybillName { get; set; }
        public Nullable<int> RsWaybillTypeID { get; set; }
        public Nullable<int> RsWaybillStatusID { get; set; }
        public string RsCompanyKEY { get; set; }
        public string RsCompanyNAME { get; set; }
        public string RsStartAddress { get; set; }
        public string RsEndAddress { get; set; }
        public Nullable<System.DateTime> RsCreateDate { get; set; }
        public Nullable<System.DateTime> RsDeliveriDate { get; set; }
        public Nullable<System.DateTime> RsActivateDate { get; set; }
        public Nullable<System.DateTime> RsCloseDate { get; set; }
        public Nullable<System.DateTime> RsBeginDate { get; set; }
        public Nullable<int> RsConfirmationStatusID { get; set; }
        public string RsPersonKEY { get; set; }
        public string RsPersonNAME { get; set; }
        public string RsTransportKEY { get; set; }
        public Nullable<long> RsWaybillLineID { get; set; }
        public Nullable<int> RsWaybillLineStatusID { get; set; }
        public string RsItemKey { get; set; }
        public string RSItemName { get; set; }
        public Nullable<int> RSUnitID { get; set; }
        public string RSUnitNAME { get; set; }
        public Nullable<double> RSQuantity { get; set; }
        public Nullable<double> RSPrice { get; set; }
        public Nullable<int> RSTaxId { get; set; }
        public Nullable<int> RSTaxId2 { get; set; }
        public Nullable<double> RSAmount { get; set; }
        public Nullable<int> StockEntryID { get; set; }
        public Nullable<long> StockEntryLineID { get; set; }
        public Nullable<int> StockSupplierID { get; set; }
        public string StockSupplierName { get; set; }
        public Nullable<int> StockCustomerID { get; set; }
        public Nullable<int> StockLocationID { get; set; }
        public Nullable<int> StockPersonID { get; set; }
        public Nullable<int> StockCarID { get; set; }
        public Nullable<int> StockItemID { get; set; }
        public Nullable<int> StockItemUnitID { get; set; }
        public Nullable<double> StockItemUnitFactor { get; set; }
        public Nullable<double> StockPrice { get; set; }
        public Nullable<int> StockPriceLineTypeID { get; set; }
        public Nullable<double> StockPriceTaxID { get; set; }
        public Nullable<double> StockPriceTaxFactor { get; set; }
        public Nullable<double> StockAmount { get; set; }
        public Nullable<double> StockTaxAmount { get; set; }
        public Nullable<double> StockBaseAmount { get; set; }
        public Nullable<int> RSCorrectionStatusID { get; set; }
        public Nullable<System.DateTime> ShellCreated { get; set; }
        public Nullable<System.DateTime> ShellUpdated { get; set; }
        public Nullable<int> StockMarkupGroupID { get; set; }
        public Nullable<int> StockMarkupID { get; set; }
        public Nullable<double> TransPrice { get; set; }
        public Nullable<int> TransTaxID { get; set; }
        public Nullable<double> TransTaxFactor { get; set; }
        public Nullable<double> TransAmount { get; set; }
        public Nullable<double> TransTaxAmount { get; set; }
        public Nullable<double> TransBaseAmount { get; set; }
        public string StockEntryName { get; set; }
    }
}