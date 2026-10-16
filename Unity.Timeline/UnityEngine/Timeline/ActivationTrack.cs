namespace UnityEngine.Timeline;

[ExcludeFromPreset]
[TrackBindingType(typeof(GameObject))]
[TrackClipType(typeof(ActivationPlayableAsset))]
public class ActivationTrack : TrackAsset
{
	internal enum PostPlaybackState
	{
		Active = 0,
		Inactive = 1,
		Revert = 2,
		LeaveAsIs = 3,
	}

	[SerializeField]
	private PostPlaybackState m_PostPlaybackState; //Field offset: 0x58
	private ActivationMixerPlayable m_ActivationMixer; //Field offset: 0x5C

	public PostPlaybackState postPlaybackState
	{
		 get { } //Length: 11
		 set { } //Length: 26
	}

	public ActivationTrack() { }

	internal virtual bool CanCompileClips() { }

	public virtual Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount) { }

	public virtual void GatherProperties(PlayableDirector director, IPropertyCollector driver) { }

	public PostPlaybackState get_postPlaybackState() { }

	protected virtual void OnCreateClip(TimelineClip clip) { }

	public void set_postPlaybackState(PostPlaybackState value) { }

	internal void UpdateTrackMode() { }

}

