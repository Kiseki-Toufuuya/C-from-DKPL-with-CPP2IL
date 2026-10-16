namespace UnityEngine.Localization.Operations;

internal class LoadTableOperation : WaitForCurrentOperationAsyncOperationBase<TTable>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c<TTable, TEntry> <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal LoadTableOperation<TTable, TEntry> <.cctor>b__26_0() { }

	}

	public static readonly ObjectPool<LoadTableOperation`2<TTable, TEntry>> Pool; //Field offset: 0x0
	private readonly Action<AsyncOperationHandle`1<SharedTableData>> m_LoadTableByGuidAction; //Field offset: 0x0
	private readonly Action<AsyncOperationHandle`1<IList`1<IResourceLocation>>> m_LoadTableResourceAction; //Field offset: 0x0
	private readonly Action<AsyncOperationHandle`1<TTable>> m_TableLoadedAction; //Field offset: 0x0
	private readonly Action<AsyncOperationHandle`1<TTable>> m_CustomTableLoadedAction; //Field offset: 0x0
	private LocalizedDatabase<TTable, TEntry> m_Database; //Field offset: 0x0
	private TableReference m_TableReference; //Field offset: 0x0
	private AsyncOperationHandle<TTable> m_LoadTableOperation; //Field offset: 0x0
	private Locale m_SelectedLocale; //Field offset: 0x0
	private string m_CollectionName; //Field offset: 0x0
	[CompilerGenerated]
	private Action<AsyncOperationHandle`1<TTable>> <RegisterTableOperation>k__BackingField; //Field offset: 0x0

	public private Action<AsyncOperationHandle`1<TTable>> RegisterTableOperation
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 33
	}

	private static LoadTableOperation`2() { }

	public LoadTableOperation`2() { }

	private void CustomTableLoaded(AsyncOperationHandle<TTable> operationHandle) { }

	private void DefaultLoadTableByName() { }

	protected virtual void Destroy() { }

	protected virtual void Execute() { }

	private void FindTableByName(string collectionName) { }

	[CompilerGenerated]
	public Action<AsyncOperationHandle`1<TTable>> get_RegisterTableOperation() { }

	public void Init(LocalizedDatabase<TTable, TEntry> database, TableReference tableReference, Locale locale) { }

	private void LoadTableByGuid(AsyncOperationHandle<SharedTableData> operationHandle) { }

	private void LoadTableResource(AsyncOperationHandle<IList`1<IResourceLocation>> operationHandle) { }

	[CompilerGenerated]
	private void set_RegisterTableOperation(Action<AsyncOperationHandle`1<TTable>> value) { }

	private void TableLoaded(AsyncOperationHandle<TTable> operationHandle) { }

	public virtual string ToString() { }

	private bool TryLoadWithTableProvider() { }

}

