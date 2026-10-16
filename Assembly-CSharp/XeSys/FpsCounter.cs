namespace XeSys;

public class FpsCounter
{
	private const float UPDATE_INTERVAL = 0.5; //Field offset: 0x0
	private float mLastInterval; //Field offset: 0x8
	private int mFrames; //Field offset: 0xC
	private Single[] mFpsArray; //Field offset: 0x10
	private int mIndex; //Field offset: 0x14
	[CompilerGenerated]
	private float <average>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private float <fps>k__BackingField; //Field offset: 0x1C

	public private float average
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 18
	}

	public private float fps
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 18
	}

	public FpsCounter() { }

	[CompilerGenerated]
	public float get_average() { }

	[CompilerGenerated]
	public float get_fps() { }

	public void Reset() { }

	[CompilerGenerated]
	private void set_average(float value) { }

	[CompilerGenerated]
	private void set_fps(float value) { }

	public void Update() { }

	private void UpdateAverage() { }

}

