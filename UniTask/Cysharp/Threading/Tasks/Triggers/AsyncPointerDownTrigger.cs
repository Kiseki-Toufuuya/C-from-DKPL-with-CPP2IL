namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncPointerDownTrigger : AsyncTriggerBase<PointerEventData>, IPointerDownHandler, IEventSystemHandler
{

	public AsyncPointerDownTrigger() { }

	public IAsyncOnPointerDownHandler GetOnPointerDownAsyncHandler() { }

	public IAsyncOnPointerDownHandler GetOnPointerDownAsyncHandler(CancellationToken cancellationToken) { }

	public UniTask<PointerEventData> OnPointerDownAsync() { }

	public UniTask<PointerEventData> OnPointerDownAsync(CancellationToken cancellationToken) { }

	private override void UnityEngine.EventSystems.IPointerDownHandler.OnPointerDown(PointerEventData eventData) { }

}

