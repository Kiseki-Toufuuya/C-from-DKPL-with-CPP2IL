namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncParticleUpdateJobScheduledTrigger : AsyncTriggerBase<ParticleSystemJobData>
{

	public AsyncParticleUpdateJobScheduledTrigger() { }

	public IAsyncOnParticleUpdateJobScheduledHandler GetOnParticleUpdateJobScheduledAsyncHandler() { }

	public IAsyncOnParticleUpdateJobScheduledHandler GetOnParticleUpdateJobScheduledAsyncHandler(CancellationToken cancellationToken) { }

	private void OnParticleUpdateJobScheduled(ParticleSystemJobData particles) { }

	public UniTask<ParticleSystemJobData> OnParticleUpdateJobScheduledAsync() { }

	public UniTask<ParticleSystemJobData> OnParticleUpdateJobScheduledAsync(CancellationToken cancellationToken) { }

}

