namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncTriggerExit2DTrigger : AsyncTriggerBase<Collider2D>
{

	public AsyncTriggerExit2DTrigger() { }

	public IAsyncOnTriggerExit2DHandler GetOnTriggerExit2DAsyncHandler() { }

	public IAsyncOnTriggerExit2DHandler GetOnTriggerExit2DAsyncHandler(CancellationToken cancellationToken) { }

	private void OnTriggerExit2D(Collider2D other) { }

	public UniTask<Collider2D> OnTriggerExit2DAsync() { }

	public UniTask<Collider2D> OnTriggerExit2DAsync(CancellationToken cancellationToken) { }

}

