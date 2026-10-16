namespace UnityEngine.Localization.Operations;

internal class PreloadLocaleOperation : WaitForCurrentOperationAsyncOperationBase<LocalizedDatabase`2<TTable, TEntry>>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c<TTable, TEntry> <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal PreloadLocaleOperation<TTable, TEntry> <.cctor>b__28_0() { }

	}

	public static readonly ObjectPool<PreloadLocaleOperation`2<TTable, TEntry>> Pool; //Field offset: 0x0
	private readonly Action<AsyncOperationHandle`1<IList`1<IResourceLocation>>> m_LoadTablesAction; //Field offset: 0x0
	private readonly Action<AsyncOperationHandle`1<TTable>> m_LoadTableContentsAction; //Field offset: 0x0
	private readonly Action<AsyncOperationHandle> m_FinishPreloadingAction; //Field offset: 0x0
	private readonly Action<AsyncOperationHandle`1<IList`1<AsyncOperationHandle>>> m_PreloadTablesCompletedAction; //Field offset: 0x0
	private LocalizedDatabase<TTable, TEntry> m_Database; //Field offset: 0x0
	private Locale m_Locale; //Field offset: 0x0
	private AsyncOperationHandle<IList`1<IResourceLocation>> m_LoadResourcesOperation; //Field offset: 0x0
	private AsyncOperationHandle<IList`1<AsyncOperationHandle>> m_LoadTablesGroupOperation; //Field offset: 0x0
	private AsyncOperationHandle<IList`1<AsyncOperationHandle>> m_LoadTableContentsOperation; //Field offset: 0x0
	private readonly List<AsyncOperationHandle> m_LoadTablesOperations; //Field offset: 0x0
	private readonly List<AsyncOperationHandle> m_PreloadTableContentsOperations; //Field offset: 0x0
	private readonly List<String> m_ResourceLabels; //Field offset: 0x0
	private float m_Progress; //Field offset: 0x0

	protected virtual string DebugName
	{
		 get { } //Length: 83
	}

	protected virtual float Progress
	{
		 get { } //Length: 14
	}

	private static PreloadLocaleOperation`2() { }

	public PreloadLocaleOperation`2() { }

	private void BeginPreloading() { }

	private void CompleteAndRelease(bool success, string errorMsg) { }

	protected virtual void Destroy() { }

	protected virtual void Execute() { }

	private void FinishPreloading(AsyncOperationHandle op) { }

	protected virtual string get_DebugName() { }

	protected virtual float get_Progress() { }

	public void Init(LocalizedDatabase<TTable, TEntry> database, Locale locale) { }

	private void LoadTableContents(AsyncOperationHandle<TTable> operation) { }

	private void LoadTables(AsyncOperationHandle<IList`1<IResourceLocation>> loadResourcesOperation) { }

	private void PreloadTablesCompleted(AsyncOperationHandle<IList`1<AsyncOperationHandle>> obj) { }

}

