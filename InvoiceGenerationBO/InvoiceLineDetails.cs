using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceGenerationBO
{
    public class InvoiceLineDetails
    {
        public long inv_line_id { get; set; }
        public long Inv_id { get; set; }
        public string Inv_TransCat { get; set; }
        public string Inv_Detail_ICR { get; set; }
        public string Inv_DetailDesc { get; set; }
        public string Inv_Detail_ConNote { get; set; }
        public string Inv_DetailVatType { get; set; }
        public decimal Inv_DetailAmtChargedExcl { get; set; }
        public decimal Inv_DetailCurrencyCharged { get; set; }
        public decimal Inv_DetailVATPctCharged { get; set; }
        public decimal Inv_DetailVATAmtCharged { get; set; }
        public decimal Inv_DetailAmtCharged { get; set; }
        public decimal Inv_DetailAmtRecExcl { get; set; }
        public decimal Inv_DetailVATAmtRec { get; set; }
        public decimal Inv_DetailAmtRec { get; set; }
        public decimal Inv_DetailCurrencyRec { get; set; }
        public decimal Inv_DetailUSDValue { get; set; }
        public string Inv_DetailNominalCode { get; set; }
        public string Inv_DetailWHT { get; set; }
        public decimal Inv_EuroValue { get; set; }
        public decimal Inv_EuroTaxAmount { get; set; }
        public string Inv_DetailDocLink { get; set; }
        public string Inv_SAPLink1 { get; set; }
        public string Inv_SAPLink2 { get; set; }
        public string Inv_SAPLink3 { get; set; }
        public string Inv_SAPLink4 { get; set; }
        public string Inv_SAPLink5 { get; set; }
        public string Inv_SAPLink6 { get; set; }
        public string Inv_SAPLink7 { get; set; }
        public string Inv_SAPLink8 { get; set; }
        public string Inv_SAPLink9 { get; set; }
        public string Inv_SAPLink10 { get; set; }
        public DateTime created_date { get; set; }
        public DateTime updated_date { get; set; }
        public string created_by { get; set; }
        public string updated_by { get; set; }
        public string is_active { get; set; }
        public string is_deleted { get; set; }
    }
}

