namespace UnityEngine.Rendering.PostProcessing;

[Preserve]
internal sealed class GrainRenderer : PostProcessEffectRenderer<Grain>
{
	private const int k_SampleCount = 1024; //Field offset: 0x0
	private RenderTexture m_GrainLookupRT; //Field offset: 0x10
	private int m_SampleIndex; //Field offset: 0x14

	public GrainRenderer() { }

	private RenderTextureFormat GetLookupFormat() { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

}

