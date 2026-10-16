namespace System.Runtime.Serialization;

internal class XmlReaderDelegator
{
	protected XmlReader reader; //Field offset: 0x8
	protected XmlDictionaryReader dictionaryReader; //Field offset: 0xC
	protected bool isEndOfEmptyElement; //Field offset: 0x10

	internal int AttributeCount
	{
		internal get { } //Length: 50
	}

	internal int Depth
	{
		internal get { } //Length: 40
	}

	internal bool EOF
	{
		internal get { } //Length: 40
	}

	internal bool IsEmptyElement
	{
		internal get { } //Length: 3
	}

	internal int LineNumber
	{
		internal get { } //Length: 77
	}

	internal int LinePosition
	{
		internal get { } //Length: 77
	}

	public string LocalName
	{
		 get { } //Length: 40
	}

	internal string Name
	{
		internal get { } //Length: 40
	}

	internal string NamespaceURI
	{
		internal get { } //Length: 40
	}

	public XmlNodeType NodeType
	{
		 get { } //Length: 53
	}

	internal bool Normalized
	{
		internal get { } //Length: 173
		internal set { } //Length: 171
	}

	internal ExtensionDataReader UnderlyingExtensionDataReader
	{
		internal get { } //Length: 112
	}

	internal XmlReader UnderlyingReader
	{
		internal get { } //Length: 11
	}

	internal string Value
	{
		internal get { } //Length: 40
	}

	internal Type ValueType
	{
		internal get { } //Length: 40
	}

	internal WhitespaceHandling WhitespaceHandling
	{
		internal get { } //Length: 176
		internal set { } //Length: 260
	}

	public XmlReaderDelegator(XmlReader reader) { }

	private void CheckActualArrayLength(int expectedLength, int actualLength, XmlDictionaryString itemName, XmlDictionaryString itemNamespace) { }

	private void CheckExpectedArrayLength(XmlObjectSerializerReadContext context, int arrayLength) { }

	private Exception CreateInvalidPrimitiveTypeException(Type type) { }

	internal int get_AttributeCount() { }

	internal int get_Depth() { }

	internal bool get_EOF() { }

	internal bool get_IsEmptyElement() { }

	internal int get_LineNumber() { }

	internal int get_LinePosition() { }

	public string get_LocalName() { }

	internal string get_Name() { }

	internal string get_NamespaceURI() { }

	public XmlNodeType get_NodeType() { }

	internal bool get_Normalized() { }

	internal ExtensionDataReader get_UnderlyingExtensionDataReader() { }

	internal XmlReader get_UnderlyingReader() { }

	internal string get_Value() { }

	internal Type get_ValueType() { }

	internal WhitespaceHandling get_WhitespaceHandling() { }

	protected int GetArrayLengthQuota(XmlObjectSerializerReadContext context) { }

	internal string GetAttribute(int i) { }

	internal string GetAttribute(string name, string namespaceUri) { }

	internal string GetAttribute(string name) { }

	internal IDictionary<String, String> GetNamespacesInScope(XmlNamespaceScope scope) { }

	internal bool HasLineInfo() { }

	internal int IndexOfLocalName(XmlDictionaryString[] localNames, XmlDictionaryString ns) { }

	internal bool IsLocalName(string localName) { }

	internal bool IsLocalName(XmlDictionaryString localName) { }

	internal bool IsNamespaceUri(XmlDictionaryString ns) { }

	internal bool IsNamespaceURI(string ns) { }

	public bool IsStartElement() { }

	public bool IsStartElement(XmlDictionaryString localname, XmlDictionaryString ns) { }

	internal bool IsStartElement(string localname, string ns) { }

	internal string LookupNamespace(string prefix) { }

	internal bool MoveToAttribute(string name, string ns) { }

	internal void MoveToAttribute(int i) { }

	internal bool MoveToAttribute(string name) { }

	internal XmlNodeType MoveToContent() { }

	internal bool MoveToElement() { }

	internal bool MoveToFirstAttribute() { }

	internal bool MoveToNextAttribute() { }

	private XmlQualifiedName ParseQualifiedName(string str) { }

	internal bool Read() { }

	internal bool ReadAttributeValue() { }

	internal object ReadContentAsAnyType(Type valueType) { }

