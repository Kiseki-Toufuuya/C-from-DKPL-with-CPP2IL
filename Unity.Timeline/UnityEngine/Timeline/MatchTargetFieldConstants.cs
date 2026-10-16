namespace UnityEngine.Timeline;

[Extension]
internal static class MatchTargetFieldConstants
{
	public static MatchTargetFields All; //Field offset: 0x0
	public static MatchTargetFields None; //Field offset: 0x4
	public static MatchTargetFields Position; //Field offset: 0x8
	public static MatchTargetFields Rotation; //Field offset: 0xC

	private static MatchTargetFieldConstants() { }

	[Extension]
	public static bool HasAny(MatchTargetFields me, MatchTargetFields fields) { }

	[Extension]
	public static MatchTargetFields Toggle(MatchTargetFields me, MatchTargetFields flag) { }

}

