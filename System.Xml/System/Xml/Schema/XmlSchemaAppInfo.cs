namespace System.Xml.Schema;

public class XmlSchemaAppInfo : XmlSchemaObject
{
	private string source; //Field offset: 0x20
	private XmlNode[] markup; //Field offset: 0x24

	[XmlAnyElement]
	[XmlText]
	public XmlNode[] Markup
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	[XmlAttribute("source", DataType = "anyURI")]
	public string Source
	{
		 set { } //Length: 27
	}

	public XmlSchemaAppInfo() { }

	public XmlNode[] get_Markup() { }

	public void set_Markup(XmlNode[] value) { }

	public void set_Source(string value) { }

}

