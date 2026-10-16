namespace UnityEngine;

[NativeHeader("Modules/Animation/Motion.h")]
public class Motion : object
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly bool <isAnimatorMotion>k__BackingField; //Field offset: 0xC

	public bool isLooping
	{
		[NativeMethod("IsLooping")]
		 get { } //Length: 98
	}

	protected Motion() { }

	[NativeMethod("IsLooping")]
	public bool get_isLooping() { }

	private static bool get_isLooping_Injected(IntPtr _unity_self) { }

}

