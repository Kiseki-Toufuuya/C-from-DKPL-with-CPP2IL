namespace System.Xml;

internal class XmlUtf8RawTextWriterIndent : XmlUtf8RawTextWriter
{
	[CompilerGenerated]
	private struct <WriteIndentAsync>d__47 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public XmlUtf8RawTextWriterIndent <>4__this; //Field offset: 0x10
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x14
		private int <i>5__2; //Field offset: 0x1C

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteStartAttributeAsync>d__34 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public XmlUtf8RawTextWriterIndent <>4__this; //Field offset: 0x10
		public string prefix; //Field offset: 0x14
		public string localName; //Field offset: 0x18
		public string ns; //Field offset: 0x1C
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x20

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	protected int indentLevel; //Field offset: 0x60
	protected bool newLineOnAttributes; //Field offset: 0x64
	protected string indentChars; //Field offset: 0x68
	protected bool mixedContent; //Field offset: 0x6C
	private BitStack mixedContentStack; //Field offset: 0x70
	protected ConformanceLevel conformanceLevel; //Field offset: 0x74

	public virtual XmlWriterSettings Settings
	{
		 get { } //Length: 240
	}

	public XmlUtf8RawTextWriterIndent(Stream stream, XmlWriterSettings settings) { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task <>n__4(string prefix, string localName, string ns) { }

	public virtual XmlWriterSettings get_Settings() { }

	private void Init(XmlWriterSettings settings) { }

	internal virtual void OnRootElement(ConformanceLevel currentConformanceLevel) { }

	internal virtual void StartElementContent() { }

	public virtual void WriteBase64(Byte[] buffer, int index, int count) { }

	public virtual Task WriteBase64Async(Byte[] buffer, int index, int count) { }

	public virtual void WriteCData(string text) { }

	public virtual void WriteCharEntity(char ch) { }

	public virtual Task WriteCharEntityAsync(char ch) { }

	public virtual void WriteChars(Char[] buffer, int index, int count) { }

	public virtual Task WriteCharsAsync(Char[] buffer, int index, int count) { }

	public virtual void WriteComment(string text) { }

	public virtual void WriteDocType(string name, string pubid, string sysid, string subset) { }

	internal virtual void WriteEndElement(string prefix, string localName, string ns) { }

	public virtual void WriteEntityRef(string name) { }

	public virtual Task WriteEntityRefAsync(string name) { }

	internal virtual void WriteFullEndElement(string prefix, string localName, string ns) { }

	private void WriteIndent() { }

	[AsyncStateMachine(typeof(<WriteIndentAsync>d__47))]
	private Task WriteIndentAsync() { }

	public virtual void WriteProcessingInstruction(string target, string text) { }

	public virtual void WriteRaw(Char[] buffer, int index, int count) { }

	public virtual void WriteRaw(string data) { }

	public virtual Task WriteRawAsync(Char[] buffer, int index, int count) { }

	public virtual Task WriteRawAsync(string data) { }

	public virtual void WriteStartAttribute(string prefix, string localName, string ns) { }

	[AsyncStateMachine(typeof(<WriteStartAttributeAsync>d__34))]
	protected private virtual Task WriteStartAttributeAsync(string prefix, string localName, string ns) { }

	public virtual void WriteStartElement(string prefix, string localName, string ns) { }

	public virtual void WriteString(string text) { }

	public virtual Task WriteStringAsync(string text) { }

	public virtual void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	public virtual Task WriteSurrogateCharEntityAsync(char lowChar, char highChar) { }

	public virtual void WriteWhitespace(string ws) { }

	public virtual Task WriteWhitespaceAsync(string ws) { }

}

