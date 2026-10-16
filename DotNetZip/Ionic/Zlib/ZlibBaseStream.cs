namespace Ionic.Zlib;

internal class ZlibBaseStream : Stream
{
	public enum StreamMode
	{
		Writer = 0,
		Reader = 1,
		Undefined = 2,
	}

	protected private ZlibCodec _z; //Field offset: 0x14
	protected private StreamMode _streamMode; //Field offset: 0x18
	protected private FlushType _flushMode; //Field offset: 0x1C
	protected private ZlibStreamFlavor _flavor; //Field offset: 0x20
	protected private CompressionMode _compressionMode; //Field offset: 0x24
	protected private CompressionLevel _level; //Field offset: 0x28
	protected private bool _leaveOpen; //Field offset: 0x2C
	protected private Byte[] _workingBuffer; //Field offset: 0x30
	protected private int _bufferSize; //Field offset: 0x34
	protected private Byte[] _buf1; //Field offset: 0x38
	protected private Stream _stream; //Field offset: 0x3C
	protected private CompressionStrategy Strategy; //Field offset: 0x40
	private CRC32 crc; //Field offset: 0x44
	protected private string _GzipFileName; //Field offset: 0x48
	protected private string _GzipComment; //Field offset: 0x4C
	protected private DateTime _GzipMtime; //Field offset: 0x50
	protected private int _gzipHeaderByteCount; //Field offset: 0x58
	private bool nomoreinput; //Field offset: 0x5C

	protected private bool _wantCompress
	{
		private get { } //Length: 15
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

	internal int Crc32
	{
		internal get { } //Length: 26
	}

	public virtual long Length
	{
		 get { } //Length: 40
	}

	public virtual long Position
	{
		 get { } //Length: 47
		 set { } //Length: 47
	}

	private Byte[] workingBuffer
	{
		private get { } //Length: 78
	}

	private ZlibCodec z
	{
		private get { } //Length: 356
	}

	private int _ReadAndValidateGzipHeader() { }

	public ZlibBaseStream(Stream stream, CompressionMode compressionMode, CompressionLevel level, ZlibStreamFlavor flavor, bool leaveOpen) { }

	protected virtual void Dispose(bool disposing) { }

	private void end() { }

	private void finish() { }

	public virtual void Flush() { }

	protected private bool get__wantCompress() { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanSeek() { }

	public virtual bool get_CanWrite() { }

	internal int get_Crc32() { }

	public virtual long get_Length() { }

	public virtual long get_Position() { }

	private Byte[] get_workingBuffer() { }

	private ZlibCodec get_z() { }

	public virtual int Read(Byte[] buffer, int offset, int count) { }

	private string ReadZeroTerminatedString() { }

	public virtual long Seek(long offset, SeekOrigin origin) { }

	public virtual void set_Position(long value) { }

	public virtual void SetLength(long value) { }

	public virtual void Write(Byte[] buffer, int offset, int count) { }

}

