namespace Heqet.Danmaku;

[DisplayName("Heqet/TestPlayableAsset")]
public class TestPlayableAsset : PlayableAsset
{

	public TestPlayableAsset() { }

	public virtual Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

}

