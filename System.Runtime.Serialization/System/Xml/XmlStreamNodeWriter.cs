namespace System.Xml;

internal abstract class XmlStreamNodeWriter : XmlNodeWriter
{
	private class FlushBufferAsyncResult : AsyncResult
	{
		private static AsyncCompletion onComplete; //Field offset: 0x0
		private XmlStreamNodeWriter writer; //Field offset: 0x38

		private static FlushBufferAsyncResult() { }

		public FlushBufferAsyncResult(XmlStreamNodeWriter writer, AsyncCallback callback, object state) { }

		public static void End(IAsyncResult result) { }

		private bool HandleFlushBuffer(IAsyncResult result) { }

		private static bool OnComplete(IAsyncResult result) { }

	}

	public class GetBufferArgs
	{
		[CompilerGenerated]
		private int <Count>k__BackingField; //Field offset: 0x8

		public int Count
		{
			[CompilerGenerated]
			 get { } //Length: 11
			[CompilerGenerated]
			 set { } //Length: 14
		}

		public GetBufferArgs() { }

		[CompilerGenerated]
		public int get_Count() { }

		[CompilerGenerated]
		public void set_Count(int value) { }

	}

	public class GetBufferAsyncEventArgs : AsyncEventArgs<GetBufferArgs, GetBufferEventResult>
	{

		public GetBufferAsyncEventArgs() { }

	}

	private class GetBufferAsyncResult : AsyncResult
	{
		private static AsyncCompletion onComplete; //Field offset: 0x0
		private XmlStreamNodeWriter writer; //Field offset: 0x38
		private int offset; //Field offset: 0x3C
		private int count; //Field offset: 0x40

		private static GetBufferAsyncResult() { }

		public GetBufferAsyncResult(int count, XmlStreamNodeWriter writer, AsyncCallback callback, object state) { }

		public static Byte[] End(IAsyncResult result, out int offset) { }

		private bool HandleFlushBuffer(IAsyncResult result) { }

		private static bool OnComplete(IAsyncResult result) { }

	}

	public class GetBufferEventResult
	{
		[CompilerGenerated]
		private Byte[] <Buffer>k__BackingField; //Field offset: 0x8
		[CompilerGenerated]
		private int <Offset>k__BackingField; //Field offset: 0xC

		internal Byte[] Buffer
		{
			[CompilerGenerated]
			internal get { } //Length: 11
			[CompilerGenerated]
			internal set { } //Length: 27
		}

		internal int Offset
		{
			[CompilerGenerated]
			internal get { } //Length: 11
			[CompilerGenerated]
			internal set { } //Length: 14
		}

		public GetBufferEventResult() { }

		[CompilerGenerated]
		internal Byte[] get_Buffer() { }

		[CompilerGenerated]
		internal int get_Offset() { }

		[CompilerGenerated]
		internal void set_Buffer(Byte[] value) { }

		[CompilerGenerated]
		internal void set_Offset(int value) { }

	}

	private class WriteBytesAsyncResult : AsyncResult
	{
		private static AsyncCompletion onHandleGetBufferComplete; //Field offset: 0x0
		private static AsyncCompletion onHandleFlushBufferComplete; //Field offset: 0x4
		private static AsyncCompletion onHandleWrite; //Field offset: 0x8
		private Byte[] byteBuffer; //Field offset: 0x38
		private int byteOffset; //Field offset: 0x3C
		private int byteCount; //Field offset: 0x40
		private XmlStreamNodeWriter writer; //Field offset: 0x44

		private static WriteBytesAsyncResult() { }

		public WriteBytesAsyncResult(Byte[] byteBuffer, int byteOffset, int byteCount, XmlStreamNodeWriter writer, AsyncCallback callback, object state) { }

		public static void End(IAsyncResult result) { }

		private bool HandleFlushBuffer(IAsyncResult result) { }

		private bool HandleGetBuffer(IAsyncResult result) { }

		private bool HandleWrite(IAsyncResult result) { }

