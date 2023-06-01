using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WS_Insurer_SGB.Models
{
    public class M_OUTPUT_ALL_INSURANCE_DATA
    {
        
        public string priceListCode { get; set; }
        public string priceListName { get; set; }
        public string insuranceCompany { get; set; }
        public string carNo { get; set; }
        public string carBrand { get; set; }
        public string carModel { get; set; }
        public string carEngineCC { get; set; }
        public string carRegisYear { get; set; }
        public string carFixType { get; set; }
        public string carInsuranceType { get; set; }
		public string carInsuranceTypeName { get; set; }
		public string sumInsuranceAMT { get; set; }
        public string premiumInsuranceAMT { get; set; }
        public string stampInsuranceTotal { get; set; }
        public string vatInsuranceTotal { get; set; }
        public string premiumInsuranceTotal { get; set; }
        public string bodyPersonAMT { get; set; }
        public string accidentPersonAMT { get; set; }
        public string propertiesPersonAMT { get; set; }
        public string thieftAMT { get; set; }
        public string fireAMT { get; set; }
        public string floodAMT { get; set; }
        public string PackacarDecitibleAMTge_code { get; set; }
        public string personalAccidentAMT { get; set; }
        public string accidentDrive { get; set; }
        public string acidentPassenger { get; set; }
        public string disibilityAMT { get; set; }
        public string disibilityDriver { get; set; }
        public string disibilityPassenger { get; set; }
        public string medicalExpenseAMT { get; set; }
        public string bailBondAMT { get; set; }
        public string effectiveDate { get; set; }
        public string expireDate { get; set; }
        public string carDecitibleAMT { get; set; }
    }
}