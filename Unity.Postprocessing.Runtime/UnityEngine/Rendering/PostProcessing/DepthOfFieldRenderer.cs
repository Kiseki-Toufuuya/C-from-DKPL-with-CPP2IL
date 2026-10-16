namespace UnityEngine.Rendering.PostProcessing;

[Preserve]
internal sealed class DepthOfFieldRenderer : PostProcessEffectRenderer<DepthOfField>
{
	private enum Pass
	{
		CoCCalculation = 0,
		CoCTemporalFilter = 1,
		DownsampleAndPrefilter = 2,
		BokehSmallKernel = 3,
		BokehMediumKernel = 4,
		BokehLargeKernel = 5,
		BokehVeryLargeKernel = 6,
		PostFilter = 7,
		Combine = 8,
		DebugOverlay = 9,
	}

	private const int k_NumEyes = 2; //Field offset: 0x0
	private const int k_NumCoCHistoryTextures = 2; //Field offset: 0x0
	private const float k_FilmHeight = 0.024; //Field offset: 0x0
	private readonly RenderTexture[][] m_CoCHistoryTextures; //Field offset: 0x10
	private Int32[] m_HistoryPingPong; //Field offset: 0x14

	public DepthOfFieldRenderer() { }

	private float CalculateMaxCoCRadius(int screenHeight) { }

	private RenderTexture CheckHistory(int eye, int id, PostProcessRenderContext context, RenderTextureFormat format) { }

	public virtual DepthTextureMode GetCameraFlags() { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

	private RenderTextureFormat SelectFormat(RenderTextureFormat primary, RenderTextureFormat secondary) { }

}

