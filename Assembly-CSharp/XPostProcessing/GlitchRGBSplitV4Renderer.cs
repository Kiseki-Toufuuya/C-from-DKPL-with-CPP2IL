namespace XPostProcessing;

public sealed class GlitchRGBSplitV4Renderer : PostProcessEffectRenderer<GlitchRGBSplitV4>
{
	private static class ShaderIDs
	{
		internal static readonly int Params; //Field offset: 0x0

		private static ShaderIDs() { }

	}

	private const string PROFILER_TAG = "X-GlitchRGBSplitV4"; //Field offset: 0x0
	private Shader shader; //Field offset: 0x10
	private float randomFrequency; //Field offset: 0x14
	private float TimeX; //Field offset: 0x18

	public GlitchRGBSplitV4Renderer() { }

	public virtual void Init() { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

}

