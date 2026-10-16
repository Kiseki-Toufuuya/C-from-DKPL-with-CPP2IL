namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncPointerEnterTrigger : AsyncTriggerBase<PointerEventData>, IPointerEnterHandler, IEventSystemHandler
{

	public AsyncPointerEnterTrigger() { }

	public IAsyncOnPointerEnterHandler GetOnPointerEnterAsyncHandler() { }

	public IAsyncOnPointerEnterHandler GetOnPointerEnterAsyncHandler(CancellationToken cancellationToken) { }

	public UniTask<PointerEventData> OnPointerEnterAsync() { }

	public UniTask<PointerEventData> OnPointerEnterAsync(CancellationToken cancellationToken) { }

	private override void UnityEngine.EventSystems.IPointerEnterHandler.OnPointerEnter(PointerEventData eventData) { }

}

