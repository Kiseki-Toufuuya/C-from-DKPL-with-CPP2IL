namespace System.Runtime;

internal abstract class AsyncResult : IAsyncResult
{
	internal sealed class AsyncCompletion : MulticastDelegate
	{

		public AsyncCompletion(object object, IntPtr method) { }

		public override bool Invoke(IAsyncResult result) { }

	}

	private static AsyncCallback asyncCompletionWrapperCallback; //Field offset: 0x0
	private AsyncCallback callback; //Field offset: 0x8
	private bool completedSynchronously; //Field offset: 0xC
	private bool endCalled; //Field offset: 0xD
	private Exception exception; //Field offset: 0x10
	private bool isCompleted; //Field offset: 0x14
	private AsyncCompletion nextAsyncCompletion; //Field offset: 0x18
	private object state; //Field offset: 0x1C
	private Action beforePrepareAsyncCompletionAction; //Field offset: 0x20
	private Func<IAsyncResult, Boolean> checkSyncValidationFunc; //Field offset: 0x24
	private ManualResetEvent manualResetEvent; //Field offset: 0x28
	private object thisLock; //Field offset: 0x2C
	[CompilerGenerated]
	private Action<AsyncResult, Exception> <OnCompleting>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private Action<AsyncCallback, IAsyncResult> <VirtualCallback>k__BackingField; //Field offset: 0x34

	public override object AsyncState
	{
		 get { } //Length: 11
	}

	public override WaitHandle AsyncWaitHandle
	{
		 get { } //Length: 298
	}

	public override bool CompletedSynchronously
	{
		 get { } //Length: 11
	}

	public override bool IsCompleted
	{
		 get { } //Length: 11
	}

	protected Action<AsyncResult, Exception> OnCompleting
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	private object ThisLock
	{
		private get { } //Length: 11
	}

	protected Action<AsyncCallback, IAsyncResult> VirtualCallback
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	protected AsyncResult(AsyncCallback callback, object state) { }

	private static void AsyncCompletionWrapperCallback(IAsyncResult result) { }

	protected void Complete(bool completedSynchronously) { }

	protected void Complete(bool completedSynchronously, Exception exception) { }

	protected static TAsyncResult End(IAsyncResult result) { }

	public override object get_AsyncState() { }

	public override WaitHandle get_AsyncWaitHandle() { }

	public override bool get_CompletedSynchronously() { }

	public override bool get_IsCompleted() { }

	[CompilerGenerated]
	protected Action<AsyncResult, Exception> get_OnCompleting() { }

	private object get_ThisLock() { }

	[CompilerGenerated]
	protected Action<AsyncCallback, IAsyncResult> get_VirtualCallback() { }

	private AsyncCompletion GetNextCompletion() { }

	protected override bool OnContinueAsyncCompletion(IAsyncResult result) { }

	protected AsyncCallback PrepareAsyncCompletion(AsyncCompletion callback) { }

	protected bool SyncContinue(IAsyncResult result) { }

	protected static void ThrowInvalidAsyncResult(string debugText) { }

	protected static void ThrowInvalidAsyncResult(IAsyncResult result) { }

	private bool TryContinueHelper(IAsyncResult result, out AsyncCompletion callback) { }

}

