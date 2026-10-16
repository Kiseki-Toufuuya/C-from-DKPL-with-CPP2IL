namespace Ionic.Zip;

public class CountingStream : Stream
{
	private Stream _s; //Field offset: 0x14
	private long _bytesWritten; //Field offset: 0x18
	private long _bytesRead; //Field offset: 0x20
	private long _initialOffset; //Field offset: 0x28

	public long BytesRead
	{
		 get { } //Length: 14
	}

	public long BytesWritten
	{
		 get { } //Length: 14
	}

	public virtual bool CanRead
	{
		 get { } //Length: 40
	}

	public virtual bool CanSeek
	{
		 get { } //Length: 40
	}

	public virtual bool CanWrite
	{
		 get { } //Length: 40
	}

	public long ComputedPosition
	{
		 get { } //Length: 20
	}

	public virtual long Length
	{
		 get { } //Length: 40
	}

	public virtual long Position
	{
		 get { } //Length: 40
		 set { } //Length: 48
	}

	public CountingStream(Stream stream) { }

	public void Adjust(long delta) { }

	public virtual void Flush() { }

	public long get_BytesRead() { }

	public long get_BytesWritten() { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanSeek() { }

	public virtual bool get_CanWrite() { }

	public long get_ComputedPosition() { }

	public virtual long get_Length() { }

	public virtual long get_Position() { }

	public virtual int Read(Byte[] buffer, int offset, int count) { }

	public virtual long Seek(long offset, SeekOrigin origin) { }

	public virtual void set_Position(long value) { }

	public virtual void SetLength(long value) { }

	public virtual void Write(Byte[] buffer, int offset, int count) { }

}

