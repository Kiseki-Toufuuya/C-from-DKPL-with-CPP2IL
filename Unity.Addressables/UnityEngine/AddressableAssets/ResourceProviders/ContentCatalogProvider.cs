namespace UnityEngine.AddressableAssets.ResourceProviders;

[DisplayName("Content Catalog Provider")]
public class ContentCatalogProvider : ResourceProviderBase
{
	internal enum DependencyHashIndex
	{
		Remote = 0,
		Cache = 1,
		Local = 2,
		Count = 3,
	}

	public class InternalOp
	{
		public class BundledCatalog
		{
			private readonly string m_BundlePath; //Field offset: 0x8
			private bool m_OpInProgress; //Field offset: 0xC
			private AssetBundleCreateRequest m_LoadBundleRequest; //Field offset: 0x10
			internal AssetBundle m_CatalogAssetBundle; //Field offset: 0x14
			private AssetBundleRequest m_LoadTextAssetRequest; //Field offset: 0x18
			private ContentCatalogData m_CatalogData; //Field offset: 0x1C
			private WebRequestQueueOperation m_WebRequestQueueOperation; //Field offset: 0x20
			private AsyncOperation m_RequestOperation; //Field offset: 0x24
			private int m_WebRequestTimeout; //Field offset: 0x28
			[CompilerGenerated]
			private Action<ContentCatalogData> OnLoaded; //Field offset: 0x2C

			public event Action<ContentCatalogData> OnLoaded
			{
				[CompilerGenerated]
				 add { } //Length: 125
				[CompilerGenerated]
				 remove { } //Length: 125
			}

			public bool OpInProgress
			{
				 get { } //Length: 11
			}

			public bool OpIsSuccess
			{
				 get { } //Length: 25
			}

			public BundledCatalog(string bundlePath, int webRequestTimeout = 0) { }

			[CompilerGenerated]
			private void <LoadCatalogFromBundleAsync>b__19_0(AsyncOperation loadOp) { }

			[CompilerGenerated]
			private void <LoadCatalogFromBundleAsync>b__19_1(UnityWebRequestAsyncOperation asyncOp) { }

			[CompilerGenerated]
			public void add_OnLoaded(Action<ContentCatalogData> value) { }

			protected virtual void Finalize() { }

			public bool get_OpInProgress() { }

			public bool get_OpIsSuccess() { }

			public void LoadCatalogFromBundleAsync() { }

			private void LoadTextAssetRequestComplete(AsyncOperation op) { }

			[CompilerGenerated]
			public void remove_OnLoaded(Action<ContentCatalogData> value) { }

			private void Unload() { }

			public bool WaitForCompletion() { }

			private void WebRequestOperationCompleted(AsyncOperation op) { }

		}

		private const string kCatalogExt = ".bin"; //Field offset: 0x0
		private string m_LocalDataPath; //Field offset: 0x8
		private string m_RemoteHashValue; //Field offset: 0xC
		internal string m_LocalHashValue; //Field offset: 0x10
		private ProvideHandle m_ProviderInterface; //Field offset: 0x14
		internal ContentCatalogData m_ContentCatalogData; //Field offset: 0x20
		private AsyncOperationHandle<ContentCatalogData> m_ContentCatalogDataLoadOp; //Field offset: 0x24
		private BundledCatalog m_BundledCatalog; //Field offset: 0x30
		private bool m_Retried; //Field offset: 0x34
		private bool m_DisableCatalogUpdateOnStart; //Field offset: 0x35
		private bool m_IsLocalCatalogInBundle; //Field offset: 0x36

		public InternalOp() { }

		[CompilerGenerated]
		private void <LoadCatalog>b__14_0(ContentCatalogData ccd) { }

		internal bool CanLoadCatalogFromBundle(string idToLoad, IResourceLocation location) { }

		private void CatalogLoadOpCompleteCallback(AsyncOperationHandle<ContentCatalogData> op) { }

		internal string DetermineIdToLoad(IResourceLocation location, IList<Object> dependencyObjects, bool disableCatalogUpdateOnStart = false) { }

		private string GetTransformedInternalId(IResourceLocation loc) { }

		internal void LoadCatalog(string idToLoad, bool loadCatalogFromLocalBundle) { }

		private void OnCatalogLoaded(ContentCatalogData ccd) { }

		public void Release() { }

		public void Start(ProvideHandle providerInterface, bool disableCatalogUpdateOnStart, bool isLocalCatalogInBundle) { }

		private bool WaitForCompletionCallback() { }

	}

	public bool DisableCatalogUpdateOnStart; //Field offset: 0x10
	public bool IsLocalCatalogInBundle; //Field offset: 0x11
	internal Dictionary<IResourceLocation, InternalOp> m_LocationToCatalogLoadOpMap; //Field offset: 0x14

	public ContentCatalogProvider(ResourceManager resourceManagerInstance) { }

	public virtual void Provide(ProvideHandle providerInterface) { }

	public virtual void Release(IResourceLocation location, object obj) { }

}

