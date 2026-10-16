namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncBeginDragTrigger : AsyncTriggerBase<PointerEventData>, IBeginDragHandler, IEventSystemHandler
{

	public AsyncBeginDragTrigger() { }

	public IAsyncOnBeginDragHandler GetOnBeginDragAsyncHandler() { }

	public IAsyncOnBeginDragHandler GetOnBeginDragAsyncHandler(CancellationToken cancellationToken) { }

	public UniTask<PointerEventData> OnBeginDragAsync() { }

	public UniTask<PointerEventData> OnBeginDragAsync(CancellationToken cancellationToken) { }

	private override void UnityEngine.EventSystems.IBeginDragHandler.OnBeginDrag(PointerEventData eventData) { }

}

