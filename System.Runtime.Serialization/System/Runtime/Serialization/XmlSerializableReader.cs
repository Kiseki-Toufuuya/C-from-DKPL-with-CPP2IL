namespace System.Runtime.Serialization;

[DefaultMember("Item")]
internal class XmlSerializableReader : XmlReader, IXmlLineInfo, IXmlTextParser
{
	private XmlReaderDelegator xmlReader; //Field offset: 0x8
	private int startDepth; //Field offset: 0xC
	private bool isRootEmptyElement; //Field offset: 0x10
	private XmlReader innerReader; //Field offset: 0x14

	public virtual int AttributeCount
	{
		 get { } //Length: 40
	}

	public virtual string BaseURI
	{
		 get { } //Length: 40
	}

	public virtual bool CanReadBinaryContent
	{
		 get { } //Length: 40
	}

	public virtual bool CanReadValueChunk
	{
		 get { } //Length: 40
	}

	public virtual bool CanResolveEntity
	{
		 get { } //Length: 40
	}

	public virtual int Depth
	{
		 get { } //Length: 40
	}

	public virtual bool EOF
	{
		 get { } //Length: 40
	}

	public virtual bool HasAttributes
	{
		 get { } //Length: 40
	}

	public virtual bool HasValue
	{
		 get { } //Length: 40
	}

	private XmlReader InnerReader
	{
		private get { } //Length: 11
	}

	public virtual bool IsDefault
	{
		 get { } //Length: 40
	}

	public virtual bool IsEmptyElement
	{
		 get { } //Length: 40
	}

	public virtual string Item
	{
		 get { } //Length: 46
	}

	public virtual string Item
	{
		 get { } //Length: 43
	}

	public virtual string Item
	{
		 get { } //Length: 43
	}

	public virtual string LocalName
	{
		 get { } //Length: 40
	}

	public virtual string Name
	{
		 get { } //Length: 40
	}

	public virtual string NamespaceURI
	{
		 get { } //Length: 40
	}

	public virtual XmlNameTable NameTable
	{
		 get { } //Length: 40
	}

	public virtual XmlNodeType NodeType
	{
		 get { } //Length: 40
	}

	public virtual string Prefix
	{
		 get { } //Length: 40
	}

	public virtual char QuoteChar
	{
		 get { } //Length: 40
	}

	public virtual ReadState ReadState
	{
		 get { } //Length: 40
	}

	public virtual IXmlSchemaInfo SchemaInfo
	{
		 get { } //Length: 40
	}

	public virtual XmlReaderSettings Settings
	{
		 get { } //Length: 40
	}

	private override int System.Xml.IXmlLineInfo.LineNumber
	{
		private get { } //Length: 106
	}

	private override int System.Xml.IXmlLineInfo.LinePosition
	{
		private get { } //Length: 106
	}

	private override bool System.Xml.Serialization.IXmlTextParser.Normalized
	{
		private get { } //Length: 106
		private set { } //Length: 201
	}

	private override WhitespaceHandling System.Xml.Serialization.IXmlTextParser.WhitespaceHandling
	{
		private get { } //Length: 106
		private set { } //Length: 201
	}

	public virtual string Value
	{
		 get { } //Length: 40
	}

	public virtual Type ValueType
	{
		 get { } //Length: 40
	}

	public virtual string XmlLang
	{
		 get { } //Length: 40
	}

	public virtual XmlSpace XmlSpace
	{
		 get { } //Length: 40
	}

	public XmlSerializableReader() { }

	internal void BeginRead(XmlReaderDelegator xmlReader) { }

	public virtual void Close() { }

	internal void EndRead() { }

	public virtual int get_AttributeCount() { }

	public virtual string get_BaseURI() { }

	public virtual bool get_CanReadBinaryContent() { }

	public virtual bool get_CanReadValueChunk() { }

	public virtual bool get_CanResolveEntity() { }

	public virtual int get_Depth() { }

	public virtual bool get_EOF() { }

	public virtual bool get_HasAttributes() { }

	public virtual bool get_HasValue() { }

	private XmlReader get_InnerReader() { }

	public virtual bool get_IsDefault() { }

	public virtual bool get_IsEmptyElement() { }

	public virtual string get_Item(int i) { }

	public virtual string get_Item(string name, string namespaceURI) { }

	public virtual string get_Item(string name) { }

	public virtual string get_LocalName() { }

	public virtual string get_Name() { }

	public virtual string get_NamespaceURI() { }

	public virtual XmlNameTable get_NameTable() { }

	public virtual XmlNodeType get_NodeType() { }

	public virtual string get_Prefix() { }

	public virtual char get_QuoteChar() { }

	public virtual ReadState get_ReadState() { }

	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	public virtual XmlReaderSettings get_Settings() { }

	public virtual string get_Value() { }

	public virtual Type get_ValueType() { }

	public virtual string get_XmlLang() { }

	public virtual XmlSpace get_XmlSpace() { }

	public virtual string GetAttribute(int i) { }

	public virtual string GetAttribute(string name, string namespaceURI) { }

	public virtual string GetAttribute(string name) { }

	public virtual bool IsStartElement(string localname, string ns) { }

	public virtual bool IsStartElement(string name) { }

	public virtual bool IsStartElement() { }

	public virtual string LookupNamespace(string prefix) { }

	public virtual bool MoveToAttribute(string name) { }

	public virtual bool MoveToAttribute(string name, string ns) { }

	public virtual void MoveToAttribute(int i) { }

	public virtual XmlNodeType MoveToContent() { }

	public virtual bool MoveToElement() { }

	public virtual bool MoveToFirstAttribute() { }

	public virtual bool MoveToNextAttribute() { }

	public virtual bool Read() { }

	public virtual bool ReadAttributeValue() { }

	public virtual object ReadContentAs(Type returnType, IXmlNamespaceResolver namespaceResolver) { }

	public virtual int ReadContentAsBase64(Byte[] buffer, int index, int count) { }

	public virtual int ReadContentAsBinHex(Byte[] buffer, int index, int count) { }

	public virtual bool ReadContentAsBoolean() { }

	public virtual DateTime ReadContentAsDateTime() { }

	public virtual double ReadContentAsDouble() { }

	public virtual int ReadContentAsInt() { }

	public virtual long ReadContentAsLong() { }

	public virtual object ReadContentAsObject() { }

	public virtual string ReadContentAsString() { }

	public virtual string ReadString() { }

	public virtual int ReadValueChunk(Char[] buffer, int index, int count) { }

	public virtual void ResolveEntity() { }

	private override int System.Xml.IXmlLineInfo.get_LineNumber() { }

	private override int System.Xml.IXmlLineInfo.get_LinePosition() { }

	private override bool System.Xml.IXmlLineInfo.HasLineInfo() { }

	private override bool System.Xml.Serialization.IXmlTextParser.get_Normalized() { }

	private override WhitespaceHandling System.Xml.Serialization.IXmlTextParser.get_WhitespaceHandling() { }

	private override void System.Xml.Serialization.IXmlTextParser.set_Normalized(bool value) { }

	private override void System.Xml.Serialization.IXmlTextParser.set_WhitespaceHandling(WhitespaceHandling value) { }

}

