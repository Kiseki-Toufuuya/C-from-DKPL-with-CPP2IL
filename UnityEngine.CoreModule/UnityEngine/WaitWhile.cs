namespace UnityEngine;

public sealed class WaitWhile : CustomYieldInstruction
{
	private readonly Func<Boolean> m_Predicate; //Field offset: 0x8
	private readonly Action m_TimeoutCallback; //Field offset: 0xC
	private readonly WaitTimeoutMode m_TimeoutMode; //Field offset: 0x10
	private readonly double m_MaxExecutionTime; //Field offset: 0x18

	public virtual bool keepWaiting
	{
		 get { } //Length: 177
	}

	public WaitWhile(Func<Boolean> predicate) { }

	public virtual bool get_keepWaiting() { }

	private double GetTime() { }

}

