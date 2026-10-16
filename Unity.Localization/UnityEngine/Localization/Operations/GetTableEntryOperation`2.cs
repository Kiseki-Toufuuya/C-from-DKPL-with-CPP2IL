namespace UnityEngine.Localization.Operations;

internal class GetTableEntryOperation : WaitForCurrentOperationAsyncOperationBase<TableEntryResult<TTable, TEntry>>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c<TTable, TEntry> <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal GetTableEntryOperation<TTable, TEntry> <.cctor>b__23_0() { }

	}

	public static readonly ObjectPool<GetTableEntryOperation`2<TTable, TEntry>> Pool; //Field offset: 0x0
	private readonly Action<AsyncOperationHandle`1<TTable>> m_ExtractEntryFromTableAction; //Field offset: 0x0
	private AsyncOperationHandle<TTable> m_LoadTableOperation; //Field offset: 0x0
	private TableReference m_TableReference; //Field offset: 0x0
	private TableEntryReference m_TableEntryReference; //Field offset: 0x0
	private LocalizedDatabase<TTable, TEntry> m_Database; //Field offset: 0x0
	private Locale m_SelectedLocale; //Field offset: 0x0
	private Locale m_CurrentLocale; //Field offset: 0x0
	private HashSet<Locale> m_HandledFallbacks; //Field offset: 0x0
	private List<Locale> m_FallbackQueue; //Field offset: 0x0
	private bool m_UseFallback; //Field offset: 0x0
	private bool m_AutoRelease; //Field offset: 0x0

	private static GetTableEntryOperation`2() { }

	public GetTableEntryOperation`2() { }

	private bool ApplyEntryOverride(IEntryOverride entryOverride, AsyncOperationHandle<TTable> asyncOperation, TEntry entry) { }

	private void CompleteAndRelease(TableEntryResult<TTable, TEntry> result, bool success, string errorMsg) { }

	protected virtual void Destroy() { }

	protected virtual void Execute() { }

	private void ExtractEntryFromTable(AsyncOperationHandle<TTable> asyncOperation) { }

	private Locale GetNextFallback(Locale currentLocale) { }

	private bool HandleEntryOverride(AsyncOperationHandle<TTable> asyncOperation, TEntry entry) { }

	private bool HandleFallback(AsyncOperationHandle<TTable> asyncOperation, TEntry entry) { }

	public void Init(LocalizedDatabase<TTable, TEntry> database, AsyncOperationHandle<TTable> loadTableOperation, TableReference tableReference, TableEntryReference tableEntryReference, Locale selectedLoale, bool UseFallBack, bool autoRelease) { }

	public virtual string ToString() { }

}

