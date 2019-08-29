
// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
using System.Collections.Generic;
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class Addresses
{

    private List<AddressesAddress> addressListField = new List<AddressesAddress>();

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Address", IsNullable = false)]
    public List<AddressesAddress> AddressList
    {
        get
        {
            return this.addressListField;
        }
        set
        {
            this.addressListField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class AddressesAddress
{

    private string nameField;

    private string ipField;

    /// <remarks/>
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

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
}

