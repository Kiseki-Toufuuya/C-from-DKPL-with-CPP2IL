namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncMouseDragTrigger : AsyncTriggerBase<AsyncUnit>
{

	public AsyncMouseDragTrigger() { }

	public IAsyncOnMouseDragHandler GetOnMouseDragAsyncHandler() { }

	public IAsyncOnMouseDragHandler GetOnMouseDragAsyncHandler(CancellationToken cancellationToken) { }

	private void OnMouseDrag() { }

	public UniTask OnMouseDragAsync() { }

	public UniTask OnMouseDragAsync(CancellationToken cancellationToken) { }

}

