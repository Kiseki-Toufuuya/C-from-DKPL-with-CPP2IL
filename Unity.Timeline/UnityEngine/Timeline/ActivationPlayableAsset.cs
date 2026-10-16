namespace UnityEngine.Timeline;

internal class ActivationPlayableAsset : PlayableAsset, ITimelineClipAsset
{

	public override ClipCaps clipCaps
	{
		 get { } //Length: 3
	}

	public ActivationPlayableAsset() { }

	public virtual Playable CreatePlayable(PlayableGraph graph, GameObject go) { }

	public override ClipCaps get_clipCaps() { }

}

