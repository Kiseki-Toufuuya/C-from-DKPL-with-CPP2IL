namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncMouseUpAsButtonTrigger : AsyncTriggerBase<AsyncUnit>
{

	public AsyncMouseUpAsButtonTrigger() { }

	public IAsyncOnMouseUpAsButtonHandler GetOnMouseUpAsButtonAsyncHandler() { }

	public IAsyncOnMouseUpAsButtonHandler GetOnMouseUpAsButtonAsyncHandler(CancellationToken cancellationToken) { }

	private void OnMouseUpAsButton() { }

	public UniTask OnMouseUpAsButtonAsync() { }

	public UniTask OnMouseUpAsButtonAsync(CancellationToken cancellationToken) { }

}

