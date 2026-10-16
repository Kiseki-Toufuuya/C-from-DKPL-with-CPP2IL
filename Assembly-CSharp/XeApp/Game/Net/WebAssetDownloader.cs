namespace XeApp.Game.Net;

public class WebAssetDownloader : IDisposable
{
	[CompilerGenerated]
	private sealed class <Co_Download>d__14 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public Request request; //Field offset: 0x10
		public WebAssetDownloader <>4__this; //Field offset: 0x14
		private Content <content>5__2; //Field offset: 0x18
		private string <path>5__3; //Field offset: 0x1C
		private CriFsLoadFileRequest <req>5__4; //Field offset: 0x20
		private int <i>5__5; //Field offset: 0x24
		private UnityWebRequest <req>5__6; //Field offset: 0x28

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		[DebuggerHidden]
		public <Co_Download>d__14(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal class Content
	{
		public string URL; //Field offset: 0x8
		public long GetTime; //Field offset: 0x10
		public Byte[] FileImage; //Field offset: 0x18
		public bool IsMemoryLoaded; //Field offset: 0x1C
		public Texture2D Texture; //Field offset: 0x20
		public JsonData JsonData; //Field offset: 0x24
		public string CachePath; //Field offset: 0x28
		public ContentType ContentType; //Field offset: 0x2C

		public Content() { }

	}

	internal enum ContentType
	{
		RawImage = 0,
		UGCImage = 1,
	}

	internal class Request
	{
		public bool IsDone; //Field offset: 0x8
		public bool IsError; //Field offset: 0x9
		public string RequestID; //Field offset: 0xC
		public string DownloadURL; //Field offset: 0x10
		public bool IsAnnouncment; //Field offset: 0x14
		public int Salt; //Field offset: 0x18
		public ContentType ContentType; //Field offset: 0x1C
		public Action<String, Content> OnLoaded; //Field offset: 0x20

		public Request() { }

	}

	private Dictionary<String, Content> CacheEntries; //Field offset: 0x8
	public Queue<Request> Requests; //Field offset: 0xC
	public List<Request> Downloads; //Field offset: 0x10
	public int RetryCount; //Field offset: 0x14
	public int MultiDownloadCount; //Field offset: 0x18
	private object lockObject; //Field offset: 0x1C
	private bool disposedValue; //Field offset: 0x20

	public WebAssetDownloader() { }

	public void ClearCacheEntries(bool onlyLoadedContent) { }

	private void ClearContent(Content content) { }

	[IteratorStateMachine(typeof(<Co_Download>d__14))]
	private IEnumerator Co_Download(Request request) { }

	protected override void Dispose(bool disposing) { }

	public override void Dispose() { }

	public Request DownloadRequest(string requestID, string url, ContentType contentType, int salt, Action<String, Content> onLoaded, bool isAnnouncement) { }

	public int GetProcessingCount() { }

	public void Update() { }

}

