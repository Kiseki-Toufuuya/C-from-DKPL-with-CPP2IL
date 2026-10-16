namespace UnityEngine.Rendering.PostProcessing;

[Preserve]
internal sealed class AutoExposureRenderer : PostProcessEffectRenderer<AutoExposure>
{
	private const int k_NumEyes = 2; //Field offset: 0x0
	private const int k_NumAutoExposureTextures = 2; //Field offset: 0x0
	private readonly RenderTexture[][] m_AutoExposurePool; //Field offset: 0x10
	private Int32[] m_AutoExposurePingPong; //Field offset: 0x14
	private RenderTexture m_CurrentAutoExposure; //Field offset: 0x18

	public AutoExposureRenderer() { }

	private void CheckTexture(int eye, int id) { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

}

