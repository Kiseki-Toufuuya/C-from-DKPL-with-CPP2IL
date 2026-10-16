namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncLateUpdateTrigger : AsyncTriggerBase<AsyncUnit>
{

	public AsyncLateUpdateTrigger() { }

	public IAsyncLateUpdateHandler GetLateUpdateAsyncHandler() { }

	public IAsyncLateUpdateHandler GetLateUpdateAsyncHandler(CancellationToken cancellationToken) { }

	private void LateUpdate() { }

	public UniTask LateUpdateAsync() { }

	public UniTask LateUpdateAsync(CancellationToken cancellationToken) { }

}

