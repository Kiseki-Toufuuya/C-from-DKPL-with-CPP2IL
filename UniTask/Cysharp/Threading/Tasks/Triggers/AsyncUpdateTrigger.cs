namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncUpdateTrigger : AsyncTriggerBase<AsyncUnit>
{

	public AsyncUpdateTrigger() { }

	public IAsyncUpdateHandler GetUpdateAsyncHandler() { }

	public IAsyncUpdateHandler GetUpdateAsyncHandler(CancellationToken cancellationToken) { }

	private void Update() { }

	public UniTask UpdateAsync() { }

	public UniTask UpdateAsync(CancellationToken cancellationToken) { }

}

