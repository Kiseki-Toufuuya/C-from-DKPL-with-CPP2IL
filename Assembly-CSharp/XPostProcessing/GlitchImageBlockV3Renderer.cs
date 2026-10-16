namespace XPostProcessing;

public sealed class GlitchImageBlockV3Renderer : PostProcessEffectRenderer<GlitchImageBlockV3>
{
	private static class ShaderIDs
	{
		internal static readonly int Params; //Field offset: 0x0

		private static ShaderIDs() { }

	}

	private const string PROFILER_TAG = "X-GlitchImageBlockV3"; //Field offset: 0x0
	private Shader shader; //Field offset: 0x10

	public GlitchImageBlockV3Renderer() { }

	public virtual void Init() { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

}

