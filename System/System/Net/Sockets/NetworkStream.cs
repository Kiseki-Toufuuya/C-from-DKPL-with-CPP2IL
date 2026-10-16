namespace System.Net.Sockets;

public class NetworkStream : Stream
{
	private readonly Socket _streamSocket; //Field offset: 0x14
	private readonly bool _ownsSocket; //Field offset: 0x18
	private bool _readable; //Field offset: 0x19
	private bool _writeable; //Field offset: 0x1A
	private int _closeTimeout; //Field offset: 0x1C
	private bool _cleanedUp; //Field offset: 0x20
	private int _currentReadTimeout; //Field offset: 0x24
	private int _currentWriteTimeout; //Field offset: 0x28

	public virtual bool CanRead
	{
		 get { } //Length: 11
	}

	public virtual bool CanSeek
	{
		 get { } //Length: 3
	}

	public virtual bool CanTimeout
	{
		 get { } //Length: 3
	}

	public virtual bool CanWrite
	{
		 get { } //Length: 11
	}

	internal Socket InternalSocket
	{
		internal get { } //Length: 108
	}

	public virtual long Length
	{
		 get { } //Length: 64
	}

	public virtual long Position
	{
		 get { } //Length: 64
		 set { } //Length: 64
	}

	public virtual int ReadTimeout
	{
		 get { } //Length: 87
		 set { } //Length: 109
	}

	public virtual int WriteTimeout
	{
		 get { } //Length: 87
		 set { } //Length: 109
	}

	public NetworkStream(Socket socket) { }

	public NetworkStream(Socket socket, bool ownsSocket) { }

	public NetworkStream(Socket socket, FileAccess access, bool ownsSocket) { }

	public virtual IAsyncResult BeginRead(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	public virtual IAsyncResult BeginWrite(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	public void Close(int timeout) { }

	protected virtual void Dispose(bool disposing) { }

	public virtual int EndRead(IAsyncResult asyncResult) { }

	public virtual void EndWrite(IAsyncResult asyncResult) { }

	protected virtual void Finalize() { }

	public virtual void Flush() { }

	public virtual Task FlushAsync(CancellationToken cancellationToken) { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanSeek() { }

	public virtual bool get_CanTimeout() { }

	public virtual bool get_CanWrite() { }

	internal Socket get_InternalSocket() { }

	public virtual long get_Length() { }

	public virtual long get_Position() { }

	public virtual int get_ReadTimeout() { }

	public virtual int get_WriteTimeout() { }

	public virtual int Read(Byte[] buffer, int offset, int size) { }

	public virtual int Read(Span<Byte> destination) { }

	public virtual ValueTask<Int32> ReadAsync(Memory<Byte> buffer, CancellationToken cancellationToken) { }

	public virtual Task<Int32> ReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	public virtual int ReadByte() { }

	public virtual long Seek(long offset, SeekOrigin origin) { }

	public virtual void set_Position(long value) { }

	public virtual void set_ReadTimeout(int value) { }

	public virtual void set_WriteTimeout(int value) { }

	public virtual void SetLength(long value) { }

	internal void SetSocketTimeoutOption(SocketShutdown mode, int timeout, bool silent) { }

	public virtual void Write(ReadOnlySpan<Byte> source) { }

	public virtual void Write(Byte[] buffer, int offset, int size) { }

	public virtual Task WriteAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	public virtual ValueTask WriteAsync(ReadOnlyMemory<Byte> buffer, CancellationToken cancellationToken) { }

	public virtual void WriteByte(byte value) { }

}

