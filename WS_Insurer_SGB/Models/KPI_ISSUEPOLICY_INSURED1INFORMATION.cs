using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WS_Insurer_SGB.Models
{
    public class KPI_ISSUEPOLICY_INSURED1INFORMATION
    {
        public string type { get; set; }
        public string id_card_type { get; set; }
        public string id_card_number { get; set; }
        public string title_code { get; set; }
        public string title { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string birthdate { get; set; }
        public string email { get; set; }
        public string mobile_no { get; set; }
        public string nationality { get; set; }
        public string social_id { get; set; }
        public string sex { get; set; }
        public string marital_status { get; set; }
        public string occupation_code { get; set; }
        public KPI_ISSUEPOLICY_INSUREDADDRES insured_address { get; set; }
    }
}