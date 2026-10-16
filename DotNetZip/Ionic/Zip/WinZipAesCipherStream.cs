namespace Ionic.Zip;

internal class WinZipAesCipherStream : Stream
{
	private WinZipAesCrypto _params; //Field offset: 0x14
	private Stream _s; //Field offset: 0x18
	private CryptoMode _mode; //Field offset: 0x1C
	private int _nonce; //Field offset: 0x20
	private bool _finalBlock; //Field offset: 0x24
	internal HMACSHA1 _mac; //Field offset: 0x28
	internal Aes _aesCipher; //Field offset: 0x2C
	internal ICryptoTransform _xform; //Field offset: 0x30
	private Byte[] counter; //Field offset: 0x34
	private Byte[] counterOut; //Field offset: 0x38
	private long _length; //Field offset: 0x40
	private long _totalBytesXferred; //Field offset: 0x48
	private Byte[] _PendingWriteBlock; //Field offset: 0x50
	private int _pendingCount; //Field offset: 0x54
	private Byte[] _iobuf; //Field offset: 0x58
	private object _outputLock; //Field offset: 0x5C

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

	public Byte[] FinalAuthentication
	{
		 get { } //Length: 219
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

	internal WinZipAesCipherStream(Stream s, WinZipAesCrypto cryptoParams, long length, CryptoMode mode) { }

	internal WinZipAesCipherStream(Stream s, WinZipAesCrypto cryptoParams, CryptoMode mode) { }

	public virtual void Close() { }

	public virtual void Flush() { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanSeek() { }

	public virtual bool get_CanWrite() { }

	public Byte[] get_FinalAuthentication() { }

	public virtual long get_Length() { }

	public virtual long get_Position() { }

	public virtual int Read(Byte[] buffer, int offset, int count) { }

	private void ReadTransformBlocks(Byte[] buffer, int offset, int count) { }

	private int ReadTransformOneBlock(Byte[] buffer, int offset, int last) { }

	public virtual long Seek(long offset, SeekOrigin origin) { }

	public virtual void set_Position(long value) { }

	public virtual void SetLength(long value) { }

	public virtual void Write(Byte[] buffer, int offset, int count) { }

	private void WriteTransformBlocks(Byte[] buffer, int offset, int count) { }

	private void WriteTransformFinalBlock() { }

	private void WriteTransformOneBlock(Byte[] buffer, int offset) { }

	private void XorInPlace(Byte[] buffer, int offset, int count) { }

}

