using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceGenerationBO
{
	public class InvoiceHeader
	{
		public long Inv_id { get; set; }
		public string Inv_Period { get; set; }
		public string Inv_Year { get; set; }
		public string Inv_Header { get; set; }
		public DateTime Inv_Date { get; set; }
		public string Inv_FromAddress { get; set; }
		public string Inv_FromBU { get; set; }
		public string Inv_FromBUName { get; set; }
		public string Inv_FromCoC { get; set; }
		public string Inv_FromVATNumber { get; set; }
		public string Inv_InvoiceNumber { get; set; }
		public string Inv_InvoicePeriod { get; set; }
		public string Inv_Ref { get; set; }
		public string Inv_ToAddress { get; set; }
		public string Inv_ToBU { get; set; }
		public string Inv_ToBUName { get; set; }
		public string Inv_ToCoC { get; set; }
		public string Inv_ToVATNumber { get; set; }
		public string Inv_RevCharge { get; set; }
		public string Inv_BottomLine { get; set; }
		public decimal Inv_TotalAmtChargedExcl { get; set; }
		public decimal Inv_TotalAmtSubjToVAT1 { get; set; }
		public decimal Inv_VatRate1 { get; set; }
		public decimal Inv_TotalAmtVAT1 { get; set; }
		public decimal Inv_TotalAmtSubjToVAT2 { get; set; }
		public decimal Inv_VatRate2 { get; set; }
		public decimal Inv_TotalAmtVAT2 { get; set; }
		public decimal Inv_TotalAmtVAT_E { get; set; }
		public decimal Inv_TotalAmtVAT_O { get; set; }
		public decimal Inv_TotalAmtVAT_R { get; set; }
		public decimal Inv_TotalAmtVAT_Z { get; set; }
		public decimal Inv_Total { get; set; }
		public decimal Inv_TotalCurrencyCharged { get; set; }
		public decimal Inv_TotalReceived { get; set; }
		public decimal Inv_TotalCurrencyReceived { get; set; }
		public decimal Inv_TotalUSD { get; set; }
		public string SAP_Image_base_Link { get; set; }
		public string Inv_Source_Type { get; set; }
		public string Inv_ToStatus { get; set; }
		public string Inv_FromStatus { get; set; }
		public string Inv_FromISB { get; set; }
		public string Inv_ToISB { get; set; }
		public string Inv_FromSAPCoCode { get; set; }
		public string Inv_ToSAPCoCode { get; set; }
		public string Inv_TradingPartnerSAP { get; set; }
		public string Inv_FromSystem { get; set; }
		public string Inv_ToSystem { get; set; }
		public string Inv_WeekNo { get; set; }
		public string Inv_Category { get; set; }
		public string Inv_JournalID { get; set; }
		public string Inv_FromDocProvided { get; set; }
		public string Inv_ToDocProvided { get; set; }
		public string Inv_FromValueDate { get; set; }
		public string Inv_ToValueDate { get; set; }
		public string Inv_QuarantineReason { get; set; }
		public DateTime created_date { get; set; }
		public DateTime updated_date { get; set; }
		public string created_by { get; set; }
		public string updated_by { get; set; }
		public string is_active { get; set; }
		public string is_deleted { get; set; }
	}
}
