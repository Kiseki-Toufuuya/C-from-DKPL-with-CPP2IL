namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncTriggerExitTrigger : AsyncTriggerBase<Collider>
{

	public AsyncTriggerExitTrigger() { }

	public IAsyncOnTriggerExitHandler GetOnTriggerExitAsyncHandler() { }

	public IAsyncOnTriggerExitHandler GetOnTriggerExitAsyncHandler(CancellationToken cancellationToken) { }

	private void OnTriggerExit(Collider other) { }

	public UniTask<Collider> OnTriggerExitAsync() { }

	public UniTask<Collider> OnTriggerExitAsync(CancellationToken cancellationToken) { }

}

