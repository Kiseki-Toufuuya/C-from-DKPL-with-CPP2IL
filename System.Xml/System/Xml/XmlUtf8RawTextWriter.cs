namespace System.Xml;

internal class XmlUtf8RawTextWriter : XmlRawWriter
{
	[CompilerGenerated]
	private struct <_RawTextAsync>d__128 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public XmlUtf8RawTextWriter <>4__this; //Field offset: 0x10
		public string text; //Field offset: 0x14
		public int curIndex; //Field offset: 0x18
		public int leftCount; //Field offset: 0x1C
		private int <writeLen>5__2; //Field offset: 0x20
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x24

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <_WriteAttributeTextBlockAsync>d__118 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public XmlUtf8RawTextWriter <>4__this; //Field offset: 0x10
		public string text; //Field offset: 0x14
		public int curIndex; //Field offset: 0x18
		public int leftCount; //Field offset: 0x1C
		private int <writeLen>5__2; //Field offset: 0x20
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x24

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <_WriteElementTextBlockAsync>d__124 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public bool newLine; //Field offset: 0x10
		public XmlUtf8RawTextWriter <>4__this; //Field offset: 0x14
		public int curIndex; //Field offset: 0x18
		public int leftCount; //Field offset: 0x1C
		public string text; //Field offset: 0x20
		private int <writeLen>5__2; //Field offset: 0x24
		private bool <needWriteNewLine>5__3; //Field offset: 0x28
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x2C

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <FlushBufferAsync>d__111 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public XmlUtf8RawTextWriter <>4__this; //Field offset: 0x10
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteAttributeTextBlockAsync>d__116 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public int index; //Field offset: 0x10
		public int count; //Field offset: 0x14
		public XmlUtf8RawTextWriter <>4__this; //Field offset: 0x18
		public Char[] chars; //Field offset: 0x1C
		private int <writeLen>5__2; //Field offset: 0x20
		private int <curIndex>5__3; //Field offset: 0x24
		private int <leftCount>5__4; //Field offset: 0x28
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x2C

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteCharEntityAsync>d__103 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public XmlUtf8RawTextWriter <>4__this; //Field offset: 0x10
		public char ch; //Field offset: 0x14
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x18

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteElementTextBlockAsync>d__122 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public int index; //Field offset: 0x10
		public int count; //Field offset: 0x14
		public XmlUtf8RawTextWriter <>4__this; //Field offset: 0x18
		public Char[] chars; //Field offset: 0x1C
		private int <writeLen>5__2; //Field offset: 0x20
		private int <curIndex>5__3; //Field offset: 0x24
		private int <leftCount>5__4; //Field offset: 0x28
		private bool <needWriteNewLine>5__5; //Field offset: 0x2C
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteEntityRefAsync>d__102 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public XmlUtf8RawTextWriter <>4__this; //Field offset: 0x10
		public string name; //Field offset: 0x14
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x18

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteNamespaceDeclarationAsync>d__96 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public XmlUtf8RawTextWriter <>4__this; //Field offset: 0x10
		public string prefix; //Field offset: 0x14
		public string namespaceName; //Field offset: 0x18
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x1C

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteRawAsync>d__108 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public XmlUtf8RawTextWriter <>4__this; //Field offset: 0x10
		public Char[] buffer; //Field offset: 0x14
		public int index; //Field offset: 0x18
		public int count; //Field offset: 0x1C
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x20

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteRawAsync>d__109 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public XmlUtf8RawTextWriter <>4__this; //Field offset: 0x10
		public string data; //Field offset: 0x14
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x18

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteRawWithCharCheckingAsync>d__132 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public int index; //Field offset: 0x10
		public int count; //Field offset: 0x14
		public XmlUtf8RawTextWriter <>4__this; //Field offset: 0x18
		public Char[] chars; //Field offset: 0x1C
		private int <writeLen>5__2; //Field offset: 0x20
		private int <curIndex>5__3; //Field offset: 0x24
		private int <leftCount>5__4; //Field offset: 0x28
		private bool <needWriteNewLine>5__5; //Field offset: 0x2C
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteRawWithCharCheckingAsync>d__133 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public string text; //Field offset: 0x10
		public XmlUtf8RawTextWriter <>4__this; //Field offset: 0x14
		private int <writeLen>5__2; //Field offset: 0x18
		private int <curIndex>5__3; //Field offset: 0x1C
		private int <leftCount>5__4; //Field offset: 0x20
		private bool <needWriteNewLine>5__5; //Field offset: 0x24
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteStartNamespaceDeclarationAsync>d__97 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public XmlUtf8RawTextWriter <>4__this; //Field offset: 0x10
		public string prefix; //Field offset: 0x14
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x18

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteSurrogateCharEntityAsync>d__106 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public XmlUtf8RawTextWriter <>4__this; //Field offset: 0x10
		public char lowChar; //Field offset: 0x14
		public char highChar; //Field offset: 0x16
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x18

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteXmlDeclarationAsync>d__86 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public XmlUtf8RawTextWriter <>4__this; //Field offset: 0x10
		public XmlStandalone standalone; //Field offset: 0x14
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x18

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly bool useAsync; //Field offset: 0x14
	protected Byte[] bufBytes; //Field offset: 0x18
	protected Stream stream; //Field offset: 0x1C
	protected Encoding encoding; //Field offset: 0x20
	protected XmlCharType xmlCharType; //Field offset: 0x24
	protected int bufPos; //Field offset: 0x28
	protected int textPos; //Field offset: 0x2C
	protected int contentPos; //Field offset: 0x30
	protected int cdataPos; //Field offset: 0x34
	protected int attrEndPos; //Field offset: 0x38
	protected int bufLen; //Field offset: 0x3C
	protected bool writeToNull; //Field offset: 0x40
	protected bool hadDoubleBracket; //Field offset: 0x41
	protected bool inAttributeValue; //Field offset: 0x42
	protected NewLineHandling newLineHandling; //Field offset: 0x44
	protected bool closeOutput; //Field offset: 0x48
	protected bool omitXmlDeclaration; //Field offset: 0x49
	protected string newLineChars; //Field offset: 0x4C
	protected bool checkCharacters; //Field offset: 0x50
	protected XmlStandalone standalone; //Field offset: 0x54
	protected XmlOutputMethod outputMethod; //Field offset: 0x58
	protected bool autoXmlDeclaration; //Field offset: 0x5C
	protected bool mergeCDataSections; //Field offset: 0x5D

