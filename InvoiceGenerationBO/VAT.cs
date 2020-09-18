using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceGenerationBO
{
    public class VAT
    {
        public string legal_entity_name { get; set; }
        public string le_id { get; set; }
        public string vat_code { get; set; }
        public decimal percentage { get; set; }
        public string description { get; set; }
        public DateTime created_date { get; set; }
        public DateTime updated_date { get; set; }
        public string created_by { get; set; }
        public string updated_by { get; set; }
        public string is_active { get; set; }
        public string is_deleted { get; set; }
    }
}
