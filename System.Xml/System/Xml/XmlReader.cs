namespace System.Xml;

[DebuggerDisplay("{debuggerDisplayProxy}")]
[DebuggerDisplay("{debuggerDisplayProxy}")]
[DefaultMember("Item")]
public abstract class XmlReader : IDisposable
{
	private static uint IsTextualNodeBitmap; //Field offset: 0x0
	private static uint CanReadContentAsBitmap; //Field offset: 0x4
	private static uint HasValueBitmap; //Field offset: 0x8

	public abstract int AttributeCount
	{
		 get { } //Length: 0
	}

	public abstract string BaseURI
	{
		 get { } //Length: 0
	}

	public override bool CanReadBinaryContent
	{
		 get { } //Length: 3
	}

	public override bool CanReadValueChunk
	{
		 get { } //Length: 3
	}

	public override bool CanResolveEntity
	{
		 get { } //Length: 3
	}

	public abstract int Depth
	{
		 get { } //Length: 0
	}

	internal override IDtdInfo DtdInfo
	{
		internal get { } //Length: 3
	}

	public abstract bool EOF
	{
		 get { } //Length: 0
	}

	public override bool HasAttributes
	{
		 get { } //Length: 33
	}

	public override bool HasValue
	{
		 get { } //Length: 173
	}

	public override bool IsDefault
	{
		 get { } //Length: 3
	}

	internal bool IsDefaultInternal
	{
		internal get { } //Length: 189
	}

	public abstract bool IsEmptyElement
	{
		 get { } //Length: 0
	}

	public override string Item
	{
		 get { } //Length: 34
	}

	public override string Item
	{
		 get { } //Length: 31
	}

	public override string Item
	{
		 get { } //Length: 31
	}

	public abstract string LocalName
	{
		 get { } //Length: 0
	}

	public override string Name
	{
		 get { } //Length: 201
	}

	internal override XmlNamespaceManager NamespaceManager
	{
		internal get { } //Length: 3
	}

	public abstract string NamespaceURI
	{
		 get { } //Length: 0
	}

	public abstract XmlNameTable NameTable
	{
		 get { } //Length: 0
	}

	public abstract XmlNodeType NodeType
	{
		 get { } //Length: 0
	}

	public abstract string Prefix
	{
		 get { } //Length: 0
	}

	public override char QuoteChar
	{
		 get { } //Length: 6
	}

	public abstract ReadState ReadState
	{
		 get { } //Length: 0
	}

	public override IXmlSchemaInfo SchemaInfo
	{
		 get { } //Length: 51
	}

	public override XmlReaderSettings Settings
	{
		 get { } //Length: 3
	}

	public abstract string Value
	{
		 get { } //Length: 0
	}

	public override Type ValueType
	{
		 get { } //Length: 43
	}

	public override string XmlLang
	{
		 get { } //Length: 11
	}

	public override XmlSpace XmlSpace
	{
		 get { } //Length: 3
	}

	private static XmlReader() { }

	protected XmlReader() { }

	private static string AddLineInfo(string message, IXmlLineInfo lineInfo) { }

	internal static int CalcBufferSize(Stream input) { }

	internal static bool CanReadContentAs(XmlNodeType nodeType) { }

	internal bool CanReadContentAs() { }

	public override void Close() { }

	public static XmlReader Create(TextReader input, XmlReaderSettings settings, string baseUri) { }

	public static XmlReader Create(Stream input, XmlReaderSettings settings, string baseUri) { }

	public static XmlReader Create(TextReader input, XmlReaderSettings settings) { }

	public static XmlReader Create(TextReader input) { }

	internal Exception CreateReadContentAsException(string methodName) { }

	internal static Exception CreateReadContentAsException(string methodName, XmlNodeType nodeType, IXmlLineInfo lineInfo) { }

	internal Exception CreateReadElementContentAsException(string methodName) { }

	internal static Exception CreateReadElementContentAsException(string methodName, XmlNodeType nodeType, IXmlLineInfo lineInfo) { }

	internal static XmlReader CreateSqlReader(Stream input, XmlReaderSettings settings, XmlParserContext inputContext) { }

