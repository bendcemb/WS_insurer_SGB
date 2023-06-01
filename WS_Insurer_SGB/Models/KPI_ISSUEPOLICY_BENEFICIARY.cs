using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WS_Insurer_SGB.Models
{
    public class KPI_ISSUEPOLICY_BENEFICIARY
    {
        public string sequence { get; set; }
        public string type { get; set; }
        public string title_code { get; set; }
        public string title { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string relation_code { get; set; }
        public string relation { get; set; }
        public string percent { get; set; }
    }
}