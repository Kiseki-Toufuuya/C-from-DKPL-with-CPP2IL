namespace Ionic.Zip;

internal class ZipCipherStream : Stream
{
	private ZipCrypto _cipher; //Field offset: 0x14
	private Stream _s; //Field offset: 0x18
	private CryptoMode _mode; //Field offset: 0x1C

	public virtual bool CanRead
	{
		 get { } //Length: 15
	}

	public virtual bool CanSeek
	{
		 get { } //Length: 3
	}

	public virtual bool CanWrite
	{
		 get { } //Length: 15
	}

	public virtual long Length
	{
		 get { } //Length: 47
	}

	public virtual long Position
	{
		 get { } //Length: 47
		 set { } //Length: 47
	}

	public ZipCipherStream(Stream s, ZipCrypto cipher, CryptoMode mode) { }

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

