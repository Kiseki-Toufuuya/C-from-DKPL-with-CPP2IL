namespace System.Xml;

[DefaultMember("Item")]
internal abstract class XmlBaseReader : XmlDictionaryReader
{
	private class AttributeSorter : IComparer
	{
		private Object[] indeces; //Field offset: 0x8
		private XmlAttributeNode[] attributeNodes; //Field offset: 0xC
		private int attributeCount; //Field offset: 0x10
		private int attributeIndex1; //Field offset: 0x14
		private int attributeIndex2; //Field offset: 0x18

		public AttributeSorter() { }

		public void Close() { }

		public override int Compare(object obj1, object obj2) { }

		public int CompareQNameType(QNameType type1, QNameType type2) { }

		public void GetIndeces(out int attributeIndex1, out int attributeIndex2) { }

		private bool IsSorted() { }

		public bool Sort(XmlAttributeNode[] attributeNodes, int attributeCount) { }

		private bool Sort() { }

	}

	internal class Namespace
	{
		private PrefixHandle prefix; //Field offset: 0x8
		private StringHandle uri; //Field offset: 0xC
		private int depth; //Field offset: 0x10
		private Namespace outerUri; //Field offset: 0x14
		private string uriString; //Field offset: 0x18

		public int Depth
		{
			 get { } //Length: 11
			 set { } //Length: 14
		}

		public Namespace OuterUri
		{
			 get { } //Length: 11
			 set { } //Length: 27
		}

		public PrefixHandle Prefix
		{
			 get { } //Length: 11
		}

		public StringHandle Uri
		{
			 get { } //Length: 11
		}

		public Namespace(XmlBufferReader bufferReader) { }

		public void Clear() { }

		public int get_Depth() { }

		public Namespace get_OuterUri() { }

		public PrefixHandle get_Prefix() { }

		public StringHandle get_Uri() { }

		public bool IsUri(string s) { }

		public bool IsUri(XmlDictionaryString s) { }

		public void set_Depth(int value) { }

		public void set_OuterUri(Namespace value) { }

	}

	private class NamespaceManager
	{
		private class XmlAttribute
		{
			private XmlSpace space; //Field offset: 0x8
			private string lang; //Field offset: 0xC
			private int depth; //Field offset: 0x10

			public int Depth
			{
				 get { } //Length: 11
				 set { } //Length: 14
			}

			public string XmlLang
			{
				 get { } //Length: 11
				 set { } //Length: 27
			}

			public XmlSpace XmlSpace
			{
				 get { } //Length: 11
				 set { } //Length: 14
			}

			public XmlAttribute() { }

			public int get_Depth() { }

			public string get_XmlLang() { }

			public XmlSpace get_XmlSpace() { }

			public void set_Depth(int value) { }

			public void set_XmlLang(string value) { }

			public void set_XmlSpace(XmlSpace value) { }

		}

		private static Namespace emptyNamespace; //Field offset: 0x0
		private static Namespace xmlNamespace; //Field offset: 0x4
		private XmlBufferReader bufferReader; //Field offset: 0x8
		private Namespace[] namespaces; //Field offset: 0xC
		private int nsCount; //Field offset: 0x10
		private int depth; //Field offset: 0x14
		private Namespace[] shortPrefixUri; //Field offset: 0x18
		private XmlAttribute[] attributes; //Field offset: 0x1C
		private int attributeCount; //Field offset: 0x20
		private XmlSpace space; //Field offset: 0x24
		private string lang; //Field offset: 0x28

		public static Namespace EmptyNamespace
		{
			 get { } //Length: 60
		}

		public string XmlLang
		{
			 get { } //Length: 11
		}

		public static Namespace XmlNamespace
		{
			 get { } //Length: 347
		}

		public XmlSpace XmlSpace
		{
			 get { } //Length: 11
		}

		private static NamespaceManager() { }

		public NamespaceManager(XmlBufferReader bufferReader) { }

		private void AddAttribute() { }

		public void AddLangAttribute(string lang) { }

		public Namespace AddNamespace() { }

		public void AddSpaceAttribute(XmlSpace space) { }

		public void Clear() { }

		public void Close() { }

