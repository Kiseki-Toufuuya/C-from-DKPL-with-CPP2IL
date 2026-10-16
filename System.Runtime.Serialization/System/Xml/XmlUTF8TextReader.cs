namespace System.Xml;

internal class XmlUTF8TextReader : XmlBaseReader, IXmlLineInfo, IXmlTextReaderInitializer
{
	private static class CharType
	{
		public const byte None = 0; //Field offset: 0x0
		public const byte FirstName = 1; //Field offset: 0x0
		public const byte Name = 2; //Field offset: 0x0
		public const byte Whitespace = 4; //Field offset: 0x0
		public const byte Text = 8; //Field offset: 0x0
		public const byte AttributeText = 16; //Field offset: 0x0
		public const byte SpecialWhitespace = 32; //Field offset: 0x0
		public const byte Comment = 64; //Field offset: 0x0

	}

	private const int MaxTextChunk = 2048; //Field offset: 0x0
	private static Byte[] charType; //Field offset: 0x0
	private PrefixHandle prefix; //Field offset: 0x84
	private StringHandle localName; //Field offset: 0x88
	private Int32[] rowOffsets; //Field offset: 0x8C
	private OnXmlDictionaryReaderClose onClose; //Field offset: 0x90
	private bool buffered; //Field offset: 0x94
	private int maxBytesPerRead; //Field offset: 0x98

	public override int LineNumber
	{
		 get { } //Length: 48
	}

	public override int LinePosition
	{
		 get { } //Length: 48
	}

	private static XmlUTF8TextReader() { }

	public XmlUTF8TextReader() { }

	private int BreakText(Byte[] buffer, int offset, int length) { }

	private void BufferElement() { }

	public virtual void Close() { }

	protected virtual XmlSigningNodeWriter CreateSigningNodeWriter() { }

	public override int get_LineNumber() { }

	public override int get_LinePosition() { }

	private void GetPosition(out int row, out int column) { }

	public override bool HasLineInfo() { }

	private bool IsNextCharacterNonFFFE(Byte[] buffer, int offset) { }

	private void MoveToInitial(XmlDictionaryReaderQuotas quotas, OnXmlDictionaryReaderClose onClose) { }

	public virtual bool Read() { }

	private void ReadAttributes() { }

	private int ReadAttributeText(Byte[] buffer, int offset, int offsetMax) { }

	private void ReadCData() { }

	private int ReadCharRef() { }

	private void ReadComment() { }

	private void ReadDeclaration() { }

	private void ReadEndElement() { }

	private void ReadEscapedText() { }

	private void ReadNonFFFE() { }

	private void ReadQualifiedName(PrefixHandle prefix, StringHandle localName) { }

	private void ReadStartElement() { }

	private int ReadText(Byte[] buffer, int offset, int offsetMax) { }

	private void ReadText(bool hasLeadingByteOf0xEF) { }

	private int ReadTextAndWatchForInvalidCharacters(Byte[] buffer, int offset, int offsetMax) { }

	private void ReadWhitespace() { }

	private int ReadWhitespace(Byte[] buffer, int offset, int offsetMax) { }

	public override void SetInput(Byte[] buffer, int offset, int count, Encoding encoding, XmlDictionaryReaderQuotas quotas, OnXmlDictionaryReaderClose onClose) { }

	public override void SetInput(Stream stream, Encoding encoding, XmlDictionaryReaderQuotas quotas, OnXmlDictionaryReaderClose onClose) { }

	private void SkipWhitespace() { }

	private void VerifyNCName(string s) { }

}

