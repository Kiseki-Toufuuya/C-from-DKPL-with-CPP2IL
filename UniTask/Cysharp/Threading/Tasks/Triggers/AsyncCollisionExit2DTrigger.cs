namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncCollisionExit2DTrigger : AsyncTriggerBase<Collision2D>
{

	public AsyncCollisionExit2DTrigger() { }

	public IAsyncOnCollisionExit2DHandler GetOnCollisionExit2DAsyncHandler() { }

	public IAsyncOnCollisionExit2DHandler GetOnCollisionExit2DAsyncHandler(CancellationToken cancellationToken) { }

	private void OnCollisionExit2D(Collision2D coll) { }

	public UniTask<Collision2D> OnCollisionExit2DAsync() { }

	public UniTask<Collision2D> OnCollisionExit2DAsync(CancellationToken cancellationToken) { }

}

