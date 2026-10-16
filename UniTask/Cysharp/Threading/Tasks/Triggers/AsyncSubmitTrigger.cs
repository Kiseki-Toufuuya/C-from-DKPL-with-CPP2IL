namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncSubmitTrigger : AsyncTriggerBase<BaseEventData>, ISubmitHandler, IEventSystemHandler
{

	public AsyncSubmitTrigger() { }

	public IAsyncOnSubmitHandler GetOnSubmitAsyncHandler() { }

	public IAsyncOnSubmitHandler GetOnSubmitAsyncHandler(CancellationToken cancellationToken) { }

	public UniTask<BaseEventData> OnSubmitAsync() { }

	public UniTask<BaseEventData> OnSubmitAsync(CancellationToken cancellationToken) { }

	private override void UnityEngine.EventSystems.ISubmitHandler.OnSubmit(BaseEventData eventData) { }

}

