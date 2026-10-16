namespace UnityEngine.Localization.Operations;

internal class LoadSubAssetOperation : WaitForCurrentOperationAsyncOperationBase<TObject>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c<TObject> <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal LoadSubAssetOperation<TObject> <.cctor>b__12_0() { }

	}

	public static readonly ObjectPool<LoadSubAssetOperation`1<TObject>> Pool; //Field offset: 0x0
	private readonly Action<AsyncOperationHandle`1<TObject>> m_AssetLoadedAction; //Field offset: 0x0
	private AsyncOperationHandle<TObject> m_AssetOperation; //Field offset: 0x0
	private AsyncOperationHandle<Object[]> m_PreloadOperations; //Field offset: 0x0
	private string m_Address; //Field offset: 0x0
	private bool m_IsSubAsset; //Field offset: 0x0
	private string m_SubAssetName; //Field offset: 0x0

	private static LoadSubAssetOperation`1() { }

	public LoadSubAssetOperation`1() { }

	private void AssetLoaded(AsyncOperationHandle<TObject> handle) { }

	protected virtual void Destroy() { }

	protected virtual void Execute() { }

	public void Init(AsyncOperationHandle<Object[]> preloadOperations, string address, bool isSubAsset, string subAssetName) { }

}

