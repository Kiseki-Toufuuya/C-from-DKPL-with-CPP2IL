namespace System.Xml.Schema;

public class XmlSchemaSimpleContent : XmlSchemaContentModel
{
	private XmlSchemaContent content; //Field offset: 0x2C

	[XmlElement("extension", typeof(XmlSchemaSimpleContentExtension))]
	[XmlElement("restriction", typeof(XmlSchemaSimpleContentRestriction))]
	public virtual XmlSchemaContent Content
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public XmlSchemaSimpleContent() { }

	public virtual XmlSchemaContent get_Content() { }

	public virtual void set_Content(XmlSchemaContent value) { }

}

