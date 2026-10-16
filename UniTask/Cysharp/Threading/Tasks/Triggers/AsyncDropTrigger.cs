namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncDropTrigger : AsyncTriggerBase<PointerEventData>, IDropHandler, IEventSystemHandler
{

	public AsyncDropTrigger() { }

	public IAsyncOnDropHandler GetOnDropAsyncHandler() { }

	public IAsyncOnDropHandler GetOnDropAsyncHandler(CancellationToken cancellationToken) { }

	public UniTask<PointerEventData> OnDropAsync() { }

	public UniTask<PointerEventData> OnDropAsync(CancellationToken cancellationToken) { }

	private override void UnityEngine.EventSystems.IDropHandler.OnDrop(PointerEventData eventData) { }

}

