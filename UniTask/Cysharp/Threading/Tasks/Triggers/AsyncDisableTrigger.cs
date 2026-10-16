namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncDisableTrigger : AsyncTriggerBase<AsyncUnit>
{

	public AsyncDisableTrigger() { }

	public IAsyncOnDisableHandler GetOnDisableAsyncHandler() { }

	public IAsyncOnDisableHandler GetOnDisableAsyncHandler(CancellationToken cancellationToken) { }

	private void OnDisable() { }

	public UniTask OnDisableAsync() { }

	public UniTask OnDisableAsync(CancellationToken cancellationToken) { }

}

