namespace System.Data.SqlTypes;

internal sealed class SqlXmlStreamWrapper : Stream
{
	private Stream _stream; //Field offset: 0x14
	private long _lPosition; //Field offset: 0x18
	private bool _isClosed; //Field offset: 0x20

	public virtual bool CanRead
	{
		 get { } //Length: 62
	}

	public virtual bool CanSeek
	{
		 get { } //Length: 62
	}

	public virtual bool CanWrite
	{
		 get { } //Length: 62
	}

	public virtual long Length
	{
		 get { } //Length: 166
	}

	public virtual long Position
	{
		 get { } //Length: 140
		 set { } //Length: 263
	}

	internal SqlXmlStreamWrapper(Stream stream) { }

	protected virtual void Dispose(bool disposing) { }

	public virtual void Flush() { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanSeek() { }

	public virtual bool get_CanWrite() { }

	public virtual long get_Length() { }

	public virtual long get_Position() { }

	private bool IsStreamClosed() { }

	public virtual int Read(Byte[] buffer, int offset, int count) { }

	public virtual int ReadByte() { }

	public virtual long Seek(long offset, SeekOrigin origin) { }

	public virtual void set_Position(long value) { }

	public virtual void SetLength(long value) { }

	private void ThrowIfStreamCannotRead(string method) { }

	private void ThrowIfStreamCannotSeek(string method) { }

	private void ThrowIfStreamCannotWrite(string method) { }

	private void ThrowIfStreamClosed(string method) { }

	public virtual void Write(Byte[] buffer, int offset, int count) { }

	public virtual void WriteByte(byte value) { }

}

