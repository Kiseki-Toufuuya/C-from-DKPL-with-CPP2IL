namespace System.IO;

public class MemoryStream : Stream
{
	private Byte[] _buffer; //Field offset: 0x14
	private int _origin; //Field offset: 0x18
	private int _position; //Field offset: 0x1C
	private int _length; //Field offset: 0x20
	private int _capacity; //Field offset: 0x24
	private bool _expandable; //Field offset: 0x28
	private bool _writable; //Field offset: 0x29
	private bool _exposable; //Field offset: 0x2A
	private bool _isOpen; //Field offset: 0x2B
	private Task<Int32> _lastReadTask; //Field offset: 0x2C

	public virtual bool CanRead
	{
		 get { } //Length: 11
	}

	public virtual bool CanSeek
	{
		 get { } //Length: 11
	}

	public virtual bool CanWrite
	{
		 get { } //Length: 11
	}

	public override int Capacity
	{
		 get { } //Length: 51
		 set { } //Length: 383
	}

	public virtual long Length
	{
		 get { } //Length: 52
	}

	public virtual long Position
	{
		 get { } //Length: 52
		 set { } //Length: 229
	}

	public MemoryStream() { }

	public MemoryStream(int capacity) { }

	public MemoryStream(Byte[] buffer) { }

	public MemoryStream(Byte[] buffer, bool writable) { }

	public MemoryStream(Byte[] buffer, int index, int count) { }

	public MemoryStream(Byte[] buffer, int index, int count, bool writable, bool publiclyVisible) { }

	public virtual void CopyTo(Stream destination, int bufferSize) { }

	public virtual Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken) { }

	protected virtual void Dispose(bool disposing) { }

	private bool EnsureCapacity(int value) { }

	private void EnsureNotClosed() { }

	private void EnsureWriteable() { }

	public virtual void Flush() { }

	public virtual Task FlushAsync(CancellationToken cancellationToken) { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanSeek() { }

	public virtual bool get_CanWrite() { }

	public override int get_Capacity() { }

	public virtual long get_Length() { }

	public virtual long get_Position() { }

	public override Byte[] GetBuffer() { }

	internal int InternalEmulateRead(int count) { }

	internal Byte[] InternalGetBuffer() { }

	internal int InternalGetPosition() { }

	internal int InternalReadInt32() { }

	public virtual int Read(Byte[] buffer, int offset, int count) { }

	public virtual int Read(Span<Byte> buffer) { }

	public virtual Task<Int32> ReadAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	public virtual ValueTask<Int32> ReadAsync(Memory<Byte> buffer, CancellationToken cancellationToken = null) { }

	public virtual int ReadByte() { }

	public virtual long Seek(long offset, SeekOrigin loc) { }

	public override void set_Capacity(int value) { }

	public virtual void set_Position(long value) { }

	public virtual void SetLength(long value) { }

	public override Byte[] ToArray() { }

	public virtual void Write(Byte[] buffer, int offset, int count) { }

	public virtual void Write(ReadOnlySpan<Byte> buffer) { }

	public virtual ValueTask WriteAsync(ReadOnlyMemory<Byte> buffer, CancellationToken cancellationToken = null) { }

	public virtual Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	public virtual void WriteByte(byte value) { }

}

