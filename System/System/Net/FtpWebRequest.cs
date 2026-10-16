namespace System.Net;

public sealed class FtpWebRequest : WebRequest
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<X509CertificateCollection> <>9__114_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal X509CertificateCollection <get_ClientCertificates>b__114_0() { }

	}

	[CompilerGenerated]
	private struct <CreateConnectionAsync>d__86 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public FtpWebRequest <>4__this; //Field offset: 0x14
		private TcpClient <client>5__2; //Field offset: 0x18
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x1C

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private enum RequestStage
	{
		CheckForError = 0,
		RequestStarted = 1,
		WriteReady = 2,
		ReadReady = 3,
		ReleaseConnection = 4,
	}

	private static readonly NetworkCredential s_defaultFtpNetworkCredential; //Field offset: 0x0
	private static readonly Queue s_DefaultTimerQueue; //Field offset: 0x4
	private object _syncObject; //Field offset: 0x20
	private ICredentials _authInfo; //Field offset: 0x24
	private readonly Uri _uri; //Field offset: 0x28
	private FtpMethodInfo _methodInfo; //Field offset: 0x2C
	private string _renameTo; //Field offset: 0x30
	private bool _getRequestStreamStarted; //Field offset: 0x34
	private bool _getResponseStarted; //Field offset: 0x35
	private DateTime _startTime; //Field offset: 0x38
	private int _timeout; //Field offset: 0x40
	private int _remainingTimeout; //Field offset: 0x44
	private long _contentLength; //Field offset: 0x48
	private long _contentOffset; //Field offset: 0x50
	private X509CertificateCollection _clientCertificates; //Field offset: 0x58
	private bool _passive; //Field offset: 0x5C
	private bool _binary; //Field offset: 0x5D
	private bool _async; //Field offset: 0x5E
	private bool _aborted; //Field offset: 0x5F
	private bool _timedOut; //Field offset: 0x60
	private Exception _exception; //Field offset: 0x64
	private Queue _timerQueue; //Field offset: 0x68
	private Callback _timerCallback; //Field offset: 0x6C
	private bool _enableSsl; //Field offset: 0x70
	private FtpControlStream _connection; //Field offset: 0x74
	private Stream _stream; //Field offset: 0x78
	private RequestStage _requestStage; //Field offset: 0x7C
	private bool _onceFailed; //Field offset: 0x80
	private WebHeaderCollection _ftpRequestHeaders; //Field offset: 0x84
	private FtpWebResponse _ftpWebResponse; //Field offset: 0x88
	private int _readWriteTimeout; //Field offset: 0x8C
	private ContextAwareResult _writeAsyncResult; //Field offset: 0x90
	private LazyAsyncResult _readAsyncResult; //Field offset: 0x94
	private LazyAsyncResult _requestCompleteAsyncResult; //Field offset: 0x98

	internal bool Aborted
	{
		internal get { } //Length: 11
	}

	public virtual RequestCachePolicy CachePolicy
	{
		 set { } //Length: 85
	}

	public X509CertificateCollection ClientCertificates
	{
		 get { } //Length: 217
	}

	public virtual long ContentLength
	{
		 get { } //Length: 14
	}

	public long ContentOffset
	{
		 get { } //Length: 14
	}

	public virtual ICredentials Credentials
	{
		 get { } //Length: 11
		 set { } //Length: 308
	}

	public bool EnableSsl
	{
		 get { } //Length: 11
	}

	public virtual WebHeaderCollection Headers
	{
		 get { } //Length: 161
	}

	private bool InUse
	{
		private get { } //Length: 25
	}

	public virtual string Method
	{
		 get { } //Length: 23
		 set { } //Length: 465
	}

	internal FtpMethodInfo MethodInfo
	{
		internal get { } //Length: 11
	}

	public virtual IWebProxy Proxy
	{
		 get { } //Length: 3
		 set { } //Length: 85
	}

	public int ReadWriteTimeout
	{
		 get { } //Length: 14
	}

	internal int RemainingTimeout
	{
		internal get { } //Length: 11
	}

	public string RenameTo
	{
		 get { } //Length: 11
	}

	public virtual Uri RequestUri
	{
		 get { } //Length: 11
	}

	public virtual int Timeout
	{
		 get { } //Length: 11
	}

	private Queue TimerQueue
	{
		private get { } //Length: 97
	}

	public bool UseBinary
	{
		 get { } //Length: 11
	}

	public virtual bool UseDefaultCredentials
	{
		 get { } //Length: 30
	}

	public bool UsePassive
	{
		 get { } //Length: 11
	}

	private static FtpWebRequest() { }

	internal FtpWebRequest(Uri uri) { }

	public virtual void Abort() { }

	private void AsyncRequestCallback(object obj) { }

	private bool AttemptedRecovery(Exception e) { }

	public virtual IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	private void CheckError() { }

	private FtpControlStream CreateConnection() { }

	[AsyncStateMachine(typeof(<CreateConnectionAsync>d__86))]
	private void CreateConnectionAsync() { }

	internal void DataStreamClosed(CloseExState closeState) { }

	public virtual WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	private void EnsureFtpWebResponse(Exception exception) { }

	private RequestStage FinishRequestStage(RequestStage stage) { }

	internal bool get_Aborted() { }

	public X509CertificateCollection get_ClientCertificates() { }

	public virtual long get_ContentLength() { }

	public long get_ContentOffset() { }

	public virtual ICredentials get_Credentials() { }

	public bool get_EnableSsl() { }

	public virtual WebHeaderCollection get_Headers() { }

	private bool get_InUse() { }

	public virtual string get_Method() { }

	internal FtpMethodInfo get_MethodInfo() { }

	public virtual IWebProxy get_Proxy() { }

	public int get_ReadWriteTimeout() { }

	internal int get_RemainingTimeout() { }

	public string get_RenameTo() { }

	public virtual Uri get_RequestUri() { }

	public virtual int get_Timeout() { }

	private Queue get_TimerQueue() { }

	public bool get_UseBinary() { }

	public virtual bool get_UseDefaultCredentials() { }

	public bool get_UsePassive() { }

	public virtual WebResponse GetResponse() { }

	internal void RequestCallback(object obj) { }

	public virtual void set_CachePolicy(RequestCachePolicy value) { }

	public virtual void set_Credentials(ICredentials value) { }

	public virtual void set_Method(string value) { }

	public virtual void set_Proxy(IWebProxy value) { }

	private void SetException(Exception exception) { }

	private void SubmitRequest(bool isAsync) { }

	private void SyncRequestCallback(object obj) { }

	private Stream TimedSubmitRequestHelper(bool isAsync) { }

	private void TimerCallback(Timer timer, int timeNoticed, object context) { }

	private Exception TranslateConnectException(Exception e) { }

}

