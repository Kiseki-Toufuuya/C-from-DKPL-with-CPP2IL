namespace XPostProcessing;

public sealed class ColorAdjustmentBleachBypassRenderer : PostProcessEffectRenderer<ColorAdjustmentBleachBypass>
{
	private static class ShaderIDs
	{
		internal static readonly int Indensity; //Field offset: 0x0

		private static ShaderIDs() { }

	}

	private const string PROFILER_TAG = "X-ColorAdjustmentBleachBypass"; //Field offset: 0x0
	private Shader shader; //Field offset: 0x10

	public ColorAdjustmentBleachBypassRenderer() { }

	public virtual void Init() { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

}

