namespace System.Xml;

internal class DelimittedStreamReader
{
	private class DelimittedReadStream : Stream
	{
		private DelimittedStreamReader reader; //Field offset: 0x14

		public virtual bool CanRead
		{
			 get { } //Length: 3
		}

		public virtual bool CanSeek
		{
			 get { } //Length: 3
		}

		public virtual bool CanWrite
		{
			 get { } //Length: 3
		}

		public virtual long Length
		{
			 get { } //Length: 163
		}

		public virtual long Position
		{
			 get { } //Length: 163
			 set { } //Length: 163
		}

		public DelimittedReadStream(DelimittedStreamReader reader) { }

		public virtual IAsyncResult BeginWrite(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

		public virtual void Close() { }

		public virtual void EndWrite(IAsyncResult asyncResult) { }

		public virtual void Flush() { }

		public virtual bool get_CanRead() { }

		public virtual bool get_CanSeek() { }

		public virtual bool get_CanWrite() { }

		public virtual long get_Length() { }

		public virtual long get_Position() { }

		public virtual int Read(Byte[] buffer, int offset, int count) { }

		public virtual long Seek(long offset, SeekOrigin origin) { }

		public virtual void set_Position(long value) { }

		public virtual void SetLength(long value) { }

		public virtual void Write(Byte[] buffer, int offset, int count) { }

	}

	private enum MatchState
	{
		True = 0,
		False = 1,
		InsufficientData = 2,
	}

	private bool canGetNextStream; //Field offset: 0x8
	private DelimittedReadStream currentStream; //Field offset: 0xC
	private Byte[] delimitter; //Field offset: 0x10
	private Byte[] matchBuffer; //Field offset: 0x14
	private Byte[] scratch; //Field offset: 0x18
	private BufferedReadStream stream; //Field offset: 0x1C

	public DelimittedStreamReader(Stream stream) { }

	public void Close() { }

	private void Close(DelimittedReadStream caller) { }

	public Stream GetNextStream(Byte[] delimitter) { }

	private MatchState MatchDelimitter(Byte[] buffer, int start, int end) { }

	private bool MatchRemainder(int start, int count) { }

	private int ProcessRead(Byte[] buffer, int offset, int read) { }

	internal void Push(Byte[] buffer, int offset, int count) { }

	private int Read(DelimittedReadStream caller, Byte[] buffer, int offset, int count) { }

}

