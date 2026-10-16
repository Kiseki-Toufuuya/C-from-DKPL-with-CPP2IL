namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncMoveTrigger : AsyncTriggerBase<AxisEventData>, IMoveHandler, IEventSystemHandler
{

	public AsyncMoveTrigger() { }

	public IAsyncOnMoveHandler GetOnMoveAsyncHandler() { }

	public IAsyncOnMoveHandler GetOnMoveAsyncHandler(CancellationToken cancellationToken) { }

	public UniTask<AxisEventData> OnMoveAsync() { }

	public UniTask<AxisEventData> OnMoveAsync(CancellationToken cancellationToken) { }

	private override void UnityEngine.EventSystems.IMoveHandler.OnMove(AxisEventData eventData) { }

}

