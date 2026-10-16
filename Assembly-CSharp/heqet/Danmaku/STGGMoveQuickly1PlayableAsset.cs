namespace Heqet.Danmaku;

[DisplayName("Heqet/STGGimmick/MoveQuickly1")]
public class STGGMoveQuickly1PlayableAsset : DanmakuPlayableAsset<STGGMoveQuickly1PlayableBehaviour>
{
	public STGGMoveQuickly1PlayableBehaviour Behaviour; //Field offset: 0x10

	public virtual DanmakuPlayableBehaviourBase BehaviourBase
	{
		 get { } //Length: 11
	}

	public STGGMoveQuickly1PlayableAsset() { }

	public virtual DanmakuPlayableBehaviourBase get_BehaviourBase() { }

	protected virtual void OnCreatePlayable(PlayableGraph graph, GameObject owner, IPlayableBehaviour playableBehaviour) { }

}

