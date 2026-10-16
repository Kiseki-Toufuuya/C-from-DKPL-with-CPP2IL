namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncRectTransformRemovedTrigger : AsyncTriggerBase<AsyncUnit>
{

	public AsyncRectTransformRemovedTrigger() { }

	public IAsyncOnRectTransformRemovedHandler GetOnRectTransformRemovedAsyncHandler() { }

	public IAsyncOnRectTransformRemovedHandler GetOnRectTransformRemovedAsyncHandler(CancellationToken cancellationToken) { }

	private void OnRectTransformRemoved() { }

	public UniTask OnRectTransformRemovedAsync() { }

	public UniTask OnRectTransformRemovedAsync(CancellationToken cancellationToken) { }

}

