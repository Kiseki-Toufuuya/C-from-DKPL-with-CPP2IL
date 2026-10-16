namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncParticleSystemStoppedTrigger : AsyncTriggerBase<AsyncUnit>
{

	public AsyncParticleSystemStoppedTrigger() { }

	public IAsyncOnParticleSystemStoppedHandler GetOnParticleSystemStoppedAsyncHandler() { }

	public IAsyncOnParticleSystemStoppedHandler GetOnParticleSystemStoppedAsyncHandler(CancellationToken cancellationToken) { }

	private void OnParticleSystemStopped() { }

	public UniTask OnParticleSystemStoppedAsync() { }

	public UniTask OnParticleSystemStoppedAsync(CancellationToken cancellationToken) { }

}

