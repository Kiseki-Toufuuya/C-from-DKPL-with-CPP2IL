namespace System.Xml;

internal class XsdValidatingReader : XmlReader, IXmlSchemaInfo, IXmlLineInfo, IXmlNamespaceResolver
{
	private enum ValidatingReaderState
	{
		None = 0,
		Init = 1,
		Read = 2,
		OnDefaultAttribute = -1,
		OnReadAttributeValue = -2,
		OnAttribute = 3,
		ClearAttributes = 4,
		ParseInlineSchema = 5,
		ReadAhead = 6,
		OnReadBinaryContent = 7,
		ReaderClosed = 8,
		EOF = 9,
		Error = 10,
	}

	private static Type TypeOfString; //Field offset: 0x0
	private XmlReader coreReader; //Field offset: 0x8
	private IXmlNamespaceResolver coreReaderNSResolver; //Field offset: 0xC
	private IXmlNamespaceResolver thisNSResolver; //Field offset: 0x10
	private XmlSchemaValidator validator; //Field offset: 0x14
	private XmlResolver xmlResolver; //Field offset: 0x18
	private ValidationEventHandler validationEvent; //Field offset: 0x1C
	private ValidatingReaderState validationState; //Field offset: 0x20
	private XmlValueGetter valueGetter; //Field offset: 0x24
	private XmlNamespaceManager nsManager; //Field offset: 0x28
	private bool manageNamespaces; //Field offset: 0x2C
	private bool processInlineSchema; //Field offset: 0x2D
	private bool replayCache; //Field offset: 0x2E
	private ValidatingReaderNodeData cachedNode; //Field offset: 0x30
	private AttributePSVIInfo attributePSVI; //Field offset: 0x34
	private int attributeCount; //Field offset: 0x38
	private int coreReaderAttributeCount; //Field offset: 0x3C
	private int currentAttrIndex; //Field offset: 0x40
	private AttributePSVIInfo[] attributePSVINodes; //Field offset: 0x44
	private ArrayList defaultAttributes; //Field offset: 0x48
	private Parser inlineSchemaParser; //Field offset: 0x4C
	private object atomicValue; //Field offset: 0x50
	private XmlSchemaInfo xmlSchemaInfo; //Field offset: 0x54
	private string originalAtomicValueString; //Field offset: 0x58
	private XmlNameTable coreReaderNameTable; //Field offset: 0x5C
	private XsdCachingReader cachingReader; //Field offset: 0x60
	private ValidatingReaderNodeData textNode; //Field offset: 0x64
	private string NsXmlNs; //Field offset: 0x68
	private string NsXs; //Field offset: 0x6C
	private string NsXsi; //Field offset: 0x70
	private string XsiType; //Field offset: 0x74
	private string XsiNil; //Field offset: 0x78
	private string XsdSchema; //Field offset: 0x7C
	private string XsiSchemaLocation; //Field offset: 0x80
	private string XsiNoNamespaceSchemaLocation; //Field offset: 0x84
	private XmlCharType xmlCharType; //Field offset: 0x88
	private IXmlLineInfo lineInfo; //Field offset: 0x8C
	private ReadContentAsBinaryHelper readBinaryHelper; //Field offset: 0x90
	private ValidatingReaderState savedState; //Field offset: 0x94

	public virtual int AttributeCount
	{
		 get { } //Length: 11
	}

	private XmlSchemaInfo AttributeSchemaInfo
	{
		private get { } //Length: 23
	}

	private XmlSchemaType AttributeXmlType
	{
		private get { } //Length: 47
	}

	public virtual string BaseURI
	{
		 get { } //Length: 40
	}

	public virtual bool CanReadBinaryContent
	{
		 get { } //Length: 3
	}

	public virtual int Depth
	{
		 get { } //Length: 58
	}

	private XmlSchemaType ElementXmlType
	{
		private get { } //Length: 34
	}

	public virtual bool EOF
	{
		 get { } //Length: 40
	}

