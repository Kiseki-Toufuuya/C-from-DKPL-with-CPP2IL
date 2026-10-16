namespace XeSys.uGUI;

public class TweenAnimControllData
{
	[CompilerGenerated]
	private int <stateNo>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private string <id>k__BackingField; //Field offset: 0xC
	private List<String> m_labelList; //Field offset: 0x10
	private bool m_IsLoop; //Field offset: 0x14
	private bool m_IsRound; //Field offset: 0x15

	public string id
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public int stateNo
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public TweenAnimControllData(int state, string id, string slabel, string elabel, bool isLoop = false, bool isRound = false) { }

	public TweenAnimControllData(int state, string id, List<String> labelList, bool isLoop = false, bool isRound = false) { }

	public TweenAnimControllData(int state, string id, String[] labelList, bool isLoop = false, bool isRound = false) { }

	[CompilerGenerated]
	public string get_id() { }

	[CompilerGenerated]
	public int get_stateNo() { }

	public List<String> GetLabelList() { }

	[CompilerGenerated]
	public void set_id(string value) { }

	[CompilerGenerated]
	public void set_stateNo(int value) { }

	public void SetAnimEnd(LayoutUGUITweenAnimation tweenAnimation) { }

	public void StartAnim(LayoutUGUITweenAnimation tweenAnimation) { }

}

