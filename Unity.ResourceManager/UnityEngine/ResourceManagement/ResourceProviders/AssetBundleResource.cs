namespace UnityEngine.ResourceManagement.ResourceProviders;

public class AssetBundleResource : IAssetBundleResource, IUpdateReceiver
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<UnityWebRequestResult, Boolean> <>9__52_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal bool <.ctor>b__52_0(UnityWebRequestResult x) { }

	}

	internal enum LoadType
	{
		None = 0,
		Local = 1,
		Web = 2,
	}

	private const int k_WaitForWebRequestMainThreadSleep = 1; //Field offset: 0x0
	private AssetBundle m_AssetBundle; //Field offset: 0x8
	private AsyncOperation m_RequestOperation; //Field offset: 0xC
	internal WebRequestQueueOperation m_WebRequestQueueOperation; //Field offset: 0x10
	internal ProvideHandle m_ProvideHandle; //Field offset: 0x14
	internal AssetBundleRequestOptions m_Options; //Field offset: 0x20
	private bool m_RequestCompletedCallbackCalled; //Field offset: 0x24
	private int m_Retries; //Field offset: 0x28
	private BundleSource m_Source; //Field offset: 0x2C
	private long m_BytesToDownload; //Field offset: 0x30
	private long m_DownloadedBytes; //Field offset: 0x38
	private bool m_Completed; //Field offset: 0x40
	private AssetBundleUnloadOperation m_UnloadOperation; //Field offset: 0x44
	private string m_TransformedInternalId; //Field offset: 0x48
	private AssetBundleRequest m_PreloadRequest; //Field offset: 0x4C
	private bool m_PreloadCompleted; //Field offset: 0x50
	private ulong m_LastDownloadedByteCount; //Field offset: 0x58
	private float m_TimeoutTimer; //Field offset: 0x60
	private int m_TimeoutOverFrames; //Field offset: 0x64
	internal bool m_DownloadOnly; //Field offset: 0x68
	private int m_LastFrameCount; //Field offset: 0x6C
	private float m_TimeSecSinceLastUpdate; //Field offset: 0x70
	internal Func<UnityWebRequestResult, Boolean> m_RequestRetryCallback; //Field offset: 0x74

	internal long BytesToDownload
	{
		internal get { } //Length: 108
	}

	private bool HasTimedOut
	{
		private get { } //Length: 49
	}

	public AssetBundleResource() { }

	[CompilerGenerated]
	private void <AddBeginWebRequestHandler>b__45_0(UnityWebRequestAsyncOperation asyncOp) { }

	[CompilerGenerated]
	private void <GetAssetPreloadRequest>b__30_0(AsyncOperation operation) { }

	internal void AddBeginWebRequestHandler(WebRequestQueueOperation webRequestQueueOperation) { }

	private void AddBundleToProfiler(ContentStatus status, BundleSource source) { }

	private void AddCallbackInvokeIfDone(AsyncOperation operation, Action<AsyncOperation> callback) { }

	private void BeginOperation() { }

	private void BeginWebRequestOperation(AsyncOperation asyncOp) { }

	private void CompleteBundleLoad(AssetBundle bundle) { }

	internal UnityWebRequest CreateWebRequest(IResourceLocation loc) { }

	internal UnityWebRequest CreateWebRequest(string url) { }

	internal WebRequestQueueOperation EnqueueWebRequest(string internalId) { }

	internal long get_BytesToDownload() { }

	private bool get_HasTimedOut() { }

	public override AssetBundle GetAssetBundle() { }

	public AssetBundleRequest GetAssetPreloadRequest() { }

	private DownloadStatus GetDownloadStatus() { }

	internal static void GetLoadInfo(IResourceLocation location, ResourceManager resourceManager, out LoadType loadType, out string path) { }

	public static void GetLoadInfo(ProvideHandle handle, out LoadType loadType, out string path) { }

	private void LoadLocalBundle() { }

	private void LocalRequestOperationCompleted(AsyncOperation op) { }

	private void OnUnloadOperationComplete(AsyncOperation op) { }

	private float PercentComplete() { }

	private void RemoveBundleFromProfiler() { }

	public void Start(ProvideHandle provideHandle, AssetBundleUnloadOperation unloadOp, Func<UnityWebRequestResult, Boolean> requestRetryCallback) { }

	public bool Unload(out AssetBundleUnloadOperation unloadOp) { }

	public override void Update(float unscaledDeltaTime) { }

	private bool WaitForCompletionHandler() { }

	private void WebRequestOperationCompleted(AsyncOperation op) { }

}

