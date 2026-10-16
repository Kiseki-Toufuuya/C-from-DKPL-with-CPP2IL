namespace XPostProcessing;

public sealed class PixelizeCircleRenderer : PostProcessEffectRenderer<PixelizeCircle>
{
	private static class ShaderIDs
	{
		internal static readonly int Params; //Field offset: 0x0
		internal static readonly int Params2; //Field offset: 0x4
		internal static readonly int BackgroundColor; //Field offset: 0x8

		private static ShaderIDs() { }

	}

	private const string PROFILER_TAG = "X-PixelizeCircle"; //Field offset: 0x0
	private Shader shader; //Field offset: 0x10

	public PixelizeCircleRenderer() { }

	public virtual void Init() { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

}

