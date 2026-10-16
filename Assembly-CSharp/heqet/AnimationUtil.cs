namespace Heqet;

public class AnimationUtil
{
	private Animation m_Animation; //Field offset: 0x8

	public AnimationUtil() { }

	public AnimationUtil(Animation animation) { }

	public void Initialization(Animation animation) { }

	private bool IsEnableAnimation() { }

	public bool IsPlay() { }

	public void Play(float normalizedTime = 0) { }

	public void Play(int speed, float normalizedTime = 0) { }

	public void SetAnimEnabled(bool enable) { }

	public void SetEndAnimPosition() { }

	public void SetStartAnimPosition() { }

}

