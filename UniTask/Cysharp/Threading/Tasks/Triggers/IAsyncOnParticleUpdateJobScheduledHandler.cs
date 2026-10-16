namespace Cysharp.Threading.Tasks.Triggers;

public interface IAsyncOnParticleUpdateJobScheduledHandler
{

	public UniTask<ParticleSystemJobData> OnParticleUpdateJobScheduledAsync() { }

}

