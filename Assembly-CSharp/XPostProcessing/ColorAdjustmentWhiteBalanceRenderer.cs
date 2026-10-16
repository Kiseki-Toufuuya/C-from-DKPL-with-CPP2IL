namespace XPostProcessing;

public sealed class ColorAdjustmentWhiteBalanceRenderer : PostProcessEffectRenderer<ColorAdjustmentWhiteBalance>
{
	private const string PROFILER_TAG = "X-ColorAdjustmentWhiteBalance"; //Field offset: 0x0
	private Shader shader; //Field offset: 0x10

	public ColorAdjustmentWhiteBalanceRenderer() { }

	public virtual void Init() { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

}

