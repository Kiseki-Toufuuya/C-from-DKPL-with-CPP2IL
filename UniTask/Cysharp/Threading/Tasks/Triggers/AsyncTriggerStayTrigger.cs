namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncTriggerStayTrigger : AsyncTriggerBase<Collider>
{

	public AsyncTriggerStayTrigger() { }

	public IAsyncOnTriggerStayHandler GetOnTriggerStayAsyncHandler() { }

	public IAsyncOnTriggerStayHandler GetOnTriggerStayAsyncHandler(CancellationToken cancellationToken) { }

	private void OnTriggerStay(Collider other) { }

	public UniTask<Collider> OnTriggerStayAsync() { }

	public UniTask<Collider> OnTriggerStayAsync(CancellationToken cancellationToken) { }

}

