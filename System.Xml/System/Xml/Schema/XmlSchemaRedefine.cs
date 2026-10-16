namespace System.Xml.Schema;

public class XmlSchemaRedefine : XmlSchemaExternal
{
	private XmlSchemaObjectCollection items; //Field offset: 0x38
	private XmlSchemaObjectTable attributeGroups; //Field offset: 0x3C
	private XmlSchemaObjectTable types; //Field offset: 0x40
	private XmlSchemaObjectTable groups; //Field offset: 0x44

	[XmlIgnore]
	public XmlSchemaObjectTable AttributeGroups
	{
		 get { } //Length: 11
	}

	[XmlIgnore]
	public XmlSchemaObjectTable Groups
	{
		 get { } //Length: 11
	}

	[XmlElement("annotation", typeof(XmlSchemaAnnotation))]
	[XmlElement("complexType", typeof(XmlSchemaComplexType))]
	[XmlElement("group", typeof(XmlSchemaGroup))]
	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroup))]
	public XmlSchemaObjectCollection Items
	{
		 get { } //Length: 11
	}

	[XmlIgnore]
	public XmlSchemaObjectTable SchemaTypes
	{
		 get { } //Length: 11
	}

	public XmlSchemaRedefine() { }

	internal virtual void AddAnnotation(XmlSchemaAnnotation annotation) { }

	public XmlSchemaObjectTable get_AttributeGroups() { }

	public XmlSchemaObjectTable get_Groups() { }

	public XmlSchemaObjectCollection get_Items() { }

	public XmlSchemaObjectTable get_SchemaTypes() { }

}

