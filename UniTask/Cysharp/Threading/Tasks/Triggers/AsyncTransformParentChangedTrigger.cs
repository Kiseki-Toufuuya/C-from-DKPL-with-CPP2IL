namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncTransformParentChangedTrigger : AsyncTriggerBase<AsyncUnit>
{

	public AsyncTransformParentChangedTrigger() { }

	public IAsyncOnTransformParentChangedHandler GetOnTransformParentChangedAsyncHandler() { }

	public IAsyncOnTransformParentChangedHandler GetOnTransformParentChangedAsyncHandler(CancellationToken cancellationToken) { }

	private void OnTransformParentChanged() { }

	public UniTask OnTransformParentChangedAsync() { }

	public UniTask OnTransformParentChangedAsync(CancellationToken cancellationToken) { }

}

