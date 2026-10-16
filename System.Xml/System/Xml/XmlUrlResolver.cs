namespace System.Xml;

public class XmlUrlResolver : XmlResolver
{
	[CompilerGenerated]
	private struct <GetEntityAsync>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Object> <>t__builder; //Field offset: 0x4
		public Type ofObjectToReturn; //Field offset: 0x10
		public Uri absoluteUri; //Field offset: 0x14
		public XmlUrlResolver <>4__this; //Field offset: 0x18
		private ConfiguredTaskAwaiter<Stream> <>u__1; //Field offset: 0x1C

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static object s_DownloadManager; //Field offset: 0x0
	private ICredentials _credentials; //Field offset: 0x8
	private IWebProxy _proxy; //Field offset: 0xC
	private RequestCachePolicy _cachePolicy; //Field offset: 0x10

	private static XmlDownloadManager DownloadManager
	{
		private get { } //Length: 165
	}

	public XmlUrlResolver() { }

	private static XmlDownloadManager get_DownloadManager() { }

	public virtual object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn) { }

	[AsyncStateMachine(typeof(<GetEntityAsync>d__15))]
	public virtual Task<Object> GetEntityAsync(Uri absoluteUri, string role, Type ofObjectToReturn) { }

	public virtual Uri ResolveUri(Uri baseUri, string relativeUri) { }

}

