namespace XPostProcessing;

public sealed class ColorAdjustmentHueRenderer : PostProcessEffectRenderer<ColorAdjustmentHue>
{
	private const string PROFILER_TAG = "X-ColorAdjustmentHue"; //Field offset: 0x0
	private Shader shader; //Field offset: 0x10

	public ColorAdjustmentHueRenderer() { }

	public virtual void Init() { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

}

