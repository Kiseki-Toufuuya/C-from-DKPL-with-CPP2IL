namespace System.Xml.Schema;

public class XmlSchemaSimpleType : XmlSchemaType
{
	private XmlSchemaSimpleTypeContent content; //Field offset: 0x54

	[XmlElement("restriction", typeof(XmlSchemaSimpleTypeRestriction))]
	[XmlElement("list", typeof(XmlSchemaSimpleTypeList))]
	[XmlElement("union", typeof(XmlSchemaSimpleTypeUnion))]
	public XmlSchemaSimpleTypeContent Content
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public XmlSchemaSimpleType() { }

	internal virtual XmlSchemaObject Clone() { }

	public XmlSchemaSimpleTypeContent get_Content() { }

	public void set_Content(XmlSchemaSimpleTypeContent value) { }

}

