namespace Google.Protobuf;

internal sealed class LimitedInputStream : Stream
{
	private readonly Stream proxied; //Field offset: 0x14
	private int bytesLeft; //Field offset: 0x18

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
		 get { } //Length: 47
	}

	public virtual long Position
	{
		 get { } //Length: 47
		 set { } //Length: 47
	}

	internal LimitedInputStream(Stream proxied, int size) { }

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

