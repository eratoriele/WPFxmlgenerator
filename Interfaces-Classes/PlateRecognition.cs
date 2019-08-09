using System.Collections.Generic;
using System.Xml.Serialization;

namespace plate
{
    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false, ElementName = "Config")]
    public partial class ConfigP
    {
        [XmlIgnore]
        [System.ComponentModel.DataAnnotations.Key]
        public int ID { get; set; }

        private List<ConfigControllerP> controllerListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Controller", IsNullable = false)]
        public List<ConfigControllerP> ControllerList
        {
            get
            {
                return this.controllerListField;
            }
            set
            {
                this.controllerListField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ConfigControllerP
    {
        [XmlIgnore]
        [System.ComponentModel.DataAnnotations.Key]
        public int ID { get; set; }

        private string ipField;

        private string destinationPathField;

        /// <remarks/>
        public string IP
        {
            get
            {
                return this.ipField;
            }
            set
            {
                this.ipField = value;
            }
        }

        /// <remarks/>
        public string DestinationPath
        {
            get
            {
                return this.destinationPathField;
            }
            set
            {
                this.destinationPathField = value;
            }
        }
    }

}
