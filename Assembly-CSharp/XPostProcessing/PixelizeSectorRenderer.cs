namespace XPostProcessing;

public sealed class PixelizeSectorRenderer : PostProcessEffectRenderer<PixelizeSector>
{
	private static class ShaderIDs
	{
		internal static readonly int Params; //Field offset: 0x0
		internal static readonly int Params2; //Field offset: 0x4

		private static ShaderIDs() { }

	}

	private const string PROFILER_TAG = "X-PixelizeSector"; //Field offset: 0x0
	private Shader shader; //Field offset: 0x10

	public PixelizeSectorRenderer() { }

	public virtual void Init() { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

}

