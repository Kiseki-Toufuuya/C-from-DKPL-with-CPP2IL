namespace XeApp.Game.Net;

public class SeekableEncryptStream : Stream
{
	private Stream baseStream; //Field offset: 0x14
	[CompilerGenerated]
	private bool <AutoDisposeBaseStream>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private int <Salt>k__BackingField; //Field offset: 0x1C
	private ICustomEncryptor customEncryptor; //Field offset: 0x20

	public bool AutoDisposeBaseStream
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
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

	public virtual long Length
	{
		 get { } //Length: 40
	}

	public virtual long Position
	{
		 get { } //Length: 40
		 set { } //Length: 46
	}

	public int Salt
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public SeekableEncryptStream(Stream baseStream, ICustomEncryptor customEncryptor) { }

	private void Convert(Byte[] buffer, int offset, int count, long streamPos) { }

	protected virtual void Dispose(bool disposing) { }

	public virtual void Flush() { }

	[CompilerGenerated]
	public bool get_AutoDisposeBaseStream() { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanSeek() { }

	public virtual bool get_CanWrite() { }

	public virtual long get_Length() { }

	public virtual long get_Position() { }

	[CompilerGenerated]
	public int get_Salt() { }

	public virtual int Read(Byte[] buffer, int offset, int count) { }

	public virtual long Seek(long offset, SeekOrigin origin) { }

	[CompilerGenerated]
	public void set_AutoDisposeBaseStream(bool value) { }

	public virtual void set_Position(long value) { }

	[CompilerGenerated]
	public void set_Salt(int value) { }

	public virtual void SetLength(long value) { }

	public virtual void Write(Byte[] buffer, int offset, int count) { }

}

