namespace UnityEngine.Timeline;

internal class ActivationMixerPlayable : PlayableBehaviour
{
	private PostPlaybackState m_PostPlaybackState; //Field offset: 0x8
	private bool m_BoundGameObjectInitialStateIsActive; //Field offset: 0xC
	private GameObject m_BoundGameObject; //Field offset: 0x10

	public PostPlaybackState postPlaybackState
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public ActivationMixerPlayable() { }

	public static ScriptPlayable<ActivationMixerPlayable> Create(PlayableGraph graph, int inputCount) { }

	public PostPlaybackState get_postPlaybackState() { }

	public virtual void OnPlayableDestroy(Playable playable) { }

	public virtual void ProcessFrame(Playable playable, FrameData info, object playerData) { }

	public void set_postPlaybackState(PostPlaybackState value) { }

}

