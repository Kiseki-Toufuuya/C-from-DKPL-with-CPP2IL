namespace Cysharp.Threading.Tasks;

public class AutoResetUniTaskCompletionSource : IUniTaskSource, ITaskPoolNode<AutoResetUniTaskCompletionSource>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal int <.cctor>b__4_0() { }

	}

	private static TaskPool<AutoResetUniTaskCompletionSource> pool; //Field offset: 0x0
	private AutoResetUniTaskCompletionSource nextNode; //Field offset: 0x8
	private UniTaskCompletionSourceCore<AsyncUnit> core; //Field offset: 0xC

	public override AutoResetUniTaskCompletionSource NextNode
	{
		 get { } //Length: 11
	}

	private static AutoResetUniTaskCompletionSource() { }

	private AutoResetUniTaskCompletionSource() { }

	[DebuggerHidden]
	public static AutoResetUniTaskCompletionSource Create() { }

	[DebuggerHidden]
	public static AutoResetUniTaskCompletionSource CreateFromCanceled(CancellationToken cancellationToken, out short token) { }

	public override AutoResetUniTaskCompletionSource get_NextNode() { }

	[DebuggerHidden]
	public override void GetResult(short token) { }

	[DebuggerHidden]
	public override UniTaskStatus GetStatus(short token) { }

	[DebuggerHidden]
	public override void OnCompleted(Action<Object> continuation, object state, short token) { }

	[DebuggerHidden]
	private bool TryReturn() { }

	[DebuggerHidden]
	public override bool TrySetCanceled(CancellationToken cancellationToken = null) { }

	[DebuggerHidden]
	public override UniTaskStatus UnsafeGetStatus() { }

}