		public void EnterScope() { }

		public void ExitScope() { }

		public static Namespace get_EmptyNamespace() { }

		public string get_XmlLang() { }

		public static Namespace get_XmlNamespace() { }

		public XmlSpace get_XmlSpace() { }

		public Namespace LookupNamespace(PrefixHandleType prefix) { }

		public Namespace LookupNamespace(PrefixHandle prefix) { }

		public Namespace LookupNamespace(string prefix) { }

		public void Register(Namespace nameSpace) { }

		public void Sign(XmlSigningNodeWriter writer) { }

		private bool TryGetShortPrefix(string s, out PrefixHandleType shortPrefix) { }

	}

	internal enum QNameType
	{
		Normal = 0,
		Xmlns = 1,
	}

	private class QuotaNameTable : XmlNameTable
	{
		private XmlDictionaryReader reader; //Field offset: 0x8
		private XmlNameTable nameTable; //Field offset: 0xC
		private int maxCharCount; //Field offset: 0x10
		private int charCount; //Field offset: 0x14

		public QuotaNameTable(XmlDictionaryReader reader, int maxCharCount) { }

		private void Add(int charCount) { }

		public virtual string Add(Char[] chars, int offset, int count) { }

		public virtual string Add(string value) { }

		public virtual string Get(Char[] chars, int offset, int count) { }

		public virtual string Get(string value) { }

	}

	internal class XmlAtomicTextNode : XmlTextNode
	{

		public XmlAtomicTextNode(XmlBufferReader bufferReader) { }

	}

	internal class XmlAttributeNode : XmlNode
	{

		public XmlAttributeNode(XmlBufferReader bufferReader) { }

		private XmlAttributeNode(PrefixHandle prefix, StringHandle localName, ValueHandle value) { }

	}

	internal class XmlAttributeTextNode : XmlTextNode
	{

		public XmlAttributeTextNode(PrefixHandle prefix, StringHandle localName, ValueHandle value) { }

	}

	internal class XmlCDataNode : XmlTextNode
	{

		public XmlCDataNode(XmlBufferReader bufferReader) { }

	}

	internal class XmlClosedNode : XmlNode
	{

		public XmlClosedNode(XmlBufferReader bufferReader) { }

	}

	internal class XmlCommentNode : XmlNode
	{

		public XmlCommentNode(XmlBufferReader bufferReader) { }

	}

	internal class XmlComplexTextNode : XmlTextNode
	{

		public XmlComplexTextNode(XmlBufferReader bufferReader) { }

	}

	internal class XmlDeclarationNode : XmlNode
	{

		public XmlDeclarationNode(XmlBufferReader bufferReader) { }

	}

	internal class XmlElementNode : XmlNode
	{
		private XmlEndElementNode endElementNode; //Field offset: 0x3C
		private int bufferOffset; //Field offset: 0x40
		public int NameOffset; //Field offset: 0x44
		public int NameLength; //Field offset: 0x48

		public int BufferOffset
		{
			 get { } //Length: 11
			 set { } //Length: 14
		}

		public XmlEndElementNode EndElement
		{
			 get { } //Length: 11
		}

		public XmlElementNode(XmlBufferReader bufferReader) { }

		private XmlElementNode(PrefixHandle prefix, StringHandle localName, ValueHandle value) { }

		public int get_BufferOffset() { }

		public XmlEndElementNode get_EndElement() { }

		public void set_BufferOffset(int value) { }

	}

	internal class XmlEndElementNode : XmlNode
	{

		public XmlEndElementNode(PrefixHandle prefix, StringHandle localName, ValueHandle value) { }

	}

	internal class XmlEndOfFileNode : XmlNode
	{

		public XmlEndOfFileNode(XmlBufferReader bufferReader) { }

	}

	internal class XmlInitialNode : XmlNode
	{

		public XmlInitialNode(XmlBufferReader bufferReader) { }

	}

	internal class XmlNode
	{
		internal enum XmlNodeFlags
		{
			None = 0,
			CanGetAttribute = 1,
			CanMoveToElement = 2,
			HasValue = 4,
			AtomicValue = 8,
			SkipValue = 16,
			HasContent = 32,
		}

