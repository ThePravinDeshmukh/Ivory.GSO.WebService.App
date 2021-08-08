using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivory.GSO.WebService.Repository.Model
{



    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "https://webservice.meteologica.com/api/MeteologicaDataExchangeService.php")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "https://webservice.meteologica.com/api/MeteologicaDataExchangeService.php", IsNullable = false)]
    public partial class getForecastMultiResponse
    {

        private @return returnField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public @return @return
        {
            get
            {
                return this.returnField;
            }
            set
            {
                this.returnField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class @return
    {

        private string errorCodeField;

        private string variableIdField;

        private string predictorIdField;

        private byte granularityField;

        private byte percentilesField;

        private returnFacilitiesForecastData facilitiesForecastDataField;

        private returnHeader headerField;

        /// <remarks/>
        public string errorCode
        {
            get
            {
                return this.errorCodeField;
            }
            set
            {
                this.errorCodeField = value;
            }
        }

        /// <remarks/>
        public string variableId
        {
            get
            {
                return this.variableIdField;
            }
            set
            {
                this.variableIdField = value;
            }
        }

        /// <remarks/>
        public string predictorId
        {
            get
            {
                return this.predictorIdField;
            }
            set
            {
                this.predictorIdField = value;
            }
        }

        /// <remarks/>
        public byte granularity
        {
            get
            {
                return this.granularityField;
            }
            set
            {
                this.granularityField = value;
            }
        }

        /// <remarks/>
        public byte percentiles
        {
            get
            {
                return this.percentilesField;
            }
            set
            {
                this.percentilesField = value;
            }
        }

        /// <remarks/>
        public returnFacilitiesForecastData facilitiesForecastData
        {
            get
            {
                return this.facilitiesForecastDataField;
            }
            set
            {
                this.facilitiesForecastDataField = value;
            }
        }

        /// <remarks/>
        public returnHeader header
        {
            get
            {
                return this.headerField;
            }
            set
            {
                this.headerField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class returnFacilitiesForecastData
    {

        private returnFacilitiesForecastDataItem itemField;

        /// <remarks/>
        public returnFacilitiesForecastDataItem item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class returnFacilitiesForecastDataItem
    {

        private string forecastDateField;

        private string facilityIdField;

        private string forecastDataField;

        /// <remarks/>
        public string forecastDate
        {
            get
            {
                return this.forecastDateField;
            }
            set
            {
                this.forecastDateField = value;
            }
        }

        /// <remarks/>
        public string facilityId
        {
            get
            {
                return this.facilityIdField;
            }
            set
            {
                this.facilityIdField = value;
            }
        }

        /// <remarks/>
        public string forecastData
        {
            get
            {
                return this.forecastDataField;
            }
            set
            {
                this.forecastDataField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class returnHeader
    {

        private string sessionTokenField;

        private string errorCodeField;

        /// <remarks/>
        public string sessionToken
        {
            get
            {
                return this.sessionTokenField;
            }
            set
            {
                this.sessionTokenField = value;
            }
        }

        /// <remarks/>
        public string errorCode
        {
            get
            {
                return this.errorCodeField;
            }
            set
            {
                this.errorCodeField = value;
            }
        }
    }


}
