namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncBecameInvisibleTrigger : AsyncTriggerBase<AsyncUnit>
{

	public AsyncBecameInvisibleTrigger() { }

	public IAsyncOnBecameInvisibleHandler GetOnBecameInvisibleAsyncHandler() { }

	public IAsyncOnBecameInvisibleHandler GetOnBecameInvisibleAsyncHandler(CancellationToken cancellationToken) { }

	private void OnBecameInvisible() { }

	public UniTask OnBecameInvisibleAsync() { }

	public UniTask OnBecameInvisibleAsync(CancellationToken cancellationToken) { }

}

