namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncParticleCollisionTrigger : AsyncTriggerBase<GameObject>
{

	public AsyncParticleCollisionTrigger() { }

	public IAsyncOnParticleCollisionHandler GetOnParticleCollisionAsyncHandler() { }

	public IAsyncOnParticleCollisionHandler GetOnParticleCollisionAsyncHandler(CancellationToken cancellationToken) { }

	private void OnParticleCollision(GameObject other) { }

	public UniTask<GameObject> OnParticleCollisionAsync() { }

	public UniTask<GameObject> OnParticleCollisionAsync(CancellationToken cancellationToken) { }

}

