namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncControllerColliderHitTrigger : AsyncTriggerBase<ControllerColliderHit>
{

	public AsyncControllerColliderHitTrigger() { }

	public IAsyncOnControllerColliderHitHandler GetOnControllerColliderHitAsyncHandler() { }

	public IAsyncOnControllerColliderHitHandler GetOnControllerColliderHitAsyncHandler(CancellationToken cancellationToken) { }

	private void OnControllerColliderHit(ControllerColliderHit hit) { }

	public UniTask<ControllerColliderHit> OnControllerColliderHitAsync() { }

	public UniTask<ControllerColliderHit> OnControllerColliderHitAsync(CancellationToken cancellationToken) { }

}

