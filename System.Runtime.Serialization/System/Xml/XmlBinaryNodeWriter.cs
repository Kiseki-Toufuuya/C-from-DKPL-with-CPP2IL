namespace System.Xml;

internal class XmlBinaryNodeWriter : XmlStreamNodeWriter
{
	private struct AttributeValue
	{
		private string captureText; //Field offset: 0x0
		private XmlDictionaryString captureXText; //Field offset: 0x4
		private MemoryStream captureStream; //Field offset: 0x8

		public void Clear() { }

		public void WriteBase64Text(Byte[] trailBytes, int trailByteCount, Byte[] buffer, int offset, int count) { }

		public void WriteText(string s) { }

		public void WriteText(XmlDictionaryString s) { }

		public void WriteTo(XmlBinaryNodeWriter writer) { }

	}

	private const int maxBytesPerChar = 3; //Field offset: 0x0
	private IXmlDictionary dictionary; //Field offset: 0x24
	private XmlBinaryWriterSession session; //Field offset: 0x28
	private bool inAttribute; //Field offset: 0x2C
	private bool inList; //Field offset: 0x2D
	private bool wroteAttributeValue; //Field offset: 0x2E
	private AttributeValue attributeValue; //Field offset: 0x30
	private int textNodeOffset; //Field offset: 0x3C

	public XmlBinaryNodeWriter() { }

	public virtual void Close() { }

	protected virtual void FlushBuffer() { }

	private Byte[] GetTextNodeBuffer(int size, out int offset) { }

	public void SetOutput(Stream stream, IXmlDictionary dictionary, XmlBinaryWriterSession session, bool ownsStream) { }

	private bool TryGetKey(XmlDictionaryString s, out int key) { }

	private void UnsafeWriteArray(Byte* array, int byteCount) { }

	public void UnsafeWriteArray(XmlBinaryNodeType nodeType, int count, Byte* array, Byte* arrayMax) { }

	private void UnsafeWriteName(Char* chars, int charCount) { }

	private void UnsafeWriteText(Char* chars, int charCount) { }

	private void WriteArrayInfo(XmlBinaryNodeType nodeType, int count) { }

	public void WriteArrayNode() { }

	public virtual void WriteBase64Text(Byte[] trailBytes, int trailByteCount, Byte[] base64Buffer, int base64Offset, int base64Count) { }

	public virtual void WriteBoolText(bool value) { }

	public virtual void WriteCData(string value) { }

	public virtual void WriteCharEntity(int ch) { }

	public virtual void WriteComment(string value) { }

	public void WriteDateTimeArray(DateTime[] array, int offset, int count) { }

	public virtual void WriteDateTimeText(DateTime dt) { }

	public virtual void WriteDecimalText(decimal d) { }

	public virtual void WriteDeclaration() { }

	private void WriteDictionaryString(XmlDictionaryString s, int key) { }

	public virtual void WriteDoubleText(double d) { }

	private void WriteEmptyText() { }

	public virtual void WriteEndAttribute() { }

	private void WriteEndElement() { }

	public virtual void WriteEndElement(string prefix, string localName) { }

	public virtual void WriteEndListText() { }

	public virtual void WriteEndStartElement(bool isEmpty) { }

	public virtual void WriteEscapedText(string value) { }

	public virtual void WriteEscapedText(Byte[] chars, int offset, int count) { }

	public virtual void WriteEscapedText(Char[] chars, int offset, int count) { }

	public virtual void WriteEscapedText(XmlDictionaryString value) { }

	public virtual void WriteFloatText(float f) { }

	public void WriteGuidArray(Guid[] array, int offset, int count) { }

	public virtual void WriteGuidText(Guid guid) { }

	public virtual void WriteInt32Text(int value) { }

	private void WriteInt64(long value) { }

	public virtual void WriteInt64Text(long value) { }

	public virtual void WriteListSeparator() { }

	private void WriteMultiByteInt32(int i) { }

	private void WriteName(string s) { }

	private void WriteNode(XmlBinaryNodeType nodeType) { }

	private void WritePrefixNode(XmlBinaryNodeType nodeType, int ch) { }

	public virtual void WriteQualifiedName(string prefix, XmlDictionaryString localName) { }

	public virtual void WriteStartAttribute(string prefix, string localName) { }

	public virtual void WriteStartAttribute(string prefix, XmlDictionaryString localName) { }

	public virtual void WriteStartElement(string prefix, XmlDictionaryString localName) { }

	public virtual void WriteStartElement(string prefix, string localName) { }

	public virtual void WriteStartListText() { }

	public virtual void WriteText(Byte[] chars, int charOffset, int charCount) { }

	public virtual void WriteText(Char[] chars, int offset, int count) { }

	public virtual void WriteText(XmlDictionaryString value) { }

	public virtual void WriteText(string value) { }

	private void WriteTextNode(XmlBinaryNodeType nodeType) { }

	private void WriteTextNodeWithInt64(XmlBinaryNodeType nodeType, long value) { }

	private void WriteTextNodeWithLength(XmlBinaryNodeType nodeType, int length) { }

	public void WriteTimeSpanArray(TimeSpan[] array, int offset, int count) { }

	public virtual void WriteTimeSpanText(TimeSpan value) { }

	public virtual void WriteUInt64Text(ulong value) { }

	public virtual void WriteUniqueIdText(UniqueId value) { }

	public virtual void WriteXmlnsAttribute(string prefix, string ns) { }

	public virtual void WriteXmlnsAttribute(string prefix, XmlDictionaryString ns) { }

	private void WroteAttributeValue() { }

}

