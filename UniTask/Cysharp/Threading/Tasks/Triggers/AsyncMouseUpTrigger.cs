namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncMouseUpTrigger : AsyncTriggerBase<AsyncUnit>
{

	public AsyncMouseUpTrigger() { }

	public IAsyncOnMouseUpHandler GetOnMouseUpAsyncHandler() { }

	public IAsyncOnMouseUpHandler GetOnMouseUpAsyncHandler(CancellationToken cancellationToken) { }

	private void OnMouseUp() { }

	public UniTask OnMouseUpAsync() { }

	public UniTask OnMouseUpAsync(CancellationToken cancellationToken) { }

}

