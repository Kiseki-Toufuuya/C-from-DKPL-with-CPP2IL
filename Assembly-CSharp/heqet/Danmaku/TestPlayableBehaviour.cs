namespace Heqet.Danmaku;

public class TestPlayableBehaviour : PlayableBehaviour
{
	public GameObject owner; //Field offset: 0x8

	public TestPlayableBehaviour() { }

	public virtual void OnBehaviourPause(Playable playable, FrameData info) { }

	public virtual void OnBehaviourPlay(Playable playable, FrameData info) { }

	public virtual void PrepareFrame(Playable playable, FrameData info) { }

}

