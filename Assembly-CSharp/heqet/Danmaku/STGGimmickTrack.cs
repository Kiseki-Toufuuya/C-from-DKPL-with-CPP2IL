namespace Heqet.Danmaku;

[TrackBindingType(typeof(StageController))]
[TrackClipType(typeof(STGGMoveQuickly1PlayableAsset))]
[TrackClipType(typeof(STGGMoveQuickly2PlayableAsset))]
[TrackClipType(typeof(STGGMoveQuickly3PlayableAsset))]
[TrackColor(0, 0, 255)]
public class STGGimmickTrack : TrackAsset
{

	public STGGimmickTrack() { }

	public virtual Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount) { }

	protected virtual void OnCreateClip(TimelineClip clip) { }

	private void RenameClipDisplayName(TimelineClip clip) { }

}

