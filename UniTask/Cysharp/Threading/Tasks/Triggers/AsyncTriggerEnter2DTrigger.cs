namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncTriggerEnter2DTrigger : AsyncTriggerBase<Collider2D>
{

	public AsyncTriggerEnter2DTrigger() { }

	public IAsyncOnTriggerEnter2DHandler GetOnTriggerEnter2DAsyncHandler() { }

	public IAsyncOnTriggerEnter2DHandler GetOnTriggerEnter2DAsyncHandler(CancellationToken cancellationToken) { }

	private void OnTriggerEnter2D(Collider2D other) { }

	public UniTask<Collider2D> OnTriggerEnter2DAsync() { }

	public UniTask<Collider2D> OnTriggerEnter2DAsync(CancellationToken cancellationToken) { }

}

