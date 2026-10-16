namespace Cysharp.Threading.Tasks.Triggers;

public interface IAsyncOnCollisionStayHandler
{

	public UniTask<Collision> OnCollisionStayAsync() { }

}