	internal override Byte[] ReadContentAsBase64() { }

	internal Byte[] ReadContentAsBase64(string str) { }

	internal bool ReadContentAsBoolean() { }

	internal override char ReadContentAsChar() { }

	internal override DateTime ReadContentAsDateTime() { }

	internal decimal ReadContentAsDecimal() { }

	internal double ReadContentAsDouble() { }

	internal Guid ReadContentAsGuid() { }

	internal int ReadContentAsInt() { }

	internal long ReadContentAsLong() { }

	internal override XmlQualifiedName ReadContentAsQName() { }

	internal short ReadContentAsShort() { }

	internal sbyte ReadContentAsSignedByte() { }

	internal float ReadContentAsSingle() { }

	internal string ReadContentAsString() { }

	internal TimeSpan ReadContentAsTimeSpan() { }

	internal byte ReadContentAsUnsignedByte() { }

	internal uint ReadContentAsUnsignedInt() { }

	internal override ulong ReadContentAsUnsignedLong() { }

	internal ushort ReadContentAsUnsignedShort() { }

	internal Uri ReadContentAsUri() { }

	public object ReadElementContentAsAnyType(Type valueType) { }

	internal override Byte[] ReadElementContentAsBase64() { }

	public bool ReadElementContentAsBoolean() { }

	internal override char ReadElementContentAsChar() { }

	internal override DateTime ReadElementContentAsDateTime() { }

	public decimal ReadElementContentAsDecimal() { }

	public double ReadElementContentAsDouble() { }

	public float ReadElementContentAsFloat() { }

	public Guid ReadElementContentAsGuid() { }

	public int ReadElementContentAsInt() { }

	public long ReadElementContentAsLong() { }

	public XmlQualifiedName ReadElementContentAsQName() { }

	public short ReadElementContentAsShort() { }

	public sbyte ReadElementContentAsSignedByte() { }

	public string ReadElementContentAsString() { }

	public TimeSpan ReadElementContentAsTimeSpan() { }

	public byte ReadElementContentAsUnsignedByte() { }

	public uint ReadElementContentAsUnsignedInt() { }

	internal override ulong ReadElementContentAsUnsignedLong() { }

	public ushort ReadElementContentAsUnsignedShort() { }

	public Uri ReadElementContentAsUri() { }

	public void ReadEndElement() { }

	internal IDataNode ReadExtensionData(Type valueType) { }

	internal void set_Normalized(bool value) { }

	internal void set_WhitespaceHandling(WhitespaceHandling value) { }

	internal void Skip() { }

	private void ThrowConversionException(string value, string type) { }

	private void ThrowNotAtElement() { }

	private byte ToByte(int value) { }

	private char ToChar(int value) { }

	private sbyte ToSByte(int value) { }

	private short ToShort(int value) { }

	private ushort ToUInt16(int value) { }

	private uint ToUInt32(long value) { }

	internal bool TryReadBooleanArray(XmlObjectSerializerReadContext context, XmlDictionaryString itemName, XmlDictionaryString itemNamespace, int arrayLength, out Boolean[] array) { }

	internal bool TryReadDateTimeArray(XmlObjectSerializerReadContext context, XmlDictionaryString itemName, XmlDictionaryString itemNamespace, int arrayLength, out DateTime[] array) { }

	internal bool TryReadDecimalArray(XmlObjectSerializerReadContext context, XmlDictionaryString itemName, XmlDictionaryString itemNamespace, int arrayLength, out Decimal[] array) { }

	internal bool TryReadDoubleArray(XmlObjectSerializerReadContext context, XmlDictionaryString itemName, XmlDictionaryString itemNamespace, int arrayLength, out Double[] array) { }

	internal bool TryReadInt32Array(XmlObjectSerializerReadContext context, XmlDictionaryString itemName, XmlDictionaryString itemNamespace, int arrayLength, out Int32[] array) { }

	internal bool TryReadInt64Array(XmlObjectSerializerReadContext context, XmlDictionaryString itemName, XmlDictionaryString itemNamespace, int arrayLength, out Int64[] array) { }

	internal bool TryReadSingleArray(XmlObjectSerializerReadContext context, XmlDictionaryString itemName, XmlDictionaryString itemNamespace, int arrayLength, out Single[] array) { }

}

