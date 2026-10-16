namespace System.Xml;

internal sealed class XmlSqlBinaryReader : XmlReader, IXmlNamespaceResolver
{
	private struct AttrInfo
	{
		public QName name; //Field offset: 0x0
		public string val; //Field offset: 0xC
		public int contentPos; //Field offset: 0x10
		public int hashCode; //Field offset: 0x14
		public int prevHash; //Field offset: 0x18

		public void AdjustPosition(int adj) { }

		public void GetLocalnameAndNamespaceUri(out string localname, out string namespaceUri) { }

		public int GetLocalnameAndNamespaceUriAndHash(SecureStringHasher hasher, out string localname, out string namespaceUri) { }

		public bool MatchHashNS(int hash, string localname, string namespaceUri) { }

		public bool MatchNS(string localname, string namespaceUri) { }

		public void Set(QName n, string v) { }

		public void Set(QName n, int pos) { }

	}

	private struct ElemInfo
	{
		public QName name; //Field offset: 0x0
		public string xmlLang; //Field offset: 0xC
		public XmlSpace xmlSpace; //Field offset: 0x10
		public bool xmlspacePreserve; //Field offset: 0x14
		public NamespaceDecl nsdecls; //Field offset: 0x18

		public NamespaceDecl Clear() { }

		public void Set(QName name, bool xmlspacePreserve) { }

	}

	private class NamespaceDecl
	{
		public string prefix; //Field offset: 0x8
		public string uri; //Field offset: 0xC
		public NamespaceDecl scopeLink; //Field offset: 0x10
		public NamespaceDecl prevLink; //Field offset: 0x14
		public int scope; //Field offset: 0x18
		public bool implied; //Field offset: 0x1C

		public NamespaceDecl(string prefix, string nsuri, NamespaceDecl nextInScope, NamespaceDecl prevDecl, int scope, bool implied) { }

	}

	private class NestedBinXml
	{
		public SymbolTables symbolTables; //Field offset: 0x8
		public int docState; //Field offset: 0x18
		public NestedBinXml next; //Field offset: 0x1C

		public NestedBinXml(SymbolTables symbolTables, int docState, NestedBinXml next) { }

	}

	public struct QName
	{
		public string prefix; //Field offset: 0x0
		public string localname; //Field offset: 0x4
		public string namespaceUri; //Field offset: 0x8

		public QName(string prefix, string lname, string nsUri) { }

		public void CheckPrefixNS(string prefix, string namespaceUri) { }

		public void Clear() { }

		public virtual bool Equals(object other) { }

		public virtual int GetHashCode() { }

		public int GetNSHashCode(SecureStringHasher hasher) { }

		public bool MatchNs(string lname, string nsUri) { }

		public bool MatchPrefix(string prefix, string lname) { }

		public static bool op_Equality(QName a, QName b) { }

		public void Set(string prefix, string lname, string nsUri) { }

		public virtual string ToString() { }

	}

	private enum ScanState
	{
		Doc = 0,
		XmlText = 1,
		Attr = 2,
		AttrVal = 3,
		AttrValPseudoValue = 4,
		Init = 5,
		Error = 6,
		EOF = 7,
		Closed = 8,
	}

	private struct SymbolTables
	{
		public String[] symtable; //Field offset: 0x0
		public int symCount; //Field offset: 0x4
		public QName[] qnametable; //Field offset: 0x8
		public int qnameCount; //Field offset: 0xC

		public void Init() { }

	}

