namespace XeSys.uGUI;

public class UGUIAnimatorControll : UGUIAnimControllBase<AnimatorControllData>
{
	private Animator m_Animator; //Field offset: 0x14

	public Animator Animator
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public UGUIAnimatorControll() { }

	public Animator get_Animator() { }

	public virtual bool IsPlaying() { }

	public virtual bool IsPlaying(int no) { }

	public void set_Animator(Animator value) { }

	public virtual void SetSpeed(float speed) { }

	public virtual void SetStateAnimEnd(int no) { }

	public virtual void SetStateEnd(int no) { }

	public virtual void StartState(int no) { }

	public virtual void StartStateAnim(int no) { }

}

