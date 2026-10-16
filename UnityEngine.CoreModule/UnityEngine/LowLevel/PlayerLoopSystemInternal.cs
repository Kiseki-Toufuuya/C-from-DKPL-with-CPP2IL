namespace UnityEngine.LowLevel;

[MovedFrom("UnityEngine.Experimental.LowLevel")]
[NativeType(Header = "Runtime/Misc/PlayerLoop.h")]
[RequiredByNativeCode]
internal struct PlayerLoopSystemInternal
{
	public Type type; //Field offset: 0x0
	public UpdateFunction updateDelegate; //Field offset: 0x4
	public IntPtr updateFunction; //Field offset: 0x8
	public IntPtr loopConditionFunction; //Field offset: 0xC
	public int numSubSystems; //Field offset: 0x10

}

