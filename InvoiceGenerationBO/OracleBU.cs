using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceGenerationBO
{
    public class OracleBU
    {
        public string business_unit { get; set; }
        public string tagging { get; set; }
        public string shorttag { get; set; }
        public DateTime created_date { get; set; }
        public DateTime updated_date { get; set; }
        public string created_by { get; set; }
        public string updated_by { get; set; }
        public string is_active { get; set; }
        public string is_deleted { get; set; }
    }
}
