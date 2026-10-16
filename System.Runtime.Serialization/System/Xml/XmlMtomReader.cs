namespace System.Xml;

[DefaultMember("Item")]
internal class XmlMtomReader : XmlDictionaryReader, IXmlLineInfo, IXmlMtomReaderInitializer
{
	public class MimePart
	{
		private Stream stream; //Field offset: 0x8
		private MimeHeaders headers; //Field offset: 0xC
		private Byte[] buffer; //Field offset: 0x10
		private bool isReferencedFromInfoset; //Field offset: 0x14

		internal MimeHeaders Headers
		{
			internal get { } //Length: 11
		}

		internal long Length
		{
			internal get { } //Length: 80
		}

		internal bool ReferencedFromInfoset
		{
			internal get { } //Length: 11
			internal set { } //Length: 14
		}

		internal Stream Stream
		{
			internal get { } //Length: 11
		}

		internal MimePart(Stream stream, MimeHeaders headers) { }

		internal MimeHeaders get_Headers() { }

		internal long get_Length() { }

		internal bool get_ReferencedFromInfoset() { }

		internal Stream get_Stream() { }

		internal Byte[] GetBuffer(int maxBuffer, ref int remaining) { }

		internal void Release(int maxBuffer, ref int remaining) { }

		internal void set_ReferencedFromInfoset(bool value) { }

	}

	[DefaultMember("Item")]
	public class XopIncludeReader : XmlDictionaryReader, IXmlLineInfo
	{
		private int chunkSize; //Field offset: 0x8
		private int bytesRemaining; //Field offset: 0xC
		private MimePart part; //Field offset: 0x10
		private ReadState readState; //Field offset: 0x14
		private XmlDictionaryReader parentReader; //Field offset: 0x18
		private string stringValue; //Field offset: 0x1C
		private int stringOffset; //Field offset: 0x20
		private XmlNodeType nodeType; //Field offset: 0x24
		private MemoryStream binHexStream; //Field offset: 0x28
		private Byte[] valueBuffer; //Field offset: 0x2C
		private int valueOffset; //Field offset: 0x30
		private int valueCount; //Field offset: 0x34
		private bool finishedStream; //Field offset: 0x38

		public virtual int AttributeCount
		{
			 get { } //Length: 3
		}

		public virtual string BaseURI
		{
			 get { } //Length: 40
		}

		public virtual bool CanReadBinaryContent
		{
			 get { } //Length: 3
		}

		public virtual bool CanReadValueChunk
		{
			 get { } //Length: 3
		}

		public virtual bool CanResolveEntity
		{
			 get { } //Length: 40
		}

		public virtual int Depth
		{
			 get { } //Length: 73
		}

		public virtual bool EOF
		{
			 get { } //Length: 15
		}

		public virtual bool HasAttributes
		{
			 get { } //Length: 3
		}

		public virtual bool HasValue
		{
			 get { } //Length: 15
		}

		public virtual bool IsDefault
		{
			 get { } //Length: 3
		}

		public virtual bool IsEmptyElement
		{
			 get { } //Length: 3
		}

		public virtual string Item
		{
			 get { } //Length: 3
		}

		public virtual string Item
		{
			 get { } //Length: 3
		}

		public virtual string Item
		{
			 get { } //Length: 3
		}

		public virtual string LocalName
		{
			 get { } //Length: 58
		}

		public virtual string Name
		{
			 get { } //Length: 58
		}

		public virtual string NamespaceURI
		{
			 get { } //Length: 58
		}

		public virtual XmlNameTable NameTable
		{
			 get { } //Length: 40
		}

		public virtual XmlNodeType NodeType
		{
			 get { } //Length: 51
		}

		public virtual string Prefix
		{
			 get { } //Length: 58
		}

		public virtual XmlDictionaryReaderQuotas Quotas
		{
			 get { } //Length: 40
		}

		public virtual char QuoteChar
		{
			 get { } //Length: 40
		}

		public virtual ReadState ReadState
		{
			 get { } //Length: 11
		}

		public virtual XmlReaderSettings Settings
		{
			 get { } //Length: 40
		}

		private override int System.Xml.IXmlLineInfo.LineNumber
		{
			private get { } //Length: 117
		}

		private override int System.Xml.IXmlLineInfo.LinePosition
		{
			private get { } //Length: 117
		}

		public virtual string Value
		{
			 get { } //Length: 369
		}

		public virtual Type ValueType
		{
			 get { } //Length: 116
		}

		public virtual string XmlLang
		{
			 get { } //Length: 40
		}

		public virtual XmlSpace XmlSpace
		{
			 get { } //Length: 40
		}

		public XopIncludeReader(MimePart part, XmlDictionaryReader reader) { }

		public virtual void Close() { }

		private void CloseStreams() { }

		public virtual int get_AttributeCount() { }

		public virtual string get_BaseURI() { }

		public virtual bool get_CanReadBinaryContent() { }

		public virtual bool get_CanReadValueChunk() { }

