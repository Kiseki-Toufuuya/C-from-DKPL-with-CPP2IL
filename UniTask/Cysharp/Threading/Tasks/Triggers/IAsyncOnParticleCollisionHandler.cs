namespace Cysharp.Threading.Tasks.Triggers;

public interface IAsyncOnParticleCollisionHandler
{

	public UniTask<GameObject> OnParticleCollisionAsync() { }

}

