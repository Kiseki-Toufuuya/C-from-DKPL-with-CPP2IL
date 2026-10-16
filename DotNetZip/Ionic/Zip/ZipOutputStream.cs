namespace Ionic.Zip;

public class ZipOutputStream : Stream
{
	[CompilerGenerated]
	private int <CodecBufferSize>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private CompressionStrategy <Strategy>k__BackingField; //Field offset: 0x18
	internal string _password; //Field offset: 0x1C
	private Stream _outputStream; //Field offset: 0x20
	private ZipEntry _currentEntry; //Field offset: 0x24
	internal Zip64Option _zip64; //Field offset: 0x28
	private Dictionary<String, ZipEntry> _entriesWritten; //Field offset: 0x2C
	private int _entryCount; //Field offset: 0x30
	private ZipOption _alternateEncodingUsage; //Field offset: 0x34
	private Encoding _alternateEncoding; //Field offset: 0x38
	private bool _disposed; //Field offset: 0x3C
	private bool _exceptionPending; //Field offset: 0x3D
	private CountingStream _outputCounter; //Field offset: 0x40
	private Stream _encryptor; //Field offset: 0x44
	private Stream _deflater; //Field offset: 0x48
	private CrcCalculatorStream _entryOutputStream; //Field offset: 0x4C
	private bool _needToWriteEntryHeader; //Field offset: 0x50
	internal ParallelDeflateOutputStream ParallelDeflater; //Field offset: 0x54
	private long _ParallelDeflateThreshold; //Field offset: 0x58
	private int _maxBufferPairs; //Field offset: 0x60

	public Encoding AlternateEncoding
	{
		 get { } //Length: 11
	}

	public ZipOption AlternateEncodingUsage
	{
		 get { } //Length: 11
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
		 get { } //Length: 3
	}

	public int CodecBufferSize
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public static Encoding DefaultEncoding
	{
		 get { } //Length: 46
	}

	public Zip64Option EnableZip64
	{
		 get { } //Length: 11
	}

	public virtual long Length
	{
		 get { } //Length: 47
	}

	internal Stream OutputStream
	{
		internal get { } //Length: 11
	}

	public int ParallelDeflateMaxBufferPairs
	{
		 get { } //Length: 11
	}

	public long ParallelDeflateThreshold
	{
		 get { } //Length: 14
	}

	public virtual long Position
	{
		 get { } //Length: 40
		 set { } //Length: 47
	}

	public CompressionStrategy Strategy
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	private void _InitiateCurrentEntry(bool finishing) { }

	public virtual void Flush() { }

	public Encoding get_AlternateEncoding() { }

	public ZipOption get_AlternateEncodingUsage() { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanSeek() { }

	public virtual bool get_CanWrite() { }

	[CompilerGenerated]
	public int get_CodecBufferSize() { }

	public static Encoding get_DefaultEncoding() { }

	public Zip64Option get_EnableZip64() { }

	public virtual long get_Length() { }

	internal Stream get_OutputStream() { }

	public int get_ParallelDeflateMaxBufferPairs() { }

	public long get_ParallelDeflateThreshold() { }

	public virtual long get_Position() { }

	[CompilerGenerated]
	public CompressionStrategy get_Strategy() { }

	public virtual int Read(Byte[] buffer, int offset, int count) { }

	public virtual long Seek(long offset, SeekOrigin origin) { }

	public virtual void set_Position(long value) { }

	public virtual void SetLength(long value) { }

	public virtual void Write(Byte[] buffer, int offset, int count) { }

}

