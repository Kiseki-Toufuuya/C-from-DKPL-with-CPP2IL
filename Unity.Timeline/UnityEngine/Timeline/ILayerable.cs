namespace UnityEngine.Timeline;

public interface ILayerable
{

	public Playable CreateLayerMixer(PlayableGraph graph, GameObject go, int inputCount) { }

}