	internal static readonly Type TypeOfObject; //Field offset: 0x0
	internal static readonly Type TypeOfString; //Field offset: 0x4
	private static Type[] TokenTypeMap; //Field offset: 0x8
	private static Byte[] XsdKatmaiTimeScaleToValueLengthMap; //Field offset: 0xC
	private static ReadState[] ScanState2ReadState; //Field offset: 0x10
	private Stream inStrm; //Field offset: 0x8
	private Byte[] data; //Field offset: 0xC
	private int pos; //Field offset: 0x10
	private int mark; //Field offset: 0x14
	private int end; //Field offset: 0x18
	private long offset; //Field offset: 0x20
	private bool eof; //Field offset: 0x28
	private bool sniffed; //Field offset: 0x29
	private bool isEmpty; //Field offset: 0x2A
	private int docState; //Field offset: 0x2C
	private SymbolTables symbolTables; //Field offset: 0x30
	private XmlNameTable xnt; //Field offset: 0x40
	private bool xntFromSettings; //Field offset: 0x44
	private string xml; //Field offset: 0x48
	private string xmlns; //Field offset: 0x4C
	private string nsxmlns; //Field offset: 0x50
	private string baseUri; //Field offset: 0x54
	private ScanState state; //Field offset: 0x58
	private XmlNodeType nodetype; //Field offset: 0x5C
	private BinXmlToken token; //Field offset: 0x60
	private int attrIndex; //Field offset: 0x64
	private QName qnameOther; //Field offset: 0x68
	private QName qnameElement; //Field offset: 0x74
	private XmlNodeType parentNodeType; //Field offset: 0x80
	private ElemInfo[] elementStack; //Field offset: 0x84
	private int elemDepth; //Field offset: 0x88
	private AttrInfo[] attributes; //Field offset: 0x8C
	private Int32[] attrHashTbl; //Field offset: 0x90
	private int attrCount; //Field offset: 0x94
	private int posAfterAttrs; //Field offset: 0x98
	private bool xmlspacePreserve; //Field offset: 0x9C
	private int tokLen; //Field offset: 0xA0
	private int tokDataPos; //Field offset: 0xA4
	private bool hasTypedValue; //Field offset: 0xA8
	private Type valueType; //Field offset: 0xAC
	private string stringValue; //Field offset: 0xB0
	private Dictionary<String, NamespaceDecl> namespaces; //Field offset: 0xB4
	private NestedBinXml prevNameInfo; //Field offset: 0xB8
	private XmlReader textXmlReader; //Field offset: 0xBC
	private bool closeInput; //Field offset: 0xC0
	private bool checkCharacters; //Field offset: 0xC1
	private bool ignoreWhitespace; //Field offset: 0xC2
	private bool ignorePIs; //Field offset: 0xC3
	private bool ignoreComments; //Field offset: 0xC4
	private DtdProcessing dtdProcessing; //Field offset: 0xC8
	private SecureStringHasher hasher; //Field offset: 0xCC
	private XmlCharType xmlCharType; //Field offset: 0xD0
	private Encoding unicode; //Field offset: 0xD4
	private byte version; //Field offset: 0xD8

	public virtual int AttributeCount
	{
		 get { } //Length: 92
	}

	public virtual string BaseURI
	{
		 get { } //Length: 11
	}

	public virtual int Depth
	{
		 get { } //Length: 172
	}

	public virtual bool EOF
	{
		 get { } //Length: 15
	}

	public virtual bool HasValue
	{
		 get { } //Length: 116
	}

	public virtual bool IsEmptyElement
	{
		 get { } //Length: 21
	}

	public virtual string LocalName
	{
		 get { } //Length: 11
	}

	public virtual string NamespaceURI
	{
		 get { } //Length: 11
	}

	public virtual XmlNameTable NameTable
	{
		 get { } //Length: 11
	}

	public virtual XmlNodeType NodeType
	{
		 get { } //Length: 11
	}

	public virtual string Prefix
	{
		 get { } //Length: 11
	}

	public virtual ReadState ReadState
	{
		 get { } //Length: 93
	}

	public virtual XmlReaderSettings Settings
	{
		 get { } //Length: 242
	}

	public virtual string Value
	{
		 get { } //Length: 831
	}

	public virtual Type ValueType
	{
		 get { } //Length: 14
	}

	public virtual string XmlLang
	{
		 get { } //Length: 134
	}

	public virtual XmlSpace XmlSpace
	{
		 get { } //Length: 126
	}

	private static XmlSqlBinaryReader() { }

	public XmlSqlBinaryReader(Stream stream, Byte[] data, int len, string baseUri, bool closeInput, XmlReaderSettings settings) { }

	private void AddInitNamespace(string prefix, string uri) { }

	private void AddName() { }

	private void AddQName() { }

	private string CDATAValue() { }

	private void CheckAllowContent() { }

	private XmlNodeType CheckText(bool attr) { }

	private XmlNodeType CheckTextIsWS() { }

	private void CheckValueTokenBounds() { }

	private void ClearAttributes() { }

	public virtual void Close() { }

	private void Fill(int require) { }

	private void Fill_(int require) { }

	private bool FillAllowEOF() { }

	private void FinishCDATA() { }

	private int FinishContentAsXXX(int origPos) { }

	private void FinishEndElement() { }

	private void GenerateImpliedXmlnsAttrs() { }

	private void GenerateTokenTypeMap() { }

	public virtual int get_AttributeCount() { }

	public virtual string get_BaseURI() { }

	public virtual int get_Depth() { }

	public virtual bool get_EOF() { }

	public virtual bool get_HasValue() { }

	public virtual bool get_IsEmptyElement() { }

	public virtual string get_LocalName() { }

	public virtual string get_NamespaceURI() { }

	public virtual XmlNameTable get_NameTable() { }

	public virtual XmlNodeType get_NodeType() { }

	public virtual string get_Prefix() { }

	public virtual ReadState get_ReadState() { }

	public virtual XmlReaderSettings get_Settings() { }

	public virtual string get_Value() { }

	public virtual Type get_ValueType() { }

	public virtual string get_XmlLang() { }

	public virtual XmlSpace get_XmlSpace() { }

	public virtual string GetAttribute(string name) { }

	public virtual string GetAttribute(int i) { }

	public virtual string GetAttribute(string name, string ns) { }

	private string GetAttributeText(int i) { }

	private double GetDouble(int offset) { }

