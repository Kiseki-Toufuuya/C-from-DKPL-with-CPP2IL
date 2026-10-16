namespace XPostProcessing;

public sealed class PixelizeDiamondRenderer : PostProcessEffectRenderer<PixelizeDiamond>
{
	private static class ShaderIDs
	{
		internal static readonly int PixelSize; //Field offset: 0x0

		private static ShaderIDs() { }

	}

	private const string PROFILER_TAG = "X-PixelizeDiamond"; //Field offset: 0x0
	private Shader shader; //Field offset: 0x10

	public PixelizeDiamondRenderer() { }

	public virtual void Init() { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

}

