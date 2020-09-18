using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceGenerationBO
{
	public class Auto1Source
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
		public string From_BU_Amount { get; set; }
		public decimal To_BU_Amount { get; set; }
		public string VAT_Type { get; set; }
		public decimal VAT_Rate { get; set; }
		public decimal From_BU_VAT_Amount { get; set; }
		public decimal To_BU_VAT_Amount { get; set; }
		public DateTime Created_Date { get; set; }
	}
}
