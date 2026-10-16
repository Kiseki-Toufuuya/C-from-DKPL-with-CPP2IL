namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncUpdateSelectedTrigger : AsyncTriggerBase<BaseEventData>, IUpdateSelectedHandler, IEventSystemHandler
{

	public AsyncUpdateSelectedTrigger() { }

	public IAsyncOnUpdateSelectedHandler GetOnUpdateSelectedAsyncHandler() { }

	public IAsyncOnUpdateSelectedHandler GetOnUpdateSelectedAsyncHandler(CancellationToken cancellationToken) { }

	public UniTask<BaseEventData> OnUpdateSelectedAsync() { }

	public UniTask<BaseEventData> OnUpdateSelectedAsync(CancellationToken cancellationToken) { }

	private override void UnityEngine.EventSystems.IUpdateSelectedHandler.OnUpdateSelected(BaseEventData eventData) { }

}

