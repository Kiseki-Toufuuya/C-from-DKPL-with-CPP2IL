namespace XeSys.uGUI;

public class LayoutAnimControllData
{
	internal enum AnimaRange
	{
		Self = 0,
		All = 1,
		Children = 2,
		Self_Children = 3,
	}

	[CompilerGenerated]
	private int <stateNo>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private string <id>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private string <startLabel>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <endLabel>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private AnimaRange <animRange>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private bool <isLoop>k__BackingField; //Field offset: 0x1C

	public AnimaRange animRange
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public string endLabel
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public string id
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public bool isLoop
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public string startLabel
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

	public LayoutAnimControllData(int state, string id, string slabel, string elabel, AnimaRange range, bool loop) { }

	public static LayoutAnimControllData CreateDefAnimIn(int state) { }

	public static LayoutAnimControllData CreateDefAnimOut(int state) { }

	[CompilerGenerated]
	public AnimaRange get_animRange() { }

	[CompilerGenerated]
	public string get_endLabel() { }

	[CompilerGenerated]
	public string get_id() { }

	[CompilerGenerated]
	public bool get_isLoop() { }

	[CompilerGenerated]
	public string get_startLabel() { }

	[CompilerGenerated]
	public int get_stateNo() { }

	[CompilerGenerated]
	public void set_animRange(AnimaRange value) { }

	[CompilerGenerated]
	public void set_endLabel(string value) { }

	[CompilerGenerated]
	public void set_id(string value) { }

	[CompilerGenerated]
	public void set_isLoop(bool value) { }

	[CompilerGenerated]
	public void set_startLabel(string value) { }

	[CompilerGenerated]
	public void set_stateNo(int value) { }

	public void StartAnim(ViewBase view) { }

}

