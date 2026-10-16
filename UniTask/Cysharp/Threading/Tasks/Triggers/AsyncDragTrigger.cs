namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncDragTrigger : AsyncTriggerBase<PointerEventData>, IDragHandler, IEventSystemHandler
{

	public AsyncDragTrigger() { }

	public IAsyncOnDragHandler GetOnDragAsyncHandler() { }

	public IAsyncOnDragHandler GetOnDragAsyncHandler(CancellationToken cancellationToken) { }

	public UniTask<PointerEventData> OnDragAsync() { }

	public UniTask<PointerEventData> OnDragAsync(CancellationToken cancellationToken) { }

	private override void UnityEngine.EventSystems.IDragHandler.OnDrag(PointerEventData eventData) { }

}

