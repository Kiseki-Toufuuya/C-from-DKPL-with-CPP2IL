namespace UnityEngine.Timeline;

public class ActivationControlPlayable : PlayableBehaviour
{
	private enum InitialState
	{
		Unset = 0,
		Active = 1,
		Inactive = 2,
	}

	internal enum PostPlaybackState
	{
		Active = 0,
		Inactive = 1,
		Revert = 2,
	}

	public GameObject gameObject; //Field offset: 0x8
	public PostPlaybackState postPlayback; //Field offset: 0xC
	private InitialState m_InitialState; //Field offset: 0x10

	public ActivationControlPlayable() { }

	public static ScriptPlayable<ActivationControlPlayable> Create(PlayableGraph graph, GameObject gameObject, PostPlaybackState postPlaybackState) { }

	public virtual void OnBehaviourPause(Playable playable, FrameData info) { }

	public virtual void OnBehaviourPlay(Playable playable, FrameData info) { }

	public virtual void OnGraphStart(Playable playable) { }

	public virtual void OnPlayableDestroy(Playable playable) { }

	public virtual void ProcessFrame(Playable playable, FrameData info, object userData) { }

}

