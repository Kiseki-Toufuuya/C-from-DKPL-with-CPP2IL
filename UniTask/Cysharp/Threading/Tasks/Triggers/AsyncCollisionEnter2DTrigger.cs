namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncCollisionEnter2DTrigger : AsyncTriggerBase<Collision2D>
{

	public AsyncCollisionEnter2DTrigger() { }

	public IAsyncOnCollisionEnter2DHandler GetOnCollisionEnter2DAsyncHandler() { }

	public IAsyncOnCollisionEnter2DHandler GetOnCollisionEnter2DAsyncHandler(CancellationToken cancellationToken) { }

	private void OnCollisionEnter2D(Collision2D coll) { }

	public UniTask<Collision2D> OnCollisionEnter2DAsync() { }

	public UniTask<Collision2D> OnCollisionEnter2DAsync(CancellationToken cancellationToken) { }

}

