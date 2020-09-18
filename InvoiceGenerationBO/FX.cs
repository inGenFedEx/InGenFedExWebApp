using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceGenerationBO
{
    public class FX
    {
		public int fx_id { get; set; }
		public string to_currency { get; set; }
		public string from_currency { get; set; }
		public string prior_rate_avg { get; set; }
		public string prior_rate_month { get; set; }
		public string month { get; set; }
		public string year { get; set; }
		public DateTime created_date { get; set; }
		public DateTime updated_date { get; set; }
		public string created_by { get; set; }
		public string updated_by { get; set; }
		public string is_active { get; set; }
		public string is_deleted { get; set; }
	}
}
