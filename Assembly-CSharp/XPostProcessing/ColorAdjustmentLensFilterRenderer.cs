namespace XPostProcessing;

public sealed class ColorAdjustmentLensFilterRenderer : PostProcessEffectRenderer<ColorAdjustmentLensFilter>
{
	private static class ShaderIDs
	{
		internal static readonly int LensColor; //Field offset: 0x0
		internal static readonly int Indensity; //Field offset: 0x4

		private static ShaderIDs() { }

	}

	private const string PROFILER_TAG = "X-ColorAdjustmentLensFilter"; //Field offset: 0x0
	private Shader shader; //Field offset: 0x10

	public ColorAdjustmentLensFilterRenderer() { }

	public virtual void Init() { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

}

