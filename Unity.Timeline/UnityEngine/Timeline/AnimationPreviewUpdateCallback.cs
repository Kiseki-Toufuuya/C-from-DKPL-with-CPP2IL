namespace UnityEngine.Timeline;

internal class AnimationPreviewUpdateCallback : ITimelineEvaluateCallback
{
	private AnimationPlayableOutput m_Output; //Field offset: 0x8
	private PlayableGraph m_Graph; //Field offset: 0x10
	private List<IAnimationWindowPreview> m_PreviewComponents; //Field offset: 0x18

	public AnimationPreviewUpdateCallback(AnimationPlayableOutput output) { }

	public override void Evaluate() { }

	private void FetchPreviewComponents() { }

}

