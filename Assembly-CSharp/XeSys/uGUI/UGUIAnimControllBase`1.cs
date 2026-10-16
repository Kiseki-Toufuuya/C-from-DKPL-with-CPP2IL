namespace XeSys.uGUI;

public abstract class UGUIAnimControllBase
{
	private int m_StateNo; //Field offset: 0x0
	protected List<T> m_AnimCtrlDataList; //Field offset: 0x0
	protected T m_CurrentAnimCtrlData; //Field offset: 0x0

	protected List<T> AnimCtrlDataList
	{
		 get { } //Length: 11
	}

	protected T CurrentAnimCtrlData
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public int StateNo
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	protected UGUIAnimControllBase`1() { }

	public override void AddAnimCtrlData(T data) { }

	public void ClearAnimCtrlDataList() { }

	protected List<T> get_AnimCtrlDataList() { }

	protected T get_CurrentAnimCtrlData() { }

	public int get_StateNo() { }

	public abstract bool IsPlaying() { }

	public abstract bool IsPlaying(int no) { }

	protected void set_CurrentAnimCtrlData(T value) { }

	public void set_StateNo(int value) { }

	public override void SetAnimCtrlDataList(List<T> list) { }

	public abstract void SetSpeed(float speed) { }

	public abstract void SetStateAnimEnd(int no) { }

	public abstract void SetStateEnd(int no) { }

	public abstract void StartState(int no) { }

	public abstract void StartStateAnim(int no) { }

}

