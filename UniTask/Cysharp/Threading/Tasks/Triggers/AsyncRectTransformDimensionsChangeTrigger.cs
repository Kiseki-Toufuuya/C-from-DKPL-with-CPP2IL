namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncRectTransformDimensionsChangeTrigger : AsyncTriggerBase<AsyncUnit>
{

	public AsyncRectTransformDimensionsChangeTrigger() { }

	public IAsyncOnRectTransformDimensionsChangeHandler GetOnRectTransformDimensionsChangeAsyncHandler() { }

	public IAsyncOnRectTransformDimensionsChangeHandler GetOnRectTransformDimensionsChangeAsyncHandler(CancellationToken cancellationToken) { }

	private void OnRectTransformDimensionsChange() { }

	public UniTask OnRectTransformDimensionsChangeAsync() { }

	public UniTask OnRectTransformDimensionsChangeAsync(CancellationToken cancellationToken) { }

}

