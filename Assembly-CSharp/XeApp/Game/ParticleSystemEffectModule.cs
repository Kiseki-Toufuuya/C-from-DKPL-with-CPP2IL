namespace XeApp.Game;

internal class ParticleSystemEffectModule : IEffectModule
{
	private ParticleSystem particle; //Field offset: 0x8

	public override bool IsStopped
	{
		 get { } //Length: 113
	}

	private ParticleSystemEffectModule() { }

	public ParticleSystemEffectModule(ParticleSystem particle_) { }

	public override bool get_IsStopped() { }

	public override void Pause(bool enable) { }

	public override void Play() { }

	public override void Release() { }

	public override void Simulate(float time) { }

	public override void Stop() { }

}