		private XmlNodeType nodeType; //Field offset: 0x8
		private PrefixHandle prefix; //Field offset: 0xC
		private StringHandle localName; //Field offset: 0x10
		private ValueHandle value; //Field offset: 0x14
		private Namespace ns; //Field offset: 0x18
		private bool hasValue; //Field offset: 0x1C
		private bool canGetAttribute; //Field offset: 0x1D
		private bool canMoveToElement; //Field offset: 0x1E
		private ReadState readState; //Field offset: 0x20
		private XmlAttributeTextNode attributeTextNode; //Field offset: 0x24
		private bool exitScope; //Field offset: 0x28
		private int depthDelta; //Field offset: 0x2C
		private bool isAtomicValue; //Field offset: 0x30
		private bool skipValue; //Field offset: 0x31
		private QNameType qnameType; //Field offset: 0x34
		private bool hasContent; //Field offset: 0x38
		private bool isEmptyElement; //Field offset: 0x39
		private char quoteChar; //Field offset: 0x3A

		public XmlAttributeTextNode AttributeText
		{
			 get { } //Length: 11
		}

		public bool CanGetAttribute
		{
			 get { } //Length: 11
		}

		public bool CanMoveToElement
		{
			 get { } //Length: 11
		}

		public int DepthDelta
		{
			 get { } //Length: 11
		}

		public bool ExitScope
		{
			 get { } //Length: 11
			 set { } //Length: 14
		}

		public bool HasContent
		{
			 get { } //Length: 11
		}

		public bool HasValue
		{
			 get { } //Length: 11
		}

		public bool IsAtomicValue
		{
			 get { } //Length: 11
			 set { } //Length: 14
		}

		public bool IsEmptyElement
		{
			 get { } //Length: 11
			 set { } //Length: 14
		}

		public StringHandle LocalName
		{
			 get { } //Length: 11
		}

		public Namespace Namespace
		{
			 get { } //Length: 11
			 set { } //Length: 27
		}

		public XmlNodeType NodeType
		{
			 get { } //Length: 11
			 set { } //Length: 14
		}

		public PrefixHandle Prefix
		{
			 get { } //Length: 11
		}

		public QNameType QNameType
		{
			 get { } //Length: 11
			 set { } //Length: 14
		}

		public char QuoteChar
		{
			 get { } //Length: 12
			 set { } //Length: 16
		}

		public ReadState ReadState
		{
			 get { } //Length: 11
		}

		public bool SkipValue
		{
			 get { } //Length: 11
		}

		public ValueHandle Value
		{
			 get { } //Length: 11
		}

		public string ValueAsString
		{
			 get { } //Length: 70
		}

		protected XmlNode(XmlNodeType nodeType, PrefixHandle prefix, StringHandle localName, ValueHandle value, XmlNodeFlags nodeFlags, ReadState readState, XmlAttributeTextNode attributeTextNode, int depthDelta) { }

		public XmlAttributeTextNode get_AttributeText() { }

		public bool get_CanGetAttribute() { }

		public bool get_CanMoveToElement() { }

		public int get_DepthDelta() { }

		public bool get_ExitScope() { }

		public bool get_HasContent() { }

		public bool get_HasValue() { }

		public bool get_IsAtomicValue() { }

		public bool get_IsEmptyElement() { }

		public StringHandle get_LocalName() { }

		public Namespace get_Namespace() { }

		public XmlNodeType get_NodeType() { }

		public PrefixHandle get_Prefix() { }

		public QNameType get_QNameType() { }

		public char get_QuoteChar() { }

		public ReadState get_ReadState() { }

		public bool get_SkipValue() { }

		public ValueHandle get_Value() { }

		public string get_ValueAsString() { }

		public bool IsLocalName(string localName) { }

		public bool IsLocalName(XmlDictionaryString localName) { }

		public bool IsLocalNameAndNamespaceUri(string localName, string ns) { }

		public bool IsLocalNameAndNamespaceUri(XmlDictionaryString localName, XmlDictionaryString ns) { }

		public bool IsNamespaceUri(string ns) { }

		public bool IsNamespaceUri(XmlDictionaryString ns) { }

