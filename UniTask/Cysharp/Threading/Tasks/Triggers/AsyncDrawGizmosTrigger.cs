namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncDrawGizmosTrigger : AsyncTriggerBase<AsyncUnit>
{

	public AsyncDrawGizmosTrigger() { }

	public IAsyncOnDrawGizmosHandler GetOnDrawGizmosAsyncHandler() { }

	public IAsyncOnDrawGizmosHandler GetOnDrawGizmosAsyncHandler(CancellationToken cancellationToken) { }

	private void OnDrawGizmos() { }

	public UniTask OnDrawGizmosAsync() { }

	public UniTask OnDrawGizmosAsync(CancellationToken cancellationToken) { }

}

