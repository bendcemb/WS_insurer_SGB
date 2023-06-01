using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WS_Insurer_SGB.Models
{
    public class VIB_GET_QUOTATION_PERSONACCIDENT
    {
        public string driverDeath { get; set; }
        public string passengerDeath { get; set; }
        public string numberPassengerDeath { get; set; }
        public string temporaryDisabilityDriver { get; set; }
        public string temporaryDisabilityPassenger { get; set; }
        public string numberPassengerTemporaryDisability { get; set; }

    }
}