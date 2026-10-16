namespace System.Xml.Schema;

internal sealed class XmlSchemaCollectionNode
{
	private string namespaceUri; //Field offset: 0x8
	private SchemaInfo schemaInfo; //Field offset: 0xC
	private XmlSchema schema; //Field offset: 0x10

	internal string NamespaceURI
	{
		internal set { } //Length: 27
	}

	internal XmlSchema Schema
	{
		internal get { } //Length: 11
		internal set { } //Length: 27
	}

	internal SchemaInfo SchemaInfo
	{
		internal get { } //Length: 11
		internal set { } //Length: 27
	}

	public XmlSchemaCollectionNode() { }

	internal XmlSchema get_Schema() { }

	internal SchemaInfo get_SchemaInfo() { }

	internal void set_NamespaceURI(string value) { }

	internal void set_Schema(XmlSchema value) { }

	internal void set_SchemaInfo(SchemaInfo value) { }

}

