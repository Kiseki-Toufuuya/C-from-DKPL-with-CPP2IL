namespace System.IO;

public class StreamReader : TextReader
{
	private class NullStreamReader : StreamReader
	{

		public virtual Stream BaseStream
		{
			 get { } //Length: 60
		}

		public virtual Encoding CurrentEncoding
		{
			 get { } //Length: 11
		}

		internal NullStreamReader() { }

		protected virtual void Dispose(bool disposing) { }

		public virtual Stream get_BaseStream() { }

		public virtual Encoding get_CurrentEncoding() { }

		public virtual int Peek() { }

		public virtual int Read() { }

		public virtual int Read(Char[] buffer, int index, int count) { }

		internal virtual int ReadBuffer() { }

		public virtual string ReadLine() { }

		public virtual string ReadToEnd() { }

	}

	public static readonly StreamReader Null; //Field offset: 0x0
	private Stream _stream; //Field offset: 0xC
	private Encoding _encoding; //Field offset: 0x10
	private Decoder _decoder; //Field offset: 0x14
	private Byte[] _byteBuffer; //Field offset: 0x18
	private Char[] _charBuffer; //Field offset: 0x1C
	private int _charPos; //Field offset: 0x20
	private int _charLen; //Field offset: 0x24
	private int _byteLen; //Field offset: 0x28
	private int _bytePos; //Field offset: 0x2C
	private int _maxCharsPerBuffer; //Field offset: 0x30
	private bool _detectEncoding; //Field offset: 0x34
	private bool _checkPreamble; //Field offset: 0x35
	private bool _isBlocked; //Field offset: 0x36
	private bool _closable; //Field offset: 0x37
	private Task _asyncReadTask; //Field offset: 0x38

	public override Stream BaseStream
	{
		 get { } //Length: 11
	}

	public override Encoding CurrentEncoding
	{
		 get { } //Length: 11
	}

	internal bool LeaveOpen
	{
		internal get { } //Length: 15
	}

	private static StreamReader() { }

	public StreamReader(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize) { }

	internal StreamReader() { }

	public StreamReader(Stream stream) { }

	public StreamReader(Stream stream, bool detectEncodingFromByteOrderMarks) { }

	public StreamReader(Stream stream, Encoding encoding) { }

	public StreamReader(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize) { }

	public StreamReader(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen) { }

	public StreamReader(string path) { }

	public StreamReader(string path, bool detectEncodingFromByteOrderMarks) { }

	public StreamReader(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks) { }

	private void CheckAsyncTaskInProgress() { }

	public virtual void Close() { }

	private void CompressBuffer(int n) { }

	internal bool DataAvailable() { }

	private void DetectEncoding() { }

	protected virtual void Dispose(bool disposing) { }

	public override Stream get_BaseStream() { }

	public override Encoding get_CurrentEncoding() { }

	internal bool get_LeaveOpen() { }

	private void Init(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen) { }

	internal void Init(Stream stream) { }

	private bool IsPreamble() { }

	public virtual int Peek() { }

	public virtual int Read() { }

	public virtual int Read(Char[] buffer, int index, int count) { }

	internal override int ReadBuffer() { }

	private int ReadBuffer(Span<Char> userBuffer, out bool readToUserBuffer) { }

	public virtual string ReadLine() { }

	private int ReadSpan(Span<Char> buffer) { }

	public virtual string ReadToEnd() { }

	private static void ThrowAsyncIOInProgress() { }

}

