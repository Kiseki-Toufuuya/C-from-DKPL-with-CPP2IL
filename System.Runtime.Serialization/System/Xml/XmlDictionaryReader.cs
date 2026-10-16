namespace System.Xml;

public abstract class XmlDictionaryReader : XmlReader
{
	[DefaultMember("Item")]
	private class XmlWrappedReader : XmlDictionaryReader, IXmlLineInfo
	{
		private XmlReader reader; //Field offset: 0x8
		private XmlNamespaceManager nsMgr; //Field offset: 0xC

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

		public virtual int Depth
		{
			 get { } //Length: 40
		}

		public virtual bool EOF
		{
			 get { } //Length: 40
		}

		public virtual bool HasValue
		{
			 get { } //Length: 40
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

		public override int LineNumber
		{
			 get { } //Length: 82
		}

		public override int LinePosition
		{
			 get { } //Length: 82
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

		public XmlWrappedReader(XmlReader reader, XmlNamespaceManager nsMgr) { }

		public virtual void Close() { }

		public virtual int get_AttributeCount() { }

		public virtual string get_BaseURI() { }

		public virtual bool get_CanReadBinaryContent() { }

		public virtual bool get_CanReadValueChunk() { }

		public virtual int get_Depth() { }

		public virtual bool get_EOF() { }

		public virtual bool get_HasValue() { }

		public virtual bool get_IsDefault() { }

		public virtual bool get_IsEmptyElement() { }

		public virtual string get_Item(string name, string namespaceUri) { }

		public virtual string get_Item(string name) { }

		public virtual string get_Item(int index) { }

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

		public virtual string get_Value() { }

		public virtual Type get_ValueType() { }

		public virtual string get_XmlLang() { }

		public virtual XmlSpace get_XmlSpace() { }

		public virtual string GetAttribute(int index) { }

		public virtual string GetAttribute(string name) { }

		public virtual string GetAttribute(string name, string namespaceUri) { }

		public override bool HasLineInfo() { }

		public virtual bool IsStartElement(string name) { }

		public virtual bool IsStartElement(string localName, string namespaceUri) { }

		public virtual string LookupNamespace(string namespaceUri) { }

		public virtual bool MoveToAttribute(string name, string namespaceUri) { }

		public virtual bool MoveToAttribute(string name) { }

		public virtual void MoveToAttribute(int index) { }

		public virtual bool MoveToElement() { }

		public virtual bool MoveToFirstAttribute() { }

		public virtual bool MoveToNextAttribute() { }

		public virtual bool Read() { }

		public virtual bool ReadAttributeValue() { }

		public virtual object ReadContentAs(Type type, IXmlNamespaceResolver namespaceResolver) { }

		public virtual int ReadContentAsBase64(Byte[] buffer, int offset, int count) { }

		public virtual int ReadContentAsBinHex(Byte[] buffer, int offset, int count) { }

		public virtual bool ReadContentAsBoolean() { }

		public virtual DateTime ReadContentAsDateTime() { }

		public virtual decimal ReadContentAsDecimal() { }

		public virtual double ReadContentAsDouble() { }

		public virtual float ReadContentAsFloat() { }

		public virtual int ReadContentAsInt() { }

		public virtual long ReadContentAsLong() { }

		public virtual string ReadContentAsString() { }

		public virtual int ReadElementContentAsBase64(Byte[] buffer, int offset, int count) { }

		public virtual int ReadElementContentAsBinHex(Byte[] buffer, int offset, int count) { }

		public virtual string ReadElementString(string localName, string namespaceUri) { }

		public virtual string ReadElementString(string name) { }

		public virtual void ReadEndElement() { }

		public virtual string ReadInnerXml() { }

		public virtual string ReadOuterXml() { }

		public virtual void ReadStartElement(string name) { }

		public virtual void ReadStartElement(string localName, string namespaceUri) { }

		public virtual string ReadString() { }

		public virtual int ReadValueChunk(Char[] chars, int offset, int count) { }

		public virtual void ResolveEntity() { }

	}

	internal const int MaxInitialArrayLength = 65535; //Field offset: 0x0

	public override bool CanCanonicalize
	{
		 get { } //Length: 3
	}

	public override XmlDictionaryReaderQuotas Quotas
	{
		 get { } //Length: 115
	}

	protected XmlDictionaryReader() { }

	private void CheckArray(Array array, int offset, int count) { }

	public static XmlDictionaryReader CreateBinaryReader(Byte[] buffer, XmlDictionaryReaderQuotas quotas) { }

	public static XmlDictionaryReader CreateBinaryReader(Byte[] buffer, int offset, int count, XmlDictionaryReaderQuotas quotas) { }

	public static XmlDictionaryReader CreateBinaryReader(Byte[] buffer, int offset, int count, IXmlDictionary dictionary, XmlDictionaryReaderQuotas quotas) { }

	public static XmlDictionaryReader CreateBinaryReader(Byte[] buffer, int offset, int count, IXmlDictionary dictionary, XmlDictionaryReaderQuotas quotas, XmlBinaryReaderSession session) { }

	public static XmlDictionaryReader CreateBinaryReader(Byte[] buffer, int offset, int count, IXmlDictionary dictionary, XmlDictionaryReaderQuotas quotas, XmlBinaryReaderSession session, OnXmlDictionaryReaderClose onClose) { }

	public static XmlDictionaryReader CreateBinaryReader(Stream stream, XmlDictionaryReaderQuotas quotas) { }

	public static XmlDictionaryReader CreateBinaryReader(Stream stream, IXmlDictionary dictionary, XmlDictionaryReaderQuotas quotas) { }

	public static XmlDictionaryReader CreateBinaryReader(Stream stream, IXmlDictionary dictionary, XmlDictionaryReaderQuotas quotas, XmlBinaryReaderSession session) { }

	public static XmlDictionaryReader CreateBinaryReader(Stream stream, IXmlDictionary dictionary, XmlDictionaryReaderQuotas quotas, XmlBinaryReaderSession session, OnXmlDictionaryReaderClose onClose) { }

	public static XmlDictionaryReader CreateDictionaryReader(XmlReader reader) { }

	public static XmlDictionaryReader CreateMtomReader(Byte[] buffer, int offset, int count, Encoding[] encodings, XmlDictionaryReaderQuotas quotas) { }

	public static XmlDictionaryReader CreateMtomReader(Byte[] buffer, int offset, int count, Encoding[] encodings, string contentType, XmlDictionaryReaderQuotas quotas, int maxBufferSize, OnXmlDictionaryReaderClose onClose) { }

	public static XmlDictionaryReader CreateMtomReader(Stream stream, Encoding encoding, XmlDictionaryReaderQuotas quotas) { }

	public static XmlDictionaryReader CreateMtomReader(Stream stream, Encoding[] encodings, XmlDictionaryReaderQuotas quotas) { }

	public static XmlDictionaryReader CreateMtomReader(Stream stream, Encoding[] encodings, string contentType, XmlDictionaryReaderQuotas quotas) { }

	public static XmlDictionaryReader CreateMtomReader(Stream stream, Encoding[] encodings, string contentType, XmlDictionaryReaderQuotas quotas, int maxBufferSize, OnXmlDictionaryReaderClose onClose) { }

	public static XmlDictionaryReader CreateMtomReader(Byte[] buffer, int offset, int count, Encoding encoding, XmlDictionaryReaderQuotas quotas) { }

	public static XmlDictionaryReader CreateMtomReader(Byte[] buffer, int offset, int count, Encoding[] encodings, string contentType, XmlDictionaryReaderQuotas quotas) { }

	public static XmlDictionaryReader CreateTextReader(Byte[] buffer, int offset, int count, XmlDictionaryReaderQuotas quotas) { }

	public static XmlDictionaryReader CreateTextReader(Byte[] buffer, int offset, int count, Encoding encoding, XmlDictionaryReaderQuotas quotas, OnXmlDictionaryReaderClose onClose) { }

	public static XmlDictionaryReader CreateTextReader(Stream stream, Encoding encoding, XmlDictionaryReaderQuotas quotas, OnXmlDictionaryReaderClose onClose) { }

	public static XmlDictionaryReader CreateTextReader(Stream stream, XmlDictionaryReaderQuotas quotas) { }

	public static XmlDictionaryReader CreateTextReader(Byte[] buffer, XmlDictionaryReaderQuotas quotas) { }

	public override void EndCanonicalization() { }

	public override bool get_CanCanonicalize() { }

	public override XmlDictionaryReaderQuotas get_Quotas() { }

	public override string GetAttribute(XmlDictionaryString localName, XmlDictionaryString namespaceUri) { }

	public override void GetNonAtomizedNames(out string localName, out string namespaceUri) { }

	public override int IndexOfLocalName(XmlDictionaryString[] localNames, XmlDictionaryString namespaceUri) { }

	public override int IndexOfLocalName(String[] localNames, string namespaceUri) { }

	public override bool IsLocalName(string localName) { }

	public override bool IsLocalName(XmlDictionaryString localName) { }

	public override bool IsNamespaceUri(string namespaceUri) { }

	public override bool IsNamespaceUri(XmlDictionaryString namespaceUri) { }

	public override bool IsStartArray(out Type type) { }

	public override bool IsStartElement(XmlDictionaryString localName, XmlDictionaryString namespaceUri) { }

	protected bool IsTextNode(XmlNodeType nodeType) { }

	public override void MoveToStartElement(string localName, string namespaceUri) { }

	public override void MoveToStartElement() { }

	public override void MoveToStartElement(string name) { }

	public override void MoveToStartElement(XmlDictionaryString localName, XmlDictionaryString namespaceUri) { }

	public override int ReadArray(string localName, string namespaceUri, DateTime[] array, int offset, int count) { }

	public override int ReadArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri, Guid[] array, int offset, int count) { }

