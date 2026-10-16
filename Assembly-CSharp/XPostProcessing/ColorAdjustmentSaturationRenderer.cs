namespace XPostProcessing;

public sealed class ColorAdjustmentSaturationRenderer : PostProcessEffectRenderer<ColorAdjustmentSaturation>
{
	private const string PROFILER_TAG = "X-ColorAdjustmentSaturation"; //Field offset: 0x0
	private Shader shader; //Field offset: 0x10

	public ColorAdjustmentSaturationRenderer() { }

	public virtual void Init() { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

}

