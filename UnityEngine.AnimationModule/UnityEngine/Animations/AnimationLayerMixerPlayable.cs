namespace UnityEngine.Animations;

[NativeHeader("Modules/Animation/Director/AnimationLayerMixerPlayable.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationLayerMixerPlayable.bindings.h")]
[RequiredByNativeCode]
[StaticAccessor("AnimationLayerMixerPlayableBindings", StaticAccessorType::DoubleColon (2))]
public struct AnimationLayerMixerPlayable : IPlayable, IEquatable<AnimationLayerMixerPlayable>
{
	private static readonly AnimationLayerMixerPlayable m_NullPlayable; //Field offset: 0x0
	private PlayableHandle m_Handle; //Field offset: 0x0

	private static AnimationLayerMixerPlayable() { }

	internal AnimationLayerMixerPlayable(PlayableHandle handle, bool singleLayerOptimization = true) { }

	public static AnimationLayerMixerPlayable Create(PlayableGraph graph, int inputCount = 0) { }

	public static AnimationLayerMixerPlayable Create(PlayableGraph graph, int inputCount, bool singleLayerOptimization) { }

	private static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount = 0) { }

	[NativeThrows]
	private static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle) { }

	private static bool CreateHandleInternal_Injected(in PlayableGraph graph, ref PlayableHandle handle) { }

	public override bool Equals(AnimationLayerMixerPlayable other) { }

	public override PlayableHandle GetHandle() { }

	public static Playable op_Implicit(AnimationLayerMixerPlayable playable) { }

	public void SetLayerAdditive(uint layerIndex, bool value) { }

	[NativeThrows]
	private static void SetLayerAdditiveInternal(ref PlayableHandle handle, uint layerIndex, bool value) { }

	public void SetLayerMaskFromAvatarMask(uint layerIndex, AvatarMask mask) { }

	[NativeThrows]
	private static void SetLayerMaskFromAvatarMaskInternal(ref PlayableHandle handle, uint layerIndex, AvatarMask mask) { }

	private static void SetLayerMaskFromAvatarMaskInternal_Injected(ref PlayableHandle handle, uint layerIndex, IntPtr mask) { }

	[NativeThrows]
	private static void SetSingleLayerOptimizationInternal(ref PlayableHandle handle, bool value) { }

}

