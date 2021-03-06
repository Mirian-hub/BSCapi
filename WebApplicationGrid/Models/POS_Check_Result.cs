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
    
    public partial class POS_Check_Result
    {
        public int StockEntryID { get; set; }
        public int StockEntryParentID { get; set; }
        public string StockEntryKey { get; set; }
        public string StockEntryName { get; set; }
        public string FiscalPrinterKey { get; set; }
        public string FiscalPrinterKey2 { get; set; }
        public string MyStockCompanyName { get; set; }
        public string MyStockCompanyAddress { get; set; }
        public string MyStockCompanyTaxNumber { get; set; }
        public System.DateTime StockEntryDate { get; set; }
        public string StockEntryTypeName { get; set; }
        public string StockPayMethodName { get; set; }
        public string StockTaxMethodName { get; set; }
        public string StockLocationName { get; set; }
        public string StockLocationAddress { get; set; }
        public string ShellComputerName { get; set; }
        public string ShellUserName { get; set; }
        public string StockItemName { get; set; }
        public string StockItemUnitName { get; set; }
        public Nullable<double> Quantity { get; set; }
        public double Price { get; set; }
        public double Amount { get; set; }
        public double SummaryAmount { get; set; }
        public double SummaryServiceAmount { get; set; }
        public Nullable<double> SummaryDiscountAmount { get; set; }
        public double TotalAmount { get; set; }
        public Nullable<double> TotalTaxAmount { get; set; }
        public string TotalAmountInWords { get; set; }
        public double SummaryPayCashAmount { get; set; }
        public double SummaryPayCashChangeAmount { get; set; }
        public double SummaryPayBankAmount { get; set; }
        public double SummaryPayInvoiceAmount { get; set; }
        public double SummaryPayOtherAmount { get; set; }
        public Nullable<double> TotalPayAmount { get; set; }
    }
}