		public bool IsPrefixAndLocalName(string prefix, string localName) { }

		public void set_ExitScope(bool value) { }

		public void set_IsAtomicValue(bool value) { }

		public void set_IsEmptyElement(bool value) { }

		public void set_Namespace(Namespace value) { }

		public void set_NodeType(XmlNodeType value) { }

		public void set_QNameType(QNameType value) { }

		public void set_QuoteChar(char value) { }

		public bool TryGetLocalNameAsDictionaryString(out XmlDictionaryString localName) { }

		public bool TryGetNamespaceUriAsDictionaryString(out XmlDictionaryString ns) { }

		public bool TryGetValueAsDictionaryString(out XmlDictionaryString value) { }

	}

	internal class XmlTextNode : XmlNode
	{

		protected XmlTextNode(XmlNodeType nodeType, PrefixHandle prefix, StringHandle localName, ValueHandle value, XmlNodeFlags nodeFlags, ReadState readState, XmlAttributeTextNode attributeTextNode, int depthDelta) { }

	}

	internal class XmlWhitespaceTextNode : XmlTextNode
	{

		public XmlWhitespaceTextNode(XmlBufferReader bufferReader) { }

	}

	private const string xmlNamespace = "http://www.w3.org/XML/1998/namespace"; //Field offset: 0x0
	private const string xml = "xml"; //Field offset: 0x0
	private const string xmlns = "xmlns"; //Field offset: 0x0
	private static XmlInitialNode initialNode; //Field offset: 0x0
	private const string xmlnsNamespace = "http://www.w3.org/2000/xmlns/"; //Field offset: 0x0
	private static XmlEndOfFileNode endOfFileNode; //Field offset: 0x4
	private static XmlClosedNode closedNode; //Field offset: 0x8
	private static BinHexEncoding binhexEncoding; //Field offset: 0xC
	private static Base64Encoding base64Encoding; //Field offset: 0x10
	private XmlBufferReader bufferReader; //Field offset: 0x8
	private XmlNode node; //Field offset: 0xC
	private NamespaceManager nsMgr; //Field offset: 0x10
	private XmlElementNode[] elementNodes; //Field offset: 0x14
	private XmlAttributeNode[] attributeNodes; //Field offset: 0x18
	private XmlAtomicTextNode atomicTextNode; //Field offset: 0x1C
	private int depth; //Field offset: 0x20
	private int attributeCount; //Field offset: 0x24
	private int attributeStart; //Field offset: 0x28
	private XmlDictionaryReaderQuotas quotas; //Field offset: 0x2C
	private XmlNameTable nameTable; //Field offset: 0x30
	private XmlDeclarationNode declarationNode; //Field offset: 0x34
	private XmlComplexTextNode complexTextNode; //Field offset: 0x38
	private XmlWhitespaceTextNode whitespaceTextNode; //Field offset: 0x3C
	private XmlCDataNode cdataNode; //Field offset: 0x40
	private XmlCommentNode commentNode; //Field offset: 0x44
	private XmlElementNode rootElementNode; //Field offset: 0x48
	private int attributeIndex; //Field offset: 0x4C
	private Char[] chars; //Field offset: 0x50
	private string prefix; //Field offset: 0x54
	private string localName; //Field offset: 0x58
	private string ns; //Field offset: 0x5C
	private string value; //Field offset: 0x60
	private int trailCharCount; //Field offset: 0x64
	private int trailByteCount; //Field offset: 0x68
	private Char[] trailChars; //Field offset: 0x6C
	private Byte[] trailBytes; //Field offset: 0x70
	private bool rootElement; //Field offset: 0x74
	private bool readingElement; //Field offset: 0x75
	private XmlSigningNodeWriter signingWriter; //Field offset: 0x78
	private bool signing; //Field offset: 0x7C
	private AttributeSorter attributeSorter; //Field offset: 0x80

	public virtual int AttributeCount
	{
		 get { } //Length: 33
	}

	private static Base64Encoding Base64Encoding
	{
		private get { } //Length: 193
	}

	public virtual string BaseURI
	{
		 get { } //Length: 11
	}

