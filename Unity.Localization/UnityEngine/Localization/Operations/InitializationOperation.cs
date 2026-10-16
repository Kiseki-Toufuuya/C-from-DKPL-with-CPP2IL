namespace UnityEngine.Localization.Operations;

internal class InitializationOperation : WaitForCurrentOperationAsyncOperationBase<LocalizationSettings>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal InitializationOperation <.cctor>b__30_0() { }

	}

	private class UnloadBundlesOperation : AsyncOperationBase<Object>
	{
		private readonly Action<AsyncOperation> m_OperationCompleted; //Field offset: 0x50
		private readonly List<AsyncOperation> m_UnloadBundleOperations; //Field offset: 0x54

		public UnloadBundlesOperation() { }

		protected virtual void Destroy() { }

		protected virtual void Execute() { }

		protected virtual bool InvokeWaitForCompletion() { }

		private void OnOperationCompleted(AsyncOperation obj) { }

	}

	internal const string k_LocaleError = "Failed to initialize localization, could not load the selected locale.
{0}"; //Field offset: 0x0
	internal const string k_PreloadAssetTablesError = "Failed to initialize localization, could not preload asset tables.
{0}"; //Field offset: 0x0
	internal const string k_PreloadStringTablesError = "Failed to initialize localization, could not preload string tables.
{0}"; //Field offset: 0x0
	private const int k_PreloadSteps = 3; //Field offset: 0x0
	public static readonly ObjectPool<InitializationOperation> Pool; //Field offset: 0x0
	private AsyncOperationHandle m_UnloadBundlesOperationHandle; //Field offset: 0x6C
	private readonly Action<AsyncOperationHandle> m_LoadLocales; //Field offset: 0x78
	private readonly Action<AsyncOperationHandle`1<Locale>> m_LoadLocalesCompletedAction; //Field offset: 0x7C
	private readonly Action<AsyncOperationHandle> m_FinishPreloadingTablesAction; //Field offset: 0x80
	private LocalizationSettings m_Settings; //Field offset: 0x84
	private readonly List<AsyncOperationHandle> m_LoadDatabasesOperations; //Field offset: 0x88
	private AsyncOperationHandle<IList`1<AsyncOperationHandle>> m_PreloadDatabasesOperation; //Field offset: 0x8C
	private int m_RemainingSteps; //Field offset: 0x98

	protected virtual string DebugName
	{
		 get { } //Length: 35
	}

	protected virtual float Progress
	{
		 get { } //Length: 174
	}

	private static InitializationOperation() { }

	public InitializationOperation() { }

	[CompilerGenerated]
	private void <.ctor>b__18_0(AsyncOperationHandle _) { }

	[CompilerGenerated]
	private void <.ctor>b__18_1(AsyncOperationHandle _) { }

	private bool CheckOperationSucceeded(AsyncOperationHandle handle, string errorMessage) { }

	protected virtual void Destroy() { }

	protected virtual void Execute() { }

	private void FinishInitializing(bool success, string error) { }

	private void FinishInitializing(AsyncOperationHandle op) { }

	protected virtual string get_DebugName() { }

	protected virtual float get_Progress() { }

	public void Init(LocalizationSettings settings) { }

	private void LoadLocales() { }

	private void LoadLocalesCompleted(AsyncOperationHandle<Locale> operationHandle) { }

	private void PostInitializeExtensions() { }

	private void PreloadTables() { }

	private void PreloadTablesCompleted() { }

}

