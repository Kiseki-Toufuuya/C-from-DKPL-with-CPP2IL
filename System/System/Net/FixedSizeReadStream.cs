namespace System.Net;

internal class FixedSizeReadStream : WebReadStream
{
	[CompilerGenerated]
	private struct <ProcessReadAsync>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Int32> <>t__builder; //Field offset: 0x4
		public CancellationToken cancellationToken; //Field offset: 0x10
		public FixedSizeReadStream <>4__this; //Field offset: 0x14
		public int size; //Field offset: 0x18
		public Byte[] buffer; //Field offset: 0x1C
		public int offset; //Field offset: 0x20
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x24

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private readonly long <ContentLength>k__BackingField; //Field offset: 0x20
	private long position; //Field offset: 0x28

	public long ContentLength
	{
		[CompilerGenerated]
		 get { } //Length: 14
	}

	public FixedSizeReadStream(WebOperation operation, Stream innerStream, long contentLength) { }

	[CompilerGenerated]
	public long get_ContentLength() { }

	[AsyncStateMachine(typeof(<ProcessReadAsync>d__5))]
	protected virtual Task<Int32> ProcessReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

}

