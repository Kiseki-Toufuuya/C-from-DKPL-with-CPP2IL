namespace Heqet.Danmaku;

[TrackBindingType(typeof(GameObject))]
[TrackClipType(typeof(Test2PlayableAsset))]
[TrackColor(255, 0, 0)]
public class Test2PlayableTrack : TrackAsset
{

	public Test2PlayableTrack() { }

	protected virtual Playable CreatePlayable(PlayableGraph graph, GameObject go, TimelineClip clip) { }

}

