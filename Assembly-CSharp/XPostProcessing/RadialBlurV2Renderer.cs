namespace XPostProcessing;

public sealed class RadialBlurV2Renderer : PostProcessEffectRenderer<RadialBlurV2>
{
	private static class ShaderIDs
	{
		internal static readonly int Params; //Field offset: 0x0

		private static ShaderIDs() { }

	}

	private const string PROFILER_TAG = "X-RadialBlurV2"; //Field offset: 0x0
	private Shader shader; //Field offset: 0x10

	public RadialBlurV2Renderer() { }

	public virtual void Init() { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

}

