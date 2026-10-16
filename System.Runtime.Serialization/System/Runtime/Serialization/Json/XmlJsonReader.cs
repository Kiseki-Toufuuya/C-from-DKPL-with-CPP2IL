namespace System.Runtime.Serialization.Json;

internal class XmlJsonReader : XmlBaseReader, IXmlJsonReaderInitializer
{
	private static class CharType
	{
		public const byte FirstName = 1; //Field offset: 0x0
		public const byte Name = 2; //Field offset: 0x0
		public const byte None = 0; //Field offset: 0x0

	}

	private enum JsonComplexTextMode
	{
		QuotedText = 0,
		NumericalText = 1,
		None = 2,
	}

	private const int MaxTextChunk = 2048; //Field offset: 0x0
	private static Byte[] charType; //Field offset: 0x0
	private bool buffered; //Field offset: 0x84
	private Byte[] charactersToSkipOnNextRead; //Field offset: 0x88
	private JsonComplexTextMode complexTextMode; //Field offset: 0x8C
	private bool expectingFirstElementInNonPrimitiveChild; //Field offset: 0x90
	private int maxBytesPerRead; //Field offset: 0x94
	private OnXmlDictionaryReaderClose onReaderClose; //Field offset: 0x98
	private bool readServerTypeElement; //Field offset: 0x9C
	private int scopeDepth; //Field offset: 0xA0
	private JsonNodeType[] scopes; //Field offset: 0xA4

	public virtual bool CanCanonicalize
	{
		 get { } //Length: 3
	}

	private bool IsAttributeValue
	{
		private get { } //Length: 135
	}

	private bool IsReadingCollection
	{
		private get { } //Length: 59
	}

	private bool IsReadingComplexText
	{
		private get { } //Length: 37
	}

	public virtual string Value
	{
		 get { } //Length: 118
	}

	private static XmlJsonReader() { }

	public XmlJsonReader() { }

	private static int BreakText(Byte[] buffer, int offset, int length) { }

	private void BufferElement() { }

	internal static void CheckArray(Array array, int offset, int count) { }

	public virtual void Close() { }

	private static int ComputeNumericalTextLength(Byte[] buffer, int offset, int offsetMax) { }

	private static int ComputeQuotedTextLengthUntilEndQuote(Byte[] buffer, int offset, int offsetMax, out bool escaped) { }

	protected virtual XmlSigningNodeWriter CreateSigningNodeWriter() { }

	public virtual void EndCanonicalization() { }

	private void EnterJsonScope(JsonNodeType currentNodeType) { }

	private JsonNodeType ExitJsonScope() { }

	public virtual bool get_CanCanonicalize() { }

	private bool get_IsAttributeValue() { }

	private bool get_IsReadingCollection() { }

	private bool get_IsReadingComplexText() { }

	public virtual string get_Value() { }

	public virtual string GetAttribute(string localName, string namespaceUri) { }

	public virtual string GetAttribute(string name) { }

	public virtual string GetAttribute(XmlDictionaryString localName, XmlDictionaryString namespaceUri) { }

	public virtual string GetAttribute(int index) { }

	private static bool IsWhitespace(byte ch) { }

	private void MoveToEndElement() { }

	private void MoveToInitial(XmlDictionaryReaderQuotas quotas, OnXmlDictionaryReaderClose onClose) { }

	private void ParseAndSetLocalName() { }

	private static char ParseChar(string value, NumberStyles style) { }

	private static int ParseInt(string value, NumberStyles style) { }

	private void ParseStartElement() { }

	public virtual bool Read() { }

	private void ReadAttributes() { }

	public virtual decimal ReadContentAsDecimal() { }

	public virtual int ReadContentAsInt() { }

	public virtual long ReadContentAsLong() { }

	private void ReadEscapedCharacter(bool moveToText) { }

	private void ReadNonExistentElementName(StringHandleConstStringType elementName) { }

	private int ReadNonFFFE() { }

	private void ReadNumericalText() { }

	private void ReadQuotedText(bool moveToText) { }

	private void ReadServerTypeAttribute(bool consumedObjectChar) { }

	public virtual int ReadValueAsBase64(Byte[] buffer, int offset, int count) { }

	public virtual int ReadValueChunk(Char[] chars, int offset, int count) { }

	private void ResetState() { }

	public override void SetInput(Stream stream, Encoding encoding, XmlDictionaryReaderQuotas quotas, OnXmlDictionaryReaderClose onClose) { }

	public override void SetInput(Byte[] buffer, int offset, int count, Encoding encoding, XmlDictionaryReaderQuotas quotas, OnXmlDictionaryReaderClose onClose) { }

	private void SetJsonNameWithMapping(XmlElementNode elementNode) { }

	private void SkipExpectedByteInBufferReader(byte characterToSkip) { }

	private void SkipWhitespaceInBufferReader() { }

	public virtual void StartCanonicalization(Stream stream, bool includeComments, String[] inclusivePrefixes) { }

	private bool TryGetByte(out byte ch) { }

	private string UnescapeJsonString(string val) { }

}