		public virtual bool get_CanResolveEntity() { }

		public virtual int get_Depth() { }

		public virtual bool get_EOF() { }

		public virtual bool get_HasAttributes() { }

		public virtual bool get_HasValue() { }

		public virtual bool get_IsDefault() { }

		public virtual bool get_IsEmptyElement() { }

		public virtual string get_Item(int index) { }

		public virtual string get_Item(string name, string ns) { }

		public virtual string get_Item(string name) { }

		public virtual string get_LocalName() { }

		public virtual string get_Name() { }

		public virtual string get_NamespaceURI() { }

		public virtual XmlNameTable get_NameTable() { }

		public virtual XmlNodeType get_NodeType() { }

		public virtual string get_Prefix() { }

		public virtual XmlDictionaryReaderQuotas get_Quotas() { }

		public virtual char get_QuoteChar() { }

		public virtual ReadState get_ReadState() { }

		public virtual XmlReaderSettings get_Settings() { }

		public virtual string get_Value() { }

		public virtual Type get_ValueType() { }

		public virtual string get_XmlLang() { }

		public virtual XmlSpace get_XmlSpace() { }

		public virtual string GetAttribute(int index) { }

		public virtual string GetAttribute(XmlDictionaryString localName, XmlDictionaryString ns) { }

		public virtual string GetAttribute(string name, string ns) { }

		public virtual string GetAttribute(string name) { }

		public virtual bool IsLocalName(string localName) { }

		public virtual bool IsLocalName(XmlDictionaryString localName) { }

		public virtual bool IsNamespaceUri(string ns) { }

		public virtual bool IsNamespaceUri(XmlDictionaryString ns) { }

		public virtual bool IsStartElement() { }

		public virtual bool IsStartElement(string localName) { }

		public virtual bool IsStartElement(string localName, string ns) { }

		public virtual bool IsStartElement(XmlDictionaryString localName, XmlDictionaryString ns) { }

		public virtual string LookupNamespace(string ns) { }

		public virtual bool MoveToAttribute(string name, string ns) { }

		public virtual bool MoveToAttribute(string name) { }

		public virtual void MoveToAttribute(int index) { }

		public virtual bool MoveToElement() { }

		public virtual bool MoveToFirstAttribute() { }

		public virtual bool MoveToNextAttribute() { }

		public virtual bool Read() { }

		public virtual bool ReadAttributeValue() { }

		public virtual int ReadContentAsBase64(Byte[] buffer, int offset, int count) { }

		public virtual int ReadContentAsBinHex(Byte[] buffer, int offset, int count) { }

		public virtual string ReadContentAsString() { }

		public virtual string ReadInnerXml() { }

		public virtual string ReadOuterXml() { }

		public virtual int ReadValueAsBase64(Byte[] buffer, int offset, int count) { }

		public virtual int ReadValueChunk(Char[] chars, int offset, int count) { }

		public virtual void ResolveEntity() { }

		public virtual void Skip() { }

		private override int System.Xml.IXmlLineInfo.get_LineNumber() { }

		private override int System.Xml.IXmlLineInfo.get_LinePosition() { }

		private override bool System.Xml.IXmlLineInfo.HasLineInfo() { }

	}

