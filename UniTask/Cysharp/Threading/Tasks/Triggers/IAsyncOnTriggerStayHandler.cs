namespace Cysharp.Threading.Tasks.Triggers;

public interface IAsyncOnTriggerStayHandler
{

	public UniTask<Collider> OnTriggerStayAsync() { }

}

