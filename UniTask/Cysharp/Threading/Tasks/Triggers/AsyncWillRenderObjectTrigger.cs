namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncWillRenderObjectTrigger : AsyncTriggerBase<AsyncUnit>
{

	public AsyncWillRenderObjectTrigger() { }

	public IAsyncOnWillRenderObjectHandler GetOnWillRenderObjectAsyncHandler() { }

	public IAsyncOnWillRenderObjectHandler GetOnWillRenderObjectAsyncHandler(CancellationToken cancellationToken) { }

	private void OnWillRenderObject() { }

	public UniTask OnWillRenderObjectAsync() { }

	public UniTask OnWillRenderObjectAsync(CancellationToken cancellationToken) { }

}

