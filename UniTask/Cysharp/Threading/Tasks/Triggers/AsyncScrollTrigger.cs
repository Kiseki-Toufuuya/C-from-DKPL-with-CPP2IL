namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncScrollTrigger : AsyncTriggerBase<PointerEventData>, IScrollHandler, IEventSystemHandler
{

	public AsyncScrollTrigger() { }

	public IAsyncOnScrollHandler GetOnScrollAsyncHandler() { }

	public IAsyncOnScrollHandler GetOnScrollAsyncHandler(CancellationToken cancellationToken) { }

	public UniTask<PointerEventData> OnScrollAsync() { }

	public UniTask<PointerEventData> OnScrollAsync(CancellationToken cancellationToken) { }

	private override void UnityEngine.EventSystems.IScrollHandler.OnScroll(PointerEventData eventData) { }

}

