namespace XPostProcessing;

public sealed class GlitchScanLineJitterRenderer : PostProcessEffectRenderer<GlitchScanLineJitter>
{
	private static class ShaderIDs
	{
		internal static readonly int Params; //Field offset: 0x0
		internal static readonly int JitterIndensity; //Field offset: 0x4

		private static ShaderIDs() { }

	}

	private const string PROFILER_TAG = "X-GlitchScanLineJitter"; //Field offset: 0x0
	private Shader shader; //Field offset: 0x10
	private float randomFrequency; //Field offset: 0x14

	public GlitchScanLineJitterRenderer() { }

	public virtual void Init() { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

	private void UpdateFrequency(PropertySheet sheet) { }

}

