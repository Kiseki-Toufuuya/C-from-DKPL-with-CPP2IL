namespace Ionic.Zip;

internal class ZipSegmentedStream : Stream
{
	private enum RwMode
	{
		None = 0,
		ReadOnly = 1,
		Write = 2,
	}

	private RwMode rwMode; //Field offset: 0x14
	private bool _exceptionPending; //Field offset: 0x18
	private string _baseName; //Field offset: 0x1C
	private string _baseDir; //Field offset: 0x20
	private string _currentName; //Field offset: 0x24
	private string _currentTempName; //Field offset: 0x28
	private uint _currentDiskNumber; //Field offset: 0x2C
	private uint _maxDiskNumber; //Field offset: 0x30
	private long _maxSegmentSize; //Field offset: 0x38
	private Stream _innerStream; //Field offset: 0x40
	[CompilerGenerated]
	private bool <ContiguousWrite>k__BackingField; //Field offset: 0x44

	public virtual bool CanRead
	{
		 get { } //Length: 47
	}

	public virtual bool CanSeek
	{
		 get { } //Length: 41
	}

	public virtual bool CanWrite
	{
		 get { } //Length: 47
	}

	public bool ContiguousWrite
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public string CurrentName
	{
		 get { } //Length: 46
	}

	public private uint CurrentSegment
	{
		 get { } //Length: 11
		private set { } //Length: 35
	}

	public string CurrentTempName
	{
		 get { } //Length: 11
	}

	public virtual long Length
	{
		 get { } //Length: 40
	}

	public virtual long Position
	{
		 get { } //Length: 40
		 set { } //Length: 361
	}

	private string _NameForSegment(uint diskNumber) { }

	private void _SetReadStream() { }

	private void _SetWriteStream(uint increment) { }

	private ZipSegmentedStream() { }

	public uint ComputeSegment(int length) { }

	protected virtual void Dispose(bool disposing) { }

	public virtual void Flush() { }

	public static ZipSegmentedStream ForReading(string name, uint initialDiskNumber, uint maxDiskNumber) { }

	public static Stream ForUpdate(string name, uint diskNumber) { }

	public static ZipSegmentedStream ForWriting(string name, long maxSegmentSize) { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanSeek() { }

	public virtual bool get_CanWrite() { }

	[CompilerGenerated]
	public bool get_ContiguousWrite() { }

	public string get_CurrentName() { }

	public uint get_CurrentSegment() { }

	public string get_CurrentTempName() { }

	public virtual long get_Length() { }

	public virtual long get_Position() { }

	public virtual int Read(Byte[] buffer, int offset, int count) { }

	public virtual long Seek(long offset, SeekOrigin origin) { }

	[CompilerGenerated]
	public void set_ContiguousWrite(bool value) { }

	private void set_CurrentSegment(uint value) { }

	public virtual void set_Position(long value) { }

	public virtual void SetLength(long value) { }

	public virtual string ToString() { }

	public long TruncateBackward(uint diskNumber, long offset) { }

	public virtual void Write(Byte[] buffer, int offset, int count) { }

}

