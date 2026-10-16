namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncMouseOverTrigger : AsyncTriggerBase<AsyncUnit>
{

	public AsyncMouseOverTrigger() { }

	public IAsyncOnMouseOverHandler GetOnMouseOverAsyncHandler() { }

	public IAsyncOnMouseOverHandler GetOnMouseOverAsyncHandler(CancellationToken cancellationToken) { }

	private void OnMouseOver() { }

	public UniTask OnMouseOverAsync() { }

	public UniTask OnMouseOverAsync(CancellationToken cancellationToken) { }

}

