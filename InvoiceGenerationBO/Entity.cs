using System;

namespace InvoiceGenerationBO
{
	public class Entity
	{
		public long entity_id { get; set; }
		public string icr_code { get; set; }
		public string rbc_code { get; set; }
		public string sap_company_code { get; set; }
		public string ols_code { get; set; }
		public string system_currency { get; set; }
		public string search_name { get; set; }
		public string legal_entity_name { get; set; }
		public string joint_venture_name { get; set; }
		public string icr_address_line_1 { get; set; }
		public string icr_address_line_2 { get; set; }
		public string icr_address_line_3 { get; set; }
		public string icr_address_line_4 { get; set; }
		public string icr_address_line_5 { get; set; }
		public string icr_address_line_6 { get; set; }
		public string vat_number { get; set; }
		public string chamber_of_commerce_number { get; set; }
		public string contact_name { get; set; }
		public string contact_phone_number { get; set; }
		public string contact_fax_number { get; set; }
		public string contact_email_address { get; set; }
		public string fa_manager { get; set; }
		public string bank_account_type { get; set; }
		public string bmg_bank_account_name { get; set; }
		public string bmg_bank_account_number { get; set; }
		public string bmg_it2_party_code { get; set; }
		public string bmg_it2_account_code { get; set; }
		public string bmg_currency { get; set; }
		public string ing_bank_account_name { get; set; }
		public string ing_bank_account_number { get; set; }
		public string ing_entity_location { get; set; }
		public string other_bank_account_name { get; set; }
		public string other_bank_account_name2 { get; set; }
		public string other_bankaccount_currency { get; set; }
		public string other_swift_code { get; set; }
		public string other_correspondent_bank { get; set; }
		public string other_swift_code_correspondent { get; set; }
		public string bottom_line_message { get; set; }
		public string reversed_charge_message { get; set; }
		public string z_rate_message { get; set; }
		public string invoice_number { get; set; }
		public string invoice_name { get; set; }
		public string miscellaneous_text { get; set; }
		public string icr_number { get; set; }
		public string no_outbound_approval { get; set; }
		public string no_inbound_invoicing { get; set; }
		public string inbound_approval_required { get; set; }
		public string exclude_from_back_up_file_upload { get; set; }
		public string sap_pending_account { get; set; }
		public string sap_vendor_account { get; set; }
		public string sap_customer_account { get; set; }
		public string it2_party_bank_code { get; set; }
		public string header_line { get; set; }
		public string settlement_type { get; set; }
		public string entity_type { get; set; }
		public DateTime created_date { get; set; }
		public DateTime updated_date { get; set; }
		public string created_by { get; set; }
		public string updated_by { get; set; }
		public string is_active { get; set; }
		public string is_deleted { get; set; }

	}
}