	public virtual bool HasValue
	{
		 get { } //Length: 50
	}

	public virtual bool IsDefault
	{
		 get { } //Length: 50
	}

	public virtual bool IsEmptyElement
	{
		 get { } //Length: 40
	}

	public override int LineNumber
	{
		 get { } //Length: 72
	}

	public override int LinePosition
	{
		 get { } //Length: 72
	}

	public virtual string LocalName
	{
		 get { } //Length: 58
	}

	public virtual string Name
	{
		 get { } //Length: 243
	}

	public virtual string NamespaceURI
	{
		 get { } //Length: 58
	}

	public virtual XmlNameTable NameTable
	{
		 get { } //Length: 11
	}

	public virtual XmlNodeType NodeType
	{
		 get { } //Length: 132
	}

	public virtual string Prefix
	{
		 get { } //Length: 58
	}

	public virtual char QuoteChar
	{
		 get { } //Length: 40
	}

	public virtual ReadState ReadState
	{
		 get { } //Length: 50
	}

	public virtual IXmlSchemaInfo SchemaInfo
	{
		 get { } //Length: 8
	}

	public virtual XmlReaderSettings Settings
	{
		 get { } //Length: 184
	}

	private override bool System.Xml.Schema.IXmlSchemaInfo.IsDefault
	{
		private get { } //Length: 142
	}

	private override bool System.Xml.Schema.IXmlSchemaInfo.IsNil
	{
		private get { } //Length: 60
	}

	private override XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.MemberType
	{
		private get { } //Length: 336
	}

	private override XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.SchemaAttribute
	{
		private get { } //Length: 64
	}

	private override XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.SchemaElement
	{
		private get { } //Length: 80
	}

	private override XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.SchemaType
	{
		private get { } //Length: 79
	}

	private override XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.Validity
	{
		private get { } //Length: 147
	}

	public virtual string Value
	{
		 get { } //Length: 101
	}

	public virtual Type ValueType
	{
		 get { } //Length: 190
	}

	public virtual string XmlLang
	{
		 get { } //Length: 40
	}

	public virtual XmlSpace XmlSpace
	{
		 get { } //Length: 40
	}

	internal XsdValidatingReader(XmlReader reader, XmlResolver xmlResolver, XmlReaderSettings readerSettings, XmlSchemaObject partialValidationType) { }

	internal XsdValidatingReader(XmlReader reader, XmlResolver xmlResolver, XmlReaderSettings readerSettings) { }

	private AttributePSVIInfo AddAttributePSVI(int attIndex) { }

	internal void CachingCallBack(XsdCachingReader cachingReader) { }

	private void ClearAttributesInfo() { }

	public virtual void Close() { }

	internal ValidatingReaderNodeData CreateDummyTextNode(string attributeValue, int depth) { }

	public virtual int get_AttributeCount() { }

	private XmlSchemaInfo get_AttributeSchemaInfo() { }

	private XmlSchemaType get_AttributeXmlType() { }

	public virtual string get_BaseURI() { }

	public virtual bool get_CanReadBinaryContent() { }

	public virtual int get_Depth() { }

	private XmlSchemaType get_ElementXmlType() { }

	public virtual bool get_EOF() { }

	public virtual bool get_HasValue() { }

	public virtual bool get_IsDefault() { }

	public virtual bool get_IsEmptyElement() { }

	public override int get_LineNumber() { }

	public override int get_LinePosition() { }

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

	public virtual string GetAttribute(string name, string namespaceURI) { }

	public virtual string GetAttribute(string name) { }

	public virtual string GetAttribute(int i) { }

	private AttributePSVIInfo GetAttributePSVI(string localName, string ns) { }

	private AttributePSVIInfo GetAttributePSVI(string name) { }

	private XsdCachingReader GetCachingReader() { }

	private ValidatingReaderNodeData GetDefaultAttribute(string attrLocalName, string ns, bool updatePosition) { }

