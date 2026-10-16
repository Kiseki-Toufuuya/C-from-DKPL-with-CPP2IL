namespace UnityEngine.Animations;

[NativeHeader("Modules/Animation/Director/AnimationMixerPlayable.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationMixerPlayable.bindings.h")]
[RequiredByNativeCode]
[StaticAccessor("AnimationMixerPlayableBindings", StaticAccessorType::DoubleColon (2))]
public struct AnimationMixerPlayable : IPlayable, IEquatable<AnimationMixerPlayable>
{
	private static readonly AnimationMixerPlayable m_NullPlayable; //Field offset: 0x0
	private PlayableHandle m_Handle; //Field offset: 0x0

	private static AnimationMixerPlayable() { }

	internal AnimationMixerPlayable(PlayableHandle handle) { }

	public static AnimationMixerPlayable Create(PlayableGraph graph, int inputCount = 0) { }

	private static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount = 0) { }

	[NativeThrows]
	private static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle) { }

	private static bool CreateHandleInternal_Injected(in PlayableGraph graph, ref PlayableHandle handle) { }

	public override bool Equals(AnimationMixerPlayable other) { }

	public override PlayableHandle GetHandle() { }

	public static Playable op_Implicit(AnimationMixerPlayable playable) { }

}

