namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncPointerClickTrigger : AsyncTriggerBase<PointerEventData>, IPointerClickHandler, IEventSystemHandler
{

	public AsyncPointerClickTrigger() { }

	public IAsyncOnPointerClickHandler GetOnPointerClickAsyncHandler() { }

	public IAsyncOnPointerClickHandler GetOnPointerClickAsyncHandler(CancellationToken cancellationToken) { }

	public UniTask<PointerEventData> OnPointerClickAsync() { }

	public UniTask<PointerEventData> OnPointerClickAsync(CancellationToken cancellationToken) { }

	private override void UnityEngine.EventSystems.IPointerClickHandler.OnPointerClick(PointerEventData eventData) { }

}

