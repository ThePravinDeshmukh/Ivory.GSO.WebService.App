using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using SoapCore;

namespace Ivory.GSO.WebService.App
{
    [DataContract]
    public class MMFParameter
    {
        [DataMember]
        public DateTime MeasurementTime { get; set; }
        [DataMember]
        public string ResultParameter { get; set; }
        [DataMember]
        public string Unit { get; set; }
        [DataMember]
        public double MMF1 { get; set; }
        [DataMember]
        public double MMF2 { get; set; }
        [DataMember]
        public double MMF3 { get; set; }
    }
}