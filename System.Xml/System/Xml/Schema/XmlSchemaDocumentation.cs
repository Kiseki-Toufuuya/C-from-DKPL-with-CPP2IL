namespace System.Xml.Schema;

public class XmlSchemaDocumentation : XmlSchemaObject
{
	private static XmlSchemaSimpleType languageType; //Field offset: 0x0
	private string source; //Field offset: 0x20
	private string language; //Field offset: 0x24
	private XmlNode[] markup; //Field offset: 0x28

	[XmlAttribute("xml:lang")]
	public string Language
	{
		 set { } //Length: 192
	}

	[XmlAnyElement]
	[XmlText]
	public XmlNode[] Markup
	{
		 set { } //Length: 27
	}

	[XmlAttribute("source", DataType = "anyURI")]
	public string Source
	{
		 set { } //Length: 27
	}

	private static XmlSchemaDocumentation() { }

	public XmlSchemaDocumentation() { }

	public void set_Language(string value) { }

	public void set_Markup(XmlNode[] value) { }

	public void set_Source(string value) { }

}

