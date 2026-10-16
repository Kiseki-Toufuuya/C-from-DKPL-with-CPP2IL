namespace System.Xml.Schema;

public class XmlSchemaAnnotated : XmlSchemaObject
{
	private string id; //Field offset: 0x20
	private XmlSchemaAnnotation annotation; //Field offset: 0x24
	private XmlAttribute[] moreAttributes; //Field offset: 0x28

	[XmlElement("annotation", typeof(XmlSchemaAnnotation))]
	public XmlSchemaAnnotation Annotation
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

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

	[XmlAnyAttribute]
	public XmlAttribute[] UnhandledAttributes
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public XmlSchemaAnnotated() { }

	internal virtual void AddAnnotation(XmlSchemaAnnotation annotation) { }

	public XmlSchemaAnnotation get_Annotation() { }

	public string get_Id() { }

	internal virtual string get_IdAttribute() { }

	public XmlAttribute[] get_UnhandledAttributes() { }

	public void set_Annotation(XmlSchemaAnnotation value) { }

	public void set_Id(string value) { }

	internal virtual void set_IdAttribute(string value) { }

	public void set_UnhandledAttributes(XmlAttribute[] value) { }

	internal virtual void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

}