	private static BinHexEncoding BinHexEncoding
	{
		private get { } //Length: 193
	}

	protected XmlBufferReader BufferReader
	{
		 get { } //Length: 11
	}

	public virtual bool CanCanonicalize
	{
		 get { } //Length: 3
	}

	public virtual bool CanReadBinaryContent
	{
		 get { } //Length: 3
	}

	public virtual bool CanReadValueChunk
	{
		 get { } //Length: 3
	}

	public virtual int Depth
	{
		 get { } //Length: 26
	}

	protected XmlElementNode ElementNode
	{
		 get { } //Length: 47
	}

	public virtual bool EOF
	{
		 get { } //Length: 27
	}

	public virtual bool HasValue
	{
		 get { } //Length: 23
	}

	public virtual bool IsDefault
	{
		 get { } //Length: 3
	}

	public virtual bool IsEmptyElement
	{
		 get { } //Length: 23
	}

	public virtual string Item
	{
		 get { } //Length: 31
	}

	public virtual string Item
	{
		 get { } //Length: 31
	}

	public virtual string Item
	{
		 get { } //Length: 34
	}

	public virtual string LocalName
	{
		 get { } //Length: 45
	}

	public virtual string NamespaceURI
	{
		 get { } //Length: 45
	}

	public virtual XmlNameTable NameTable
	{
		 get { } //Length: 478
	}

	protected XmlNode Node
	{
		 get { } //Length: 11
	}

	public virtual XmlNodeType NodeType
	{
		 get { } //Length: 23
	}

	protected bool OutsideRootElement
	{
		 get { } //Length: 15
	}

	public virtual string Prefix
	{
		 get { } //Length: 283
	}

	public virtual XmlDictionaryReaderQuotas Quotas
	{
		 get { } //Length: 11
	}

	public virtual char QuoteChar
	{
		 get { } //Length: 24
	}

	public virtual ReadState ReadState
	{
		 get { } //Length: 23
	}

	protected bool Signing
	{
		 get { } //Length: 11
	}

	public virtual string Value
	{
		 get { } //Length: 95
	}

	public virtual Type ValueType
	{
		 get { } //Length: 198
	}

	public virtual string XmlLang
	{
		 get { } //Length: 23
	}

	public virtual XmlSpace XmlSpace
	{
		 get { } //Length: 23
	}

	private static XmlBaseReader() { }

	protected XmlBaseReader() { }

	private XmlAttributeNode AddAttribute(QNameType qnameType, bool isAtomicValue) { }

	protected XmlAttributeNode AddAttribute() { }

	protected Namespace AddNamespace() { }

	protected XmlAttributeNode AddXmlAttribute() { }

	protected XmlAttributeNode AddXmlnsAttribute(Namespace ns) { }

	private void CheckAttributes(XmlAttributeNode[] attributeNodes, int attributeCount) { }

	private bool CheckDeclAttribute(int index, string localName, string value, bool checkLower, string valueSR) { }

	private bool CheckStandalone(int attr) { }

	public virtual void Close() { }

	protected abstract XmlSigningNodeWriter CreateSigningNodeWriter() { }

	public virtual void EndCanonicalization() { }

	protected XmlElementNode EnterScope() { }

	protected void ExitScope() { }

	protected void FixXmlAttribute(XmlAttributeNode attributeNode) { }

	public virtual int get_AttributeCount() { }

	private static Base64Encoding get_Base64Encoding() { }

	public virtual string get_BaseURI() { }

	private static BinHexEncoding get_BinHexEncoding() { }

	protected XmlBufferReader get_BufferReader() { }

	public virtual bool get_CanCanonicalize() { }

	public virtual bool get_CanReadBinaryContent() { }

	public virtual bool get_CanReadValueChunk() { }

	public virtual int get_Depth() { }

	protected XmlElementNode get_ElementNode() { }

	public virtual bool get_EOF() { }

	public virtual bool get_HasValue() { }

	public virtual bool get_IsDefault() { }

	public virtual bool get_IsEmptyElement() { }

	public virtual string get_Item(string name) { }

	public virtual string get_Item(int index) { }

	public virtual string get_Item(string localName, string namespaceUri) { }

	public virtual string get_LocalName() { }

