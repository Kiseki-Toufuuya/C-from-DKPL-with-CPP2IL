namespace XPostProcessing;

public sealed class ColorAdjustmentContrastV3Renderer : PostProcessEffectRenderer<ColorAdjustmentContrastV3>
{
	private const string PROFILER_TAG = "X-ColorAdjustmentContrastV3"; //Field offset: 0x0
	private Shader shader; //Field offset: 0x10

	public ColorAdjustmentContrastV3Renderer() { }

	public virtual void Init() { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

}

