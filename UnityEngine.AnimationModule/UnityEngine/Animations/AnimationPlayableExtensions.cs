namespace UnityEngine.Animations;

[Extension]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Modules/Animation/AnimationClip.h")]
[NativeHeader("Modules/Animation/Director/AnimationPlayableExtensions.h")]
public static class AnimationPlayableExtensions
{

	[Extension]
	public static void SetAnimatedProperties(U playable, AnimationClip clip) { }

	[NativeThrows]
	internal static void SetAnimatedPropertiesInternal(ref PlayableHandle playable, AnimationClip animatedProperties) { }

	private static void SetAnimatedPropertiesInternal_Injected(ref PlayableHandle playable, IntPtr animatedProperties) { }

}

