namespace System.Xml.Schema;

public class XmlSchemaNotation : XmlSchemaAnnotated
{
	private string name; //Field offset: 0x2C
	private string publicId; //Field offset: 0x30
	private string systemId; //Field offset: 0x34
	private XmlQualifiedName qname; //Field offset: 0x38

	[XmlAttribute("name")]
	public string Name
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	[XmlIgnore]
	internal virtual string NameAttribute
	{
		internal get { } //Length: 11
		internal set { } //Length: 27
	}

	[XmlAttribute("public")]
	public string Public
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	[XmlIgnore]
	internal XmlQualifiedName QualifiedName
	{
		internal get { } //Length: 11
		internal set { } //Length: 27
	}

	[XmlAttribute("system")]
	public string System
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public XmlSchemaNotation() { }

	public string get_Name() { }

	internal virtual string get_NameAttribute() { }

	public string get_Public() { }

	internal XmlQualifiedName get_QualifiedName() { }

	public string get_System() { }

	public void set_Name(string value) { }

	internal virtual void set_NameAttribute(string value) { }

	public void set_Public(string value) { }

	internal void set_QualifiedName(XmlQualifiedName value) { }

	public void set_System(string value) { }

}

