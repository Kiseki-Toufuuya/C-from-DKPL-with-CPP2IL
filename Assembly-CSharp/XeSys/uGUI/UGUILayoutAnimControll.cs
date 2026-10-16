namespace XeSys.uGUI;

public class UGUILayoutAnimControll : UGUIAnimControllBase<LayoutAnimControllDataWork>
{
	private ViewBase m_RootView; //Field offset: 0x14
	private Dictionary<String, ViewBase> m_ViewDic; //Field offset: 0x18
	private List<LayoutAnimControllDataWork> m_CurrentAnimCtrlList; //Field offset: 0x1C

	private List<LayoutAnimControllDataWork> CurrentAnimCtrlList
	{
		private get { } //Length: 11
	}

	private ViewBase RootView
	{
		private get { } //Length: 11
		private set { } //Length: 27
	}

	private Dictionary<String, ViewBase> ViewDic
	{
		private get { } //Length: 11
	}

	public UGUILayoutAnimControll() { }

	public void AddAnimCtrlData(LayoutAnimControllData data) { }

	public void AddAnimCtrlDataWork(LayoutAnimControllDataWork work) { }

	public void ClearViewDic() { }

	private List<LayoutAnimControllDataWork> get_CurrentAnimCtrlList() { }

	private ViewBase get_RootView() { }

	private Dictionary<String, ViewBase> get_ViewDic() { }

	public virtual bool IsPlaying() { }

	public virtual bool IsPlaying(int no) { }

	private ViewBase SearchView(string id) { }

	private void set_RootView(ViewBase value) { }

	public void SetAnimCtrlDataList(List<LayoutAnimControllData> list) { }

	public void SetAnimCtrlDataWorkList(List<LayoutAnimControllDataWork> list) { }

	public void SetRoot(ViewBase root) { }

	public virtual void SetSpeed(float speed) { }

	public virtual void SetStateAnimEnd(int no) { }

	public virtual void SetStateEnd(int no) { }

	public virtual void StartState(int no) { }

	public virtual void StartStateAnim(int no) { }

}