	public virtual XmlWriterSettings Settings
	{
		 get { } //Length: 202
	}

	internal virtual bool SupportsNamespaceDeclarationInChunks
	{
		internal get { } //Length: 3
	}

	[AsyncStateMachine(typeof(<_RawTextAsync>d__128))]
	private Task _RawTextAsync(string text, int curIndex, int leftCount) { }

	[AsyncStateMachine(typeof(<_WriteAttributeTextBlockAsync>d__118))]
	private Task _WriteAttributeTextBlockAsync(string text, int curIndex, int leftCount) { }

	[AsyncStateMachine(typeof(<_WriteElementTextBlockAsync>d__124))]
	private Task _WriteElementTextBlockAsync(bool newLine, string text, int curIndex, int leftCount) { }

	protected XmlUtf8RawTextWriter(XmlWriterSettings settings) { }

	public XmlUtf8RawTextWriter(Stream stream, XmlWriterSettings settings) { }

	protected static Byte* AmpEntity(Byte* pDst) { }

	protected static Byte* CarriageReturnEntity(Byte* pDst) { }

	private static Byte* CharEntity(Byte* pDst, char ch) { }

	internal static void CharToUTF8(ref Char* pSrc, Char* pSrcEnd, ref Byte* pDst) { }

	protected void CheckAsyncCall() { }

	public virtual void Close() { }

	internal void EncodeChar(ref Char* pSrc, Char* pSrcEnd, ref Byte* pDst) { }

	internal static Byte* EncodeMultibyteUTF8(int ch, Byte* pDst) { }

	private static Byte* EncodeSurrogate(Char* pSrc, Char* pSrcEnd, Byte* pDst) { }

	public virtual void Flush() { }

	protected override void FlushBuffer() { }

	[AsyncStateMachine(typeof(<FlushBufferAsync>d__111))]
	protected override Task FlushBufferAsync() { }

	private void FlushEncoder() { }

	public virtual XmlWriterSettings get_Settings() { }

	internal virtual bool get_SupportsNamespaceDeclarationInChunks() { }

	protected static Byte* GtEntity(Byte* pDst) { }

	private Byte* InvalidXmlChar(int ch, Byte* pDst, bool entitize) { }

	private static bool IsSurrogateByte(byte b) { }

	protected static Byte* LineFeedEntity(Byte* pDst) { }

	protected static Byte* LtEntity(Byte* pDst) { }

	protected static Byte* QuoteEntity(Byte* pDst) { }

	protected static Byte* RawEndCData(Byte* pDst) { }

	protected static Byte* RawStartCData(Byte* pDst) { }

	protected void RawText(string s) { }

	protected void RawText(Char* pSrcBegin, Char* pSrcEnd) { }

	protected Task RawTextAsync(string text) { }

	protected int RawTextNoFlush(Char* pSrcBegin, Char* pSrcEnd) { }

	protected int RawTextNoFlush(string text, int index, int count) { }

	internal virtual void StartElementContent() { }

	protected static Byte* TabEntity(Byte* pDst) { }

	protected void ValidateContentChars(string chars, string propertyName, bool allowOnlyWhitespace) { }

	protected void WriteAttributeTextBlock(Char* pSrc, Char* pSrcEnd) { }

	[AsyncStateMachine(typeof(<WriteAttributeTextBlockAsync>d__116))]
	protected Task WriteAttributeTextBlockAsync(Char[] chars, int index, int count) { }

	protected Task WriteAttributeTextBlockAsync(string text) { }

	protected int WriteAttributeTextBlockNoFlush(string text, int index, int count) { }

	protected int WriteAttributeTextBlockNoFlush(Char[] chars, int index, int count) { }

	protected int WriteAttributeTextBlockNoFlush(Char* pSrc, Char* pSrcEnd) { }

