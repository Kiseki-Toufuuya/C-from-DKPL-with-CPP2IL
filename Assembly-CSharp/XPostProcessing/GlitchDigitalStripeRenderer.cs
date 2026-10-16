namespace XPostProcessing;

public sealed class GlitchDigitalStripeRenderer : PostProcessEffectRenderer<GlitchDigitalStripe>
{
	private static class ShaderIDs
	{
		internal static readonly int indensity; //Field offset: 0x0
		internal static readonly int noiseTex; //Field offset: 0x4
		internal static readonly int StripColorAdjustColor; //Field offset: 0x8
		internal static readonly int StripColorAdjustIndensity; //Field offset: 0xC

		private static ShaderIDs() { }

	}

	private const string PROFILER_TAG = "X-GlitchDigitalStripe"; //Field offset: 0x0
	private Shader shader; //Field offset: 0x10
	private Texture2D _noiseTexture; //Field offset: 0x14
	private RenderTexture _trashFrame1; //Field offset: 0x18
	private RenderTexture _trashFrame2; //Field offset: 0x1C

	public GlitchDigitalStripeRenderer() { }

	public virtual void Init() { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

	private void UpdateNoiseTexture(int frame, int noiseTextureWidth, int noiseTextureHeight, float stripLength) { }

}

