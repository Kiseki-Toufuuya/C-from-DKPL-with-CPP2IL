namespace Mono.Net.Security;

internal abstract class MobileAuthenticatedStream : AuthenticatedStream, IDisposable
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass66_0
	{
		public MobileAuthenticatedStream <>4__this; //Field offset: 0x8
		public int len; //Field offset: 0xC

		public <>c__DisplayClass66_0() { }

		internal int <InnerRead>b__0() { }

	}

	[CompilerGenerated]
	private struct <InnerRead>d__66 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Int32> <>t__builder; //Field offset: 0x4
		public MobileAuthenticatedStream <>4__this; //Field offset: 0x10
		public CancellationToken cancellationToken; //Field offset: 0x14
		public int requestedSize; //Field offset: 0x18
		public bool sync; //Field offset: 0x1C
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x20

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <InnerWrite>d__67 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public CancellationToken cancellationToken; //Field offset: 0x10
		public MobileAuthenticatedStream <>4__this; //Field offset: 0x14
		public bool sync; //Field offset: 0x18
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x1C

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ProcessAuthentication>d__48 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public MonoSslAuthenticationOptions options; //Field offset: 0x10
		public MobileAuthenticatedStream <>4__this; //Field offset: 0x14
		public bool runSynchronously; //Field offset: 0x18
		public CancellationToken cancellationToken; //Field offset: 0x1C
		private ConfiguredTaskAwaiter<AsyncProtocolResult> <>u__1; //Field offset: 0x20

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StartOperation>d__57 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Int32> <>t__builder; //Field offset: 0x4
		public MobileAuthenticatedStream <>4__this; //Field offset: 0x10
		public OperationType type; //Field offset: 0x14
		public AsyncProtocolRequest asyncRequest; //Field offset: 0x18
		public CancellationToken cancellationToken; //Field offset: 0x1C
		private ConfiguredTaskAwaiter<AsyncProtocolResult> <>u__1; //Field offset: 0x20

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private enum Operation
	{
		None = 0,
		Handshake = 1,
		Authenticated = 2,
		Renegotiate = 3,
		Read = 4,
		Write = 5,
		Close = 6,
	}

	private enum OperationType
	{
		Read = 0,
		Write = 1,
		Renegotiate = 2,
		Shutdown = 3,
	}

	private static int uniqueNameInteger; //Field offset: 0x0
	private static int nextId; //Field offset: 0x4
	private MobileTlsContext xobileTlsContext; //Field offset: 0x1C
	private ExceptionDispatchInfo lastException; //Field offset: 0x20
	private AsyncProtocolRequest asyncHandshakeRequest; //Field offset: 0x24
	private AsyncProtocolRequest asyncReadRequest; //Field offset: 0x28
	private AsyncProtocolRequest asyncWriteRequest; //Field offset: 0x2C
	private BufferOffsetSize2 readBuffer; //Field offset: 0x30
	private BufferOffsetSize2 writeBuffer; //Field offset: 0x34
	private object ioLock; //Field offset: 0x38
	private int closeRequested; //Field offset: 0x3C
	private bool shutdown; //Field offset: 0x40
	private Operation operation; //Field offset: 0x44
	[CompilerGenerated]
	private readonly SslStream <SslStream>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private readonly MonoTlsSettings <Settings>k__BackingField; //Field offset: 0x4C
	[CompilerGenerated]
	private readonly MobileTlsProvider <Provider>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private string <TargetHost>k__BackingField; //Field offset: 0x54
	internal readonly int ID; //Field offset: 0x58

	public virtual bool CanRead
	{
		 get { } //Length: 67
	}

	public virtual bool CanSeek
	{
		 get { } //Length: 3
	}

	public virtual bool CanTimeout
	{
		 get { } //Length: 40
	}

	public virtual bool CanWrite
	{
		 get { } //Length: 84
	}

	public override X509Certificate InternalLocalCertificate
	{
		 get { } //Length: 323
	}

	public virtual bool IsAuthenticated
	{
		 get { } //Length: 251
	}

	public virtual long Length
	{
		 get { } //Length: 40
	}

	public override X509Certificate LocalCertificate
	{
		 get { } //Length: 332
	}

	public virtual long Position
	{
		 get { } //Length: 40
		 set { } //Length: 47
	}

	public MobileTlsProvider Provider
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public virtual int ReadTimeout
	{
		 get { } //Length: 40
		 set { } //Length: 43
	}

	public MonoTlsSettings Settings
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public override SslStream SslStream
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	internal string TargetHost
	{
		[CompilerGenerated]
		internal get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public virtual int WriteTimeout
	{
		 get { } //Length: 40
		 set { } //Length: 43
	}

	private static MobileAuthenticatedStream() { }

	public MobileAuthenticatedStream(Stream innerStream, bool leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MobileTlsProvider provider) { }

	[CompilerGenerated]
	private void <InnerWrite>b__67_0() { }

	public void AuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	public override Task AuthenticateAsClientAsync(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	internal void CheckThrow(bool authSuccessCheck, bool shutdownCheck = false) { }

	protected abstract MobileTlsContext CreateContext(MonoSslAuthenticationOptions options) { }

	protected virtual void Dispose(bool disposing) { }

	public virtual void Flush() { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanSeek() { }

	public virtual bool get_CanTimeout() { }

	public virtual bool get_CanWrite() { }

	public override X509Certificate get_InternalLocalCertificate() { }

	public virtual bool get_IsAuthenticated() { }

	public virtual long get_Length() { }

	public override X509Certificate get_LocalCertificate() { }

	public virtual long get_Position() { }

	[CompilerGenerated]
	public MobileTlsProvider get_Provider() { }

	public virtual int get_ReadTimeout() { }

	[CompilerGenerated]
	public MonoTlsSettings get_Settings() { }

	[CompilerGenerated]
	public override SslStream get_SslStream() { }

	[CompilerGenerated]
	internal string get_TargetHost() { }

	public virtual int get_WriteTimeout() { }

	internal static Exception GetInternalError() { }

	internal static Exception GetInvalidNestedCallException() { }

	internal static Exception GetIOException(Exception e, string message) { }

	internal static Exception GetSSPIException(Exception e) { }

	[AsyncStateMachine(typeof(<InnerRead>d__66))]
	internal Task<Int32> InnerRead(bool sync, int requestedSize, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<InnerWrite>d__67))]
	internal Task InnerWrite(bool sync, CancellationToken cancellationToken) { }

	private ValueTuple<Int32, Boolean> InternalRead(AsyncProtocolRequest asyncRequest, BufferOffsetSize internalBuffer, Byte[] buffer, int offset, int size) { }

	internal int InternalRead(Byte[] buffer, int offset, int size, out bool outWantMore) { }

	private bool InternalWrite(AsyncProtocolRequest asyncRequest, BufferOffsetSize2 internalBuffer, Byte[] buffer, int offset, int size) { }

	internal bool InternalWrite(Byte[] buffer, int offset, int size) { }

	[AsyncStateMachine(typeof(<ProcessAuthentication>d__48))]
	private Task ProcessAuthentication(bool runSynchronously, MonoSslAuthenticationOptions options, CancellationToken cancellationToken) { }

	internal AsyncOperationStatus ProcessHandshake(AsyncOperationStatus status, bool renegotiate) { }

	internal ValueTuple<Int32, Boolean> ProcessRead(BufferOffsetSize userBuffer) { }

	internal ValueTuple<Int32, Boolean> ProcessWrite(BufferOffsetSize userBuffer) { }

	public virtual int Read(Byte[] buffer, int offset, int count) { }

	public virtual Task<Int32> ReadAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	public virtual long Seek(long offset, SeekOrigin origin) { }

	public virtual void set_Position(long value) { }

	public virtual void set_ReadTimeout(int value) { }

	[CompilerGenerated]
	private void set_TargetHost(string value) { }

	public virtual void set_WriteTimeout(int value) { }

	internal ExceptionDispatchInfo SetException(Exception e) { }

	public virtual void SetLength(long value) { }

	[AsyncStateMachine(typeof(<StartOperation>d__57))]
	private Task<Int32> StartOperation(OperationType type, AsyncProtocolRequest asyncRequest, CancellationToken cancellationToken) { }

	public virtual void Write(Byte[] buffer, int offset, int count) { }

	public virtual Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

}

