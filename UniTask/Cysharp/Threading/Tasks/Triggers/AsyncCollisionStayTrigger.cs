namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncCollisionStayTrigger : AsyncTriggerBase<Collision>
{

	public AsyncCollisionStayTrigger() { }

	public IAsyncOnCollisionStayHandler GetOnCollisionStayAsyncHandler() { }

	public IAsyncOnCollisionStayHandler GetOnCollisionStayAsyncHandler(CancellationToken cancellationToken) { }

	private void OnCollisionStay(Collision coll) { }

	public UniTask<Collision> OnCollisionStayAsync() { }

	public UniTask<Collision> OnCollisionStayAsync(CancellationToken cancellationToken) { }

}

