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
    
    public partial class StockSalesPriceByDate_Result
    {
        public int StockItemID { get; set; }
        public string StockItemKey { get; set; }
        public string StockItemName { get; set; }
        public int StockItemUnitTypeID { get; set; }
        public int StockCustomerID { get; set; }
        public string StockCustomerKey { get; set; }
        public string StockCustomerName { get; set; }
        public Nullable<int> StockPriceID { get; set; }
        public Nullable<long> StockPriceLineID { get; set; }
        public Nullable<int> StockPriceLineSortID { get; set; }
        public Nullable<int> StockPackQuantity { get; set; }
        public string StockPackUnitKey { get; set; }
        public int StockPackUnitID { get; set; }
        public Nullable<double> StockPackFactor { get; set; }
        public Nullable<int> StockCurrencyID { get; set; }
        public Nullable<double> StockPackPrice { get; set; }
        public Nullable<int> StockTaxCodeID { get; set; }
        public Nullable<double> StockTaxGFactor { get; set; }
        public Nullable<double> StockTaxNFactor { get; set; }
        public Nullable<double> StockTaxTFactor { get; set; }
        public Nullable<double> StockPackFullPrice { get; set; }
        public Nullable<int> StockAllowChange { get; set; }
        public Nullable<double> StockCommisionPercent { get; set; }
        public Nullable<int> DMQuantity { get; set; }
        public string DMUnit { get; set; }
        public Nullable<double> DMFactor { get; set; }
        public Nullable<double> FCPrice { get; set; }
        public Nullable<int> TaxCodeID { get; set; }
        public Nullable<int> CurrencyID { get; set; }
        public Nullable<double> CommisionPercent { get; set; }
        public int IsPriceAgreement { get; set; }
    }
}
