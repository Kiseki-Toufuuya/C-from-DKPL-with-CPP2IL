namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncBeforeTransformParentChangedTrigger : AsyncTriggerBase<AsyncUnit>
{

	public AsyncBeforeTransformParentChangedTrigger() { }

	public IAsyncOnBeforeTransformParentChangedHandler GetOnBeforeTransformParentChangedAsyncHandler() { }

	public IAsyncOnBeforeTransformParentChangedHandler GetOnBeforeTransformParentChangedAsyncHandler(CancellationToken cancellationToken) { }

	private void OnBeforeTransformParentChanged() { }

	public UniTask OnBeforeTransformParentChangedAsync() { }

	public UniTask OnBeforeTransformParentChangedAsync(CancellationToken cancellationToken) { }

}

