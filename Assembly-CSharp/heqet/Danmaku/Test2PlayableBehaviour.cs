namespace Heqet.Danmaku;

public class Test2PlayableBehaviour : PlayableBehaviour
{
	public GameObject owner; //Field offset: 0x8

	public Test2PlayableBehaviour() { }

	public virtual void OnBehaviourPause(Playable playable, FrameData info) { }

	public virtual void OnBehaviourPlay(Playable playable, FrameData info) { }

	public virtual void PrepareFrame(Playable playable, FrameData info) { }

}

