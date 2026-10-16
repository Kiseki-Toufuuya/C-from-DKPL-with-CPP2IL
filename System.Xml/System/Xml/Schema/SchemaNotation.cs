namespace System.Xml.Schema;

internal sealed class SchemaNotation
{
	private XmlQualifiedName name; //Field offset: 0x8
	private string systemLiteral; //Field offset: 0xC
	private string pubid; //Field offset: 0x10

	internal XmlQualifiedName Name
	{
		internal get { } //Length: 11
	}

	internal string Pubid
	{
		internal get { } //Length: 11
		internal set { } //Length: 27
	}

	internal string SystemLiteral
	{
		internal get { } //Length: 11
		internal set { } //Length: 27
	}

	internal SchemaNotation(XmlQualifiedName name) { }

	internal XmlQualifiedName get_Name() { }

	internal string get_Pubid() { }

	internal string get_SystemLiteral() { }

	internal void set_Pubid(string value) { }

	internal void set_SystemLiteral(string value) { }

}

