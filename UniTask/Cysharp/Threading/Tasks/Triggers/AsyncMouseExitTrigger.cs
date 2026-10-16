namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncMouseExitTrigger : AsyncTriggerBase<AsyncUnit>
{

	public AsyncMouseExitTrigger() { }

	public IAsyncOnMouseExitHandler GetOnMouseExitAsyncHandler() { }

	public IAsyncOnMouseExitHandler GetOnMouseExitAsyncHandler(CancellationToken cancellationToken) { }

	private void OnMouseExit() { }

	public UniTask OnMouseExitAsync() { }

	public UniTask OnMouseExitAsync(CancellationToken cancellationToken) { }

}

