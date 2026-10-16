namespace System.Xml;

public class XmlImplementation
{
	private XmlNameTable nameTable; //Field offset: 0x8

	internal XmlNameTable NameTable
	{
		internal get { } //Length: 11
	}

	public XmlImplementation() { }

	public XmlImplementation(XmlNameTable nt) { }

	public override XmlDocument CreateDocument() { }

	internal XmlNameTable get_NameTable() { }

}

