namespace UnityEngine.Localization.Operations;

internal class PreloadDatabaseOperation : WaitForCurrentOperationAsyncOperationBase<LocalizedDatabase`2<TTable, TEntry>>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c<TTable, TEntry> <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal PreloadDatabaseOperation<TTable, TEntry> <.cctor>b__17_0() { }

	}

	public static readonly ObjectPool<PreloadDatabaseOperation`2<TTable, TEntry>> Pool; //Field offset: 0x0
	private readonly Action<AsyncOperationHandle> m_CompleteOperation; //Field offset: 0x0
	private readonly Action<AsyncOperationHandle`1<IList`1<AsyncOperationHandle>>> m_CompleteGenericGroup; //Field offset: 0x0
	private LocalizedDatabase<TTable, TEntry> m_Database; //Field offset: 0x0

	protected virtual string DebugName
	{
		 get { } //Length: 74
	}

	protected virtual float Progress
	{
		 get { } //Length: 129
	}

	private static PreloadDatabaseOperation`2() { }

	public PreloadDatabaseOperation`2() { }

	private void CompleteGenericGroup(AsyncOperationHandle<IList`1<AsyncOperationHandle>> operationHandle) { }

	private void CompleteOperation(AsyncOperationHandle operationHandle) { }

	protected virtual void Destroy() { }

	protected virtual void Execute() { }

	protected virtual string get_DebugName() { }

	protected virtual float get_Progress() { }

	private void GetAllFallbackLocales(Locale current, HashSet<Locale> locales) { }

	public void Init(LocalizedDatabase<TTable, TEntry> database) { }

	private AsyncOperationHandle PreloadLocale(Locale locale) { }

	private void PreloadLocales(ICollection<Locale> locales) { }

}

