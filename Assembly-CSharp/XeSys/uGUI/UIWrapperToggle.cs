namespace XeSys.uGUI;

public class UIWrapperToggle : UIWrapperButton
{
	private int m_OffSliceNo; //Field offset: 0x74
	private int m_OnSliceNo; //Field offset: 0x78
	private string m_StaAnimLabel; //Field offset: 0x7C
	private string m_EndAnimLabel; //Field offset: 0x80
	private bool m_IsOn; //Field offset: 0x84
	private Action m_onToggleClick; //Field offset: 0x88

	public bool IsOn
	{
		 get { } //Length: 14
	}

	public Action onToggleClick
	{
		 get { } //Length: 14
		 set { } //Length: 33
	}

	public UIWrapperToggle() { }

	public static UIWrapperToggle CreateAnimatorToggle(Animator animator, GameObject root, string hitObjName, string buttonObjName, Action onClick, bool isWaitClick = true, Action<TouchInfo> onTouch = null, bool isDrag = false) { }

	public static UIWrapperToggle CreateLayoutToggle(AbsoluteLayout rootLayout, GameObject root, string hitObjName, string buttonViewName, Action onClick, bool isWaitClick = true, Action<TouchInfo> onTouch = null, bool isDrag = false) { }

	public static UIWrapperToggle CreateTweenToggle(GameObject root, string hitObjName, string buttonObjName, Action onClick, bool isWaitClick = true, Action<TouchInfo> onTouch = null, bool isDrag = false) { }

	public bool get_IsOn() { }

	public Action get_onToggleClick() { }

	public void InitAnimatorToggle(Animator animator, GameObject root, string hitObjName, string buttonObjName, Action onClick, bool isWaitClick = true, Action<TouchInfo> onTouch = null, bool isDrag = false) { }

	public void InitLayoutToggle(AbsoluteLayout rootLayout, GameObject root, string hitObjName, string buttonViewName, Action onClick, bool isWaitClick = true, Action<TouchInfo> onTouch = null, bool isDrag = false) { }

	public void InitTweenToggle(GameObject root, string hitObjName, string buttonObjName, Action onClick, bool isWaitClick = true, Action<TouchInfo> onTouch = null, bool isDrag = false) { }

	public void onClickProc() { }

	public void set_onToggleClick(Action value) { }

	public void SetOnAnimLabel(string sta, string end) { }

	public void SetOnOff(bool isOn, bool isAnim) { }

	public void SetOnOffSliceNo(int off, int on) { }

}

