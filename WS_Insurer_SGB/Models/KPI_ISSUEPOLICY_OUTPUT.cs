using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WS_Insurer_SGB.Models
{
    public class KPI_ISSUEPOLICY_OUTPUT
    {
        public class CmipolicyData
        {
            public string application_no { get; set; }
            public string policy_no { get; set; }
            public string policy_pdf { get; set; }
            public string policy_issuedate { get; set; }
            public string invoice_no { get; set; }
            public string invoice_date { get; set; }
            public string receipt_no { get; set; }
            public string receipt_date { get; set; }
            public DateTime created_at { get; set; }
        }

        public class Data
        {
            public CmipolicyData cmipolicy_data { get; set; }
            public string reference_no { get; set; }
            public VmipolicyData vmipolicy_data { get; set; }
        }

        public class KPI_Result
        {
            public Status status { get; set; }
            public Data data { get; set; }
        }

        public class Status
        {
            public string code { get; set; }
            public string message { get; set; }
        }

        public class VmipolicyData
        {
            public string application_no { get; set; }
            public string policy_no { get; set; }
            public string policy_pdf { get; set; }
            public string policy_issuedate { get; set; }
            public string invoice_no { get; set; }
            public string invoice_date { get; set; }
            public string receipt_no { get; set; }
            public string receipt_date { get; set; }
            public DateTime created_at { get; set; }
        }


    }
}