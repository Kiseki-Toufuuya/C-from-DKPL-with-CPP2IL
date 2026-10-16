namespace XeSys;

[Extension]
public static class AnimatorExtension
{

	[Extension]
	public static void CrossFadeRandomTime(Animator anim, string stateName, float transitionDuration, int layer) { }

	[Extension]
	public static void CrossFadeRandomTime(Animator anim, int stateNameHash, float transitionDuration, int layer) { }

	private static float GetRandomTime() { }

	[Extension]
	public static bool HasState(Animator anim, int layerIndex, string stateName) { }

	[Extension]
	public static void PlayCurrent(Animator anim, int layerIndex, float normalizedTime) { }

	[Extension]
	public static void PlayRandomTime(Animator anim, string stateName, int layer) { }

	[Extension]
	public static void PlayRandomTime(Animator anim, int stateNameHash, int layer) { }

}

