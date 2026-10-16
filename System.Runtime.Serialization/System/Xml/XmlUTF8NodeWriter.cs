namespace System.Xml;

internal class XmlUTF8NodeWriter : XmlStreamNodeWriter
{
	private class InternalWriteBase64TextAsyncResult : AsyncResult
	{
		private static AsyncCallback onWriteCharacters; //Field offset: 0x0
		private static AsyncCompletion onWriteTrailingCharacters; //Field offset: 0x4
		private Byte[] buffer; //Field offset: 0x38
		private int offset; //Field offset: 0x3C
		private int count; //Field offset: 0x40
		private Base64Encoding encoding; //Field offset: 0x44
		private XmlUTF8NodeWriter writer; //Field offset: 0x48

		private static InternalWriteBase64TextAsyncResult() { }

		public InternalWriteBase64TextAsyncResult(Byte[] buffer, int offset, int count, XmlUTF8NodeWriter writer, AsyncCallback callback, object state) { }

		private bool ContinueWork() { }

		public static void End(IAsyncResult result) { }

		private bool HandleWriteCharacters(IAsyncResult result) { }

		private bool HandleWriteTrailingCharacters(IAsyncResult result) { }

		private static void OnWriteCharacters(IAsyncResult result) { }

		private static bool OnWriteTrailingCharacters(IAsyncResult result) { }

	}

	private class InternalWriteBase64TextAsyncWriter
	{
		private static AsyncEventArgsCallback onTrailByteComplete; //Field offset: 0x0
		private static AsyncEventArgsCallback onWriteComplete; //Field offset: 0x4
		private static AsyncEventArgsCallback onGetBufferComplete; //Field offset: 0x8
		private AsyncEventArgs<XmlNodeWriterWriteBase64TextArgs> nodeState; //Field offset: 0x8
		private AsyncEventArgs<XmlWriteBase64AsyncArguments> writerState; //Field offset: 0xC
		private XmlWriteBase64AsyncArguments writerArgs; //Field offset: 0x10
		private XmlUTF8NodeWriter writer; //Field offset: 0x14
		private GetBufferAsyncEventArgs getBufferState; //Field offset: 0x18
		private GetBufferArgs getBufferArgs; //Field offset: 0x1C

		private static InternalWriteBase64TextAsyncWriter() { }

		public InternalWriteBase64TextAsyncWriter(XmlUTF8NodeWriter writer) { }

		private AsyncCompletionResult InternalWriteBase64TextAsync(AsyncEventArgs<XmlWriteBase64AsyncArguments> writerState) { }

		private static void OnGetBufferComplete(IAsyncEventArgs state) { }

		private static void OnTrailBytesComplete(IAsyncEventArgs eventArgs) { }

		private static void OnWriteComplete(IAsyncEventArgs eventArgs) { }

		internal AsyncCompletionResult StartAsync(AsyncEventArgs<XmlNodeWriterWriteBase64TextArgs> xmlNodeWriterState) { }

		private AsyncCompletionResult WriteBufferAsync() { }

	}

	private class WriteBase64TextAsyncResult : AsyncResult
	{
		private static AsyncCompletion onTrailBytesComplete; //Field offset: 0x0
		private static AsyncCompletion onComplete; //Field offset: 0x4
		private Byte[] trailBytes; //Field offset: 0x38
		private int trailByteCount; //Field offset: 0x3C
		private Byte[] buffer; //Field offset: 0x40
		private int offset; //Field offset: 0x44
		private int count; //Field offset: 0x48
		private XmlUTF8NodeWriter writer; //Field offset: 0x4C

		private static WriteBase64TextAsyncResult() { }

		public WriteBase64TextAsyncResult(Byte[] trailBytes, int trailByteCount, Byte[] buffer, int offset, int count, XmlUTF8NodeWriter writer, AsyncCallback callback, object state) { }

		public static void End(IAsyncResult result) { }

		private bool HandleWriteBase64Text(IAsyncResult result) { }

		private bool HandleWriteTrailBytes(IAsyncResult result) { }

		private static bool OnComplete(IAsyncResult result) { }

		private static bool OnTrailBytesComplete(IAsyncResult result) { }

	}

	private const int bufferLength = 512; //Field offset: 0x0
	private const int maxEntityLength = 32; //Field offset: 0x0
	private const int maxBytesPerChar = 3; //Field offset: 0x0
	private static readonly Byte[] startDecl; //Field offset: 0x0
	private static readonly Byte[] endDecl; //Field offset: 0x4
	private static readonly Byte[] utf8Decl; //Field offset: 0x8
	private static readonly Byte[] digits; //Field offset: 0xC
	private static readonly Boolean[] defaultIsEscapedAttributeChar; //Field offset: 0x10
	private static readonly Boolean[] defaultIsEscapedElementChar; //Field offset: 0x14
	private Byte[] entityChars; //Field offset: 0x24
	private Boolean[] isEscapedAttributeChar; //Field offset: 0x28
	private Boolean[] isEscapedElementChar; //Field offset: 0x2C
	private bool inAttribute; //Field offset: 0x30
	private Encoding encoding; //Field offset: 0x34
	private Char[] chars; //Field offset: 0x38
	private InternalWriteBase64TextAsyncWriter internalWriteBase64TextAsyncWriter; //Field offset: 0x3C

