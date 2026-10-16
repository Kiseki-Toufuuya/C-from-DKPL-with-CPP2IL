namespace System.Xml.Schema;

public class XmlSchemaSimpleTypeList : XmlSchemaSimpleTypeContent
{
	private XmlQualifiedName itemTypeName; //Field offset: 0x2C
	private XmlSchemaSimpleType itemType; //Field offset: 0x30
	private XmlSchemaSimpleType baseItemType; //Field offset: 0x34

	[XmlIgnore]
	public XmlSchemaSimpleType BaseItemType
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	public XmlSchemaSimpleType ItemType
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	[XmlAttribute("itemType")]
	public XmlQualifiedName ItemTypeName
	{
		 get { } //Length: 11
		 set { } //Length: 135
	}

	public XmlSchemaSimpleTypeList() { }

	internal virtual XmlSchemaObject Clone() { }

	public XmlSchemaSimpleType get_BaseItemType() { }

	public XmlSchemaSimpleType get_ItemType() { }

	public XmlQualifiedName get_ItemTypeName() { }

	public void set_BaseItemType(XmlSchemaSimpleType value) { }

	public void set_ItemType(XmlSchemaSimpleType value) { }

	public void set_ItemTypeName(XmlQualifiedName value) { }

}

