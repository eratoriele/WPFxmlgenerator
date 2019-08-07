namespace plate
{
    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Config2
    {

        private ConfigController[] controllerListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Controller", IsNullable = false)]
        public ConfigController[] ControllerList
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
    public partial class ConfigController
    {

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
