namespace Cysharp.Threading.Tasks.Triggers;

public interface IAsyncOnCollisionStay2DHandler
{

	public UniTask<Collision2D> OnCollisionStay2DAsync() { }

}

