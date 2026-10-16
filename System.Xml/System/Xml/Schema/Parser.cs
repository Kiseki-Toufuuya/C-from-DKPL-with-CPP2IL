namespace System.Xml.Schema;

internal sealed class Parser
{
	private SchemaType schemaType; //Field offset: 0x8
	private XmlNameTable nameTable; //Field offset: 0xC
	private SchemaNames schemaNames; //Field offset: 0x10
	private ValidationEventHandler eventHandler; //Field offset: 0x14
	private XmlNamespaceManager namespaceManager; //Field offset: 0x18
	private XmlReader reader; //Field offset: 0x1C
	private PositionInfo positionInfo; //Field offset: 0x20
	private bool isProcessNamespaces; //Field offset: 0x24
	private int schemaXmlDepth; //Field offset: 0x28
	private int markupDepth; //Field offset: 0x2C
	private SchemaBuilder builder; //Field offset: 0x30
	private XmlSchema schema; //Field offset: 0x34
	private SchemaInfo xdrSchema; //Field offset: 0x38
	private XmlResolver xmlResolver; //Field offset: 0x3C
	private XmlDocument dummyDocument; //Field offset: 0x40
	private bool processMarkup; //Field offset: 0x44
	private XmlNode parentNode; //Field offset: 0x48
	private XmlNamespaceManager annotationNSManager; //Field offset: 0x4C
	private string xmlns; //Field offset: 0x50
	private XmlCharType xmlCharType; //Field offset: 0x54

	public SchemaInfo XdrSchema
	{
		 get { } //Length: 11
	}

	internal XmlResolver XmlResolver
	{
		internal set { } //Length: 27
	}

	public XmlSchema XmlSchema
	{
		 get { } //Length: 11
	}

	public Parser(SchemaType schemaType, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler) { }

	private bool CheckSchemaRoot(SchemaType rootType, out string code) { }

	private XmlAttribute CreateXmlNsAttribute(string prefix, string value) { }

	public SchemaType FinishParsing() { }

	public SchemaInfo get_XdrSchema() { }

	public XmlSchema get_XmlSchema() { }

	private XmlAttribute LoadAttributeNode() { }

	private XmlElement LoadElementNode(bool root) { }

	private XmlEntityReference LoadEntityReferenceInAttribute() { }

	public SchemaType Parse(XmlReader reader, string targetNamespace) { }

	public bool ParseReaderNode() { }

	private void ProcessAppInfoDocMarkup(bool root) { }

	internal void set_XmlResolver(XmlResolver value) { }

	public void StartParsing(XmlReader reader, string targetNamespace) { }

}

