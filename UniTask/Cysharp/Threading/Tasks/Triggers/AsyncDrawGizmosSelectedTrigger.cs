namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncDrawGizmosSelectedTrigger : AsyncTriggerBase<AsyncUnit>
{

	public AsyncDrawGizmosSelectedTrigger() { }

	public IAsyncOnDrawGizmosSelectedHandler GetOnDrawGizmosSelectedAsyncHandler() { }

	public IAsyncOnDrawGizmosSelectedHandler GetOnDrawGizmosSelectedAsyncHandler(CancellationToken cancellationToken) { }

	private void OnDrawGizmosSelected() { }

	public UniTask OnDrawGizmosSelectedAsync() { }

	public UniTask OnDrawGizmosSelectedAsync(CancellationToken cancellationToken) { }

}

