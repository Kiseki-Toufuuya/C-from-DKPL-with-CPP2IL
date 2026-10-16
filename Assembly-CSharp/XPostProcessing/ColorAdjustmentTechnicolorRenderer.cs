namespace XPostProcessing;

public sealed class ColorAdjustmentTechnicolorRenderer : PostProcessEffectRenderer<ColorAdjustmentTechnicolor>
{
	private static class ShaderIDs
	{
		internal static readonly int exposure; //Field offset: 0x0
		internal static readonly int colorBalance; //Field offset: 0x4
		internal static readonly int indensity; //Field offset: 0x8

		private static ShaderIDs() { }

	}

	private const string PROFILER_TAG = "X-ColorAdjustmentTechnicolor"; //Field offset: 0x0
	private Shader shader; //Field offset: 0x10

	public ColorAdjustmentTechnicolorRenderer() { }

	public virtual void Init() { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

}

