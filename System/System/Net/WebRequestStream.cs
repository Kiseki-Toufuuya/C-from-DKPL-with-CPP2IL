namespace System.Net;

internal class WebRequestStream : WebConnectionStream
{
	[CompilerGenerated]
	private struct <FinishWriting>d__31 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public WebRequestStream <>4__this; //Field offset: 0x10
		public CancellationToken cancellationToken; //Field offset: 0x14
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x18

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Initialize>d__36 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public WebRequestStream <>4__this; //Field offset: 0x10
		public CancellationToken cancellationToken; //Field offset: 0x14
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x18
		private TaskAwaiter <>u__2; //Field offset: 0x20

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ProcessWrite>d__34 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public WebRequestStream <>4__this; //Field offset: 0x10
		public CancellationToken cancellationToken; //Field offset: 0x14
		public int size; //Field offset: 0x18
		public Byte[] buffer; //Field offset: 0x1C
		public int offset; //Field offset: 0x20
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x24

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SetHeadersAsync>d__37 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public WebRequestStream <>4__this; //Field offset: 0x10
		public CancellationToken cancellationToken; //Field offset: 0x14
		public bool setInternalLength; //Field offset: 0x18
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x1C

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteAsyncInner>d__33 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public WebRequestStream <>4__this; //Field offset: 0x10
		public Byte[] buffer; //Field offset: 0x14
		public int offset; //Field offset: 0x18
		public int size; //Field offset: 0x1C
		public CancellationToken cancellationToken; //Field offset: 0x20
		public WebCompletionSource completion; //Field offset: 0x24
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x28
		private TaskAwaiter <>u__2; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteChunkTrailer_inner>d__39 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public WebRequestStream <>4__this; //Field offset: 0x10
		public CancellationToken cancellationToken; //Field offset: 0x14
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x18

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteChunkTrailer>d__40 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public WebRequestStream <>4__this; //Field offset: 0x10
		private CancellationTokenSource <cts>5__2; //Field offset: 0x14
		private Task <timeoutTask>5__3; //Field offset: 0x18
		private ConfiguredTaskAwaiter<Task> <>u__1; //Field offset: 0x1C
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x24

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteRequestAsync>d__38 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public WebRequestStream <>4__this; //Field offset: 0x10
		public CancellationToken cancellationToken; //Field offset: 0x14
		private BufferOffsetSize <buffer>5__2; //Field offset: 0x18
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x1C
		private TaskAwaiter <>u__2; //Field offset: 0x24

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static Byte[] crlf; //Field offset: 0x0
	private MemoryStream writeBuffer; //Field offset: 0x30
	private bool requestWritten; //Field offset: 0x34
	private bool allowBuffering; //Field offset: 0x35
	private bool sendChunked; //Field offset: 0x36
	private WebCompletionSource pendingWrite; //Field offset: 0x38
	private long totalWritten; //Field offset: 0x40
	private Byte[] headers; //Field offset: 0x48
	private bool headersSent; //Field offset: 0x4C
	private int completeRequestWritten; //Field offset: 0x50
	private int chunkTrailerWritten; //Field offset: 0x54
	[CompilerGenerated]
	private readonly Stream <InnerStream>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private readonly bool <KeepAlive>k__BackingField; //Field offset: 0x5C

	public virtual bool CanRead
	{
		 get { } //Length: 3
	}

	public virtual bool CanWrite
	{
		 get { } //Length: 3
	}

	internal bool HasWriteBuffer
	{
		internal get { } //Length: 37
	}

	internal Stream InnerStream
	{
		[CompilerGenerated]
		internal get { } //Length: 11
	}

	public bool KeepAlive
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	internal int WriteBufferLength
	{
		internal get { } //Length: 78
	}

	private static WebRequestStream() { }

	public WebRequestStream(WebConnection connection, WebOperation operation, Stream stream, WebConnectionTunnel tunnel) { }

	private void CheckWriteOverflow(long contentLength, long totalWritten, long size) { }

	protected virtual void Close_internal(ref bool disposed) { }

	[AsyncStateMachine(typeof(<FinishWriting>d__31))]
	private Task FinishWriting(CancellationToken cancellationToken) { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanWrite() { }

	internal bool get_HasWriteBuffer() { }

	[CompilerGenerated]
	internal Stream get_InnerStream() { }

	[CompilerGenerated]
	public bool get_KeepAlive() { }

	internal int get_WriteBufferLength() { }

	internal BufferOffsetSize GetWriteBuffer() { }

	[AsyncStateMachine(typeof(<Initialize>d__36))]
	internal Task Initialize(CancellationToken cancellationToken) { }

	internal void KillBuffer() { }

	[AsyncStateMachine(typeof(<ProcessWrite>d__34))]
	private Task ProcessWrite(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	public virtual Task<Int32> ReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<SetHeadersAsync>d__37))]
	private Task SetHeadersAsync(bool setInternalLength, CancellationToken cancellationToken) { }

	protected virtual bool TryReadFromBufferedContent(Byte[] buffer, int offset, int count, out int result) { }

	public virtual Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<WriteAsyncInner>d__33))]
	private Task WriteAsyncInner(Byte[] buffer, int offset, int size, WebCompletionSource completion, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<WriteChunkTrailer>d__40))]
	private Task WriteChunkTrailer() { }

	[AsyncStateMachine(typeof(<WriteChunkTrailer_inner>d__39))]
	private Task WriteChunkTrailer_inner(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<WriteRequestAsync>d__38))]
	internal Task WriteRequestAsync(CancellationToken cancellationToken) { }

}

