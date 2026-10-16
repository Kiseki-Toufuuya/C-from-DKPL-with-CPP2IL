namespace System.Net;

internal class WebConnection : IDisposable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<IPEndPoint, AsyncCallback, Object, IAsyncResult> <>9__16_0; //Field offset: 0x4
		public static Action<IAsyncResult> <>9__16_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal IAsyncResult <Connect>b__16_0(IPEndPoint targetEndPoint, AsyncCallback callback, object state) { }

		internal void <Connect>b__16_1(IAsyncResult asyncResult) { }

	}

	[CompilerGenerated]
	private struct <Connect>d__16 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public WebConnection <>4__this; //Field offset: 0x10
		public WebOperation operation; //Field offset: 0x14
		public CancellationToken cancellationToken; //Field offset: 0x18
		private Exception <connectException>5__2; //Field offset: 0x1C
		private IPAddress[] <>7__wrap2; //Field offset: 0x20
		private int <>7__wrap3; //Field offset: 0x24
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CreateStream>d__18 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x4
		public WebConnection <>4__this; //Field offset: 0x10
		public WebOperation operation; //Field offset: 0x14
		public bool reused; //Field offset: 0x18
		public CancellationToken cancellationToken; //Field offset: 0x1C
		private NetworkStream <stream>5__2; //Field offset: 0x20
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x24
		private ConfiguredTaskAwaiter<Stream> <>u__2; //Field offset: 0x2C

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <InitConnection>d__19 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<WebRequestStream> <>t__builder; //Field offset: 0x4
		public WebOperation operation; //Field offset: 0x10
		public CancellationToken cancellationToken; //Field offset: 0x14
		public WebConnection <>4__this; //Field offset: 0x18
		private bool <reused>5__2; //Field offset: 0x1C
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x20
		private ConfiguredTaskAwaiter<Boolean> <>u__2; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private NetworkCredential ntlm_credentials; //Field offset: 0x8
	private bool ntlm_authenticated; //Field offset: 0xC
	private bool unsafe_sharing; //Field offset: 0xD
	private Stream networkStream; //Field offset: 0x10
	private Socket socket; //Field offset: 0x14
	private MonoTlsStream monoTlsStream; //Field offset: 0x18
	private WebConnectionTunnel tunnel; //Field offset: 0x1C
	private int disposed; //Field offset: 0x20
	[CompilerGenerated]
	private readonly ServicePoint <ServicePoint>k__BackingField; //Field offset: 0x24
	private DateTime idleSince; //Field offset: 0x28
	private WebOperation currentOperation; //Field offset: 0x30

	public bool Closed
	{
		 get { } //Length: 15
	}

	public DateTime IdleSince
	{
		 get { } //Length: 14
	}

	internal bool NtlmAuthenticated
	{
		internal get { } //Length: 11
		internal set { } //Length: 14
	}

	internal NetworkCredential NtlmCredential
	{
		internal get { } //Length: 11
		internal set { } //Length: 27
	}

	public ServicePoint ServicePoint
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	internal bool UnsafeAuthenticatedConnectionSharing
	{
		internal get { } //Length: 11
		internal set { } //Length: 14
	}

	public WebConnection(ServicePoint sPoint) { }

	private bool CanReuse() { }

	internal bool CanReuseConnection(WebOperation operation) { }

	private bool CheckReusable() { }

	private void Close(bool reset) { }

	private void CloseSocket() { }

	[AsyncStateMachine(typeof(<Connect>d__16))]
	private Task Connect(WebOperation operation, CancellationToken cancellationToken) { }

	public bool Continue(WebOperation next) { }

	[AsyncStateMachine(typeof(<CreateStream>d__18))]
	private Task<Boolean> CreateStream(WebOperation operation, bool reused, CancellationToken cancellationToken) { }

	public override void Dispose() { }

	private void Dispose(bool disposing) { }

	public bool get_Closed() { }

	public DateTime get_IdleSince() { }

	internal bool get_NtlmAuthenticated() { }

	internal NetworkCredential get_NtlmCredential() { }

	[CompilerGenerated]
	public ServicePoint get_ServicePoint() { }

	internal bool get_UnsafeAuthenticatedConnectionSharing() { }

	internal static WebException GetException(WebExceptionStatus status, Exception error) { }

	[AsyncStateMachine(typeof(<InitConnection>d__19))]
	internal Task<WebRequestStream> InitConnection(WebOperation operation, CancellationToken cancellationToken) { }

	private bool PrepareSharingNtlm(WebOperation operation) { }

	internal static bool ReadLine(Byte[] buffer, ref int start, int max, ref string output) { }

	private void Reset() { }

	private void ResetNtlm() { }

	internal void set_NtlmAuthenticated(bool value) { }

	internal void set_NtlmCredential(NetworkCredential value) { }

	internal void set_UnsafeAuthenticatedConnectionSharing(bool value) { }

	public bool StartOperation(WebOperation operation, bool reused) { }

}

