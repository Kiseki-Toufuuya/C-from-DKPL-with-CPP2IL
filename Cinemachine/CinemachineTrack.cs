//Type is in global namespace

[TrackBindingType(typeof(CinemachineBrain), TrackBindingFlags::None (0))]
[TrackClipType(typeof(CinemachineShot))]
[TrackColor(0.53, 0, 0.08)]
public class CinemachineTrack : TrackAsset
{

	public CinemachineTrack() { }

	public virtual Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount) { }

}

