using CsvHelper.Configuration;
using System;

namespace InvoiceGenerationBO
{
    public class P2Source
	{
		public string Inv_Date { get; set; }
		public string Year { get; set; }
		public string Period { get; set; }
		public string Inv_FromSystem { get; set; }
		public string Inv_ToSystem { get; set; }
		public string From_BU { get; set; }
		public string From_BU_Currency { get; set; }
		public string To_BU { get; set; }
		public string To_BU_Currency { get; set; }
		public string FromISB { get; set; }
		public string ToISB { get; set; }
		public string TransCategory { get; set; }
		public string Description { get; set; }
		public string Nominal_Code { get; set; }
		public string Journal_ID { get; set; }
		public string Source { get; set; }
		public string From_BU_LE_Address { get; set; }
		public string From_BU_LE_Name { get; set; }
		public string From_BU_CoC { get; set; }
		public string From_BU_VAT_Number { get; set; }
		public string To_BU_LE_Address { get; set; }
		public string To_BU_LE_Name { get; set; }
		public string To_BU_CoC { get; set; }
		public string To_BU_VAT_Number { get; set; }
		public decimal From_BU_Amount { get; set; }
		public decimal To_BU_Amount { get; set; }
		public string VAT_Type { get; set; }
		public decimal VAT_Rate { get; set; }
		public decimal From_BU_VAT_Amount { get; set; }
		public decimal To_BU_VAT_Amount { get; set; }
		public DateTime Created_Date { get; set; }
	}

	public sealed class P2SourceMap : ClassMap<P2Source>
	{
		public P2SourceMap()
		{
			Map(m => m.Inv_Date).Name("Inv_Date");
			Map(m => m.Year).Name("Year");
			Map(m => m.Period).Name("Period");
			Map(m => m.Inv_FromSystem).Name("Inv_FromSystem");
			Map(m => m.Inv_ToSystem).Name("Inv_ToSystem");
			Map(m => m.From_BU).Name("From BU");
			Map(m => m.From_BU_Currency).Name("From BU Currency");
			Map(m => m.To_BU).Name("To BU");
			Map(m => m.To_BU_Currency).Name("To BU Currency");
			Map(m => m.FromISB).Name("FromISB");
			Map(m => m.ToISB).Name("ToISB");
			Map(m => m.TransCategory).Name("TransCategory");
			Map(m => m.Description).Name("Description");
			Map(m => m.Nominal_Code).Name("Nominal Code");
			Map(m => m.Journal_ID).Name("Journal ID");
			Map(m => m.Source).Name("Source");
			Map(m => m.From_BU_LE_Address).Name("From BU.LE Address");
			Map(m => m.From_BU_LE_Name).Name("From BU.LE Name");
			Map(m => m.From_BU_CoC).Name("From BU.CoC");
			Map(m => m.From_BU_VAT_Number).Name("From BU.VAT Number");
			Map(m => m.To_BU_LE_Address).Name("To BU.LE Address");
			Map(m => m.To_BU_LE_Name).Name("To BU.LE Name");
			Map(m => m.To_BU_CoC).Name("To BU.CoC");
			Map(m => m.To_BU_VAT_Number).Name("To BU.VAT Number");
			Map(m => m.From_BU_Amount).Name("From BU Amount");
			Map(m => m.To_BU_Amount).Name("To BU Amount");
			Map(m => m.VAT_Type).Name("VAT Type");
			Map(m => m.VAT_Rate).Name("VAT Rate");
			Map(m => m.From_BU_VAT_Amount).Name("From BU VAT Amount");
			Map(m => m.To_BU_VAT_Amount).Name("To BU VAT Amount");
			Map(m => m.Created_Date).Optional().Default(DateTime.Now);
		}
	}

}
