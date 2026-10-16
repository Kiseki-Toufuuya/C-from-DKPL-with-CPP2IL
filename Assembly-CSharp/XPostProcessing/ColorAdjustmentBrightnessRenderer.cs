namespace XPostProcessing;

public sealed class ColorAdjustmentBrightnessRenderer : PostProcessEffectRenderer<ColorAdjustmentBrightness>
{
	private static class ShaderIDs
	{
		internal static readonly int brightness; //Field offset: 0x0

		private static ShaderIDs() { }

	}

	private const string PROFILER_TAG = "X-ColorAdjustmentBrightness"; //Field offset: 0x0
	private Shader shader; //Field offset: 0x10

	public ColorAdjustmentBrightnessRenderer() { }

	public virtual void Init() { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

}

