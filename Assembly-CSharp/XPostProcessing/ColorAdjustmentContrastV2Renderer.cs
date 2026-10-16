namespace XPostProcessing;

public sealed class ColorAdjustmentContrastV2Renderer : PostProcessEffectRenderer<ColorAdjustmentContrastV2>
{
	private const string PROFILER_TAG = "X-ColorAdjustmentContrastV2"; //Field offset: 0x0
	private Shader shader; //Field offset: 0x10

	public ColorAdjustmentContrastV2Renderer() { }

	public virtual void Init() { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

}

