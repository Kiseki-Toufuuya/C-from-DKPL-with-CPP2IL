namespace XeSys.uGUI;

public class uGUILayoutButton : uGUILayoutButtonBase
{
	private static LayoutAnimControllData[] DefAnimControllData; //Field offset: 0x0
	private LayoutAnimControllData[] m_AnimControllData; //Field offset: 0x40
	private ViewBase m_ButtonView; //Field offset: 0x44

	public ViewBase ButtonView
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	private static uGUILayoutButton() { }

	public uGUILayoutButton(GameObject buttonHitObject, ViewBase buttonView, Action onClick, bool isWaitClickAnim, Action<TouchInfo> onTouch, bool isDrag) { }

	public virtual void Clear() { }

	public ViewBase get_ButtonView() { }

	public virtual bool IsEndAnim() { }

	public void set_ButtonView(ViewBase value) { }

	public void SetStateAnimData(State state, LayoutAnimControllData data) { }

	protected virtual void StartAnim(State state) { }

}