		private static bool OnHandleFlushBufferComplete(IAsyncResult result) { }

		private static bool OnHandleGetBufferComplete(IAsyncResult result) { }

		private static bool OnHandleWrite(IAsyncResult result) { }

	}

	private const int bufferLength = 512; //Field offset: 0x0
	private const int maxEntityLength = 32; //Field offset: 0x0
	private const int maxBytesPerChar = 3; //Field offset: 0x0
	private static UTF8Encoding UTF8Encoding; //Field offset: 0x0
	private static AsyncCallback onFlushBufferComplete; //Field offset: 0x4
	private static AsyncEventArgsCallback onGetFlushComplete; //Field offset: 0x8
	private Stream stream; //Field offset: 0x8
	private Byte[] buffer; //Field offset: 0xC
	private int offset; //Field offset: 0x10
	private bool ownsStream; //Field offset: 0x14
	private Encoding encoding; //Field offset: 0x18
	private int hasPendingWrite; //Field offset: 0x1C
	private AsyncEventArgs<Object> flushBufferState; //Field offset: 0x20

	public int BufferOffset
	{
		 get { } //Length: 11
	}

	public int Position
	{
		 get { } //Length: 54
	}

	public Stream Stream
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public Byte[] StreamBuffer
	{
		 get { } //Length: 11
	}

	private static XmlStreamNodeWriter() { }

	protected XmlStreamNodeWriter() { }

	protected void Advance(int count) { }

	protected override IAsyncResult BeginFlushBuffer(AsyncCallback callback, object state) { }

	protected IAsyncResult BeginGetBuffer(int count, AsyncCallback callback, object state) { }

	public IAsyncResult BeginWriteBytes(Byte[] byteBuffer, int byteOffset, int byteCount, AsyncCallback callback, object state) { }

	public virtual void Close() { }

	protected override void EndFlushBuffer(IAsyncResult result) { }

	protected Byte[] EndGetBuffer(IAsyncResult result, out int offset) { }

	public void EndWriteBytes(IAsyncResult result) { }

	private void EnsureByte() { }

	public virtual void Flush() { }

	protected override void FlushBuffer() { }

	private AsyncCompletionResult FlushBufferAsync(AsyncEventArgs<Object> state) { }

	public int get_BufferOffset() { }

	public int get_Position() { }

	public Stream get_Stream() { }

	public Byte[] get_StreamBuffer() { }

	protected Byte[] GetBuffer(int count, out int offset) { }

	internal AsyncCompletionResult GetBufferAsync(GetBufferAsyncEventArgs getBufferState) { }

	private static void GetBufferFlushComplete(IAsyncEventArgs completionState) { }

	private static void OnFlushBufferCompete(IAsyncResult result) { }

	public void set_Stream(Stream value) { }

	protected void SetOutput(Stream stream, bool ownsStream, Encoding encoding) { }

	protected int UnsafeGetUnicodeChars(Char* chars, int charCount, Byte[] buffer, int offset) { }

	protected int UnsafeGetUTF8Chars(Char* chars, int charCount, Byte[] buffer, int offset) { }

	protected int UnsafeGetUTF8Length(Char* chars, int charCount) { }

	protected void UnsafeWriteBytes(Byte* bytes, int byteCount) { }

	protected void UnsafeWriteUnicodeChars(Char* chars, int charCount) { }

	protected void UnsafeWriteUTF8Chars(Char* chars, int charCount) { }

	protected void WriteByte(char ch) { }

	protected void WriteByte(byte b) { }

	protected void WriteBytes(char ch1, char ch2) { }

	public void WriteBytes(Byte[] byteBuffer, int byteOffset, int byteCount) { }

	protected void WriteBytes(byte b1, byte b2) { }

	protected void WriteUTF8Char(int ch) { }

	protected void WriteUTF8Chars(Byte[] chars, int charOffset, int charCount) { }

	protected void WriteUTF8Chars(string value) { }

}

