using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WS_Insurer_SGB.Models
{
    public class KPI_GET_QUOTATION
    {
        public class CoverageList
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
        public class Plan
        {
            public string brand { get; set; }
            public int carGroup { get; set; }
            public string carManufactureMonth { get; set; }
            public string carManufactureYear { get; set; }
            public string carYearNickName { get; set; }
            public List<KPI_GET_QUOTATION_COVERAGE> coverageList { get; set; }
            public string create_datetime { get; set; }
            public string create_tag { get; set; }
            public string displayNameEn { get; set; }
            public string displayNameTh { get; set; }
            public string engineCapacity { get; set; }
            public string generator_sha { get; set; }
            public string goodRetail { get; set; }
            public string grossVehicleMass { get; set; }
            public string insuranceCode { get; set; }
            public string insuranceType { get; set; }
            public string insuredVehicleSymbol2 { get; set; }
            public string ldFactPa02Amt { get; set; }
            public string model { get; set; }
            public string motorClass { get; set; }
            public List<string> msg_tag { get; set; }
            public int mv01CoverageMax { get; set; }
            public int mv01CoverageMin { get; set; }
            public int mv05Text { get; set; }
            public int mvNon1CoverageMax { get; set; }
            public int mvNon1CoverageMin { get; set; }
            public bool obsolete { get; set; }
            public string otherDiscountAmt { get; set; }
            public string packageType { get; set; }
            public List<KPI_GET_QUOTATION_PLANLIST> plan { get; set; }
            public string planNameEn { get; set; }
            public string planNameTh { get; set; }
            public bool primary { get; set; }
            public string productCode { get; set; }
            public string redbookDate { get; set; }
            public int refNumPolicy { get; set; }
            public string repairOption { get; set; }
            public string samplePolicy { get; set; }
            public string samplePolicy01 { get; set; }
            public string seatCapacity { get; set; }
            public double si { get; set; }
            public string subModel { get; set; }
            public string template_sha { get; set; }
            public string totalDisc { get; set; }
            public string transBasis { get; set; }
            public int transVat { get; set; }
            public string type { get; set; }
            public string vehicleKey { get; set; }
            public string vehicleTypeCode { get; set; }
            public string capacity { get; set; }
            public object effectiveDate { get; set; }
            public string enabled { get; set; }
            public string engineCode { get; set; }
            public string engineDescTh { get; set; }
            public object expiryDate { get; set; }
            public double netPrem { get; set; }
            public int netPrem1Year { get; set; }
            public int passenger { get; set; }
            public int percentPeriod { get; set; }
            public int period { get; set; }
            public string periodType { get; set; }
            public string planCode { get; set; }
            public bool recommend { get; set; }
            public int recommendedScore { get; set; }
            public int selectedScore { get; set; }
            public string sos { get; set; }
            public int stamp { get; set; }
            public int sumInsured { get; set; }
            public double totalPrem { get; set; }
            public double totalPrem1Year { get; set; }
            public string uuid { get; set; }
            public double vat { get; set; }
            public string vehicleCat { get; set; }
            public string vehicleCode { get; set; }
            public string vehicleTypeDisplayTh { get; set; }
            public string vehicleUse { get; set; }
            public bool visible { get; set; }
        }

        public class Result
        {
            public string resultCode { get; set; }
            public string resultMessage { get; set; }
            public int resultSize { get; set; }
        }

        public class PlanList
        {
            public List<Plan> plan { get; set; }
            public Result result { get; set; }
        }


    }
}