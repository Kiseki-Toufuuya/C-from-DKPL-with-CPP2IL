namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncEnableTrigger : AsyncTriggerBase<AsyncUnit>
{

	public AsyncEnableTrigger() { }

	public IAsyncOnEnableHandler GetOnEnableAsyncHandler() { }

	public IAsyncOnEnableHandler GetOnEnableAsyncHandler(CancellationToken cancellationToken) { }

	private void OnEnable() { }

	public UniTask OnEnableAsync() { }

	public UniTask OnEnableAsync(CancellationToken cancellationToken) { }

}

