namespace System.Xml.Schema;

public class XmlSchemaAnnotation : XmlSchemaObject
{
	private string id; //Field offset: 0x20
	private XmlSchemaObjectCollection items; //Field offset: 0x24
	private XmlAttribute[] moreAttributes; //Field offset: 0x28

	[XmlAttribute("id", DataType = "ID")]
	public string Id
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	[XmlIgnore]
	internal virtual string IdAttribute
	{
		internal get { } //Length: 11
		internal set { } //Length: 27
	}

	[XmlElement("documentation", typeof(XmlSchemaDocumentation))]
	[XmlElement("appinfo", typeof(XmlSchemaAppInfo))]
	public XmlSchemaObjectCollection Items
	{
		 get { } //Length: 11
	}

	public XmlSchemaAnnotation() { }

	public string get_Id() { }

	internal virtual string get_IdAttribute() { }

	public XmlSchemaObjectCollection get_Items() { }

	public void set_Id(string value) { }

	internal virtual void set_IdAttribute(string value) { }

	internal virtual void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

}

