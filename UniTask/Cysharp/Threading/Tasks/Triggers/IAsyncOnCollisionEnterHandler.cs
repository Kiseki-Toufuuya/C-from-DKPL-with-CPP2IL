namespace Cysharp.Threading.Tasks.Triggers;

public interface IAsyncOnCollisionEnterHandler
{

	public UniTask<Collision> OnCollisionEnterAsync() { }

}

