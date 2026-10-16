namespace UnityEngine.Timeline;

[ExcludeFromPreset]
[HideInMenu]
[TrackBindingType(typeof(GameObject))]
public class MarkerTrack : TrackAsset
{

	public virtual IEnumerable<PlayableBinding> outputs
	{
		 get { } //Length: 462
	}

	public MarkerTrack() { }

	public virtual IEnumerable<PlayableBinding> get_outputs() { }

}

