namespace Ionic.Zlib;

public class ParallelDeflateOutputStream : Stream
{
	[Flags]
	private enum TraceBits
	{
		None = 0,
		NotUsed1 = 1,
		EmitLock = 2,
		EmitEnter = 4,
		EmitBegin = 8,
		EmitDone = 16,
		EmitSkip = 32,
		EmitAll = 58,
		Flush = 64,
		Lifecycle = 128,
		Session = 256,
		Synch = 512,
		Instance = 1024,
		Compress = 2048,
		Write = 4096,
		WriteEnter = 8192,
		WriteTake = 16384,
		All = 4294967295,
	}

	private static readonly int IO_BUFFER_SIZE_DEFAULT; //Field offset: 0x0
	private static readonly int BufferPairsPerCore; //Field offset: 0x4
	private List<WorkItem> _pool; //Field offset: 0x14
	private bool _leaveOpen; //Field offset: 0x18
	private bool emitting; //Field offset: 0x19
	private Stream _outStream; //Field offset: 0x1C
	private int _maxBufferPairs; //Field offset: 0x20
	private int _bufferSize; //Field offset: 0x24
	private AutoResetEvent _newlyCompressedBlob; //Field offset: 0x28
	private object _outputLock; //Field offset: 0x2C
	private bool _isClosed; //Field offset: 0x30
	private bool _firstWriteDone; //Field offset: 0x31
	private int _currentlyFilling; //Field offset: 0x34
	private int _lastFilled; //Field offset: 0x38
	private int _lastWritten; //Field offset: 0x3C
	private int _latestCompressed; //Field offset: 0x40
	private int _Crc32; //Field offset: 0x44
	private CRC32 _runningCrc; //Field offset: 0x48
	private object _latestLock; //Field offset: 0x4C
	private Queue<Int32> _toWrite; //Field offset: 0x50
	private Queue<Int32> _toFill; //Field offset: 0x54
	private long _totalBytesProcessed; //Field offset: 0x58
	private CompressionLevel _compressLevel; //Field offset: 0x60
	private Exception _pendingException; //Field offset: 0x64
	private bool _handlingException; //Field offset: 0x68
	private object _eLock; //Field offset: 0x6C
	private TraceBits _DesiredTrace; //Field offset: 0x70
	[CompilerGenerated]
	private CompressionStrategy <Strategy>k__BackingField; //Field offset: 0x74

	public int BufferSize
	{
		 set { } //Length: 96
	}

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
		 get { } //Length: 40
	}

	public virtual long Length
	{
		 get { } //Length: 47
	}

	public int MaxBufferPairs
	{
		 set { } //Length: 93
	}

	public virtual long Position
	{
		 get { } //Length: 40
		 set { } //Length: 47
	}

	public private CompressionStrategy Strategy
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	private void _DeflateOne(object wi) { }

	private void _Flush(bool lastInput) { }

	private void _FlushFinish() { }

	private void _InitializePoolOfWorkItems() { }

	private static ParallelDeflateOutputStream() { }

	public ParallelDeflateOutputStream(Stream stream, CompressionLevel level, CompressionStrategy strategy, bool leaveOpen) { }

	public virtual void Close() { }

	private bool DeflateOneSegment(WorkItem workitem) { }

	protected virtual void Dispose(bool disposing) { }

	public void Dispose() { }

	private void EmitPendingBuffers(bool doAll, bool mustWait) { }

	public virtual void Flush() { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanSeek() { }

	public virtual bool get_CanWrite() { }

	public virtual long get_Length() { }

	public virtual long get_Position() { }

	[CompilerGenerated]
	public CompressionStrategy get_Strategy() { }

	private void InnerClose() { }

	public virtual int Read(Byte[] buffer, int offset, int count) { }

	public void Reset(Stream stream) { }

	public virtual long Seek(long offset, SeekOrigin origin) { }

	public void set_BufferSize(int value) { }

	public void set_MaxBufferPairs(int value) { }

	public virtual void set_Position(long value) { }

	[CompilerGenerated]
	private void set_Strategy(CompressionStrategy value) { }

	public virtual void SetLength(long value) { }

	public virtual void Write(Byte[] buffer, int offset, int count) { }

}

