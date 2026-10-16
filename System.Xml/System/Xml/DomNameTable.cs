namespace System.Xml;

internal class DomNameTable
{
	private XmlName[] entries; //Field offset: 0x8
	private int count; //Field offset: 0xC
	private int mask; //Field offset: 0x10
	private XmlDocument ownerDocument; //Field offset: 0x14
	private XmlNameTable nameTable; //Field offset: 0x18

	public DomNameTable(XmlDocument document) { }

	public XmlName AddName(string prefix, string localName, string ns, IXmlSchemaInfo schemaInfo) { }

	public XmlName GetName(string prefix, string localName, string ns, IXmlSchemaInfo schemaInfo) { }

	private void Grow() { }

}