	private ValidatingReaderNodeData GetDefaultAttribute(string name, bool updatePosition) { }

	private void GetIsDefault() { }

	private void GetMemberType() { }

	private string GetOriginalAtomicValueStringOfElement() { }

	private object GetStringValue() { }

	public override bool HasLineInfo() { }

	private void Init() { }

	private object InternalReadContentAsObject(bool unwrapTypedValue, out string originalStringValue) { }

	private object InternalReadContentAsObject(bool unwrapTypedValue) { }

	private object InternalReadContentAsObject() { }

	private object InternalReadElementContentAsObject(out XmlSchemaType xmlType, bool unwrapTypedValue, out string originalString) { }

	private object InternalReadElementContentAsObject(out XmlSchemaType xmlType, bool unwrapTypedValue) { }

	private object InternalReadElementContentAsObject(out XmlSchemaType xmlType) { }

	private bool IsXSDRoot(string localName, string ns) { }

	public virtual string LookupNamespace(string prefix) { }

	public virtual bool MoveToAttribute(string name, string ns) { }

	public virtual void MoveToAttribute(int i) { }

	public virtual bool MoveToAttribute(string name) { }

	public virtual bool MoveToElement() { }

	public virtual bool MoveToFirstAttribute() { }

	public virtual bool MoveToNextAttribute() { }

	private void ProcessElementEvent() { }

	private void ProcessEndElementEvent() { }

	private void ProcessInlineSchema() { }

	private void ProcessReaderEvent() { }

	public virtual bool Read() { }

	private void ReadAheadForMemberType() { }

	public virtual bool ReadAttributeValue() { }

	public virtual object ReadContentAs(Type returnType, IXmlNamespaceResolver namespaceResolver) { }

	public virtual int ReadContentAsBase64(Byte[] buffer, int index, int count) { }

	public virtual int ReadContentAsBinHex(Byte[] buffer, int index, int count) { }

	public virtual bool ReadContentAsBoolean() { }

	public virtual DateTime ReadContentAsDateTime() { }

	public virtual decimal ReadContentAsDecimal() { }

	public virtual double ReadContentAsDouble() { }

	public virtual float ReadContentAsFloat() { }

	public virtual int ReadContentAsInt() { }

	public virtual long ReadContentAsLong() { }

	public virtual object ReadContentAsObject() { }

	public virtual string ReadContentAsString() { }

	public virtual int ReadElementContentAsBase64(Byte[] buffer, int index, int count) { }

	public virtual int ReadElementContentAsBinHex(Byte[] buffer, int index, int count) { }

	public virtual bool ReadElementContentAsBoolean() { }

	public virtual DateTime ReadElementContentAsDateTime() { }

	public virtual decimal ReadElementContentAsDecimal() { }

	public virtual double ReadElementContentAsDouble() { }

	public virtual float ReadElementContentAsFloat() { }

	public virtual int ReadElementContentAsInt() { }

	public virtual long ReadElementContentAsLong() { }

	public virtual string ReadElementContentAsString() { }

	private object ReadTillEndElement() { }

	public virtual void ResolveEntity() { }

	private object ReturnBoxedValue(object typedValue, XmlSchemaType xmlType, bool unWrap) { }

	private void SetupValidator(XmlReaderSettings readerSettings, XmlReader reader, XmlSchemaObject partialValidationType) { }

	public virtual void Skip() { }

	private void SwitchReader() { }

	private override IDictionary<String, String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	private override string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	private override string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	private override bool System.Xml.Schema.IXmlSchemaInfo.get_IsDefault() { }

	private override bool System.Xml.Schema.IXmlSchemaInfo.get_IsNil() { }

	private override XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.get_MemberType() { }

	private override XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.get_SchemaAttribute() { }

	private override XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.get_SchemaElement() { }

	private override XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.get_SchemaType() { }

	private override XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.get_Validity() { }

	private void ValidateAttributes() { }

}

