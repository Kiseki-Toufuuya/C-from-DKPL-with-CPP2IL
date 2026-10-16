namespace UnityEngine.Timeline;

internal class AnimationOutputWeightProcessor : ITimelineEvaluateCallback
{
	private struct WeightInfo
	{
		public Playable mixer; //Field offset: 0x0
		public Playable parentMixer; //Field offset: 0x8
		public int port; //Field offset: 0x10

	}

	private AnimationPlayableOutput m_Output; //Field offset: 0x8
	private AnimationMotionXToDeltaPlayable m_MotionXPlayable; //Field offset: 0x10
	private readonly List<WeightInfo> m_Mixers; //Field offset: 0x18

	public AnimationOutputWeightProcessor(AnimationPlayableOutput output) { }

	public override void Evaluate() { }

	private void FindMixers() { }

	private void FindMixers(Playable parent, int port, Playable node) { }

}

