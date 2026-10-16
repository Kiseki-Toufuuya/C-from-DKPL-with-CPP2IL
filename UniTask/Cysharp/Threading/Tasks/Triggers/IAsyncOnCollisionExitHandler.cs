namespace Cysharp.Threading.Tasks.Triggers;

public interface IAsyncOnCollisionExitHandler
{

	public UniTask<Collision> OnCollisionExitAsync() { }

}

