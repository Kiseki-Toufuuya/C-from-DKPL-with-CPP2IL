namespace XPostProcessing;

public sealed class PixelizeTriangleRenderer : PostProcessEffectRenderer<PixelizeTriangle>
{
	private static class ShaderIDs
	{
		internal static readonly int Params; //Field offset: 0x0

		private static ShaderIDs() { }

	}

	private const string PROFILER_TAG = "X-PixelizeTriangle"; //Field offset: 0x0
	private Shader shader; //Field offset: 0x10

	public PixelizeTriangleRenderer() { }

	public virtual void Init() { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

}

