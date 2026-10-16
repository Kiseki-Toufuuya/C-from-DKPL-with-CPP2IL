namespace UnityEngine.Timeline;

[Obsolete("For best performance use PlayableAsset and PlayableBehaviour.")]
public class BasicPlayableBehaviour : ScriptableObject, IPlayableAsset, IPlayableBehaviour
{

	public override double duration
	{
		 get { } //Length: 61
	}

	public override IEnumerable<PlayableBinding> outputs
	{
		 get { } //Length: 60
	}

	public BasicPlayableBehaviour() { }

	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	public override double get_duration() { }

	public override IEnumerable<PlayableBinding> get_outputs() { }

	public override void OnBehaviourPause(Playable playable, FrameData info) { }

	public override void OnBehaviourPlay(Playable playable, FrameData info) { }

	public override void OnGraphStart(Playable playable) { }

	public override void OnGraphStop(Playable playable) { }

	public override void OnPlayableCreate(Playable playable) { }

	public override void OnPlayableDestroy(Playable playable) { }

	public override void PrepareFrame(Playable playable, FrameData info) { }

	public override void ProcessFrame(Playable playable, FrameData info, object playerData) { }

}

