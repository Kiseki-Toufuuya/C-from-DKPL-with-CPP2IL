namespace UnityEngine.Playables;

[Extension]
public static class PlayableExtensions
{

	[Extension]
	public static void ConnectInput(U playable, int inputIndex, V sourcePlayable, int sourceOutputIndex, float weight) { }

	[Extension]
	public static void ConnectInput(U playable, int inputIndex, V sourcePlayable, int sourceOutputIndex) { }

	[Extension]
	public static void DisconnectInput(U playable, int inputPort) { }

	[Extension]
	public static double GetDuration(U playable) { }

	[Extension]
	public static PlayableGraph GetGraph(U playable) { }

	[Extension]
	public static Playable GetInput(U playable, int inputPort) { }

	[Extension]
	public static int GetInputCount(U playable) { }

	[Extension]
	public static float GetInputWeight(U playable, int inputIndex) { }

	[Extension]
	public static PlayState GetPlayState(U playable) { }

	[Extension]
	public static double GetPreviousTime(U playable) { }

	[Extension]
	public static double GetSpeed(U playable) { }

	[Extension]
	public static double GetTime(U playable) { }

	[Extension]
	internal static DirectorWrapMode GetTimeWrapMode(U playable) { }

	[Extension]
	public static bool IsDone(U playable) { }

	[Extension]
	public static bool IsValid(U playable) { }

	[Extension]
	public static void Pause(U playable) { }

	[Extension]
	public static void Play(U playable) { }

	[Extension]
	public static void SetDuration(U playable, double value) { }

	[Extension]
	public static void SetInputCount(U playable, int value) { }

	[Extension]
	public static void SetInputWeight(U playable, int inputIndex, float weight) { }

	[Extension]
	public static void SetInputWeight(U playable, V input, float weight) { }

	[Extension]
	public static void SetPropagateSetTime(U playable, bool value) { }

	[Extension]
	public static void SetSpeed(U playable, double value) { }

	[Extension]
	public static void SetTime(U playable, double value) { }

	[Extension]
	internal static void SetTimeWrapMode(U playable, DirectorWrapMode value) { }

	[Extension]
	public static void SetTraversalMode(U playable, PlayableTraversalMode mode) { }

}

