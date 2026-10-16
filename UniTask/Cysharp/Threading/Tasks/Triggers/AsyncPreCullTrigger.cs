namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncPreCullTrigger : AsyncTriggerBase<AsyncUnit>
{

	public AsyncPreCullTrigger() { }

	public IAsyncOnPreCullHandler GetOnPreCullAsyncHandler() { }

	public IAsyncOnPreCullHandler GetOnPreCullAsyncHandler(CancellationToken cancellationToken) { }

	private void OnPreCull() { }

	public UniTask OnPreCullAsync() { }

	public UniTask OnPreCullAsync(CancellationToken cancellationToken) { }

}

