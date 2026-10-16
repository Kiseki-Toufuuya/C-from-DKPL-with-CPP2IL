namespace UnityEngine.LowLevel;

[MovedFrom("UnityEngine.Experimental.LowLevel")]
public struct PlayerLoopSystem
{
	internal sealed class UpdateFunction : MulticastDelegate
	{

		public UpdateFunction(object object, IntPtr method) { }

		public override void Invoke() { }

	}

	public Type type; //Field offset: 0x0
	public PlayerLoopSystem[] subSystemList; //Field offset: 0x4
	public UpdateFunction updateDelegate; //Field offset: 0x8
	public IntPtr updateFunction; //Field offset: 0xC
	public IntPtr loopConditionFunction; //Field offset: 0x10

	public virtual string ToString() { }

}

