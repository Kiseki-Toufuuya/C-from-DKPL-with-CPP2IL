namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncCollisionEnterTrigger : AsyncTriggerBase<Collision>
{

	public AsyncCollisionEnterTrigger() { }

	public IAsyncOnCollisionEnterHandler GetOnCollisionEnterAsyncHandler() { }

	public IAsyncOnCollisionEnterHandler GetOnCollisionEnterAsyncHandler(CancellationToken cancellationToken) { }

	private void OnCollisionEnter(Collision coll) { }

	public UniTask<Collision> OnCollisionEnterAsync() { }

	public UniTask<Collision> OnCollisionEnterAsync(CancellationToken cancellationToken) { }

}

