using System;

namespace InvoiceGenerationBO
{
	public class UserEntity
	{
		public string user_id { get; set; }
		public string entity_id { get; set; }
		public string entity_code { get; set; }
		public string entity_type { get; set; }
		public DateTime created_date { get; set; }
		public DateTime updated_date { get; set; }
		public string created_by { get; set; }
		public string updated_by { get; set; }
		public string is_active { get; set; }
		public string is_deleted { get; set; }
	}
}
