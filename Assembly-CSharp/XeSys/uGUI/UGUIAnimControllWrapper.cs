namespace XeSys.uGUI;

public class UGUIAnimControllWrapper
{
	private UGUILayoutAnimControll m_LayoutAnimControll; //Field offset: 0x8
	private UGUITweenAnimControll m_TweenAnimControll; //Field offset: 0xC
	private UGUIAnimatorControll m_AnimatorControll; //Field offset: 0x10
	private int m_StateNo; //Field offset: 0x14

	public int StateNo
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public UGUIAnimControllWrapper() { }

	public void AddAnimCtrlData(LayoutAnimControllData data) { }

	public void AddAnimCtrlData(TweenAnimControllData data) { }

	public void AddAnimCtrlData(AnimatorControllData data) { }

	public bool CheckAnimData(StringBuilder log) { }

	public void ClearAnimCtrlDataList() { }

	public void ClearViewDic() { }

	public int get_StateNo() { }

	public bool IsPlaying() { }

	public bool IsPlaying(int no) { }

	public void set_StateNo(int value) { }

	public void SetAnimator(Animator animator) { }

	public void SetAnimCtrlDataList(List<AnimatorControllData> list) { }

	public void SetAnimCtrlDataList(List<LayoutAnimControllData> list) { }

	public void SetAnimCtrlDataList(List<TweenAnimControllData> list) { }

	public void SetRoot(ViewBase root) { }

	public void SetRoot(GameObject root) { }

	public void SetSpeed(float speed) { }

	public void SetStateAnimEnd(int no) { }

	public void SetStateEnd(int no) { }

	public void StartState(int no) { }

	public void StartStateAnim(int no) { }

}

