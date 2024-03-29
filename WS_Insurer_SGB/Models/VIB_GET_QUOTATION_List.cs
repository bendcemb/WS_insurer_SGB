﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WS_Insurer_SGB.Models
{
    public class VIB_GET_QUOTATION_List
    {
        
        public string quotationNumber { get; set; }
        public string carBrand { get; set; }
        public string carModel { get; set; }
        public string carSubModel { get; set; }

        public string registrationYear { get; set; }
        public string vehicleTypeCode { get; set; }

        public string engineCC { get; set; }
        public string packageCode { get; set; }
        public string packageName { get; set; }
        public string insuranceType { get; set; }
		public string insuranceTypeName { get; set; }
		public string repairType { get; set; }
        public VIB_GET_QUOTATION_LIABILITY liability { get; set; }
        public VIB_GET_QUOTATION_OWNDAMAGE ownDamage { get; set; }

        public List<VIB_GET_QUOTATION_ADDITIONALNAMESPERIL> additionalNamesPeril { get; set; }

        public List<VIB_GET_QUOTATION_ADDITIONALCOVERAGE> additionalCoverage { get; set; }

        public string terrorismExclusion { get; set; }

        public string ageRange { get; set; }
        public string netPremium { get; set; }
        public string stamp { get; set; }
        public string vat { get; set; }
        public string totalPremium { get; set; }
    }
}