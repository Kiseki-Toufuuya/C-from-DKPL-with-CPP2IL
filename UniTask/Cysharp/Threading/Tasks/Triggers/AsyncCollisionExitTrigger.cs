namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncCollisionExitTrigger : AsyncTriggerBase<Collision>
{

	public AsyncCollisionExitTrigger() { }

	public IAsyncOnCollisionExitHandler GetOnCollisionExitAsyncHandler() { }

	public IAsyncOnCollisionExitHandler GetOnCollisionExitAsyncHandler(CancellationToken cancellationToken) { }

	private void OnCollisionExit(Collision coll) { }

	public UniTask<Collision> OnCollisionExitAsync() { }

	public UniTask<Collision> OnCollisionExitAsync(CancellationToken cancellationToken) { }

}

