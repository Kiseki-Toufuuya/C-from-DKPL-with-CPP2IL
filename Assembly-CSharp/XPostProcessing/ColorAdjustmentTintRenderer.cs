namespace XPostProcessing;

public sealed class ColorAdjustmentTintRenderer : PostProcessEffectRenderer<ColorAdjustmentTint>
{
	private const string PROFILER_TAG = "X-ColorAdjustmentTint"; //Field offset: 0x0
	private Shader shader; //Field offset: 0x10

	public ColorAdjustmentTintRenderer() { }

	public virtual void Init() { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

}

