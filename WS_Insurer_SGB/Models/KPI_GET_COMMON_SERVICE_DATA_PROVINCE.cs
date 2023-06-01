using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WS_Insurer_SGB.Models
{
    public class KPI_GET_COMMON_SERVICE_DATA_PROVINCE
    {

        public int count { get; set; }
        public List<KPI_GET_COMMON_SERVICE_DATA_PROVINCE_DATA> data { get; set; }
        public string _id { get; set; }
        public string code { get; set; }
        public DateTime created_at { get; set; }
        public string name { get; set; }
        public string postcode { get; set; }
        public string query_code { get; set; }
        public string title_en { get; set; }
        public string title_th { get; set; }
        public DateTime updated_at { get; set; }

    }
    public class KPI_GET_COMMON_SERVICE_DATA_PROVINCE_ROOT
    {
        public Status status { get; set; }
        public KPI_GET_COMMON_SERVICE_DATA_PROVINCE data { get; set; }
    }

    public class Status
    {
        public string code { get; set; }
        public string message { get; set; }
    }

}
