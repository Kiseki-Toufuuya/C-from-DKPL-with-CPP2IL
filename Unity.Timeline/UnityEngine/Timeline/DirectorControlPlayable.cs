namespace UnityEngine.Timeline;

public class DirectorControlPlayable : PlayableBehaviour
{
	internal enum PauseAction
	{
		StopDirector = 0,
		PauseDirector = 1,
	}

	public PlayableDirector director; //Field offset: 0x8
	public PauseAction pauseAction; //Field offset: 0xC
	private bool m_SyncTime; //Field offset: 0x10
	private double m_AssetDuration; //Field offset: 0x18

	public DirectorControlPlayable() { }

	public static ScriptPlayable<DirectorControlPlayable> Create(PlayableGraph graph, PlayableDirector director) { }

	private bool DetectDiscontinuity(Playable playable, FrameData info) { }

	private bool DetectOutOfSync(Playable playable) { }

	public virtual void OnBehaviourPause(Playable playable, FrameData info) { }

	public virtual void OnBehaviourPlay(Playable playable, FrameData info) { }

	public virtual void OnPlayableDestroy(Playable playable) { }

	public virtual void PrepareFrame(Playable playable, FrameData info) { }

	public virtual void ProcessFrame(Playable playable, FrameData info, object playerData) { }

	private void SyncSpeed(double speed) { }

	private void SyncStart(PlayableGraph graph, double time) { }

	private void SyncStop(PlayableGraph graph, double time) { }

	private void UpdateTime(Playable playable) { }

}

