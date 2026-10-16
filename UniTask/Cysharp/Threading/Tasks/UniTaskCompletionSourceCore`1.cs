namespace Cysharp.Threading.Tasks;

public struct UniTaskCompletionSourceCore
{
	private TResult result; //Field offset: 0x0
	private object error; //Field offset: 0x0
	private short version; //Field offset: 0x0
	private bool hasUnhandledError; //Field offset: 0x0
	private int completedCount; //Field offset: 0x0
	private Action<Object> continuation; //Field offset: 0x0
	private object continuationState; //Field offset: 0x0

	[DebuggerHidden]
	public short Version
	{
		 get { } //Length: 12
	}

	public short get_Version() { }

	[DebuggerHidden]
	public TResult GetResult(short token) { }

	[DebuggerHidden]
	public UniTaskStatus GetStatus(short token) { }

	[DebuggerHidden]
	public void OnCompleted(Action<Object> continuation, object state, short token) { }

	private void ReportUnhandledError() { }

	[DebuggerHidden]
	public void Reset() { }

	[DebuggerHidden]
	public bool TrySetCanceled(CancellationToken cancellationToken = null) { }

	[DebuggerHidden]
	public bool TrySetException(Exception error) { }

	[DebuggerHidden]
	public bool TrySetResult(TResult result) { }

	[DebuggerHidden]
	public UniTaskStatus UnsafeGetStatus() { }

	[DebuggerHidden]
	private void ValidateToken(short token) { }

}

