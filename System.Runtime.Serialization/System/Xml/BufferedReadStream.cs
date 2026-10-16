namespace System.Xml;

internal class BufferedReadStream : Stream
{
	private Stream stream; //Field offset: 0x14
	private Byte[] storedBuffer; //Field offset: 0x18
	private int storedLength; //Field offset: 0x1C
	private int storedOffset; //Field offset: 0x20
	private bool readMore; //Field offset: 0x24

	public virtual bool CanRead
	{
		 get { } //Length: 40
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
		 get { } //Length: 173
	}

	public virtual long Position
	{
		 get { } //Length: 173
		 set { } //Length: 173
	}

	public BufferedReadStream(Stream stream) { }

	public BufferedReadStream(Stream stream, bool readMore) { }

	public virtual IAsyncResult BeginRead(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	public virtual IAsyncResult BeginWrite(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	public virtual void Close() { }

	public virtual int EndRead(IAsyncResult asyncResult) { }

	public virtual void EndWrite(IAsyncResult asyncResult) { }

	public virtual void Flush() { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanSeek() { }

	public virtual bool get_CanWrite() { }

	public virtual long get_Length() { }

	public virtual long get_Position() { }

	public void Push(Byte[] buffer, int offset, int count) { }

	public virtual int Read(Byte[] buffer, int offset, int count) { }

	public int ReadBlock(Byte[] buffer, int offset, int count) { }

	public virtual int ReadByte() { }

	public virtual long Seek(long offset, SeekOrigin origin) { }

	public virtual void set_Position(long value) { }

	public virtual void SetLength(long value) { }

	public virtual void Write(Byte[] buffer, int offset, int count) { }

}

