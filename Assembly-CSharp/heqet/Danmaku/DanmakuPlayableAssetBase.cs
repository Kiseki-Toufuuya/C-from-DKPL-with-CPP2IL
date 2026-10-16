namespace Heqet.Danmaku;

public abstract class DanmakuPlayableAssetBase : PlayableAssetBase
{

	public abstract DanmakuPlayableBehaviourBase BehaviourBase
	{
		 get { } //Length: 0
	}

	protected DanmakuPlayableAssetBase() { }

	public abstract DanmakuPlayableBehaviourBase get_BehaviourBase() { }

}

