namespace UnityEngine.Timeline;

[Extension]
internal static class TimelineClipCapsExtensions
{

	[Extension]
	public static bool HasAll(ClipCaps caps, ClipCaps flags) { }

	[Extension]
	public static bool HasAny(ClipCaps caps, ClipCaps flags) { }

	[Extension]
	public static bool SupportsBlending(TimelineClip clip) { }

	[Extension]
	public static bool SupportsClipIn(TimelineClip clip) { }

	[Extension]
	public static bool SupportsExtrapolation(TimelineClip clip) { }

	[Extension]
	public static bool SupportsLooping(TimelineClip clip) { }

	[Extension]
	public static bool SupportsSpeedMultiplier(TimelineClip clip) { }

}

