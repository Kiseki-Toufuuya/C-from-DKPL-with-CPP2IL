namespace Mono.Net.Security;

internal class MonoTlsStream : IDisposable
{
	[CompilerGenerated]
	private struct <CreateStream>d__18 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Stream> <>t__builder; //Field offset: 0x4
		public MonoTlsStream <>4__this; //Field offset: 0x10
		public WebConnectionTunnel tunnel; //Field offset: 0x14
		public CancellationToken cancellationToken; //Field offset: 0x18
		private Socket <socket>5__2; //Field offset: 0x1C
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x20

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly MobileTlsProvider provider; //Field offset: 0x8
	private readonly NetworkStream networkStream; //Field offset: 0xC
	private readonly HttpWebRequest request; //Field offset: 0x10
	private readonly MonoTlsSettings settings; //Field offset: 0x14
	private SslStream sslStream; //Field offset: 0x18
	private readonly object sslStreamLock; //Field offset: 0x1C
	private WebExceptionStatus status; //Field offset: 0x20
	[CompilerGenerated]
	private bool <CertificateValidationFailed>k__BackingField; //Field offset: 0x24

	internal bool CertificateValidationFailed
	{
		[CompilerGenerated]
		internal get { } //Length: 11
		[CompilerGenerated]
		internal set { } //Length: 14
	}

	internal WebExceptionStatus ExceptionStatus
	{
		internal get { } //Length: 11
	}

	internal HttpWebRequest Request
	{
		internal get { } //Length: 11
	}

	public MonoTlsStream(HttpWebRequest request, NetworkStream networkStream) { }

	private void CloseSslStream() { }

	[AsyncStateMachine(typeof(<CreateStream>d__18))]
	internal Task<Stream> CreateStream(WebConnectionTunnel tunnel, CancellationToken cancellationToken) { }

	public override void Dispose() { }

	[CompilerGenerated]
	internal bool get_CertificateValidationFailed() { }

	internal WebExceptionStatus get_ExceptionStatus() { }

	internal HttpWebRequest get_Request() { }

	[CompilerGenerated]
	internal void set_CertificateValidationFailed(bool value) { }

}

