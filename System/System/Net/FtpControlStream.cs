namespace System.Net;

internal class FtpControlStream : CommandStream
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass31_0
	{
		public FtpControlStream <>4__this; //Field offset: 0x8
		public TlsStream tlsStream; //Field offset: 0xC

		public <>c__DisplayClass31_0() { }

		internal void <PipelineCallback>b__0(IAsyncResult ar) { }

	}

	private enum GetPathOption
	{
		Normal = 0,
		AssumeFilename = 1,
		AssumeNoFilename = 2,
	}

	private static readonly AsyncCallback s_acceptCallbackDelegate; //Field offset: 0x0
	private static readonly AsyncCallback s_connectCallbackDelegate; //Field offset: 0x4
	private static readonly AsyncCallback s_SSLHandshakeCallback; //Field offset: 0x8
	private Socket _dataSocket; //Field offset: 0x48
	private IPEndPoint _passiveEndPoint; //Field offset: 0x4C
	private TlsStream _tlsStream; //Field offset: 0x50
	private StringBuilder _bannerMessage; //Field offset: 0x54
	private StringBuilder _welcomeMessage; //Field offset: 0x58
	private StringBuilder _exitMessage; //Field offset: 0x5C
	private WeakReference _credentials; //Field offset: 0x60
	private string _currentTypeSetting; //Field offset: 0x64
	private long _contentLength; //Field offset: 0x68
	private DateTime _lastModified; //Field offset: 0x70
	private bool _dataHandshakeStarted; //Field offset: 0x78
	private string _loginDirectory; //Field offset: 0x7C
	private string _establishedServerDirectory; //Field offset: 0x80
	private string _requestedServerDirectory; //Field offset: 0x84
	private Uri _responseUri; //Field offset: 0x88
	private FtpLoginState _loginState; //Field offset: 0x8C
	internal FtpStatusCode StatusCode; //Field offset: 0x90
	internal string StatusLine; //Field offset: 0x94

	internal string BannerMessage
	{
		internal get { } //Length: 41
	}

	internal long ContentLength
	{
		internal get { } //Length: 14
	}

	internal NetworkCredential Credentials
	{
		internal get { } //Length: 168
		internal set { } //Length: 121
	}

	internal string ExitMessage
	{
		internal get { } //Length: 41
	}

	internal DateTime LastModified
	{
		internal get { } //Length: 14
	}

	internal Uri ResponseUri
	{
		internal get { } //Length: 14
	}

	internal string WelcomeMessage
	{
		internal get { } //Length: 41
	}

	private static FtpControlStream() { }

	internal FtpControlStream(TcpClient client) { }

	internal void AbortConnect() { }

	private static void AcceptCallback(IAsyncResult asyncResult) { }

	protected virtual PipelineEntry[] BuildCommandsList(WebRequest req) { }

	protected virtual bool CheckValid(ResponseDescription response, ref int validThrough, ref int completeLength) { }

	protected virtual void ClearState() { }

	private static void ConnectCallback(IAsyncResult asyncResult) { }

	protected Socket CreateFtpDataSocket(FtpWebRequest request, Socket templateSocket) { }

	private void CreateFtpListenerSocket(FtpWebRequest request) { }

	private string FormatAddress(IPAddress address, int Port) { }

	private string FormatAddressV6(IPAddress address, int port) { }

	private string FormatFtpCommand(string command, string parameter) { }

	internal string get_BannerMessage() { }

	internal long get_ContentLength() { }

	internal NetworkCredential get_Credentials() { }

	internal string get_ExitMessage() { }

	internal DateTime get_LastModified() { }

	internal Uri get_ResponseUri() { }

	internal string get_WelcomeMessage() { }

	private long GetContentLengthFrom213Response(string responseString) { }

	private DateTime GetLastModifiedFrom213Response(string str) { }

	private string GetLoginDirectory(string str) { }

	private static void GetPathInfo(GetPathOption pathOption, Uri uri, out string path, out string directory, out string filename) { }

	private string GetPortCommandLine(FtpWebRequest request) { }

	private int GetPortV4(string responseString) { }

	private int GetPortV6(string responseString) { }

	private TriState IsFtpDataStreamWriteable() { }

	protected virtual PipelineInstruction PipelineCallback(PipelineEntry entry, ResponseDescription response, bool timeout, ref Stream stream) { }

	private PipelineInstruction QueueOrCreateDataConection(PipelineEntry entry, ResponseDescription response, bool timeout, ref Stream stream, out bool isSocketReady) { }

	private PipelineInstruction QueueOrCreateFtpDataStream(ref Stream stream) { }

	internal void set_Credentials(NetworkCredential value) { }

	private static void SSLHandshakeCallback(IAsyncResult asyncResult) { }

	private void TryUpdateContentLength(string str) { }

	private void TryUpdateResponseUri(string str, FtpWebRequest request) { }

}