	public virtual string get_NamespaceURI() { }

	public virtual XmlNameTable get_NameTable() { }

	protected XmlNode get_Node() { }

	public virtual XmlNodeType get_NodeType() { }

	protected bool get_OutsideRootElement() { }

	public virtual string get_Prefix() { }

	public virtual XmlDictionaryReaderQuotas get_Quotas() { }

	public virtual char get_QuoteChar() { }

	public virtual ReadState get_ReadState() { }

	protected bool get_Signing() { }

	public virtual string get_Value() { }

	public virtual Type get_ValueType() { }

	public virtual string get_XmlLang() { }

	public virtual XmlSpace get_XmlSpace() { }

	public virtual string GetAttribute(string name) { }

	public virtual string GetAttribute(string localName, string namespaceUri) { }

	public virtual string GetAttribute(XmlDictionaryString localName, XmlDictionaryString namespaceUri) { }

	public virtual string GetAttribute(int index) { }

	private XmlAttributeNode GetAttributeNode(XmlDictionaryString localName, XmlDictionaryString namespaceUri) { }

	private XmlAttributeNode GetAttributeNode(string name) { }

	private XmlAttributeNode GetAttributeNode(int index) { }

	private XmlAttributeNode GetAttributeNode(string localName, string namespaceUri) { }

	private Char[] GetCharBuffer(int count) { }

	private string GetLocalName(bool enforceAtomization) { }

	private string GetNamespaceUri(bool enforceAtomization) { }

	public virtual void GetNonAtomizedNames(out string localName, out string namespaceUri) { }

	public string GetOpenElements() { }

	public virtual int IndexOfLocalName(String[] localNames, string namespaceUri) { }

	public virtual int IndexOfLocalName(XmlDictionaryString[] localNames, XmlDictionaryString namespaceUri) { }

	public virtual bool IsLocalName(XmlDictionaryString localName) { }

	public virtual bool IsLocalName(string localName) { }

	public virtual bool IsNamespaceUri(string namespaceUri) { }

	public virtual bool IsNamespaceUri(XmlDictionaryString namespaceUri) { }

	public virtual bool IsStartElement() { }

	public virtual bool IsStartElement(string name) { }

	public virtual bool IsStartElement(XmlDictionaryString localName, XmlDictionaryString namespaceUri) { }

	public virtual bool IsStartElement(string localName, string namespaceUri) { }

	protected Namespace LookupNamespace(PrefixHandle prefix) { }

	protected Namespace LookupNamespace(PrefixHandleType prefix) { }

	public virtual string LookupNamespace(string prefix) { }

	protected XmlAtomicTextNode MoveToAtomicText() { }

	public virtual bool MoveToAttribute(string localName, string namespaceUri) { }

	public virtual bool MoveToAttribute(string name) { }

	public virtual void MoveToAttribute(int index) { }

	protected XmlCDataNode MoveToCData() { }

	protected XmlCommentNode MoveToComment() { }

	protected XmlComplexTextNode MoveToComplexText() { }

	public virtual XmlNodeType MoveToContent() { }

	protected XmlDeclarationNode MoveToDeclaration() { }

	public virtual bool MoveToElement() { }

	protected void MoveToEndElement() { }

	protected void MoveToEndOfFile() { }

	public virtual bool MoveToFirstAttribute() { }

	protected void MoveToInitial(XmlDictionaryReaderQuotas quotas) { }

	public virtual bool MoveToNextAttribute() { }

	protected void MoveToNode(XmlNode node) { }

	protected XmlTextNode MoveToWhitespaceText() { }

	private void ProcessAttributes(XmlAttributeNode[] attributeNodes, int attributeCount) { }

	protected void ProcessAttributes() { }

	public virtual bool ReadAttributeValue() { }

	private int ReadBytes(Encoding encoding, int byteBlock, int charBlock, Byte[] buffer, int offset, int byteCount, bool readContent) { }

	public virtual object ReadContentAs(Type type, IXmlNamespaceResolver namespaceResolver) { }

	public virtual Byte[] ReadContentAsBase64() { }

	public virtual int ReadContentAsBase64(Byte[] buffer, int offset, int count) { }

