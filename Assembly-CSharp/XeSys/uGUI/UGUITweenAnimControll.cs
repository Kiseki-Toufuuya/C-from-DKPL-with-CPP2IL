namespace XeSys.uGUI;

public class UGUITweenAnimControll : UGUIAnimControllBase<TweenAnimControllDataWork>
{
	private GameObject m_RootObject; //Field offset: 0x14
	private Dictionary<String, LayoutUGUITweenAnimation> m_TweenAnimationDic; //Field offset: 0x18
	private List<TweenAnimControllDataWork> m_TmpAnimCtrlListWork; //Field offset: 0x1C
	private List<TweenAnimControllDataWork> m_CurrentAnimCtrlList; //Field offset: 0x20
	private HashSet<LayoutUGUITweenAnimation> m_TmpAnimHashWork; //Field offset: 0x24
	private HashSet<LayoutUGUITweenAnimation> m_CurrentAnimHash; //Field offset: 0x28
	private float m_CurrentSpeed; //Field offset: 0x2C

	private List<TweenAnimControllDataWork> CurrentAnimCtrlList
	{
		private get { } //Length: 11
	}

	public GameObject RootObject
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	private List<TweenAnimControllDataWork> TmpAnimCtrlListWork
	{
		private get { } //Length: 11
	}

	private Dictionary<String, LayoutUGUITweenAnimation> TweenAnimationDic
	{
		private get { } //Length: 11
	}

	public UGUITweenAnimControll() { }

	public void AddAnimCtrlData(TweenAnimControllData data) { }

	public void AddAnimCtrlDataWork(TweenAnimControllDataWork work) { }

	public bool CheckAnimCtrlDataList(StringBuilder log) { }

	private List<TweenAnimControllDataWork> get_CurrentAnimCtrlList() { }

	public GameObject get_RootObject() { }

	private List<TweenAnimControllDataWork> get_TmpAnimCtrlListWork() { }

	private Dictionary<String, LayoutUGUITweenAnimation> get_TweenAnimationDic() { }

	public virtual bool IsPlaying() { }

	public virtual bool IsPlaying(int no) { }

	private void RemoveEndCurrentAnimList() { }

	private LayoutUGUITweenAnimation SearchAnimation(string id) { }

	public void set_RootObject(GameObject value) { }

	public void SetAnimCtrlDataList(List<TweenAnimControllData> list) { }

	public void SetAnimCtrlDataWorkList(List<TweenAnimControllDataWork> list) { }

	public virtual void SetSpeed(float speed) { }

	public virtual void SetStateAnimEnd(int no) { }

	public virtual void SetStateEnd(int no) { }

	public virtual void StartState(int no) { }

	public virtual void StartStateAnim(int no) { }

}