	public virtual void WriteCData(string text) { }

	protected void WriteCDataSection(string text) { }

	public virtual void WriteCharEntity(char ch) { }

	[AsyncStateMachine(typeof(<WriteCharEntityAsync>d__103))]
	public virtual Task WriteCharEntityAsync(char ch) { }

	public virtual void WriteChars(Char[] buffer, int index, int count) { }

	public virtual Task WriteCharsAsync(Char[] buffer, int index, int count) { }

	public virtual void WriteComment(string text) { }

	protected void WriteCommentOrPi(string text, int stopChar) { }

	public virtual void WriteDocType(string name, string pubid, string sysid, string subset) { }

	protected void WriteElementTextBlock(Char* pSrc, Char* pSrcEnd) { }

	[AsyncStateMachine(typeof(<WriteElementTextBlockAsync>d__122))]
	protected Task WriteElementTextBlockAsync(Char[] chars, int index, int count) { }

	protected Task WriteElementTextBlockAsync(string text) { }

	protected int WriteElementTextBlockNoFlush(Char* pSrc, Char* pSrcEnd, out bool needWriteNewLine) { }

	protected int WriteElementTextBlockNoFlush(Char[] chars, int index, int count, out bool needWriteNewLine) { }

	protected int WriteElementTextBlockNoFlush(string text, int index, int count, out bool needWriteNewLine) { }

	public virtual void WriteEndAttribute() { }

	protected private virtual Task WriteEndAttributeAsync() { }

	internal virtual void WriteEndElement(string prefix, string localName, string ns) { }

	internal virtual void WriteEndNamespaceDeclaration() { }

	internal virtual Task WriteEndNamespaceDeclarationAsync() { }

	public virtual void WriteEntityRef(string name) { }

	[AsyncStateMachine(typeof(<WriteEntityRefAsync>d__102))]
	public virtual Task WriteEntityRefAsync(string name) { }

	internal virtual void WriteFullEndElement(string prefix, string localName, string ns) { }

	internal virtual void WriteNamespaceDeclaration(string prefix, string namespaceName) { }

	[AsyncStateMachine(typeof(<WriteNamespaceDeclarationAsync>d__96))]
	internal virtual Task WriteNamespaceDeclarationAsync(string prefix, string namespaceName) { }

	protected Byte* WriteNewLine(Byte* pDst) { }

	public virtual void WriteProcessingInstruction(string name, string text) { }

	public virtual void WriteRaw(string data) { }

	public virtual void WriteRaw(Char[] buffer, int index, int count) { }

	[AsyncStateMachine(typeof(<WriteRawAsync>d__108))]
	public virtual Task WriteRawAsync(Char[] buffer, int index, int count) { }

	[AsyncStateMachine(typeof(<WriteRawAsync>d__109))]
	public virtual Task WriteRawAsync(string data) { }

	protected void WriteRawWithCharChecking(Char* pSrcBegin, Char* pSrcEnd) { }

	[AsyncStateMachine(typeof(<WriteRawWithCharCheckingAsync>d__133))]
	protected Task WriteRawWithCharCheckingAsync(string text) { }

	[AsyncStateMachine(typeof(<WriteRawWithCharCheckingAsync>d__132))]
	protected Task WriteRawWithCharCheckingAsync(Char[] chars, int index, int count) { }

	protected int WriteRawWithCharCheckingNoFlush(string text, int index, int count, out bool needWriteNewLine) { }

	protected int WriteRawWithCharCheckingNoFlush(Char[] chars, int index, int count, out bool needWriteNewLine) { }

	protected int WriteRawWithCharCheckingNoFlush(Char* pSrcBegin, Char* pSrcEnd, out bool needWriteNewLine) { }

	public virtual void WriteStartAttribute(string prefix, string localName, string ns) { }

	private void WriteStartAttribute_SetInAttribute() { }

	protected private virtual Task WriteStartAttributeAsync(string prefix, string localName, string ns) { }

	public virtual void WriteStartElement(string prefix, string localName, string ns) { }

	internal virtual void WriteStartNamespaceDeclaration(string prefix) { }

	[AsyncStateMachine(typeof(<WriteStartNamespaceDeclarationAsync>d__97))]
	internal virtual Task WriteStartNamespaceDeclarationAsync(string prefix) { }

	public virtual void WriteString(string text) { }

	public virtual Task WriteStringAsync(string text) { }

	public virtual void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	[AsyncStateMachine(typeof(<WriteSurrogateCharEntityAsync>d__106))]
	public virtual Task WriteSurrogateCharEntityAsync(char lowChar, char highChar) { }

	public virtual void WriteWhitespace(string ws) { }

	public virtual Task WriteWhitespaceAsync(string ws) { }

	internal virtual void WriteXmlDeclaration(string xmldecl) { }

	internal virtual void WriteXmlDeclaration(XmlStandalone standalone) { }

	[AsyncStateMachine(typeof(<WriteXmlDeclarationAsync>d__86))]
	internal virtual Task WriteXmlDeclarationAsync(XmlStandalone standalone) { }

}

