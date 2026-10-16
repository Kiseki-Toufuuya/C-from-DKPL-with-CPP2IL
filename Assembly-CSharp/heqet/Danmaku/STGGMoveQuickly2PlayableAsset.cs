namespace Heqet.Danmaku;

[DisplayName("Heqet/STGGimmick/MoveQuickly2")]
public class STGGMoveQuickly2PlayableAsset : DanmakuPlayableAsset<STGGMoveQuickly2PlayableBehaviour>
{
	public STGGMoveQuickly2PlayableBehaviour Behaviour; //Field offset: 0x10

	public virtual DanmakuPlayableBehaviourBase BehaviourBase
	{
		 get { } //Length: 11
	}

	public STGGMoveQuickly2PlayableAsset() { }

	public virtual DanmakuPlayableBehaviourBase get_BehaviourBase() { }

	protected virtual void OnCreatePlayable(PlayableGraph graph, GameObject owner, IPlayableBehaviour playableBehaviour) { }

}

