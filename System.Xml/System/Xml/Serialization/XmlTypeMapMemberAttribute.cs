namespace System.Xml.Serialization;

internal class XmlTypeMapMemberAttribute : XmlTypeMapMember
{
	private string _attributeName; //Field offset: 0x30
	private string _namespace; //Field offset: 0x34
	private XmlSchemaForm _form; //Field offset: 0x38
	private XmlTypeMapping _mappedType; //Field offset: 0x3C

	public string AttributeName
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public XmlSchemaForm Form
	{
		 set { } //Length: 14
	}

	public XmlTypeMapping MappedType
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public string Namespace
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public XmlTypeMapMemberAttribute() { }

	public string get_AttributeName() { }

	public XmlTypeMapping get_MappedType() { }

	public string get_Namespace() { }

	public void set_AttributeName(string value) { }

	public void set_Form(XmlSchemaForm value) { }

	public void set_MappedType(XmlTypeMapping value) { }

	public void set_Namespace(string value) { }

}

