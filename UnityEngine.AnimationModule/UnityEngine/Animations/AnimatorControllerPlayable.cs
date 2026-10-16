namespace UnityEngine.Animations;

[NativeHeader("Modules/Animation/ScriptBindings/AnimatorControllerPlayable.bindings.h")]
[NativeHeader("Modules/Animation/ScriptBindings/Animator.bindings.h")]
[NativeHeader("Modules/Animation/Director/AnimatorControllerPlayable.h")]
[NativeHeader("Modules/Animation/RuntimeAnimatorController.h")]
[NativeHeader("Modules/Animation/AnimatorInfo.h")]
[RequiredByNativeCode]
[StaticAccessor("AnimatorControllerPlayableBindings", StaticAccessorType::DoubleColon (2))]
public struct AnimatorControllerPlayable : IPlayable, IEquatable<AnimatorControllerPlayable>
{
	private static readonly AnimatorControllerPlayable m_NullPlayable; //Field offset: 0x0
	private PlayableHandle m_Handle; //Field offset: 0x0

	private static AnimatorControllerPlayable() { }

	internal AnimatorControllerPlayable(PlayableHandle handle) { }

	public override bool Equals(AnimatorControllerPlayable other) { }

	public AnimatorClipInfo[] GetCurrentAnimatorClipInfo(int layerIndex) { }

	[NativeThrows]
	private static AnimatorClipInfo[] GetCurrentAnimatorClipInfoInternal(ref PlayableHandle handle, int layerIndex) { }

	private static void GetCurrentAnimatorClipInfoInternal_Injected(ref PlayableHandle handle, int layerIndex, out BlittableArrayWrapper ret) { }

	public override PlayableHandle GetHandle() { }

	public AnimatorClipInfo[] GetNextAnimatorClipInfo(int layerIndex) { }

	[NativeThrows]
	private static AnimatorClipInfo[] GetNextAnimatorClipInfoInternal(ref PlayableHandle handle, int layerIndex) { }

	private static void GetNextAnimatorClipInfoInternal_Injected(ref PlayableHandle handle, int layerIndex, out BlittableArrayWrapper ret) { }

	public void SetHandle(PlayableHandle handle) { }

}

