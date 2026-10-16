namespace UnityEngine.Localization.Operations;

internal class LoadAllTablesOperation : WaitForCurrentOperationAsyncOperationBase<IList`1<TTable>>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c<TTable, TEntry> <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal LoadAllTablesOperation<TTable, TEntry> <.cctor>b__10_0() { }

	}

	public static readonly ObjectPool<LoadAllTablesOperation`2<TTable, TEntry>> Pool; //Field offset: 0x0
	private readonly Action<AsyncOperationHandle`1<IList`1<TTable>>> m_LoadingCompletedAction; //Field offset: 0x0
	private AsyncOperationHandle<IList`1<TTable>> m_AllTablesOperation; //Field offset: 0x0
	private LocalizedDatabase<TTable, TEntry> m_Database; //Field offset: 0x0
	private Locale m_SelectedLocale; //Field offset: 0x0

	private static LoadAllTablesOperation`2() { }

	public LoadAllTablesOperation`2() { }

	protected virtual void Destroy() { }

	protected virtual void Execute() { }

	public void Init(LocalizedDatabase<TTable, TEntry> database, Locale locale) { }

	private void LoadingCompleted(AsyncOperationHandle<IList`1<TTable>> obj) { }

}

