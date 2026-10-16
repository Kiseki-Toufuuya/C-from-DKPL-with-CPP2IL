namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncMouseDownTrigger : AsyncTriggerBase<AsyncUnit>
{

	public AsyncMouseDownTrigger() { }

	public IAsyncOnMouseDownHandler GetOnMouseDownAsyncHandler() { }

	public IAsyncOnMouseDownHandler GetOnMouseDownAsyncHandler(CancellationToken cancellationToken) { }

	private void OnMouseDown() { }

	public UniTask OnMouseDownAsync() { }

	public UniTask OnMouseDownAsync(CancellationToken cancellationToken) { }

}

