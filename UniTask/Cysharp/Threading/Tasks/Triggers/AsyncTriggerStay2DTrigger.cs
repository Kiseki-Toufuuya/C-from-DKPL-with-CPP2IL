namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncTriggerStay2DTrigger : AsyncTriggerBase<Collider2D>
{

	public AsyncTriggerStay2DTrigger() { }

	public IAsyncOnTriggerStay2DHandler GetOnTriggerStay2DAsyncHandler() { }

	public IAsyncOnTriggerStay2DHandler GetOnTriggerStay2DAsyncHandler(CancellationToken cancellationToken) { }

	private void OnTriggerStay2D(Collider2D other) { }

	public UniTask<Collider2D> OnTriggerStay2DAsync() { }

	public UniTask<Collider2D> OnTriggerStay2DAsync(CancellationToken cancellationToken) { }

}

