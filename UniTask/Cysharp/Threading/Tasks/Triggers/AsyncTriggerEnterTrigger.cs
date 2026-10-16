namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncTriggerEnterTrigger : AsyncTriggerBase<Collider>
{

	public AsyncTriggerEnterTrigger() { }

	public IAsyncOnTriggerEnterHandler GetOnTriggerEnterAsyncHandler() { }

	public IAsyncOnTriggerEnterHandler GetOnTriggerEnterAsyncHandler(CancellationToken cancellationToken) { }

	private void OnTriggerEnter(Collider other) { }

	public UniTask<Collider> OnTriggerEnterAsync() { }

	public UniTask<Collider> OnTriggerEnterAsync(CancellationToken cancellationToken) { }

}

