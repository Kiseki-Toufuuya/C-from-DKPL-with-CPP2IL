namespace Cysharp.Threading.Tasks.CompilerServices;

internal sealed class AsyncUniTaskVoid : IStateMachineRunner, ITaskPoolNode<AsyncUniTaskVoid`1<TStateMachine>>, IUniTaskSource
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c<TStateMachine> <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal int <.cctor>b__10_0() { }

	}

	private static TaskPool<AsyncUniTaskVoid`1<TStateMachine>> pool; //Field offset: 0x0
	[CompilerGenerated]
	private readonly Action <ReturnAction>k__BackingField; //Field offset: 0x0
	private TStateMachine stateMachine; //Field offset: 0x0
	[CompilerGenerated]
	private readonly Action <MoveNext>k__BackingField; //Field offset: 0x0
	private AsyncUniTaskVoid<TStateMachine> nextNode; //Field offset: 0x0

	public override Action MoveNext
	{
		[CompilerGenerated]
		 get { } //Length: 36
	}

	public override AsyncUniTaskVoid<TStateMachine>& NextNode
	{
		 get { } //Length: 29
	}

	public override Action ReturnAction
	{
		[CompilerGenerated]
		 get { } //Length: 36
	}

	private static AsyncUniTaskVoid`1() { }

	public AsyncUniTaskVoid`1() { }

	private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

	private override UniTaskStatus Cysharp.Threading.Tasks.IUniTaskSource.GetStatus(short token) { }

	private override void Cysharp.Threading.Tasks.IUniTaskSource.OnCompleted(Action<Object> continuation, object state, short token) { }

	private override UniTaskStatus Cysharp.Threading.Tasks.IUniTaskSource.UnsafeGetStatus() { }

	[CompilerGenerated]
	public override Action get_MoveNext() { }

	public override AsyncUniTaskVoid<TStateMachine>& get_NextNode() { }

	[CompilerGenerated]
	public override Action get_ReturnAction() { }

	public override void Return() { }

	[DebuggerHidden]
	private void Run() { }

	public static void SetStateMachine(ref TStateMachine stateMachine, ref IStateMachineRunner runnerFieldRef) { }

}

