namespace UnityEngine.Rendering.PostProcessing;

[Preserve]
internal sealed class AmbientOcclusionRenderer : PostProcessEffectRenderer<AmbientOcclusion>
{
	private IAmbientOcclusionMethod[] m_Methods; //Field offset: 0x10

	public AmbientOcclusionRenderer() { }

	public IAmbientOcclusionMethod Get() { }

	public virtual DepthTextureMode GetCameraFlags() { }

	public MultiScaleVO GetMultiScaleVO() { }

	public ScalableAO GetScalableAO() { }

	public virtual void Init() { }

	public bool IsAmbientOnly(PostProcessRenderContext context) { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

}

