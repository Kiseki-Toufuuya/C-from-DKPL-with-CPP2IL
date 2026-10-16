namespace UnityEngine.Localization.Operations;

internal class LoadAssetOperation : WaitForCurrentOperationAsyncOperationBase<TObject>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c<TObject> <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal LoadAssetOperation<TObject> <.cctor>b__11_0() { }

	}

	public static readonly ObjectPool<LoadAssetOperation`1<TObject>> Pool; //Field offset: 0x0
	private readonly Action<AsyncOperationHandle`1<TObject>> m_AssetLoadedAction; //Field offset: 0x0
	private AsyncOperationHandle<TableEntryResult<AssetTable, AssetTableEntry>> m_TableEntryOperation; //Field offset: 0x0
	private AsyncOperationHandle<TObject> m_LoadAssetOperation; //Field offset: 0x0
	private bool m_AutoRelease; //Field offset: 0x0

	private static LoadAssetOperation`1() { }

	public LoadAssetOperation`1() { }

	private void AssetLoaded(AsyncOperationHandle<TObject> handle) { }

	public void CompleteAndRelease(TObject result, bool success, string errorMsg) { }

	protected virtual void Destroy() { }

	protected virtual void Execute() { }

	public void Init(AsyncOperationHandle<TableEntryResult<AssetTable, AssetTableEntry>> loadTableEntryOperation, bool autoRelease) { }

}

