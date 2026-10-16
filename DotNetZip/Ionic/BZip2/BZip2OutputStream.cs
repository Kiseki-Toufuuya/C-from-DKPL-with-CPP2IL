namespace Ionic.BZip2;

public class BZip2OutputStream : Stream
{
	[Flags]
	private enum TraceBits
	{
		None = 0,
		Crc = 1,
		Write = 2,
		All = 4294967295,
	}

	private int totalBytesWrittenIn; //Field offset: 0x14
	private bool leaveOpen; //Field offset: 0x18
	private BZip2Compressor compressor; //Field offset: 0x1C
	private uint combinedCRC; //Field offset: 0x20
	private Stream output; //Field offset: 0x24
	private BitWriter bw; //Field offset: 0x28
	private int blockSize100k; //Field offset: 0x2C
	private TraceBits desiredTrace; //Field offset: 0x30

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
		 get { } //Length: 102
	}

	public virtual long Length
	{
		 get { } //Length: 47
	}

	public virtual long Position
	{
		 get { } //Length: 12
		 set { } //Length: 47
	}

	public BZip2OutputStream(Stream output, bool leaveOpen) { }

	public BZip2OutputStream(Stream output, int blockSize, bool leaveOpen) { }

	public virtual void Close() { }

	private void EmitHeader() { }

	private void EmitTrailer() { }

	private void Finish() { }

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

