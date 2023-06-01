using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WS_Insurer_SGB.Models
{
    public class KPI_ISSUEPOLICY_DELIVERYADDRESS
    {
        public string house_number { get; set; }
        public string village { get; set; }
        public string soi { get; set; }
        public string moo { get; set; }
        public string road { get; set; }
        public string subdistrict_code { get; set; }
        public string subdistrict { get; set; }
        public string district_code { get; set; }
        public string district { get; set; }
        public string province_code { get; set; }
        public string province { get; set; }
        public string postcode { get; set; }
    }
}