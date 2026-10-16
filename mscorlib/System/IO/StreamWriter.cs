namespace System.IO;

public class StreamWriter : TextWriter
{
	[CompilerGenerated]
	private struct <FlushAsyncInternal>d__74 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public bool haveWrittenPreamble; //Field offset: 0x10
		public StreamWriter _this; //Field offset: 0x14
		public Encoding encoding; //Field offset: 0x18
		public Stream stream; //Field offset: 0x1C
		public CancellationToken cancellationToken; //Field offset: 0x20
		public Encoder encoder; //Field offset: 0x24
		public Char[] charBuffer; //Field offset: 0x28
		public int charPos; //Field offset: 0x2C
		public Byte[] byteBuffer; //Field offset: 0x30
		public bool flushEncoder; //Field offset: 0x34
		public bool flushStream; //Field offset: 0x35
		private ConfiguredValueTaskAwaiter <>u__1; //Field offset: 0x38
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteAsyncInternal>d__62 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public int charPos; //Field offset: 0x10
		public int charLen; //Field offset: 0x14
		public StreamWriter _this; //Field offset: 0x18
		public Char[] charBuffer; //Field offset: 0x1C
		public CancellationToken cancellationToken; //Field offset: 0x20
		public ReadOnlyMemory<Char> source; //Field offset: 0x24
		public bool appendNewLine; //Field offset: 0x30
		public Char[] coreNewLine; //Field offset: 0x34
		public bool autoFlush; //Field offset: 0x38
		private int <copied>5__2; //Field offset: 0x3C
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40
		private int <i>5__3; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public static readonly StreamWriter Null; //Field offset: 0x0
	private Stream _stream; //Field offset: 0x18
	private Encoding _encoding; //Field offset: 0x1C
	private Encoder _encoder; //Field offset: 0x20
	private Byte[] _byteBuffer; //Field offset: 0x24
	private Char[] _charBuffer; //Field offset: 0x28
	private int _charPos; //Field offset: 0x2C
	private int _charLen; //Field offset: 0x30
	private bool _autoFlush; //Field offset: 0x34
	private bool _haveWrittenPreamble; //Field offset: 0x35
	private bool _closable; //Field offset: 0x36
	private Task _asyncWriteTask; //Field offset: 0x38

	public override bool AutoFlush
	{
		 set { } //Length: 112
	}

	public override Stream BaseStream
	{
		 get { } //Length: 11
	}

	private int CharPos_Prop
	{
		private set { } //Length: 14
	}

	public virtual Encoding Encoding
	{
		 get { } //Length: 11
	}

	private bool HaveWrittenPreamble_Prop
	{
		private set { } //Length: 14
	}

	internal bool LeaveOpen
	{
		internal get { } //Length: 15
	}

	private static Encoding UTF8NoBOM
	{
		private get { } //Length: 60
	}

	private static StreamWriter() { }

	public StreamWriter(string path, bool append, Encoding encoding, int bufferSize) { }

	public StreamWriter(string path, bool append, Encoding encoding) { }

	internal StreamWriter() { }

	public StreamWriter(Stream stream) { }

	public StreamWriter(Stream stream, Encoding encoding) { }

	public StreamWriter(Stream stream, Encoding encoding, int bufferSize, bool leaveOpen) { }

	public StreamWriter(string path) { }

	public StreamWriter(string path, bool append) { }

	private void CheckAsyncTaskInProgress() { }

	public virtual void Close() { }

	protected virtual void Dispose(bool disposing) { }

	public virtual void Flush() { }

	private void Flush(bool flushStream, bool flushEncoder) { }

	[AsyncStateMachine(typeof(<FlushAsyncInternal>d__74))]
	private static Task FlushAsyncInternal(StreamWriter _this, bool flushStream, bool flushEncoder, Char[] charBuffer, int charPos, bool haveWrittenPreamble, Encoding encoding, Encoder encoder, Byte[] byteBuffer, Stream stream, CancellationToken cancellationToken) { }

	private Task FlushAsyncInternal(bool flushStream, bool flushEncoder, Char[] sCharBuffer, int sCharPos, CancellationToken cancellationToken = null) { }

	public override Stream get_BaseStream() { }

	public virtual Encoding get_Encoding() { }

	internal bool get_LeaveOpen() { }

	private static Encoding get_UTF8NoBOM() { }

	private void Init(Stream streamArg, Encoding encodingArg, int bufferSize, bool shouldLeaveOpen) { }

	public override void set_AutoFlush(bool value) { }

	private void set_CharPos_Prop(int value) { }

	private void set_HaveWrittenPreamble_Prop(bool value) { }

	private static void ThrowAsyncIOInProgress() { }

	public virtual void Write(Char[] buffer, int index, int count) { }

	public virtual void Write(char value) { }

	public virtual void Write(string value) { }

	public virtual void Write(Char[] buffer) { }

	public virtual Task WriteAsync(Char[] buffer, int index, int count) { }

	[AsyncStateMachine(typeof(<WriteAsyncInternal>d__62))]
	private static Task WriteAsyncInternal(StreamWriter _this, ReadOnlyMemory<Char> source, Char[] charBuffer, int charPos, int charLen, Char[] coreNewLine, bool autoFlush, bool appendNewLine, CancellationToken cancellationToken) { }

	public virtual void WriteLine(string value) { }

	private void WriteSpan(ReadOnlySpan<Char> buffer, bool appendNewLine) { }

}

