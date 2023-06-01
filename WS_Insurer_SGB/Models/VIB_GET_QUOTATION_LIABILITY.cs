using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WS_Insurer_SGB.Models
{
    public class VIB_GET_QUOTATION_LIABILITY
    {
        public string tpbiPerPerson { get; set; }
        public string tpbiPerEvent { get; set; }
        public string tppdPerEvent { get; set; }
        public string tppdDeductible { get; set; }

    }
}