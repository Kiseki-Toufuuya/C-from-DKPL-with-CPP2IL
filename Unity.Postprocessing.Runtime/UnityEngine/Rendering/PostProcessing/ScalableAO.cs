namespace UnityEngine.Rendering.PostProcessing;

[Preserve]
internal sealed class ScalableAO : IAmbientOcclusionMethod
{
	private enum Pass
	{
		OcclusionEstimationForward = 0,
		OcclusionEstimationDeferred = 1,
		HorizontalBlurForward = 2,
		HorizontalBlurDeferred = 3,
		VerticalBlur = 4,
		CompositionForward = 5,
		CompositionDeferred = 6,
		DebugOverlay = 7,
	}

	private RenderTexture m_Result; //Field offset: 0x8
	private PropertySheet m_PropertySheet; //Field offset: 0xC
	private AmbientOcclusion m_Settings; //Field offset: 0x10
	private readonly RenderTargetIdentifier[] m_MRT; //Field offset: 0x14
	private readonly Int32[] m_SampleCount; //Field offset: 0x18

	public ScalableAO(AmbientOcclusion settings) { }

	public override void CompositeAmbientOnly(PostProcessRenderContext context) { }

	private void DoLazyInitialization(PostProcessRenderContext context) { }

	public override DepthTextureMode GetCameraFlags() { }

	public override void Release() { }

	private void Render(PostProcessRenderContext context, CommandBuffer cmd, int occlusionSource) { }

	public override void RenderAfterOpaque(PostProcessRenderContext context) { }

	public override void RenderAmbientOnly(PostProcessRenderContext context) { }

}

