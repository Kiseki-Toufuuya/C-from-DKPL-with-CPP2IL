namespace Cysharp.Threading.Tasks.Triggers;

public interface IAsyncOnControllerColliderHitHandler
{

	public UniTask<ControllerColliderHit> OnControllerColliderHitAsync() { }

}

