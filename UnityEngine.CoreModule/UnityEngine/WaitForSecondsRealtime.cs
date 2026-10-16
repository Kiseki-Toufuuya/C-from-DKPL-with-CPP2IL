namespace UnityEngine;

public class WaitForSecondsRealtime : CustomYieldInstruction
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private float <waitTime>k__BackingField; //Field offset: 0x8
	private float m_WaitUntilTime; //Field offset: 0xC

	public virtual bool keepWaiting
	{
		 get { } //Length: 146
	}

	public float waitTime
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 18
	}

	public WaitForSecondsRealtime(float time) { }

	public virtual bool get_keepWaiting() { }

	[CompilerGenerated]
	public float get_waitTime() { }

	public virtual void Reset() { }

	[CompilerGenerated]
	public void set_waitTime(float value) { }

}

