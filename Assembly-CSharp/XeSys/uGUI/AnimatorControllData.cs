namespace XeSys.uGUI;

public class AnimatorControllData
{
	[CompilerGenerated]
	private int <stateNo>k__BackingField; //Field offset: 0x8
	private string m_animationName; //Field offset: 0xC
	private int m_animationNameHash; //Field offset: 0x10
	[CompilerGenerated]
	private string <LayerName>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private int <Layer>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private bool <isLoop>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private bool <isReverse>k__BackingField; //Field offset: 0x1D
	[CompilerGenerated]
	private bool <isSetLayerNo>k__BackingField; //Field offset: 0x1E

	public string animationName
	{
		 get { } //Length: 11
		 set { } //Length: 42
	}

	public bool isLoop
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public bool isReverse
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public bool isSetLayerNo
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public int Layer
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public string LayerName
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

	public AnimatorControllData(int state, string animationName, string layerName, bool loop, bool reverse) { }

	public AnimatorControllData(int state, string animationName, int layer, bool loop, bool reverse) { }

	public string get_animationName() { }

	[CompilerGenerated]
	public bool get_isLoop() { }

	[CompilerGenerated]
	public bool get_isReverse() { }

	[CompilerGenerated]
	public bool get_isSetLayerNo() { }

	[CompilerGenerated]
	public int get_Layer() { }

	[CompilerGenerated]
	public string get_LayerName() { }

	[CompilerGenerated]
	public int get_stateNo() { }

	public void set_animationName(string value) { }

	[CompilerGenerated]
	public void set_isLoop(bool value) { }

	[CompilerGenerated]
	public void set_isReverse(bool value) { }

	[CompilerGenerated]
	public void set_isSetLayerNo(bool value) { }

	[CompilerGenerated]
	public void set_Layer(int value) { }

	[CompilerGenerated]
	public void set_LayerName(string value) { }

	[CompilerGenerated]
	public void set_stateNo(int value) { }

	public void SetAnimEnd(Animator animator) { }

	public void StartAnim(Animator animator) { }

}

