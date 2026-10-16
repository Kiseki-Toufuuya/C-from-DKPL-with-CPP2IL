namespace Ionic.BZip2;

public class ParallelBZip2OutputStream : Stream
{
	[Flags]
	private enum TraceBits
	{
		None = 0,
		Crc = 1,
		Write = 2,
		All = 4294967295,
	}

	private static readonly int BufferPairsPerCore; //Field offset: 0x0
	private int _maxWorkers; //Field offset: 0x14
	private bool firstWriteDone; //Field offset: 0x18
	private int lastFilled; //Field offset: 0x1C
	private int lastWritten; //Field offset: 0x20
	private int latestCompressed; //Field offset: 0x24
	private int currentlyFilling; //Field offset: 0x28
	private Exception pendingException; //Field offset: 0x2C
	private bool handlingException; //Field offset: 0x30
	private bool emitting; //Field offset: 0x31
	private Queue<Int32> toWrite; //Field offset: 0x34
	private Queue<Int32> toFill; //Field offset: 0x38
	private List<WorkItem> pool; //Field offset: 0x3C
	private object latestLock; //Field offset: 0x40
	private object eLock; //Field offset: 0x44
	private object outputLock; //Field offset: 0x48
	private AutoResetEvent newlyCompressedBlob; //Field offset: 0x4C
	private long totalBytesWrittenIn; //Field offset: 0x50
	private long totalBytesWrittenOut; //Field offset: 0x58
	private bool leaveOpen; //Field offset: 0x60
	private uint combinedCRC; //Field offset: 0x64
	private Stream output; //Field offset: 0x68
	private BitWriter bw; //Field offset: 0x6C
	private int blockSize100k; //Field offset: 0x70
	private TraceBits desiredTrace; //Field offset: 0x74

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

	public int MaxWorkers
	{
		 get { } //Length: 11
		 set { } //Length: 93
	}

	public virtual long Position
	{
		 get { } //Length: 14
		 set { } //Length: 47
	}

	private static ParallelBZip2OutputStream() { }

	public ParallelBZip2OutputStream(Stream output, bool leaveOpen) { }

	public ParallelBZip2OutputStream(Stream output, int blockSize, bool leaveOpen) { }

	public virtual void Close() { }

	private void CompressOne(object wi) { }

	private void EmitHeader() { }

	private void EmitPendingBuffers(bool doAll, bool mustWait) { }

	private void EmitTrailer() { }

	public virtual void Flush() { }

	private void FlushOutput(bool lastInput) { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanSeek() { }

	public virtual bool get_CanWrite() { }

	public virtual long get_Length() { }

	public int get_MaxWorkers() { }

	public virtual long get_Position() { }

	private void InitializePoolOfWorkItems() { }

	public virtual int Read(Byte[] buffer, int offset, int count) { }

	public virtual long Seek(long offset, SeekOrigin origin) { }

	public void set_MaxWorkers(int value) { }

	public virtual void set_Position(long value) { }

	public virtual void SetLength(long value) { }

	public virtual void Write(Byte[] buffer, int offset, int count) { }

}

