namespace XeSys.uGUI;

public class uGUITweenButton : uGUINoLayoutButton
{
	private LayoutuGUITweenAnimBehaviour m_tweenAnimBehaviour; //Field offset: 0x48
	private Int32[] m_AnimStaIdxData; //Field offset: 0x4C
	private Int32[] m_AnimEndIdxData; //Field offset: 0x50

	public uGUITweenButton(LayoutuGUITweenAnimBehaviour tweenAnim, GameObject buttonHitObject, IChgImageSlice chgImage, Action onClick, bool isWaitClickAnim, Action<TouchInfo> onTouch, bool isDrag) { }

	public virtual void Clear() { }

	public virtual bool IsEndAnim() { }

	public void SetAnimIdxData(State state, int staidx, int endidx) { }

	protected virtual void StartAnim(State state) { }

}

