namespace XeApp.Game;

public class EffectModuleComponent : MonoBehaviour, IEffectModule
{

	public override bool IsStopped
	{
		 get { } //Length: 3
	}

	public EffectModuleComponent() { }

	public override bool get_IsStopped() { }

	public override void Pause(bool enable) { }

	public override void Play() { }

	public override void Release() { }

	public override void Simulate(float time) { }

	public override void Stop() { }

}

