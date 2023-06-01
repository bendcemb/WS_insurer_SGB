using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WS_Insurer_SGB.Models
{
    public class KPI_GET_QUOTATION_COVERAGE
    {
        public string amtPremium { get; set; }
        public string coverageAmt { get; set; }
        public string coverageCode { get; set; }
        public string coverageId { get; set; }
        public string coverageNameEn { get; set; }
        public string coverageNameTh { get; set; }
        public bool coverageNumberChk { get; set; }
        public bool coveragePriority { get; set; }
        public string coverageRate { get; set; }
        public string coverageSequenceNo { get; set; }
        public string coverageShortNameEn { get; set; }
        public string coverageShortNameTh { get; set; }
        public string coverageUnit { get; set; }
        public string coverageWord { get; set; }
        public int passengerTotal { get; set; }
    }
}