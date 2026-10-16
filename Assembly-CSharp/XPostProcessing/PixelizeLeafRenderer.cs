namespace XPostProcessing;

public sealed class PixelizeLeafRenderer : PostProcessEffectRenderer<PixelizeLeaf>
{
	private static class ShaderIDs
	{
		internal static readonly int Params; //Field offset: 0x0

		private static ShaderIDs() { }

	}

	private const string PROFILER_TAG = "X-PixelizeLeaf"; //Field offset: 0x0
	private Shader shader; //Field offset: 0x10

	public PixelizeLeafRenderer() { }

	public virtual void Init() { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

}

