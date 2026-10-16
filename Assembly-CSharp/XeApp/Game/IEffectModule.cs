namespace XeApp.Game;

public interface IEffectModule
{

	public bool IsStopped
	{
		 get { } //Length: 0
	}

	public bool get_IsStopped() { }

	public void Pause(bool enable) { }

	public void Play() { }

	public void Release() { }

	public void Simulate(float time) { }

	public void Stop() { }

}

