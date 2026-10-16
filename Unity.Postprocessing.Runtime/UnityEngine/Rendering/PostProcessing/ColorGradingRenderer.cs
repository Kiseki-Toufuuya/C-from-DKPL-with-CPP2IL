namespace UnityEngine.Rendering.PostProcessing;

[Preserve]
internal sealed class ColorGradingRenderer : PostProcessEffectRenderer<ColorGrading>
{
	private enum Pass
	{
		LutGenLDRFromScratch = 0,
		LutGenLDR = 1,
		LutGenHDR2D = 2,
	}

	private const int k_Lut2DSize = 32; //Field offset: 0x0
	private const int k_Lut3DSize = 33; //Field offset: 0x0
	private Texture2D m_GradingCurves; //Field offset: 0x10
	private readonly Color[] m_Pixels; //Field offset: 0x14
	private RenderTexture m_InternalLdrLut; //Field offset: 0x18
	private RenderTexture m_InternalLogLut; //Field offset: 0x1C
	private readonly HableCurve m_HableCurve; //Field offset: 0x20

	public ColorGradingRenderer() { }

	private void CheckInternalLogLut() { }

	private void CheckInternalStripLut() { }

	private static TextureFormat GetCurveFormat() { }

	private Texture2D GetCurveTexture(bool hdr) { }

	private static RenderTextureFormat GetLutFormat() { }

	private static bool IsRenderTextureFormatSupportedForLinearFiltering(RenderTextureFormat format) { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

	private void RenderExternalPipeline3D(PostProcessRenderContext context) { }

	private void RenderHDRPipeline2D(PostProcessRenderContext context) { }

	private void RenderHDRPipeline3D(PostProcessRenderContext context) { }

	private void RenderLDRPipeline2D(PostProcessRenderContext context) { }

}

