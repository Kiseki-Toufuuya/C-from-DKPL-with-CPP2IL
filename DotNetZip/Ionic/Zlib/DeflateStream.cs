namespace Ionic.Zlib;

public class DeflateStream : Stream
{
	internal ZlibBaseStream _baseStream; //Field offset: 0x14
	internal Stream _innerStream; //Field offset: 0x18
	private bool _disposed; //Field offset: 0x1C

	public int BufferSize
	{
		 set { } //Length: 307
	}

	public virtual bool CanRead
	{
		 get { } //Length: 118
	}

	public virtual bool CanSeek
	{
		 get { } //Length: 3
	}

	public virtual bool CanWrite
	{
		 get { } //Length: 118
	}

	public virtual long Length
	{
		 get { } //Length: 47
	}

	public virtual long Position
	{
		 get { } //Length: 68
		 set { } //Length: 47
	}

	public CompressionStrategy Strategy
	{
		 set { } //Length: 97
	}

	public DeflateStream(Stream stream, CompressionMode mode, bool leaveOpen) { }

	public DeflateStream(Stream stream, CompressionMode mode, CompressionLevel level, bool leaveOpen) { }

	protected virtual void Dispose(bool disposing) { }

	public virtual void Flush() { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanSeek() { }

	public virtual bool get_CanWrite() { }

	public virtual long get_Length() { }

	public virtual long get_Position() { }

	public virtual int Read(Byte[] buffer, int offset, int count) { }

	public virtual long Seek(long offset, SeekOrigin origin) { }

	public void set_BufferSize(int value) { }

	public virtual void set_Position(long value) { }

	public void set_Strategy(CompressionStrategy value) { }

	public virtual void SetLength(long value) { }

	public virtual void Write(Byte[] buffer, int offset, int count) { }

}

