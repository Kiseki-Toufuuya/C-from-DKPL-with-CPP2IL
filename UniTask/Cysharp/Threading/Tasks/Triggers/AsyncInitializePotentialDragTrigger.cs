namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncInitializePotentialDragTrigger : AsyncTriggerBase<PointerEventData>, IInitializePotentialDragHandler, IEventSystemHandler
{

	public AsyncInitializePotentialDragTrigger() { }

	public IAsyncOnInitializePotentialDragHandler GetOnInitializePotentialDragAsyncHandler() { }

	public IAsyncOnInitializePotentialDragHandler GetOnInitializePotentialDragAsyncHandler(CancellationToken cancellationToken) { }

	public UniTask<PointerEventData> OnInitializePotentialDragAsync() { }

	public UniTask<PointerEventData> OnInitializePotentialDragAsync(CancellationToken cancellationToken) { }

	private override void UnityEngine.EventSystems.IInitializePotentialDragHandler.OnInitializePotentialDrag(PointerEventData eventData) { }

}

