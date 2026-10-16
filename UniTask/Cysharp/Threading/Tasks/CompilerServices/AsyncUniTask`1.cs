namespace Cysharp.Threading.Tasks.CompilerServices;

internal sealed class AsyncUniTask : IStateMachineRunnerPromise, IUniTaskSource, ITaskPoolNode<AsyncUniTask`1<TStateMachine>>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c<TStateMachine> <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal int <.cctor>b__12_0() { }

	}

	private static TaskPool<AsyncUniTask`1<TStateMachine>> pool; //Field offset: 0x0
	private readonly Action returnDelegate; //Field offset: 0x0
	[CompilerGenerated]
	private readonly Action <MoveNext>k__BackingField; //Field offset: 0x0
	private TStateMachine stateMachine; //Field offset: 0x0
	private UniTaskCompletionSourceCore<AsyncUnit> core; //Field offset: 0x0
	private AsyncUniTask<TStateMachine> nextNode; //Field offset: 0x0

	public override Action MoveNext
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public override AsyncUniTask<TStateMachine>& NextNode
	{
		 get { } //Length: 11
	}

	public override UniTask Task
	{
		[DebuggerHidden]
		 get { } //Length: 82
	}

	private static AsyncUniTask`1() { }

	private AsyncUniTask`1() { }

	[CompilerGenerated]
	public override Action get_MoveNext() { }

	public override AsyncUniTask<TStateMachine>& get_NextNode() { }

	[DebuggerHidden]
	public override UniTask get_Task() { }

	[DebuggerHidden]
	public override void GetResult(short token) { }

	[DebuggerHidden]
	public override UniTaskStatus GetStatus(short token) { }

	[DebuggerHidden]
	public override void OnCompleted(Action<Object> continuation, object state, short token) { }

	private void Return() { }

	[DebuggerHidden]
	private void Run() { }

	[DebuggerHidden]
	public override void SetException(Exception exception) { }

	[DebuggerHidden]
	public override void SetResult() { }

	public static void SetStateMachine(ref TStateMachine stateMachine, ref IStateMachineRunnerPromise runnerPromiseFieldRef) { }

	[DebuggerHidden]
	public override UniTaskStatus UnsafeGetStatus() { }

}

