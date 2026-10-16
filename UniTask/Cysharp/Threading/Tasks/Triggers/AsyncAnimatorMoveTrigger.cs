namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncAnimatorMoveTrigger : AsyncTriggerBase<AsyncUnit>
{

	public AsyncAnimatorMoveTrigger() { }

	public IAsyncOnAnimatorMoveHandler GetOnAnimatorMoveAsyncHandler() { }

	public IAsyncOnAnimatorMoveHandler GetOnAnimatorMoveAsyncHandler(CancellationToken cancellationToken) { }

	private void OnAnimatorMove() { }

	public UniTask OnAnimatorMoveAsync() { }

	public UniTask OnAnimatorMoveAsync(CancellationToken cancellationToken) { }

}