	private XmlWriter CreateWriterForInnerOuterXml(StringWriter sw) { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	private void FinishReadElementContentAsXxx() { }

	public abstract int get_AttributeCount() { }

	public abstract string get_BaseURI() { }

	public override bool get_CanReadBinaryContent() { }

	public override bool get_CanReadValueChunk() { }

	public override bool get_CanResolveEntity() { }

	public abstract int get_Depth() { }

	internal override IDtdInfo get_DtdInfo() { }

	public abstract bool get_EOF() { }

	public override bool get_HasAttributes() { }

	public override bool get_HasValue() { }

	public override bool get_IsDefault() { }

	internal bool get_IsDefaultInternal() { }

	public abstract bool get_IsEmptyElement() { }

	public override string get_Item(string name) { }

	public override string get_Item(string name, string namespaceURI) { }

	public override string get_Item(int i) { }

	public abstract string get_LocalName() { }

	public override string get_Name() { }

	internal override XmlNamespaceManager get_NamespaceManager() { }

	public abstract string get_NamespaceURI() { }

	public abstract XmlNameTable get_NameTable() { }

	public abstract XmlNodeType get_NodeType() { }

	public abstract string get_Prefix() { }

	public override char get_QuoteChar() { }

	public abstract ReadState get_ReadState() { }

	public override IXmlSchemaInfo get_SchemaInfo() { }

	public override XmlReaderSettings get_Settings() { }

	public abstract string get_Value() { }

	public override Type get_ValueType() { }

	public override string get_XmlLang() { }

	public override XmlSpace get_XmlSpace() { }

	public abstract string GetAttribute(int i) { }

	public abstract string GetAttribute(string name, string namespaceURI) { }

	public abstract string GetAttribute(string name) { }

	internal static bool HasValueInternal(XmlNodeType nodeType) { }

	internal string InternalReadContentAsString() { }

	public override bool IsStartElement(string name) { }

	public override bool IsStartElement(string localname, string ns) { }

	public override bool IsStartElement() { }

	internal static bool IsTextualNode(XmlNodeType nodeType) { }

	public abstract string LookupNamespace(string prefix) { }

	public abstract bool MoveToAttribute(string name) { }

	public abstract bool MoveToAttribute(string name, string ns) { }

	public override void MoveToAttribute(int i) { }

	public override XmlNodeType MoveToContent() { }

	public abstract bool MoveToElement() { }

	public abstract bool MoveToFirstAttribute() { }

	public abstract bool MoveToNextAttribute() { }

	public abstract bool Read() { }

	public abstract bool ReadAttributeValue() { }

	public override object ReadContentAs(Type returnType, IXmlNamespaceResolver namespaceResolver) { }

	public override int ReadContentAsBase64(Byte[] buffer, int index, int count) { }

	public override int ReadContentAsBinHex(Byte[] buffer, int index, int count) { }

	public override bool ReadContentAsBoolean() { }

	public override DateTime ReadContentAsDateTime() { }

	public override decimal ReadContentAsDecimal() { }

	public override double ReadContentAsDouble() { }

	public override float ReadContentAsFloat() { }

	public override int ReadContentAsInt() { }

	public override long ReadContentAsLong() { }

	public override object ReadContentAsObject() { }

	public override string ReadContentAsString() { }

	public override int ReadElementContentAsBase64(Byte[] buffer, int index, int count) { }

	public override int ReadElementContentAsBinHex(Byte[] buffer, int index, int count) { }

	public override bool ReadElementContentAsBoolean() { }

	public override DateTime ReadElementContentAsDateTime() { }

	public override decimal ReadElementContentAsDecimal() { }

	public override double ReadElementContentAsDouble() { }

	public override float ReadElementContentAsFloat() { }

	public override int ReadElementContentAsInt() { }

	public override long ReadElementContentAsLong() { }

	public override string ReadElementContentAsString() { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	public override string ReadElementString(string localname, string ns) { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	public override string ReadElementString() { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	public override string ReadElementString(string name) { }

	public override void ReadEndElement() { }

	public override string ReadInnerXml() { }

	public override string ReadOuterXml() { }

	public override void ReadStartElement(string localname, string ns) { }

	public override void ReadStartElement(string name) { }

	public override void ReadStartElement() { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	public override string ReadString() { }

	public override int ReadValueChunk(Char[] buffer, int index, int count) { }

	public abstract void ResolveEntity() { }

	private void SetNamespacesFlag(XmlTextWriter xtw) { }

	private bool SetupReadElementContentAsXxx(string methodName) { }

	public override void Skip() { }

	private bool SkipSubtree() { }

	private void WriteAttributeValue(XmlWriter xtw) { }

	private void WriteNode(XmlWriter xtw, bool defattr) { }

}

