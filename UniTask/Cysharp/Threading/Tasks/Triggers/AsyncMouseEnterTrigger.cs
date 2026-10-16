namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncMouseEnterTrigger : AsyncTriggerBase<AsyncUnit>
{

	public AsyncMouseEnterTrigger() { }

	public IAsyncOnMouseEnterHandler GetOnMouseEnterAsyncHandler() { }

	public IAsyncOnMouseEnterHandler GetOnMouseEnterAsyncHandler(CancellationToken cancellationToken) { }

	private void OnMouseEnter() { }

	public UniTask OnMouseEnterAsync() { }

	public UniTask OnMouseEnterAsync(CancellationToken cancellationToken) { }

}

