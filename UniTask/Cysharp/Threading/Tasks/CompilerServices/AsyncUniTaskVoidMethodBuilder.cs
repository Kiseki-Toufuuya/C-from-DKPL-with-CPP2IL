namespace Cysharp.Threading.Tasks.CompilerServices;

public struct AsyncUniTaskVoidMethodBuilder
{
	private IStateMachineRunner runner; //Field offset: 0x0

	public UniTaskVoid Task
	{
		[DebuggerHidden]
		 get { } //Length: 3
	}

	[DebuggerHidden]
	public void AwaitUnsafeOnCompleted(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }

	[DebuggerHidden]
	public static AsyncUniTaskVoidMethodBuilder Create() { }

	[DebuggerHidden]
	public UniTaskVoid get_Task() { }

	[DebuggerHidden]
	public void SetException(Exception exception) { }

	[DebuggerHidden]
	public void SetResult() { }

	[DebuggerHidden]
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	[DebuggerHidden]
	public void Start(ref TStateMachine stateMachine) { }

}

