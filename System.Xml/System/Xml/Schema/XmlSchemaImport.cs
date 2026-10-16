namespace System.Xml.Schema;

public class XmlSchemaImport : XmlSchemaExternal
{
	private string ns; //Field offset: 0x38
	private XmlSchemaAnnotation annotation; //Field offset: 0x3C

	[XmlAttribute("namespace", DataType = "anyURI")]
	public string Namespace
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public XmlSchemaImport() { }

	internal virtual void AddAnnotation(XmlSchemaAnnotation annotation) { }

	public string get_Namespace() { }

	public void set_Namespace(string value) { }

}

