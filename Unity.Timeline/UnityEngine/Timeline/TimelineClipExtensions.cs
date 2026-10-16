namespace UnityEngine.Timeline;

[Extension]
public static class TimelineClipExtensions
{
	private static readonly string k_UndoSetParentTrackText; //Field offset: 0x0

	private static TimelineClipExtensions() { }

	[Extension]
	public static void MoveToTrack(TimelineClip clip, TrackAsset destinationTrack) { }

	private static void MoveToTrack_Impl(TimelineClip clip, TrackAsset destinationTrack, object asset, TrackAsset parentTrack) { }

	[Extension]
	public static bool TryMoveToTrack(TimelineClip clip, TrackAsset destinationTrack) { }

}

