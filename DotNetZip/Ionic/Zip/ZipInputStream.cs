namespace Ionic.Zip;

public class ZipInputStream : Stream
{
	[CompilerGenerated]
	private int <CodecBufferSize>k__BackingField; //Field offset: 0x14
	private Stream _inputStream; //Field offset: 0x18
	private ZipEntry _currentEntry; //Field offset: 0x1C
	private bool _needSetup; //Field offset: 0x20
	private CrcCalculatorStream _crcStream; //Field offset: 0x24
	private long _LeftToRead; //Field offset: 0x28
	internal string _Password; //Field offset: 0x30
	private long _endOfEntry; //Field offset: 0x38
	private bool _closed; //Field offset: 0x40
	private bool _findRequired; //Field offset: 0x41
	private bool _exceptionPending; //Field offset: 0x42

	public virtual bool CanRead
	{
		 get { } //Length: 3
	}

	public virtual bool CanSeek
	{
		 get { } //Length: 40
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

	public virtual long Length
	{
		 get { } //Length: 40
	}

	public virtual long Position
	{
		 get { } //Length: 40
		 set { } //Length: 36
	}

	internal Stream ReadStream
	{
		internal get { } //Length: 11
	}

	public virtual void Flush() { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanSeek() { }

	public virtual bool get_CanWrite() { }

	[CompilerGenerated]
	public int get_CodecBufferSize() { }

	public virtual long get_Length() { }

	public virtual long get_Position() { }

	internal Stream get_ReadStream() { }

	public virtual int Read(Byte[] buffer, int offset, int count) { }

	public virtual long Seek(long offset, SeekOrigin origin) { }

	public virtual void set_Position(long value) { }

	public virtual void SetLength(long value) { }

	private void SetupStream() { }

	public virtual void Write(Byte[] buffer, int offset, int count) { }

}

