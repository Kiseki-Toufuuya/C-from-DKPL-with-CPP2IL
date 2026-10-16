namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncEndDragTrigger : AsyncTriggerBase<PointerEventData>, IEndDragHandler, IEventSystemHandler
{

	public AsyncEndDragTrigger() { }

	public IAsyncOnEndDragHandler GetOnEndDragAsyncHandler() { }

	public IAsyncOnEndDragHandler GetOnEndDragAsyncHandler(CancellationToken cancellationToken) { }

	public UniTask<PointerEventData> OnEndDragAsync() { }

	public UniTask<PointerEventData> OnEndDragAsync(CancellationToken cancellationToken) { }

	private override void UnityEngine.EventSystems.IEndDragHandler.OnEndDrag(PointerEventData eventData) { }

}

