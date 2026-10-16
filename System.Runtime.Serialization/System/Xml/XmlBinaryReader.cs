namespace System.Xml;

internal class XmlBinaryReader : XmlBaseReader, IXmlBinaryReaderInitializer
{
	private enum ArrayState
	{
		None = 0,
		Element = 1,
		Content = 2,
	}

	private bool isTextWithEndElement; //Field offset: 0x84
	private bool buffered; //Field offset: 0x85
	private ArrayState arrayState; //Field offset: 0x88
	private int arrayCount; //Field offset: 0x8C
	private int maxBytesPerRead; //Field offset: 0x90
	private XmlBinaryNodeType arrayNodeType; //Field offset: 0x94
	private OnXmlDictionaryReaderClose onClose; //Field offset: 0x98

	public XmlBinaryReader() { }

	private bool CanOptimizeReadElementContent() { }

	private void CheckArray(Array array, int offset, int count) { }

	public virtual void Close() { }

	protected virtual XmlSigningNodeWriter CreateSigningNodeWriter() { }

	private XmlBinaryNodeType GetNodeType() { }

	private void InsertNode(XmlBinaryNodeType nodeType, int length) { }

	public virtual bool IsStartArray(out Type type) { }

	private bool IsStartArray(string localName, string namespaceUri, XmlBinaryNodeType nodeType) { }

	private bool IsStartArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri, XmlBinaryNodeType nodeType) { }

	private bool IsValidArrayType(XmlBinaryNodeType nodeType) { }

	private void MoveToArrayElement() { }

	private XmlAtomicTextNode MoveToAtomicTextWithEndElement() { }

	private void MoveToInitial(XmlDictionaryReaderQuotas quotas, XmlBinaryReaderSession session, OnXmlDictionaryReaderClose onClose) { }

	public virtual bool Read() { }

	private int ReadArray(Boolean[] array, int offset, int count) { }

	private int ReadArray(Double[] array, int offset, int count) { }

	public virtual int ReadArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri, Single[] array, int offset, int count) { }

	public virtual int ReadArray(string localName, string namespaceUri, Int16[] array, int offset, int count) { }

	public virtual int ReadArray(string localName, string namespaceUri, Single[] array, int offset, int count) { }

	private int ReadArray(Single[] array, int offset, int count) { }

	public virtual int ReadArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri, Int64[] array, int offset, int count) { }

	public virtual int ReadArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri, TimeSpan[] array, int offset, int count) { }

	public virtual int ReadArray(string localName, string namespaceUri, Int64[] array, int offset, int count) { }

	private void ReadArray() { }

	private int ReadArray(Int16[] array, int offset, int count) { }

	public virtual int ReadArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri, Boolean[] array, int offset, int count) { }

	private int ReadArray(Int64[] array, int offset, int count) { }

	public virtual int ReadArray(string localName, string namespaceUri, Boolean[] array, int offset, int count) { }

	public virtual int ReadArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri, Int32[] array, int offset, int count) { }

	public virtual int ReadArray(string localName, string namespaceUri, Int32[] array, int offset, int count) { }

	public virtual int ReadArray(string localName, string namespaceUri, Double[] array, int offset, int count) { }

	private int ReadArray(Int32[] array, int offset, int count) { }

	public virtual int ReadArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri, Double[] array, int offset, int count) { }

	public virtual int ReadArray(string localName, string namespaceUri, TimeSpan[] array, int offset, int count) { }

	private int ReadArray(TimeSpan[] array, int offset, int count) { }

	public virtual int ReadArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri, Guid[] array, int offset, int count) { }

	public virtual int ReadArray(string localName, string namespaceUri, Guid[] array, int offset, int count) { }

	public virtual int ReadArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri, Int16[] array, int offset, int count) { }

	public virtual int ReadArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri, DateTime[] array, int offset, int count) { }

	public virtual int ReadArray(string localName, string namespaceUri, DateTime[] array, int offset, int count) { }

	private int ReadArray(Guid[] array, int offset, int count) { }

	private int ReadArray(DateTime[] array, int offset, int count) { }

	private int ReadArray(Decimal[] array, int offset, int count) { }

	public virtual int ReadArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri, Decimal[] array, int offset, int count) { }

	public virtual int ReadArray(string localName, string namespaceUri, Decimal[] array, int offset, int count) { }

	private void ReadAttributes() { }

	private void ReadAttributes2() { }

	private void ReadAttributeText(XmlAttributeTextNode textNode) { }

	private void ReadBinaryText(XmlTextNode textNode, int length) { }

	private int ReadDictionaryKey() { }

	private void ReadDictionaryName(StringHandle s) { }

	public virtual bool ReadElementContentAsBoolean() { }

	public virtual DateTime ReadElementContentAsDateTime() { }

	public virtual decimal ReadElementContentAsDecimal() { }

	public virtual double ReadElementContentAsDouble() { }

	public virtual float ReadElementContentAsFloat() { }

	public virtual Guid ReadElementContentAsGuid() { }

	public virtual int ReadElementContentAsInt() { }

	public virtual string ReadElementContentAsString() { }

	public virtual TimeSpan ReadElementContentAsTimeSpan() { }

	public virtual UniqueId ReadElementContentAsUniqueId() { }

	private int ReadMultiByteUInt31() { }

	private void ReadName(PrefixHandle prefix) { }

	private void ReadName(StringHandle handle) { }

	private void ReadName(ValueHandle value) { }

	private bool ReadNode() { }

	private void ReadPartialBinaryText(bool withEndElement, int length) { }

	private void ReadPartialUnicodeText(bool withEndElement, int length) { }

	private void ReadPartialUTF8Text(bool withEndElement, int length) { }

	private void ReadText(XmlTextNode textNode, ValueHandleType type, int length) { }

	private void ReadTextWithEndElement() { }

	private int ReadUInt16() { }

	private int ReadUInt31() { }

	private int ReadUInt8() { }

	private void ReadUnicodeText(bool withEndElement, int length) { }

	public override void SetInput(Byte[] buffer, int offset, int count, IXmlDictionary dictionary, XmlDictionaryReaderQuotas quotas, XmlBinaryReaderSession session, OnXmlDictionaryReaderClose onClose) { }

	public override void SetInput(Stream stream, IXmlDictionary dictionary, XmlDictionaryReaderQuotas quotas, XmlBinaryReaderSession session, OnXmlDictionaryReaderClose onClose) { }

	private void SkipArrayElements(int count) { }

	private void SkipNodeType() { }

	public virtual bool TryGetArrayLength(out int count) { }

	public virtual bool TryGetBase64ContentLength(out int length) { }

	private void VerifyWhitespace() { }

}

