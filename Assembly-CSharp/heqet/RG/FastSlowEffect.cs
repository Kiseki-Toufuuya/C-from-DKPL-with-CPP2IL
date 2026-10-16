namespace Heqet.RG;

public class FastSlowEffect : JudgeEffectBase
{
	private float scaleDuration; //Field offset: 0x10
	private float inactiveTime; //Field offset: 0x14
	private Vector3 defaultScale; //Field offset: 0x18
	private Sequence seq; //Field offset: 0x24
	private float scale; //Field offset: 0x28

	public FastSlowEffect() { }

	private void Awake() { }

	public virtual void Play() { }

	public void SetScale(float value) { }

}

