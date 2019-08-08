
// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
using System.Collections.Generic;
using System.Xml.Serialization;
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class Topology
{
    [XmlIgnore]
    [System.ComponentModel.DataAnnotations.Key]
    public int ID { get; set; }

    private List<TopologyFloor> floorsField;

    private List<TopologyGroup> groupsField;

    private TopologyDataservers dataserversField;

    private List<TopologyBehaviour> behavioursField;

    private List<TopologyController> controllersField;

    private List<TopologyDisplay> displaysField;

    private TopologyFileInfo fileInfoField;

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Floor", IsNullable = false)]
    public List<TopologyFloor> Floors
    {
        get
        {
            return this.floorsField;
        }
        set
        {
            this.floorsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Group", IsNullable = false)]
    public List<TopologyGroup> Groups
    {
        get
        {
            return this.groupsField;
        }
        set
        {
            this.groupsField = value;
        }
    }

    /// <remarks/>
    public TopologyDataservers Dataservers
    {
        get
        {
            return this.dataserversField;
        }
        set
        {
            this.dataserversField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Behaviour", IsNullable = false)]
    public List<TopologyBehaviour> Behaviours
    {
        get
        {
            return this.behavioursField;
        }
        set
        {
            this.behavioursField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Controller", IsNullable = false)]
    public List<TopologyController> Controllers
    {
        get
        {
            return this.controllersField;
        }
        set
        {
            this.controllersField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Display", IsNullable = false)]
    public List<TopologyDisplay> Displays
    {
        get
        {
            return this.displaysField;
        }
        set
        {
            this.displaysField = value;
        }
    }

    /// <remarks/>
    public TopologyFileInfo FileInfo
    {
        get
        {
            return this.fileInfoField;
        }
        set
        {
            this.fileInfoField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class TopologyFloor
{
    [XmlIgnore]
    [System.ComponentModel.DataAnnotations.Key]
    public int ID { get; set; }

    private string nameField;

    private string mapPathField;

    private byte orderField;

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
    public string MapPath
    {
        get
        {
            return this.mapPathField;
        }
        set
        {
            this.mapPathField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte Order
    {
        get
        {
            return this.orderField;
        }
        set
        {
            this.orderField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class TopologyGroup
{

    private string nameField;

    private byte typeField;

    [System.ComponentModel.DataAnnotations.Key]
    private byte idField;

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
    public byte Type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte Id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class TopologyDataservers
{
    [XmlIgnore]
    [System.ComponentModel.DataAnnotations.Key]
    public int ID { get; set; }

    private TopologyDataserversDataserver dataserverField;

    /// <remarks/>
    public TopologyDataserversDataserver Dataserver
    {
        get
        {
            return this.dataserverField;
        }
        set
        {
            this.dataserverField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class TopologyDataserversDataserver
{
    private string ipField;

    private string nameField;

    [System.ComponentModel.DataAnnotations.Key]
    private byte idField;

    /// <remarks/>
    public string Ip
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
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte Id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class TopologyBehaviour
{
    private string nameField;

    private byte typeField;

    private string startDateField;

    private System.DateTime endDateField;

    private byte dailyActivityField;

    private TopologyBehaviourTimeRows timeRowsField;

    [System.ComponentModel.DataAnnotations.Key]
    private byte idField;

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
    public byte Type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    public string StartDate
    {
        get
        {
            return this.startDateField;
        }
        set
        {
            this.startDateField = value;
        }
    }

    /// <remarks/>
    public System.DateTime EndDate
    {
        get
        {
            return this.endDateField;
        }
        set
        {
            this.endDateField = value;
        }
    }

    /// <remarks/>
    public byte DailyActivity
    {
        get
        {
            return this.dailyActivityField;
        }
        set
        {
            this.dailyActivityField = value;
        }
    }

    /// <remarks/>
    public TopologyBehaviourTimeRows TimeRows
    {
        get
        {
            return this.timeRowsField;
        }
        set
        {
            this.timeRowsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte Id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class TopologyBehaviourTimeRows
{
    [XmlIgnore]
    [System.ComponentModel.DataAnnotations.Key]
    public int ID { get; set; }

    private TopologyBehaviourTimeRowsTimeRow timeRowField;

    /// <remarks/>
    public TopologyBehaviourTimeRowsTimeRow TimeRow
    {
        get
        {
            return this.timeRowField;
        }
        set
        {
            this.timeRowField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class TopologyBehaviourTimeRowsTimeRow
{
    [XmlIgnore]
    [System.ComponentModel.DataAnnotations.Key]
    public int ID { get; set; }

    private System.DateTime timeField;

    private bool statusField;

    private byte orderField;

    /// <remarks/>
    public System.DateTime Time
    {
        get
        {
            return this.timeField;
        }
        set
        {
            this.timeField = value;
        }
    }

    /// <remarks/>
    public bool Status
    {
        get
        {
            return this.statusField;
        }
        set
        {
            this.statusField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte Order
    {
        get
        {
            return this.orderField;
        }
        set
        {
            this.orderField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class TopologyController
{
    private string ipField;

    private string nameField;

    private byte dataserverIdField;

    private byte groupIdField;

    private byte floorOrderField;

    private List<TopologyControllerCamera> camerasField;

    [System.ComponentModel.DataAnnotations.Key]
    private byte idField;

    /// <remarks/>
    public string Ip
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
    public byte DataserverId
    {
        get
        {
            return this.dataserverIdField;
        }
        set
        {
            this.dataserverIdField = value;
        }
    }

    /// <remarks/>
    public byte GroupId
    {
        get
        {
            return this.groupIdField;
        }
        set
        {
            this.groupIdField = value;
        }
    }

    /// <remarks/>
    public byte FloorOrder
    {
        get
        {
            return this.floorOrderField;
        }
        set
        {
            this.floorOrderField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Camera", IsNullable = false)]
    public List<TopologyControllerCamera> Cameras
    {
        get
        {
            return this.camerasField;
        }
        set
        {
            this.camerasField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte Id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class TopologyControllerCamera
{
    [XmlIgnore]
    [System.ComponentModel.DataAnnotations.Key]
    public int ID { get; set; }

    private string nameField;

    private string axleField;

    private List<TopologyControllerCameraSpace> spacesField;

    private byte orderField;

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
    public string Axle
    {
        get
        {
            return this.axleField;
        }
        set
        {
            this.axleField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Space", IsNullable = false)]
    public List<TopologyControllerCameraSpace> Spaces
    {
        get
        {
            return this.spacesField;
        }
        set
        {
            this.spacesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte Order
    {
        get
        {
            return this.orderField;
        }
        set
        {
            this.orderField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class TopologyControllerCameraSpace
{
    [XmlIgnore]
    [System.ComponentModel.DataAnnotations.Key]
    public int ID { get; set; }

    private string nameField;

    private TopologyControllerCameraSpaceMapLocation mapLocationField;

    private byte behaviourIdField;

    private byte orderField;

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
    public TopologyControllerCameraSpaceMapLocation MapLocation
    {
        get
        {
            return this.mapLocationField;
        }
        set
        {
            this.mapLocationField = value;
        }
    }

    /// <remarks/>
    public byte BehaviourId
    {
        get
        {
            return this.behaviourIdField;
        }
        set
        {
            this.behaviourIdField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte Order
    {
        get
        {
            return this.orderField;
        }
        set
        {
            this.orderField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class TopologyControllerCameraSpaceMapLocation
{
    [XmlIgnore]
    [System.ComponentModel.DataAnnotations.Key]
    public int ID { get; set; }

    private byte xField;

    private byte yField;

    private byte angleField;

    private byte zoomLevelField;

    /// <remarks/>
    public byte X
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    public byte Y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    public byte Angle
    {
        get
        {
            return this.angleField;
        }
        set
        {
            this.angleField = value;
        }
    }

    /// <remarks/>
    public byte ZoomLevel
    {
        get
        {
            return this.zoomLevelField;
        }
        set
        {
            this.zoomLevelField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class TopologyDisplay
{
    private string ipField;

    private string nameField;

    private object axleField;

    private byte typeField;

    private byte typeValueField;

    private TopologyDisplayMapLocation mapLocationField;

    private byte floorOrderField;

    private byte groupIdField;

    private List<TopologyDisplayZone> zonesField;

    [System.ComponentModel.DataAnnotations.Key]
    private byte idField;

    /// <remarks/>
    public string Ip
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
    public object Axle
    {
        get
        {
            return this.axleField;
        }
        set
        {
            this.axleField = value;
        }
    }

    /// <remarks/>
    public byte Type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    public byte TypeValue
    {
        get
        {
            return this.typeValueField;
        }
        set
        {
            this.typeValueField = value;
        }
    }

    /// <remarks/>
    public TopologyDisplayMapLocation MapLocation
    {
        get
        {
            return this.mapLocationField;
        }
        set
        {
            this.mapLocationField = value;
        }
    }

    /// <remarks/>
    public byte FloorOrder
    {
        get
        {
            return this.floorOrderField;
        }
        set
        {
            this.floorOrderField = value;
        }
    }

    /// <remarks/>
    public byte GroupId
    {
        get
        {
            return this.groupIdField;
        }
        set
        {
            this.groupIdField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Zone", IsNullable = false)]
    public List<TopologyDisplayZone> Zones
    {
        get
        {
            return this.zonesField;
        }
        set
        {
            this.zonesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte Id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class TopologyDisplayMapLocation
{
    [XmlIgnore]
    [System.ComponentModel.DataAnnotations.Key]
    public int ID { get; set; }

    private byte xField;

    private byte yField;

    private byte angleField;

    private byte zoomLevelField;

    /// <remarks/>
    public byte X
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    public byte Y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    public byte Angle
    {
        get
        {
            return this.angleField;
        }
        set
        {
            this.angleField = value;
        }
    }

    /// <remarks/>
    public byte ZoomLevel
    {
        get
        {
            return this.zoomLevelField;
        }
        set
        {
            this.zoomLevelField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class TopologyDisplayZone
{
    [XmlIgnore]
    [System.ComponentModel.DataAnnotations.Key]
    public int ID { get; set; }

    private byte typeField;

    private List<TopologyDisplayZoneZoneMember> zoneMembersField;

    /// <remarks/>
    public byte Type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("ZoneMember", IsNullable = false)]
    public List<TopologyDisplayZoneZoneMember> ZoneMembers
    {
        get
        {
            return this.zoneMembersField;
        }
        set
        {
            this.zoneMembersField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class TopologyDisplayZoneZoneMember
{
    [XmlIgnore]
    [System.ComponentModel.DataAnnotations.Key]
    public int ID { get; set; }

    private ushort controllerIdField;

    /// <remarks/>
    public ushort ControllerId
    {
        get
        {
            return this.controllerIdField;
        }
        set
        {
            this.controllerIdField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class TopologyFileInfo
{
    [XmlIgnore]
    [System.ComponentModel.DataAnnotations.Key]
    public int ID { get; set; }

    private string hashField;

    private string modifyTimeField;

    /// <remarks/>
    public string Hash
    {
        get
        {
            return this.hashField;
        }
        set
        {
            this.hashField = value;
        }
    }

    /// <remarks/>
    public string ModifyTime
    {
        get
        {
            return this.modifyTimeField;
        }
        set
        {
            this.modifyTimeField = value;
        }
    }
}

