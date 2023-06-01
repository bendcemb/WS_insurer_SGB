using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WS_Insurer_SGB.Models
{
    public class M_OUTPUT_JMI
    {
        public string status { get; set; }
        public string message { get; set; }
        public List<M_OUT_PUT_JMI_DATA> data { get; set; }
    }
}