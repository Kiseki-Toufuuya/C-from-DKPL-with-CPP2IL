namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncBecameVisibleTrigger : AsyncTriggerBase<AsyncUnit>
{

	public AsyncBecameVisibleTrigger() { }

	public IAsyncOnBecameVisibleHandler GetOnBecameVisibleAsyncHandler() { }

	public IAsyncOnBecameVisibleHandler GetOnBecameVisibleAsyncHandler(CancellationToken cancellationToken) { }

	private void OnBecameVisible() { }

	public UniTask OnBecameVisibleAsync() { }

	public UniTask OnBecameVisibleAsync(CancellationToken cancellationToken) { }

}

