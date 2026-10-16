namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncPointerUpTrigger : AsyncTriggerBase<PointerEventData>, IPointerUpHandler, IEventSystemHandler
{

	public AsyncPointerUpTrigger() { }

	public IAsyncOnPointerUpHandler GetOnPointerUpAsyncHandler() { }

	public IAsyncOnPointerUpHandler GetOnPointerUpAsyncHandler(CancellationToken cancellationToken) { }

	public UniTask<PointerEventData> OnPointerUpAsync() { }

	public UniTask<PointerEventData> OnPointerUpAsync(CancellationToken cancellationToken) { }

	private override void UnityEngine.EventSystems.IPointerUpHandler.OnPointerUp(PointerEventData eventData) { }

}

