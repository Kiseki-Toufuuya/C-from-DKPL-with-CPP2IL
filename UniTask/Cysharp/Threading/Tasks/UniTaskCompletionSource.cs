namespace Cysharp.Threading.Tasks;

public class UniTaskCompletionSource : IUniTaskSource
{
	private CancellationToken cancellationToken; //Field offset: 0x8
	private ExceptionHolder exception; //Field offset: 0xC
	private object gate; //Field offset: 0x10
	private Action<Object> singleContinuation; //Field offset: 0x14
	private object singleState; //Field offset: 0x18
	private List<ValueTuple`2<Action`1<Object>, Object>> secondaryContinuationList; //Field offset: 0x1C
	private int intStatus; //Field offset: 0x20
	private bool handled; //Field offset: 0x24

	public UniTask Task
	{
		[DebuggerHidden]
		 get { } //Length: 49
	}

	public UniTaskCompletionSource() { }

	[DebuggerHidden]
	public UniTask get_Task() { }

	[DebuggerHidden]
	public override void GetResult(short token) { }

	[DebuggerHidden]
	public override UniTaskStatus GetStatus(short token) { }

	[DebuggerHidden]
	internal void MarkHandled() { }

	[DebuggerHidden]
	public override void OnCompleted(Action<Object> continuation, object state, short token) { }

	[DebuggerHidden]
	public override bool TrySetResult() { }

	[DebuggerHidden]
	private bool TrySignalCompletion(UniTaskStatus status) { }

	[DebuggerHidden]
	public override UniTaskStatus UnsafeGetStatus() { }

}

