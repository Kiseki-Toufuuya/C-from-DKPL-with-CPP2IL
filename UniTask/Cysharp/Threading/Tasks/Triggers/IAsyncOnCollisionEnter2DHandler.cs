namespace Cysharp.Threading.Tasks.Triggers;

public interface IAsyncOnCollisionEnter2DHandler
{

	public UniTask<Collision2D> OnCollisionEnter2DAsync() { }

}

