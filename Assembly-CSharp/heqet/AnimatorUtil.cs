namespace Heqet;

public class AnimatorUtil
{
	public Animator m_Animator; //Field offset: 0x8

	public AnimatorUtil() { }

	public AnimatorUtil(Animator animator) { }

	public void Initialization(Animator animator) { }

	private bool IsEnableAnimator() { }

	public bool IsPlay(string animeName) { }

	public void Play(string animeName, float normalizedTime = 0) { }

	public void Play(string animeName, int speed, float normalizedTime = 0) { }

	public void SetEndAnimPosition(string animeName) { }

	public void SetStartAnimPosition(string animeName) { }

}

