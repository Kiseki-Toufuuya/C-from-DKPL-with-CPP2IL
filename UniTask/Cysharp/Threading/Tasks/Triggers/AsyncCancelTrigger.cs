namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncCancelTrigger : AsyncTriggerBase<BaseEventData>, ICancelHandler, IEventSystemHandler
{

	public AsyncCancelTrigger() { }

	public IAsyncOnCancelHandler GetOnCancelAsyncHandler() { }

	public IAsyncOnCancelHandler GetOnCancelAsyncHandler(CancellationToken cancellationToken) { }

	public UniTask<BaseEventData> OnCancelAsync() { }

	public UniTask<BaseEventData> OnCancelAsync(CancellationToken cancellationToken) { }

	private override void UnityEngine.EventSystems.ICancelHandler.OnCancel(BaseEventData eventData) { }

}

