namespace XeSys;

public class LifeTimer
{
	private float mLife; //Field offset: 0x8
	private float mStartTime; //Field offset: 0xC

	public LifeTimer() { }

	public LifeTimer(float life) { }

	public void Begin(float life) { }

	private float Diff() { }

	public float GetElapsedRate() { }

	public float GetElapsedRate01() { }

	public bool IsEnd() { }

}