	public override int ReadArray(string localName, string namespaceUri, TimeSpan[] array, int offset, int count) { }

	public override int ReadArray(string localName, string namespaceUri, Boolean[] array, int offset, int count) { }

	public override int ReadArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri, Boolean[] array, int offset, int count) { }

	public override int ReadArray(string localName, string namespaceUri, Int16[] array, int offset, int count) { }

	public override int ReadArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri, Int16[] array, int offset, int count) { }

	public override int ReadArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri, TimeSpan[] array, int offset, int count) { }

	public override int ReadArray(string localName, string namespaceUri, Int32[] array, int offset, int count) { }

	public override int ReadArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri, Int32[] array, int offset, int count) { }

	public override int ReadArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri, Decimal[] array, int offset, int count) { }

	public override int ReadArray(string localName, string namespaceUri, Guid[] array, int offset, int count) { }

	public override int ReadArray(string localName, string namespaceUri, Int64[] array, int offset, int count) { }

	public override int ReadArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri, Single[] array, int offset, int count) { }

	public override int ReadArray(string localName, string namespaceUri, Decimal[] array, int offset, int count) { }

	public override int ReadArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri, Double[] array, int offset, int count) { }

	public override int ReadArray(string localName, string namespaceUri, Double[] array, int offset, int count) { }

	public override int ReadArray(string localName, string namespaceUri, Single[] array, int offset, int count) { }

	public override int ReadArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri, DateTime[] array, int offset, int count) { }

	public override int ReadArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri, Int64[] array, int offset, int count) { }

	public override Boolean[] ReadBooleanArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri) { }

	public override Boolean[] ReadBooleanArray(string localName, string namespaceUri) { }

	public virtual object ReadContentAs(Type type, IXmlNamespaceResolver namespaceResolver) { }

	internal Byte[] ReadContentAsBase64(int maxByteArrayContentLength, int maxInitialCount) { }

	public override Byte[] ReadContentAsBase64() { }

	public override Byte[] ReadContentAsBinHex() { }

	protected Byte[] ReadContentAsBinHex(int maxByteArrayContentLength) { }

	private Byte[] ReadContentAsBytes(bool base64, int maxByteArrayContentLength) { }

	public override int ReadContentAsChars(Char[] chars, int offset, int count) { }

	public virtual decimal ReadContentAsDecimal() { }

	public virtual float ReadContentAsFloat() { }

	public override Guid ReadContentAsGuid() { }

	public override void ReadContentAsQualifiedName(out string localName, out string namespaceUri) { }

	public override string ReadContentAsString(String[] strings, out int index) { }

	public override string ReadContentAsString(XmlDictionaryString[] strings, out int index) { }

	protected string ReadContentAsString(int maxStringContentLength) { }

	public virtual string ReadContentAsString() { }

	public override TimeSpan ReadContentAsTimeSpan() { }

	public override UniqueId ReadContentAsUniqueId() { }

	public override DateTime[] ReadDateTimeArray(string localName, string namespaceUri) { }

	public override DateTime[] ReadDateTimeArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri) { }

	public override Decimal[] ReadDecimalArray(string localName, string namespaceUri) { }

	public override Decimal[] ReadDecimalArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri) { }

	public override Double[] ReadDoubleArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri) { }

	public override Double[] ReadDoubleArray(string localName, string namespaceUri) { }

	public override Byte[] ReadElementContentAsBase64() { }

	public override Byte[] ReadElementContentAsBinHex() { }

	public virtual bool ReadElementContentAsBoolean() { }

	public virtual DateTime ReadElementContentAsDateTime() { }

	public virtual decimal ReadElementContentAsDecimal() { }

	public virtual double ReadElementContentAsDouble() { }

	public virtual float ReadElementContentAsFloat() { }

	public override Guid ReadElementContentAsGuid() { }

	public virtual int ReadElementContentAsInt() { }

	public virtual long ReadElementContentAsLong() { }

	public virtual string ReadElementContentAsString() { }

	public override TimeSpan ReadElementContentAsTimeSpan() { }

	public override UniqueId ReadElementContentAsUniqueId() { }

	public override void ReadFullStartElement() { }

	public override void ReadFullStartElement(string name) { }

	public override void ReadFullStartElement(string localName, string namespaceUri) { }

	public override void ReadFullStartElement(XmlDictionaryString localName, XmlDictionaryString namespaceUri) { }

	public override Guid[] ReadGuidArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri) { }

	public override Guid[] ReadGuidArray(string localName, string namespaceUri) { }

	public override Int16[] ReadInt16Array(XmlDictionaryString localName, XmlDictionaryString namespaceUri) { }

	public override Int16[] ReadInt16Array(string localName, string namespaceUri) { }

	public override Int32[] ReadInt32Array(XmlDictionaryString localName, XmlDictionaryString namespaceUri) { }

	public override Int32[] ReadInt32Array(string localName, string namespaceUri) { }

	public override Int64[] ReadInt64Array(XmlDictionaryString localName, XmlDictionaryString namespaceUri) { }

	public override Int64[] ReadInt64Array(string localName, string namespaceUri) { }

	public override Single[] ReadSingleArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri) { }

	public override Single[] ReadSingleArray(string localName, string namespaceUri) { }

	public override void ReadStartElement(XmlDictionaryString localName, XmlDictionaryString namespaceUri) { }

	public virtual string ReadString() { }

	protected string ReadString(int maxStringContentLength) { }

	public override TimeSpan[] ReadTimeSpanArray(string localName, string namespaceUri) { }

	public override TimeSpan[] ReadTimeSpanArray(XmlDictionaryString localName, XmlDictionaryString namespaceUri) { }

	public override int ReadValueAsBase64(Byte[] buffer, int offset, int count) { }

	public override void StartCanonicalization(Stream stream, bool includeComments, String[] inclusivePrefixes) { }

	public override bool TryGetArrayLength(out int count) { }

	public override bool TryGetBase64ContentLength(out int length) { }

	public override bool TryGetLocalNameAsDictionaryString(out XmlDictionaryString localName) { }

	public override bool TryGetNamespaceUriAsDictionaryString(out XmlDictionaryString namespaceUri) { }

	public override bool TryGetValueAsDictionaryString(out XmlDictionaryString value) { }

}

