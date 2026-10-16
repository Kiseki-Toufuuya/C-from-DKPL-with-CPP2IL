namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncSelectTrigger : AsyncTriggerBase<BaseEventData>, ISelectHandler, IEventSystemHandler
{

	public AsyncSelectTrigger() { }

	public IAsyncOnSelectHandler GetOnSelectAsyncHandler() { }

	public IAsyncOnSelectHandler GetOnSelectAsyncHandler(CancellationToken cancellationToken) { }

	public UniTask<BaseEventData> OnSelectAsync() { }

	public UniTask<BaseEventData> OnSelectAsync(CancellationToken cancellationToken) { }

	private override void UnityEngine.EventSystems.ISelectHandler.OnSelect(BaseEventData eventData) { }

}

