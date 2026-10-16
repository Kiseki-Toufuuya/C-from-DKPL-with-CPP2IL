namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncRenderObjectTrigger : AsyncTriggerBase<AsyncUnit>
{

	public AsyncRenderObjectTrigger() { }

	public IAsyncOnRenderObjectHandler GetOnRenderObjectAsyncHandler() { }

	public IAsyncOnRenderObjectHandler GetOnRenderObjectAsyncHandler(CancellationToken cancellationToken) { }

	private void OnRenderObject() { }

	public UniTask OnRenderObjectAsync() { }

	public UniTask OnRenderObjectAsync(CancellationToken cancellationToken) { }

}

