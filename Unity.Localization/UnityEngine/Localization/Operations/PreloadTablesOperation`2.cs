namespace UnityEngine.Localization.Operations;

internal class PreloadTablesOperation : WaitForCurrentOperationAsyncOperationBase<LocalizedDatabase`2<TTable, TEntry>>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c<TTable, TEntry> <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal PreloadTablesOperation<TTable, TEntry> <.cctor>b__18_0() { }

	}

	public static readonly ObjectPool<PreloadTablesOperation`2<TTable, TEntry>> Pool; //Field offset: 0x0
	private LocalizedDatabase<TTable, TEntry> m_Database; //Field offset: 0x0
	private readonly List<AsyncOperationHandle`1<TTable>> m_LoadTables; //Field offset: 0x0
	private readonly List<AsyncOperationHandle> m_LoadTablesOperation; //Field offset: 0x0
	private readonly List<AsyncOperationHandle> m_PreloadTablesOperations; //Field offset: 0x0
	private readonly Action<AsyncOperationHandle`1<IList`1<AsyncOperationHandle>>> m_LoadTableContentsAction; //Field offset: 0x0
	private readonly Action<AsyncOperationHandle> m_FinishPreloadingAction; //Field offset: 0x0
	private AsyncOperationHandle<IList`1<AsyncOperationHandle>> m_LoadTablesOperationHandle; //Field offset: 0x0
	private AsyncOperationHandle<IList`1<AsyncOperationHandle>> m_PreloadTablesContentsHandle; //Field offset: 0x0
	private IList<TableReference> m_TableReferences; //Field offset: 0x0
	private Locale m_SelectedLocale; //Field offset: 0x0

	private static PreloadTablesOperation`2() { }

	public PreloadTablesOperation`2() { }

	[CompilerGenerated]
	private void <.ctor>b__11_0(AsyncOperationHandle<IList`1<AsyncOperationHandle>> a) { }

	private void BeginPreloadingTables() { }

	protected virtual void Destroy() { }

	protected virtual void Execute() { }

	private void FinishPreloading(AsyncOperationHandle op) { }

	public void Init(LocalizedDatabase<TTable, TEntry> database, IList<TableReference> tableReference, Locale locale = null) { }

	private void LoadTableContents() { }

}

