namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncDeselectTrigger : AsyncTriggerBase<BaseEventData>, IDeselectHandler, IEventSystemHandler
{

	public AsyncDeselectTrigger() { }

	public IAsyncOnDeselectHandler GetOnDeselectAsyncHandler() { }

	public IAsyncOnDeselectHandler GetOnDeselectAsyncHandler(CancellationToken cancellationToken) { }

	public UniTask<BaseEventData> OnDeselectAsync() { }

	public UniTask<BaseEventData> OnDeselectAsync(CancellationToken cancellationToken) { }

	private override void UnityEngine.EventSystems.IDeselectHandler.OnDeselect(BaseEventData eventData) { }

}