	private short GetInt16(int pos) { }

	private int GetInt32(int pos) { }

	private long GetInt64(int pos) { }

	private float GetSingle(int offset) { }

	private string GetString(int pos, int cch) { }

	private string GetStringAligned(Byte[] data, int offset, int cch) { }

	private ushort GetUInt16(int pos) { }

	private uint GetUInt32(int pos) { }

	private ulong GetUInt64(int pos) { }

	private XmlValueConverter GetValueConverter(XmlTypeCode typeCode) { }

	private Type GetValueType(BinXmlToken token) { }

	private int GetXsdKatmaiTokenLength(BinXmlToken token) { }

	private void GrowAttributes() { }

	private void GrowElements() { }

	private void HashCheckForDuplicateAttributes() { }

	private void ImplReadCDATA() { }

	private void ImplReadComment() { }

	private void ImplReadData(BinXmlToken tokenType) { }

	private void ImplReadDoctype() { }

	private void ImplReadElement() { }

	private void ImplReadEndElement() { }

	private void ImplReadEndNest() { }

	private void ImplReadNest() { }

	private void ImplReadPI() { }

	private void ImplReadXmlText() { }

	private int LocateAttribute(string name) { }

	private int LocateAttribute(string name, string ns) { }

	public virtual string LookupNamespace(string prefix) { }

	public virtual bool MoveToAttribute(string name, string ns) { }

	public virtual bool MoveToAttribute(string name) { }

	public virtual void MoveToAttribute(int i) { }

	public virtual bool MoveToElement() { }

	public virtual bool MoveToFirstAttribute() { }

	public virtual bool MoveToNextAttribute() { }

	private void NameFlush() { }

	private BinXmlToken NextToken() { }

	private BinXmlToken NextToken1() { }

	private BinXmlToken NextToken2(BinXmlToken token) { }

	private int ParseMB32(int pos) { }

	private int ParseMB32() { }

	private int ParseMB32_(byte b) { }

	private int ParseMB64() { }

	private string ParseText() { }

	private BinXmlToken PeekNextToken() { }

	private BinXmlToken PeekToken() { }

	private void PopNamespaces(NamespaceDecl firstInScopeChain) { }

	private void PositionOnAttribute(int i) { }

	private void PushNamespace(string prefix, string ns, bool implied) { }

	public virtual bool Read() { }

	public virtual bool ReadAttributeValue() { }

	private byte ReadByte() { }

	public virtual object ReadContentAs(Type returnType, IXmlNamespaceResolver namespaceResolver) { }

	public virtual bool ReadContentAsBoolean() { }

	public virtual DateTime ReadContentAsDateTime() { }

	public virtual decimal ReadContentAsDecimal() { }

	public virtual double ReadContentAsDouble() { }

	public virtual float ReadContentAsFloat() { }

	public virtual int ReadContentAsInt() { }

	public virtual long ReadContentAsLong() { }

	public virtual object ReadContentAsObject() { }

	private bool ReadDoc() { }

	private bool ReadInit(bool skipXmlDecl) { }

	private int ReadNameRef() { }

	private int ReadQNameRef() { }

	private BinXmlToken ReadToken() { }

	private ushort ReadUShort() { }

	private BinXmlToken RescanNextToken() { }

	private void ReScanOverValue(BinXmlToken token) { }

	public virtual void ResolveEntity() { }

	private void ScanAttributes() { }

	private XmlNodeType ScanOverAnyValue(BinXmlToken token, bool attr, bool checkChars) { }

	private XmlNodeType ScanOverValue(BinXmlToken token, bool attr, bool checkChars) { }

	private int ScanText(out int start) { }

	private bool SetupContentAsXXX(string name) { }

	private void SimpleCheckForDuplicateAttributes() { }

	private void SkipExtn() { }

	private override IDictionary<String, String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	private override string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	private Exception ThrowNotSupported(string res) { }

	private Exception ThrowUnexpectedToken(BinXmlToken token) { }

	private Exception ThrowXmlException(string res, string arg1, string arg2) { }

	private Exception ThrowXmlException(string res) { }

	private void UpdateFromTextReader() { }

	private bool UpdateFromTextReader(bool needUpdate) { }

	private object ValueAs(BinXmlToken token, Type returnType, IXmlNamespaceResolver namespaceResolver) { }

	private DateTime ValueAsDateTime() { }

	private DateTimeOffset ValueAsDateTimeOffset() { }

	private string ValueAsDateTimeString() { }

	private decimal ValueAsDecimal() { }

	private double ValueAsDouble() { }

	private long ValueAsLong() { }

	private object ValueAsObject(BinXmlToken token, bool returnInternalTypes) { }

	private string ValueAsString(BinXmlToken token) { }

	private ulong ValueAsULong() { }

	private void VerifyVersion(int requiredVersion, BinXmlToken token) { }

	private string XmlDeclValue() { }

	private int XsdKatmaiTimeScaleToValueLength(byte scale) { }

}

