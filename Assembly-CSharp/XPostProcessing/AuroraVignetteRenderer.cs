namespace XPostProcessing;

public sealed class AuroraVignetteRenderer : PostProcessEffectRenderer<AuroraVignette>
{
	private static class ShaderIDs
	{
		internal static readonly int vignetteArea; //Field offset: 0x0
		internal static readonly int vignetteSmothness; //Field offset: 0x4
		internal static readonly int colorChange; //Field offset: 0x8
		internal static readonly int colorFactor; //Field offset: 0xC
		internal static readonly int TimeX; //Field offset: 0x10
		internal static readonly int vignetteFading; //Field offset: 0x14

		private static ShaderIDs() { }

	}

	private const string PROFILER_TAG = "X-AuroraVignette"; //Field offset: 0x0
	private Shader shader; //Field offset: 0x10
	private float TimeX; //Field offset: 0x14

	public AuroraVignetteRenderer() { }

	public virtual void Init() { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

}

