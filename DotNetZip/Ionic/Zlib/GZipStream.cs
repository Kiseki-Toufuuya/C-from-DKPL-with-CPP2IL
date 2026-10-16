namespace Ionic.Zlib;

public class GZipStream : Stream
{
	internal static readonly DateTime _unixEpoch; //Field offset: 0x0
	internal static readonly Encoding iso8859dash1; //Field offset: 0x8
	public Nullable<DateTime> LastModified; //Field offset: 0x18
	private int _headerByteCount; //Field offset: 0x28
	internal ZlibBaseStream _baseStream; //Field offset: 0x2C
	private bool _disposed; //Field offset: 0x30
	private bool _firstReadDone; //Field offset: 0x31
	private string _FileName; //Field offset: 0x34
	private string _Comment; //Field offset: 0x38
	private int _Crc32; //Field offset: 0x3C

	public virtual bool CanRead
	{
		 get { } //Length: 118
	}

	public virtual bool CanSeek
	{
		 get { } //Length: 3
	}

	public virtual bool CanWrite
	{
		 get { } //Length: 118
	}

	public string Comment
	{
		 get { } //Length: 11
		 set { } //Length: 98
	}

	public string FileName
	{
		 get { } //Length: 11
		 set { } //Length: 418
	}

	public virtual long Length
	{
		 get { } //Length: 47
	}

	public virtual long Position
	{
		 get { } //Length: 80
		 set { } //Length: 47
	}

	private static GZipStream() { }

	public GZipStream(Stream stream, CompressionMode mode) { }

	public GZipStream(Stream stream, CompressionMode mode, CompressionLevel level, bool leaveOpen) { }

	protected virtual void Dispose(bool disposing) { }

	private int EmitHeader() { }

	public virtual void Flush() { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanSeek() { }

	public virtual bool get_CanWrite() { }

	public string get_Comment() { }

	public string get_FileName() { }

	public virtual long get_Length() { }

	public virtual long get_Position() { }

	public virtual int Read(Byte[] buffer, int offset, int count) { }

	public virtual long Seek(long offset, SeekOrigin origin) { }

	public void set_Comment(string value) { }

	public void set_FileName(string value) { }

	public virtual void set_Position(long value) { }

	public virtual void SetLength(long value) { }

	public virtual void Write(Byte[] buffer, int offset, int count) { }

}

