namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncFixedUpdateTrigger : AsyncTriggerBase<AsyncUnit>
{

	public AsyncFixedUpdateTrigger() { }

	private void FixedUpdate() { }

	public UniTask FixedUpdateAsync() { }

	public UniTask FixedUpdateAsync(CancellationToken cancellationToken) { }

	public IAsyncFixedUpdateHandler GetFixedUpdateAsyncHandler() { }

	public IAsyncFixedUpdateHandler GetFixedUpdateAsyncHandler(CancellationToken cancellationToken) { }

}

