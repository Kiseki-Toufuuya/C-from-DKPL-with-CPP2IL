namespace Cysharp.Threading.Tasks.CompilerServices;

public struct AsyncUniTaskMethodBuilder
{
	private IStateMachineRunnerPromise runnerPromise; //Field offset: 0x0
	private Exception ex; //Field offset: 0x4

	public UniTask Task
	{
		[DebuggerHidden]
		 get { } //Length: 162
	}

	[DebuggerHidden]
	public void AwaitUnsafeOnCompleted(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }

	[DebuggerHidden]
	public static AsyncUniTaskMethodBuilder Create() { }

	[DebuggerHidden]
	public UniTask get_Task() { }

	[DebuggerHidden]
	public void SetException(Exception exception) { }

	[DebuggerHidden]
	public void SetResult() { }

	[DebuggerHidden]
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	[DebuggerHidden]
	public void Start(ref TStateMachine stateMachine) { }

}

