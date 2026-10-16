namespace UnityEngine;

[RequiredByNativeCode]
public sealed class WaitForSeconds : YieldInstruction
{
	internal float m_Seconds; //Field offset: 0x8

	public WaitForSeconds(float seconds) { }

}

