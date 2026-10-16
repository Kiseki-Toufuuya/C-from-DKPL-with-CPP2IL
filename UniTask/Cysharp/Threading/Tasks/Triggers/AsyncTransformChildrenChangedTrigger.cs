namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncTransformChildrenChangedTrigger : AsyncTriggerBase<AsyncUnit>
{

	public AsyncTransformChildrenChangedTrigger() { }

	public IAsyncOnTransformChildrenChangedHandler GetOnTransformChildrenChangedAsyncHandler() { }

	public IAsyncOnTransformChildrenChangedHandler GetOnTransformChildrenChangedAsyncHandler(CancellationToken cancellationToken) { }

	private void OnTransformChildrenChanged() { }

	public UniTask OnTransformChildrenChangedAsync() { }

	public UniTask OnTransformChildrenChangedAsync(CancellationToken cancellationToken) { }

}

