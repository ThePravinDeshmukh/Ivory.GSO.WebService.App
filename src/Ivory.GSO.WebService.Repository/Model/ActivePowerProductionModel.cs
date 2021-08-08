using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivory.GSO.WebService.Repository.Model
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.xmlsoap.org/soap/envelope/", IsNullable = false)]
    public partial class Envelope
    {

        private EnvelopeBody bodyField;

        /// <remarks/>
        public EnvelopeBody Body
        {
            get
            {
                return this.bodyField;
            }
            set
            {
                this.bodyField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public partial class EnvelopeBody
    {

        private ActivePowerProductionResponse activePowerProductionResponseField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "LSS.solar.webservice")]
        public ActivePowerProductionResponse ActivePowerProductionResponse
        {
            get
            {
                return this.activePowerProductionResponseField;
            }
            set
            {
                this.activePowerProductionResponseField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "LSS.solar.webservice")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "LSS.solar.webservice", IsNullable = false)]
    public partial class ActivePowerProductionResponse
    {

        private string plantDescriptionField;

        private PlantForecastIntervalNode[] plantForecastIntervalsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://base.datacontract")]
        public string PlantDescription
        {
            get
            {
                return this.plantDescriptionField;
            }
            set
            {
                this.plantDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Namespace = "http://base.datacontract")]
        [System.Xml.Serialization.XmlArrayItemAttribute("PlantForecastIntervalNode", IsNullable = false)]
        public PlantForecastIntervalNode[] PlantForecastIntervals
        {
            get
            {
                return this.plantForecastIntervalsField;
            }
            set
            {
                this.plantForecastIntervalsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://base.datacontract")]
    public partial class PlantForecastIntervalNode
    {

        private System.DateTime intervalStartTimeField;

        private System.DateTime intervalEndTimeField;

        private byte intervalLengthField;

        private string forecastResultParameterField;

        private decimal forecastValueField;

        private string valueUnitField;

        /// <remarks/>
        public System.DateTime IntervalStartTime
        {
            get
            {
                return this.intervalStartTimeField;
            }
            set
            {
                this.intervalStartTimeField = value;
            }
        }

        /// <remarks/>
        public System.DateTime IntervalEndTime
        {
            get
            {
                return this.intervalEndTimeField;
            }
            set
            {
                this.intervalEndTimeField = value;
            }
        }

        /// <remarks/>
        public byte IntervalLength
        {
            get
            {
                return this.intervalLengthField;
            }
            set
            {
                this.intervalLengthField = value;
            }
        }

        /// <remarks/>
        public string ForecastResultParameter
        {
            get
            {
                return this.forecastResultParameterField;
            }
            set
            {
                this.forecastResultParameterField = value;
            }
        }

        /// <remarks/>
        public decimal ForecastValue
        {
            get
            {
                return this.forecastValueField;
            }
            set
            {
                this.forecastValueField = value;
            }
        }

        /// <remarks/>
        public string ValueUnit
        {
            get
            {
                return this.valueUnitField;
            }
            set
            {
                this.valueUnitField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://base.datacontract")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://base.datacontract", IsNullable = false)]
    public partial class PlantForecastIntervals
    {

        private PlantForecastIntervalNode[] plantForecastIntervalNodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PlantForecastIntervalNode")]
        public PlantForecastIntervalNode[] PlantForecastIntervalNode
        {
            get
            {
                return this.plantForecastIntervalNodeField;
            }
            set
            {
                this.plantForecastIntervalNodeField = value;
            }
        }
    }


}
