namespace XeSys.uGUI;

public class uGUIAnimatorButton : uGUINoLayoutButton
{
	internal enum ColorState
	{
		Normal = 0,
		Disable = 1,
		Select = 2,
		num = 3,
	}

	private static AnimatorControllData[] DefAnimControllData; //Field offset: 0x0
	private static AnimatorControllData[] ColorAnimControllData; //Field offset: 0x4
	private Animator m_animator; //Field offset: 0x48
	private AnimatorControllData[] m_AnimControllData; //Field offset: 0x4C

	private static uGUIAnimatorButton() { }

	public uGUIAnimatorButton(Animator animator, GameObject buttonHitObject, IChgImageSlice chgImage, Action onClick, bool isWaitClickAnim, Action<TouchInfo> onTouch, bool isDrag) { }

	public virtual void Clear() { }

	public static AnimatorControllData[] CreateDefaultAnimatorControllData(int layer) { }

	public virtual bool IsEndAnim() { }

	public void SetAnimData(State state, AnimatorControllData animCtrl) { }

	protected virtual void StartAnim(State state) { }

	public void StartColorAnim(ColorState state) { }

}

