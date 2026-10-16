namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncPointerExitTrigger : AsyncTriggerBase<PointerEventData>, IPointerExitHandler, IEventSystemHandler
{

	public AsyncPointerExitTrigger() { }

	public IAsyncOnPointerExitHandler GetOnPointerExitAsyncHandler() { }

	public IAsyncOnPointerExitHandler GetOnPointerExitAsyncHandler(CancellationToken cancellationToken) { }

	public UniTask<PointerEventData> OnPointerExitAsync() { }

	public UniTask<PointerEventData> OnPointerExitAsync(CancellationToken cancellationToken) { }

	private override void UnityEngine.EventSystems.IPointerExitHandler.OnPointerExit(PointerEventData eventData) { }

}

