namespace Cysharp.Threading.Tasks.Triggers;

public interface IAsyncOnTriggerExitHandler
{

	public UniTask<Collider> OnTriggerExitAsync() { }

}

