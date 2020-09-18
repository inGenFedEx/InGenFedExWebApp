using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceGenerationBO
{
    public class USERS
    {
		public string user_id { get; set; }
		public string user_source_system { get; set; }
		public string name { get; set; }
		public string email { get; set; }
		public string accept_transactions_and_request_credit { get; set; }
		public string settle_invoices { get; set; }
		public string reporting_workbooks { get; set; }
		public string initiate_rpa_processes { get; set; }
		public string dataflow_admin { get; set; }
		public string platform_user_administrator { get; set; }
		public string maintain_period_common_request { get; set; }
		public string attach_documents { get; set; }
		public DateTime created_date { get; set; }
		public DateTime updated_date { get; set; }
		public string created_by { get; set; }
		public string updated_by { get; set; }
		public string is_active { get; set; }
		public string is_deleted { get; set; }
	}
}
