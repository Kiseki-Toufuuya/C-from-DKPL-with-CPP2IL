namespace UnityEngine.Timeline;

[ExcludeFromPreset]
[SupportsChildTracks((Type) null, 2147483647)]
[TrackClipType(typeof(TrackAsset))]
public class GroupTrack : TrackAsset
{

	public virtual IEnumerable<PlayableBinding> outputs
	{
		 get { } //Length: 60
	}

	public GroupTrack() { }

	internal virtual bool CanCompileClips() { }

	public virtual IEnumerable<PlayableBinding> get_outputs() { }

}

