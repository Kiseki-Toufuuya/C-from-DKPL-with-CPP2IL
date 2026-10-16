namespace UnityEngine.Localization.Settings;

public abstract class LocalizedDatabase : IPreloadRequired, IReset, IDisposable
{
	internal struct TableEntryResult
	{
		[CompilerGenerated]
		private readonly TEntry <Entry>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private readonly TTable <Table>k__BackingField; //Field offset: 0x0

		public TEntry Entry
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 10
		}

		public TTable Table
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 11
		}

		internal TableEntryResult(TEntry entry, TTable table) { }

		[CompilerGenerated]
		[IsReadOnly]
		public TEntry get_Entry() { }

		[CompilerGenerated]
		[IsReadOnly]
		public TTable get_Table() { }

	}

	internal static readonly LocaleIdentifier k_SelectedLocaleId; //Field offset: 0x0
	[SerializeField]
	private TableReference m_DefaultTableReference; //Field offset: 0x0
	[SerializeReference]
	private ITableProvider m_CustomTableProvider; //Field offset: 0x0
	[SerializeReference]
	private ITablePostprocessor m_CustomTablePostprocessor; //Field offset: 0x0
	[SerializeField]
	private AsynchronousBehaviour m_AsynchronousBehaviour; //Field offset: 0x0
	[SerializeField]
	private bool m_UseFallback; //Field offset: 0x0
	internal AsyncOperationHandle m_PreloadOperationHandle; //Field offset: 0x0
	private Action<AsyncOperationHandle> m_ReleaseNextFrame; //Field offset: 0x0
	private readonly Action<AsyncOperationHandle`1<TTable>> m_PatchTableContentsAction; //Field offset: 0x0
	private readonly Action<AsyncOperationHandle`1<TTable>> m_RegisterSharedTableAndGuidOperationAction; //Field offset: 0x0
	private readonly Action<AsyncOperationHandle`1<TTable>> m_RegisterCompletedTableOperationAction; //Field offset: 0x0
	[CompilerGenerated]
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"localeIdentifier", "tableNameOrGuid"})]
	private readonly Dictionary<ValueTuple`2<LocaleIdentifier, String>, AsyncOperationHandle`1<TTable>> <TableOperations>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly Dictionary<Guid, AsyncOperationHandle`1<SharedTableData>> <SharedTableDataOperations>k__BackingField; //Field offset: 0x0

	public AsynchronousBehaviour AsynchronousBehaviour
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public override TableReference DefaultTable
	{
		 get { } //Length: 34
		 set { } //Length: 46
	}

	public override AsyncOperationHandle PreloadOperation
	{
		 get { } //Length: 318
	}

	internal Action<AsyncOperationHandle> ReleaseNextFrame
	{
		internal get { } //Length: 11
	}

	internal Dictionary<Guid, AsyncOperationHandle`1<SharedTableData>> SharedTableDataOperations
	{
		[CompilerGenerated]
		internal get { } //Length: 11
	}

	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"localeIdentifier", "tableNameOrGuid"})]
	internal Dictionary<ValueTuple`2<LocaleIdentifier, String>, AsyncOperationHandle`1<TTable>> TableOperations
	{
		[CompilerGenerated]
		internal get { } //Length: 11
	}

	public ITablePostprocessor TablePostprocessor
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public ITableProvider TableProvider
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public bool UseFallback
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	private static LocalizedDatabase`2() { }

	public LocalizedDatabase`2() { }

	internal override LoadTableOperation<TTable, TEntry> CreateLoadTableOperation() { }

	internal override PreloadTablesOperation<TTable, TEntry> CreatePreloadTablesOperation() { }

	public AsynchronousBehaviour get_AsynchronousBehaviour() { }

	public override TableReference get_DefaultTable() { }

	public override AsyncOperationHandle get_PreloadOperation() { }

	internal Action<AsyncOperationHandle> get_ReleaseNextFrame() { }

	[CompilerGenerated]
	internal Dictionary<Guid, AsyncOperationHandle`1<SharedTableData>> get_SharedTableDataOperations() { }

	[CompilerGenerated]
	internal Dictionary<ValueTuple`2<LocaleIdentifier, String>, AsyncOperationHandle`1<TTable>> get_TableOperations() { }

	public ITablePostprocessor get_TablePostprocessor() { }

	public ITableProvider get_TableProvider() { }

	public bool get_UseFallback() { }

	public override AsyncOperationHandle<IList`1<TTable>> GetAllTables(Locale locale = null) { }

	internal TableReference GetDefaultTable() { }

	public AsyncOperationHandle<TTable> GetDefaultTableAsync() { }

	internal AsyncOperationHandle<SharedTableData> GetSharedTableData(Guid tableNameGuid) { }

	public override TTable GetTable(TableReference tableReference, Locale locale = null) { }

	public override AsyncOperationHandle<TTable> GetTableAsync(TableReference tableReference, Locale locale = null) { }

	public override TableEntryResult<TTable, TEntry> GetTableEntry(TableReference tableReference, TableEntryReference tableEntryReference, Locale locale = null, FallbackBehavior fallbackBehavior = 0) { }

	public override AsyncOperationHandle<TableEntryResult<TTable, TEntry>> GetTableEntryAsync(TableReference tableReference, TableEntryReference tableEntryReference, Locale locale = null, FallbackBehavior fallbackBehavior = 0) { }

	public override bool IsTableLoaded(TableReference tableReference, Locale locale = null) { }

	public override void OnLocaleChanged(Locale locale) { }

	private void PatchTableContents(AsyncOperationHandle<TTable> tableOperation) { }

	public AsyncOperationHandle PreloadTables(TableReference tableReference, Locale locale = null) { }

	public AsyncOperationHandle PreloadTables(IList<TableReference> tableReferences, Locale locale = null) { }

	internal void RegisterCompletedTableOperation(AsyncOperationHandle<TTable> tableOperation) { }

	private void RegisterSharedTableAndGuidOperation(AsyncOperationHandle<TTable> tableOperation) { }

	private void RegisterTableNameOperation(AsyncOperationHandle<TTable> tableOperation, LocaleIdentifier localeIdentifier, string tableName) { }

	public void ReleaseAllTables(Locale locale = null) { }

	public void ReleaseTable(TableReference tableReference, Locale locale = null) { }

	internal override void ReleaseTableContents(TTable table) { }

	public override void ResetState() { }

	public void set_AsynchronousBehaviour(AsynchronousBehaviour value) { }

	public override void set_DefaultTable(TableReference value) { }

	public void set_TablePostprocessor(ITablePostprocessor value) { }

	public void set_TableProvider(ITableProvider value) { }

	public void set_UseFallback(bool value) { }

	private override void System.IDisposable.Dispose() { }

}

