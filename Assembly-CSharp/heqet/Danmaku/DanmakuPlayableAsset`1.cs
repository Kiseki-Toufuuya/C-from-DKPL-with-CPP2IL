namespace Heqet.Danmaku;

public abstract class DanmakuPlayableAsset : DanmakuPlayableAssetBase
{

	protected DanmakuPlayableAsset`1() { }

	public virtual Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	protected override void OnCreatePlayable(PlayableGraph graph, GameObject owner, IPlayableBehaviour playableBehaviour) { }

}

