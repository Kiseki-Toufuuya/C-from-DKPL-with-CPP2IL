namespace Cysharp.Threading.Tasks;

public abstract class MoveNextSource : IUniTaskSource<Boolean>, IUniTaskSource
{
	protected UniTaskCompletionSourceCore<Boolean> completionSource; //Field offset: 0x8

	protected MoveNextSource() { }

	private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

	public override bool GetResult(short token) { }

	public override UniTaskStatus GetStatus(short token) { }

	public override void OnCompleted(Action<Object> continuation, object state, short token) { }

	public override UniTaskStatus UnsafeGetStatus() { }

}

