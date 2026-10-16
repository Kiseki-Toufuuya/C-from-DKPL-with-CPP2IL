namespace UnityEngine.Timeline;

internal abstract class RuntimeElement : IInterval
{
	[CompilerGenerated]
	private int <intervalBit>k__BackingField; //Field offset: 0x8

	public abstract bool enable
	{
		 set { } //Length: 0
	}

	public int intervalBit
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public abstract long intervalEnd
	{
		 get { } //Length: 0
	}

	public abstract long intervalStart
	{
		 get { } //Length: 0
	}

	protected RuntimeElement() { }

	public abstract void DisableAt(double localTime, double rootDuration, FrameData frameData) { }

	public abstract void EvaluateAt(double localTime, FrameData frameData) { }

	[CompilerGenerated]
	public int get_intervalBit() { }

	public abstract long get_intervalEnd() { }

	public abstract long get_intervalStart() { }

	public abstract void set_enable(bool value) { }

	[CompilerGenerated]
	public void set_intervalBit(int value) { }

}

