namespace Heqet.Danmaku;

public abstract class STGGMoveQuicklyBasePlayableBehaviour : DanmakuPlayableBehaviourBase
{
	public bool Reverse; //Field offset: 0x1C

	protected STGGMoveQuicklyBasePlayableBehaviour() { }

	public virtual void DestroyGimmickObject() { }

	public virtual void Prepare() { }

	public virtual void Process(FrameInfo info) { }

}

