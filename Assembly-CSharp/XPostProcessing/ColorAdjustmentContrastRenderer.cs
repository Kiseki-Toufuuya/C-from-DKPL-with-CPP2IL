namespace XPostProcessing;

public sealed class ColorAdjustmentContrastRenderer : PostProcessEffectRenderer<ColorAdjustmentContrast>
{
	private const string PROFILER_TAG = "X-ColorAdjustmentContrast"; //Field offset: 0x0
	private Shader shader; //Field offset: 0x10

	public ColorAdjustmentContrastRenderer() { }

	public virtual void Init() { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

}

