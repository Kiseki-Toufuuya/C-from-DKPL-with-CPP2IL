namespace UnityEngine.Animations;

[NativeHeader("Modules/Animation/Director/AnimationOffsetPlayable.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationOffsetPlayable.bindings.h")]
[RequiredByNativeCode]
[StaticAccessor("AnimationOffsetPlayableBindings", StaticAccessorType::DoubleColon (2))]
internal struct AnimationOffsetPlayable : IPlayable, IEquatable<AnimationOffsetPlayable>
{
	private static readonly AnimationOffsetPlayable m_NullPlayable; //Field offset: 0x0
	private PlayableHandle m_Handle; //Field offset: 0x0

	private static AnimationOffsetPlayable() { }

	internal AnimationOffsetPlayable(PlayableHandle handle) { }

	public static AnimationOffsetPlayable Create(PlayableGraph graph, Vector3 position, Quaternion rotation, int inputCount) { }

	private static PlayableHandle CreateHandle(PlayableGraph graph, Vector3 position, Quaternion rotation, int inputCount) { }

	[NativeThrows]
	private static bool CreateHandleInternal(PlayableGraph graph, Vector3 position, Quaternion rotation, ref PlayableHandle handle) { }

	private static bool CreateHandleInternal_Injected(in PlayableGraph graph, in Vector3 position, in Quaternion rotation, ref PlayableHandle handle) { }

	public override bool Equals(AnimationOffsetPlayable other) { }

	public override PlayableHandle GetHandle() { }

	public static Playable op_Implicit(AnimationOffsetPlayable playable) { }

}

