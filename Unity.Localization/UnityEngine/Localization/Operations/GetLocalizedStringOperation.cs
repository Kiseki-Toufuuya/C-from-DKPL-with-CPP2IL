namespace UnityEngine.Localization.Operations;

internal class GetLocalizedStringOperation : WaitForCurrentOperationAsyncOperationBase<String>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal GetLocalizedStringOperation <.cctor>b__15_0() { }

	}

	public static readonly ObjectPool<GetLocalizedStringOperation> Pool; //Field offset: 0x0
	private LocalizedStringDatabase m_Database; //Field offset: 0x6C
	private AsyncOperationHandle<TableEntryResult<StringTable, StringTableEntry>> m_TableEntryOperation; //Field offset: 0x70
	private TableReference m_TableReference; //Field offset: 0x7C
	private TableEntryReference m_TableEntryReference; //Field offset: 0x98
	private Locale m_SelectedLocale; //Field offset: 0xB0
	private IList<Object> m_Arguments; //Field offset: 0xB4
	private IVariableGroup m_LocalVariables; //Field offset: 0xB8
	private bool m_AutoRelease; //Field offset: 0xBC

	private static GetLocalizedStringOperation() { }

	public GetLocalizedStringOperation() { }

	public void CompleteAndRelease(string result, bool success, string errorMsg) { }

	protected virtual void Destroy() { }

	protected virtual void Execute() { }

	public void Init(AsyncOperationHandle<TableEntryResult<StringTable, StringTableEntry>> tableEntryOperation, Locale locale, LocalizedStringDatabase database, TableReference tableReference, TableEntryReference tableEntryReference, IList<Object> arguments, IVariableGroup localVariables, bool autoRelease) { }

	public virtual string ToString() { }

}