	public Encoding Encoding
	{
		 get { } //Length: 11
	}

	private static XmlUTF8NodeWriter() { }

	public XmlUTF8NodeWriter() { }

	public XmlUTF8NodeWriter(Boolean[] isEscapedAttributeChar, Boolean[] isEscapedElementChar) { }

	private IAsyncResult BeginInternalWriteBase64Text(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	public virtual IAsyncResult BeginWriteBase64Text(Byte[] trailBytes, int trailByteCount, Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	private void EndInternalWriteBase64Text(IAsyncResult result) { }

	public virtual void EndWriteBase64Text(IAsyncResult result) { }

	public Encoding get_Encoding() { }

	private Char[] GetCharBuffer(int charCount) { }

	private Byte[] GetCharEntityBuffer() { }

	private void InternalWriteBase64Text(Byte[] buffer, int offset, int count) { }

	public void SetOutput(Stream stream, bool ownsStream, Encoding encoding) { }

	private int ToBase16(Byte[] chars, int offset, uint value) { }

	private void UnsafeWriteEscapedText(Char* chars, int count) { }

	public void WriteAmpersandCharEntity() { }

	public void WriteApostropheCharEntity() { }

	public virtual void WriteBase64Text(Byte[] trailBytes, int trailByteCount, Byte[] buffer, int offset, int count) { }

	internal virtual AsyncCompletionResult WriteBase64TextAsync(AsyncEventArgs<XmlNodeWriterWriteBase64TextArgs> xmlNodeWriterState) { }

	public virtual void WriteBoolText(bool value) { }

	public virtual void WriteCData(string text) { }

	public virtual void WriteCharEntity(int ch) { }

	public virtual void WriteComment(string text) { }

	public virtual void WriteDateTimeText(DateTime value) { }

	public virtual void WriteDecimalText(decimal value) { }

	public virtual void WriteDeclaration() { }

	public virtual void WriteDoubleText(double value) { }

	public virtual void WriteEndAttribute() { }

	private void WriteEndComment() { }

	public virtual void WriteEndElement(Byte[] prefixBuffer, int prefixOffset, int prefixLength, Byte[] localNameBuffer, int localNameOffset, int localNameLength) { }

	public virtual void WriteEndElement(string prefix, string localName) { }

	public virtual void WriteEndListText() { }

	public virtual void WriteEndStartElement(bool isEmpty) { }

	public virtual void WriteEscapedText(Byte[] chars, int offset, int count) { }

	public virtual void WriteEscapedText(string s) { }

	public virtual void WriteEscapedText(XmlDictionaryString s) { }

	public virtual void WriteEscapedText(Char[] s, int offset, int count) { }

	public virtual void WriteFloatText(float value) { }

	public void WriteGreaterThanCharEntity() { }

	public virtual void WriteGuidText(Guid value) { }

	private void WriteHexCharEntity(int ch) { }

	public virtual void WriteInt32Text(int value) { }

	public virtual void WriteInt64Text(long value) { }

	public void WriteLessThanCharEntity() { }

	public virtual void WriteListSeparator() { }

	private void WriteLocalName(Byte[] localNameBuffer, int localNameOffset, int localNameLength) { }

	private void WriteLocalName(string localName) { }

	private void WritePrefix(Byte[] prefixBuffer, int prefixOffset, int prefixLength) { }

	private void WritePrefix(string prefix) { }

	public virtual void WriteQualifiedName(string prefix, XmlDictionaryString localName) { }

	public void WriteQuoteCharEntity() { }

	public virtual void WriteStartAttribute(Byte[] prefixBuffer, int prefixOffset, int prefixLength, Byte[] localNameBuffer, int localNameOffset, int localNameLength) { }

	public virtual void WriteStartAttribute(string prefix, string localName) { }

	public virtual void WriteStartAttribute(string prefix, XmlDictionaryString localName) { }

	private void WriteStartComment() { }

	public virtual void WriteStartElement(Byte[] prefixBuffer, int prefixOffset, int prefixLength, Byte[] localNameBuffer, int localNameOffset, int localNameLength) { }

	public virtual void WriteStartElement(string prefix, string localName) { }

	public virtual void WriteStartElement(string prefix, XmlDictionaryString localName) { }

	public virtual void WriteStartListText() { }

	private void WriteStartXmlnsAttribute() { }

	public virtual void WriteText(Byte[] chars, int offset, int count) { }

	public virtual void WriteText(XmlDictionaryString value) { }

	public virtual void WriteText(string value) { }

	public virtual void WriteText(Char[] chars, int offset, int count) { }

	public void WriteText(int ch) { }

	public virtual void WriteTimeSpanText(TimeSpan value) { }

	public virtual void WriteUInt64Text(ulong value) { }

	public virtual void WriteUniqueIdText(UniqueId value) { }

	public virtual void WriteXmlnsAttribute(Byte[] prefixBuffer, int prefixOffset, int prefixLength, Byte[] nsBuffer, int nsOffset, int nsLength) { }

	public virtual void WriteXmlnsAttribute(string prefix, XmlDictionaryString ns) { }

	public virtual void WriteXmlnsAttribute(string prefix, string ns) { }

}

