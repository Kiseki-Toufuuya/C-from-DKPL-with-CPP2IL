namespace System.Xml.Schema;

public class XmlSchemaComplexContent : XmlSchemaContentModel
{
	private XmlSchemaContent content; //Field offset: 0x2C
	private bool isMixed; //Field offset: 0x30
	private bool hasMixedAttribute; //Field offset: 0x31

	[XmlElement("restriction", typeof(XmlSchemaComplexContentRestriction))]
	[XmlElement("extension", typeof(XmlSchemaComplexContentExtension))]
	public virtual XmlSchemaContent Content
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	[XmlIgnore]
	internal bool HasMixedAttribute
	{
		internal get { } //Length: 11
	}

	[XmlAttribute("mixed")]
	public bool IsMixed
	{
		 get { } //Length: 11
		 set { } //Length: 18
	}

	public XmlSchemaComplexContent() { }

	public virtual XmlSchemaContent get_Content() { }

	internal bool get_HasMixedAttribute() { }

	public bool get_IsMixed() { }

	public virtual void set_Content(XmlSchemaContent value) { }

	public void set_IsMixed(bool value) { }

}

