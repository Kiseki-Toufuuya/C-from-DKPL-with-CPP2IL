namespace UnityEngine.Localization;

public abstract class LocalizedTable
{
	internal sealed class ChangeHandler : MulticastDelegate
	{

		public ChangeHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(TTable value, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(TTable value) { }

	}

	[SerializeField]
	private TableReference m_TableReference; //Field offset: 0x0
	private CallbackArray<ChangeHandler<TTable, TEntry>> m_ChangeHandler; //Field offset: 0x0
	private Action<Locale> m_SelectedLocaleChanged; //Field offset: 0x0
	[CompilerGenerated]
	private AsyncOperationHandle<TTable> <CurrentLoadingOperationHandle>k__BackingField; //Field offset: 0x0

	public event ChangeHandler<TTable, TEntry> TableChanged
	{
		 add { } //Length: 348
		 remove { } //Length: 73
	}

	[Obsolete("CurrentLoadingOperation is deprecated, use CurrentLoadingOperationHandle instead.")]
	public Nullable<AsyncOperationHandle`1<TTable>> CurrentLoadingOperation
	{
		 get { } //Length: 128
	}

	public internal AsyncOperationHandle<TTable> CurrentLoadingOperationHandle
	{
		[CompilerGenerated]
		 get { } //Length: 26
		[CompilerGenerated]
		internal set { } //Length: 38
	}

	protected abstract LocalizedDatabase<TTable, TEntry> Database
	{
		 get { } //Length: 0
	}

	public bool IsEmpty
	{
		 get { } //Length: 87
	}

	public TableReference TableReference
	{
		 get { } //Length: 34
		 set { } //Length: 206
	}

	public LocalizedTable`2() { }

	public void add_TableChanged(ChangeHandler<TTable, TEntry> value) { }

	private void AutomaticLoadingCompleted(AsyncOperationHandle<TTable> loadOperation) { }

	private void ClearLoadingOperation() { }

	protected void ForceUpdate() { }

	public Nullable<AsyncOperationHandle`1<TTable>> get_CurrentLoadingOperation() { }

	[CompilerGenerated]
	public AsyncOperationHandle<TTable> get_CurrentLoadingOperationHandle() { }

	protected abstract LocalizedDatabase<TTable, TEntry> get_Database() { }

	public bool get_IsEmpty() { }

	public TableReference get_TableReference() { }

	public TTable GetTable() { }

	public AsyncOperationHandle<TTable> GetTableAsync() { }

	private void HandleLocaleChange(Locale _) { }

	private void InvokeChangeHandler(TTable value) { }

	public void remove_TableChanged(ChangeHandler<TTable, TEntry> value) { }

	[CompilerGenerated]
	internal void set_CurrentLoadingOperationHandle(AsyncOperationHandle<TTable> value) { }

	public void set_TableReference(TableReference value) { }

	public virtual string ToString() { }

}

