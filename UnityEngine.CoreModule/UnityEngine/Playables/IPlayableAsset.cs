namespace UnityEngine.Playables;

public interface IPlayableAsset
{

	public double duration
	{
		 get { } //Length: 0
	}

	public Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	public double get_duration() { }

}

