namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncCollisionStay2DTrigger : AsyncTriggerBase<Collision2D>
{

	public AsyncCollisionStay2DTrigger() { }

	public IAsyncOnCollisionStay2DHandler GetOnCollisionStay2DAsyncHandler() { }

	public IAsyncOnCollisionStay2DHandler GetOnCollisionStay2DAsyncHandler(CancellationToken cancellationToken) { }

	private void OnCollisionStay2D(Collision2D coll) { }

	public UniTask<Collision2D> OnCollisionStay2DAsync() { }

	public UniTask<Collision2D> OnCollisionStay2DAsync(CancellationToken cancellationToken) { }

}

