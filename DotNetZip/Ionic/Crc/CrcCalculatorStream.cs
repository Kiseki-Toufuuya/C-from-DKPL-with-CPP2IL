namespace Ionic.Crc;

public class CrcCalculatorStream : Stream, IDisposable
{
	private static readonly long UnsetLengthLimit; //Field offset: 0x0
	private readonly Stream _innerStream; //Field offset: 0x14
	private readonly CRC32 _crc32; //Field offset: 0x18
	private readonly long _lengthLimit; //Field offset: 0x20
	private bool _leaveOpen; //Field offset: 0x28

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
		 get { } //Length: 40
	}

	public int Crc
	{
		 get { } //Length: 25
	}

	public virtual long Length
	{
		 get { } //Length: 129
	}

	public virtual long Position
	{
		 get { } //Length: 26
		 set { } //Length: 47
	}

	public long TotalBytesSlurped
	{
		 get { } //Length: 26
	}

	private static CrcCalculatorStream() { }

	private CrcCalculatorStream(bool leaveOpen, long length, Stream stream, CRC32 crc32) { }

	public CrcCalculatorStream(Stream stream) { }

	public CrcCalculatorStream(Stream stream, bool leaveOpen) { }

	public CrcCalculatorStream(Stream stream, long length) { }

	public virtual void Close() { }

	public virtual void Flush() { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanSeek() { }

	public virtual bool get_CanWrite() { }

	public int get_Crc() { }

	public virtual long get_Length() { }

	public virtual long get_Position() { }

	public long get_TotalBytesSlurped() { }

	private void InnerClose() { }

	public virtual int Read(Byte[] buffer, int offset, int count) { }

	public virtual long Seek(long offset, SeekOrigin origin) { }

	public virtual void set_Position(long value) { }

	public virtual void SetLength(long value) { }

	private override void System.IDisposable.Dispose() { }

	public virtual void Write(Byte[] buffer, int offset, int count) { }

}

