namespace Cysharp.Threading.Tasks.Triggers;

public interface IAsyncOnTriggerEnterHandler
{

	public UniTask<Collider> OnTriggerEnterAsync() { }

}

