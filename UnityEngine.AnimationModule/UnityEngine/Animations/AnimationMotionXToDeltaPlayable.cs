namespace UnityEngine.Animations;

[NativeHeader("Modules/Animation/ScriptBindings/AnimationMotionXToDeltaPlayable.bindings.h")]
[RequiredByNativeCode]
[StaticAccessor("AnimationMotionXToDeltaPlayableBindings", StaticAccessorType::DoubleColon (2))]
internal struct AnimationMotionXToDeltaPlayable : IPlayable, IEquatable<AnimationMotionXToDeltaPlayable>
{
	private static readonly AnimationMotionXToDeltaPlayable m_NullPlayable; //Field offset: 0x0
	private PlayableHandle m_Handle; //Field offset: 0x0

	private static AnimationMotionXToDeltaPlayable() { }

	private AnimationMotionXToDeltaPlayable(PlayableHandle handle) { }

	public static AnimationMotionXToDeltaPlayable Create(PlayableGraph graph) { }

	private static PlayableHandle CreateHandle(PlayableGraph graph) { }

	[NativeThrows]
	private static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle) { }

	private static bool CreateHandleInternal_Injected(in PlayableGraph graph, ref PlayableHandle handle) { }

	public override bool Equals(AnimationMotionXToDeltaPlayable other) { }

	public override PlayableHandle GetHandle() { }

	public static Playable op_Implicit(AnimationMotionXToDeltaPlayable playable) { }

	public void SetAbsoluteMotion(bool value) { }

	[NativeThrows]
	private static void SetAbsoluteMotionInternal(ref PlayableHandle handle, bool value) { }

}