	private Encoding[] encodings; //Field offset: 0x8
	private XmlDictionaryReader xmlReader; //Field offset: 0xC
	private XmlDictionaryReader infosetReader; //Field offset: 0x10
	private MimeReader mimeReader; //Field offset: 0x14
	private Dictionary<String, MimePart> mimeParts; //Field offset: 0x18
	private OnXmlDictionaryReaderClose onClose; //Field offset: 0x1C
	private bool readingBinaryElement; //Field offset: 0x20
	private int maxBufferSize; //Field offset: 0x24
	private int bufferRemaining; //Field offset: 0x28
	private MimePart part; //Field offset: 0x2C

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
		 get { } //Length: 119
	}

	public override int LinePosition
	{
		 get { } //Length: 119
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

	public virtual XmlDictionaryReaderQuotas Quotas
	{
		 get { } //Length: 40
	}

	public virtual char QuoteChar
	{
		 get { } //Length: 40
	}

	public virtual ReadState ReadState
	{
		 get { } //Length: 85
	}

	public virtual XmlReaderSettings Settings
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

	public XmlMtomReader() { }

	private void AdvanceToContentOnElement() { }

	private void CheckContentTransferEncodingOnBinaryPart(ContentTransferEncodingHeader header) { }

	private void CheckContentTransferEncodingOnRoot(ContentTransferEncodingHeader header) { }

	private void CheckContentType(string contentType) { }

	public virtual void Close() { }

	internal static void DecrementBufferQuota(int maxBuffer, ref int remaining, int size) { }

	public virtual int get_AttributeCount() { }

	public virtual string get_BaseURI() { }

	public virtual bool get_CanReadBinaryContent() { }

	public virtual bool get_CanReadValueChunk() { }

	public virtual bool get_CanResolveEntity() { }

	public virtual int get_Depth() { }

	public virtual bool get_EOF() { }

	public virtual bool get_HasAttributes() { }

	public virtual bool get_HasValue() { }

	public virtual bool get_IsDefault() { }

	public virtual bool get_IsEmptyElement() { }

	public virtual string get_Item(int index) { }

	public virtual string get_Item(string name) { }

	public virtual string get_Item(string name, string ns) { }

	public override int get_LineNumber() { }

	public override int get_LinePosition() { }

	public virtual string get_LocalName() { }

	public virtual string get_Name() { }

	public virtual string get_NamespaceURI() { }

	public virtual XmlNameTable get_NameTable() { }

	public virtual XmlNodeType get_NodeType() { }

	public virtual string get_Prefix() { }

	public virtual XmlDictionaryReaderQuotas get_Quotas() { }

	public virtual char get_QuoteChar() { }

	public virtual ReadState get_ReadState() { }

	public virtual XmlReaderSettings get_Settings() { }

	public virtual string get_Value() { }

	public virtual Type get_ValueType() { }

	public virtual string get_XmlLang() { }

	public virtual XmlSpace get_XmlSpace() { }

	public virtual string GetAttribute(XmlDictionaryString localName, XmlDictionaryString ns) { }

	public virtual string GetAttribute(string name, string ns) { }

	public virtual string GetAttribute(string name) { }

	public virtual string GetAttribute(int index) { }

	private string GetStartUri(string startUri) { }

	public override bool HasLineInfo() { }

	private void Initialize(Stream stream, string contentType, XmlDictionaryReaderQuotas quotas, int maxBufferSize) { }

	public virtual bool IsLocalName(string localName) { }

	public virtual bool IsLocalName(XmlDictionaryString localName) { }

	public virtual bool IsNamespaceUri(string ns) { }

	public virtual bool IsNamespaceUri(XmlDictionaryString ns) { }

	public virtual bool IsStartElement(XmlDictionaryString localName, XmlDictionaryString ns) { }

	public virtual bool IsStartElement(string localName, string ns) { }

	public virtual bool IsStartElement(string localName) { }

	public virtual bool IsStartElement() { }

	public virtual string LookupNamespace(string ns) { }

	public virtual bool MoveToAttribute(string name, string ns) { }

	public virtual void MoveToAttribute(int index) { }

	public virtual bool MoveToAttribute(string name) { }

	public virtual bool MoveToElement() { }

	public virtual bool MoveToFirstAttribute() { }

	public virtual bool MoveToNextAttribute() { }

	public virtual bool Read() { }

	public virtual bool ReadAttributeValue() { }

	public virtual object ReadContentAs(Type returnType, IXmlNamespaceResolver namespaceResolver) { }

	public virtual Byte[] ReadContentAsBase64() { }

	public virtual int ReadContentAsBase64(Byte[] buffer, int offset, int count) { }

	public virtual int ReadContentAsBinHex(Byte[] buffer, int offset, int count) { }

	public virtual bool ReadContentAsBoolean() { }

	public virtual int ReadContentAsChars(Char[] chars, int index, int count) { }

	public virtual DateTime ReadContentAsDateTime() { }

	public virtual decimal ReadContentAsDecimal() { }

	public virtual double ReadContentAsDouble() { }

	public virtual float ReadContentAsFloat() { }

	public virtual int ReadContentAsInt() { }

	public virtual long ReadContentAsLong() { }

	public virtual object ReadContentAsObject() { }

	public virtual string ReadContentAsString() { }

	public virtual int ReadElementContentAsBase64(Byte[] buffer, int offset, int count) { }

	public virtual int ReadElementContentAsBinHex(Byte[] buffer, int offset, int count) { }

	public virtual string ReadInnerXml() { }

	private void ReadMessageContentTypeHeader(ContentTypeHeader header, out string boundary, out string start, out string startInfo) { }

	private void ReadMessageMimeVersionHeader(MimeVersionHeader header) { }

	private MimePart ReadMimePart(string uri) { }

	public virtual string ReadOuterXml() { }

	private Encoding ReadRootContentTypeHeader(ContentTypeHeader header, Encoding[] expectedEncodings, string expectedType) { }

	private MimePart ReadRootMimePart() { }

	public virtual int ReadValueAsBase64(Byte[] buffer, int offset, int count) { }

	public virtual int ReadValueChunk(Char[] buffer, int index, int count) { }

	public virtual void ResolveEntity() { }

	public override void SetInput(Stream stream, Encoding[] encodings, string contentType, XmlDictionaryReaderQuotas quotas, int maxBufferSize, OnXmlDictionaryReaderClose onClose) { }

	public override void SetInput(Byte[] buffer, int offset, int count, Encoding[] encodings, string contentType, XmlDictionaryReaderQuotas quotas, int maxBufferSize, OnXmlDictionaryReaderClose onClose) { }

	private void SetReadEncodings(Encoding[] encodings) { }

	public virtual void Skip() { }

}

