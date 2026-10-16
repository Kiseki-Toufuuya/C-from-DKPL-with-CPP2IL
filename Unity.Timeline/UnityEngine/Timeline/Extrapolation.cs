namespace UnityEngine.Timeline;

[Extension]
internal static class Extrapolation
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<TimelineClip> <>9__2_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal int <SortClipsByStartTime>b__2_0(TimelineClip clip1, TimelineClip clip2) { }

	}

	internal static readonly double kMinExtrapolationTime; //Field offset: 0x0

	private static Extrapolation() { }

	[Extension]
	internal static void CalculateExtrapolationTimes(TrackAsset asset) { }

	private static TimelineClip[] SortClipsByStartTime(TimelineClip[] clips) { }

}