	public virtual int ReadContentAsBinHex(Byte[] buffer, int offset, int count) { }

	public virtual Byte[] ReadContentAsBinHex() { }

	public virtual bool ReadContentAsBoolean() { }

	public virtual DateTime ReadContentAsDateTime() { }

	public virtual decimal ReadContentAsDecimal() { }

	public virtual double ReadContentAsDouble() { }

	public virtual float ReadContentAsFloat() { }

	public virtual Guid ReadContentAsGuid() { }

	public virtual int ReadContentAsInt() { }

	public virtual long ReadContentAsLong() { }

	public virtual object ReadContentAsObject() { }

	public virtual string ReadContentAsString() { }

	public virtual TimeSpan ReadContentAsTimeSpan() { }

	public virtual UniqueId ReadContentAsUniqueId() { }

	public virtual DateTime[] ReadDateTimeArray(string localName, string namespaceUri) { }

	public virtual DateTime[] ReadDateTimeArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri) { }

	public virtual Decimal[] ReadDecimalArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri) { }

	public virtual Decimal[] ReadDecimalArray(string localName, string namespaceUri) { }

	public virtual Double[] ReadDoubleArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri) { }

	public virtual Double[] ReadDoubleArray(string localName, string namespaceUri) { }

	public virtual int ReadElementContentAsBase64(Byte[] buffer, int offset, int count) { }

	public virtual int ReadElementContentAsBinHex(Byte[] buffer, int offset, int count) { }

	public virtual string ReadElementContentAsString() { }

	public virtual string ReadElementString() { }

	public virtual string ReadElementString(string localName, string namespaceUri) { }

	public virtual string ReadElementString(string name) { }

	public virtual void ReadEndElement() { }

	public virtual Guid[] ReadGuidArray(string localName, string namespaceUri) { }

	public virtual Guid[] ReadGuidArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri) { }

	public virtual Int16[] ReadInt16Array(string localName, string namespaceUri) { }

	public virtual Int16[] ReadInt16Array(XmlDictionaryString localName, XmlDictionaryString namespaceUri) { }

	public virtual Int32[] ReadInt32Array(string localName, string namespaceUri) { }

	public virtual Int32[] ReadInt32Array(XmlDictionaryString localName, XmlDictionaryString namespaceUri) { }

	public virtual Int64[] ReadInt64Array(string localName, string namespaceUri) { }

	public virtual Int64[] ReadInt64Array(XmlDictionaryString localName, XmlDictionaryString namespaceUri) { }

	public virtual Single[] ReadSingleArray(string localName, string namespaceUri) { }

	public virtual Single[] ReadSingleArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri) { }

	public virtual void ReadStartElement() { }

	public virtual void ReadStartElement(string name) { }

	public virtual void ReadStartElement(string localName, string namespaceUri) { }

	public virtual TimeSpan[] ReadTimeSpanArray(string localName, string namespaceUri) { }

	public virtual TimeSpan[] ReadTimeSpanArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri) { }

	public virtual int ReadValueAsBase64(Byte[] buffer, int offset, int count) { }

	public virtual int ReadValueChunk(Char[] chars, int offset, int count) { }

	public virtual void ResolveEntity() { }

	private void SignAttribute(XmlSigningNodeWriter writer, XmlAttributeNode attributeNode) { }

	private void SignEndElement(XmlSigningNodeWriter writer) { }

	private void SignNode(XmlSigningNodeWriter writer) { }

	protected void SignNode() { }

	private void SignStartElement(XmlSigningNodeWriter writer) { }

	public virtual void Skip() { }

	private void SkipValue(XmlNode node) { }

	public virtual void StartCanonicalization(Stream stream, bool includeComments, String[] inclusivePrefixes) { }

	public virtual bool TryGetBase64ContentLength(out int length) { }

	public virtual bool TryGetLocalNameAsDictionaryString(out XmlDictionaryString localName) { }

	public virtual bool TryGetNamespaceUriAsDictionaryString(out XmlDictionaryString localName) { }

	public virtual bool TryGetValueAsDictionaryString(out XmlDictionaryString value) { }

}

