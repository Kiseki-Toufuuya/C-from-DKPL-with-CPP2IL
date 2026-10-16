namespace UnityEngine.Localization;

[UxmlObject]
public class LocalizedAsset : LocalizedAssetBase, IDisposable
{
	internal sealed class ChangeHandler : MulticastDelegate
	{

		public ChangeHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(TObject value, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(TObject value) { }

	}

	private class ConvertToObjectOperation : WaitForCurrentOperationAsyncOperationBase<Object>
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c<TObject> <>9; //Field offset: 0x0

			private static <>c() { }

			public <>c() { }

			internal ConvertToObjectOperation<TObject> <.cctor>b__7_0() { }

		}

		public static readonly ObjectPool<ConvertToObjectOperation<TObject>> Pool; //Field offset: 0x0
		private AsyncOperationHandle<TObject> m_Operation; //Field offset: 0x0

		private static ConvertToObjectOperation() { }

		public ConvertToObjectOperation() { }

		protected virtual void Destroy() { }

		protected virtual void Execute() { }

		public void Init(AsyncOperationHandle<TObject> operation) { }

		private void OnCompleted(AsyncOperationHandle<TObject> op) { }

	}

	[CompilerGenerated]
	internal class UxmlSerializedData : UxmlSerializedData
	{

		public UxmlSerializedData() { }

		public virtual object CreateInstance() { }

	}

	private CallbackArray<ChangeHandler<TObject>> m_ChangeHandler; //Field offset: 0x0
	private Action<Locale> m_SelectedLocaleChanged; //Field offset: 0x0
	private Action<AsyncOperationHandle`1<TObject>> m_AutomaticLoadingCompleted; //Field offset: 0x0
	private AsyncOperationHandle<TObject> m_PreviousLoadingOperation; //Field offset: 0x0
	[CompilerGenerated]
	private AsyncOperationHandle<TObject> <CurrentLoadingOperationHandle>k__BackingField; //Field offset: 0x0
	private TObject m_CurrentValue; //Field offset: 0x0

	public event ChangeHandler<TObject> AssetChanged
	{
		 add { } //Length: 348
		 remove { } //Length: 73
	}

	public internal AsyncOperationHandle<TObject> CurrentLoadingOperationHandle
	{
		[CompilerGenerated]
		 get { } //Length: 32
		[CompilerGenerated]
		internal set { } //Length: 47
	}

	internal virtual bool ForceSynchronous
	{
		internal get { } //Length: 95
	}

	public bool HasChangeHandler
	{
		 get { } //Length: 15
	}

	public virtual bool WaitForCompletion
	{
		 set { } //Length: 227
	}

	public LocalizedAsset`1() { }

	public void add_AssetChanged(ChangeHandler<TObject> value) { }

	protected override BindingResult ApplyDataBindingValue(in BindingContext context, TObject value) { }

	private void AutomaticLoadingCompleted(AsyncOperationHandle<TObject> loadOperation) { }

	protected virtual void Cleanup() { }

	private void ClearLoadingOperation(AsyncOperationHandle<TObject> operationHandle) { }

	internal void ClearLoadingOperation() { }

	private void ClearPreviousLoadingOperation() { }

	protected virtual void Finalize() { }

	protected private virtual void ForceUpdate() { }

	[CompilerGenerated]
	public AsyncOperationHandle<TObject> get_CurrentLoadingOperationHandle() { }

	internal virtual bool get_ForceSynchronous() { }

	public bool get_HasChangeHandler() { }

	private void HandleLocaleChange(Locale locale) { }

	protected virtual void Initialize() { }

	private void InvokeChangeHandler(TObject value) { }

	public TObject LoadAsset() { }

	public virtual AsyncOperationHandle<Object> LoadAssetAsObjectAsync() { }

	public virtual AsyncOperationHandle<T> LoadAssetAsync() { }

	public AsyncOperationHandle<TObject> LoadAssetAsync() { }

	public void remove_AssetChanged(ChangeHandler<TObject> value) { }

	protected virtual void Reset() { }

	[CompilerGenerated]
	internal void set_CurrentLoadingOperationHandle(AsyncOperationHandle<TObject> value) { }

	public virtual void set_WaitForCompletion(bool value) { }

	internal BindingResult SetDataBindingValue(in BindingContext context, T value) { }

	private override void System.IDisposable.Dispose() { }

	protected virtual BindingResult Update(in BindingContext context) { }

	private void UpdateBindingValue(TObject value) { }

}

