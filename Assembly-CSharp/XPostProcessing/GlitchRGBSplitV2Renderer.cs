namespace XPostProcessing;

public sealed class GlitchRGBSplitV2Renderer : PostProcessEffectRenderer<GlitchRGBSplitV2>
{
	private static class ShaderIDs
	{
		internal static readonly int Params; //Field offset: 0x0

		private static ShaderIDs() { }

	}

	private const string PROFILER_TAG = "X-GlitchRGBSplitV2"; //Field offset: 0x0
	private Shader shader; //Field offset: 0x10
	private float TimeX; //Field offset: 0x14

	public GlitchRGBSplitV2Renderer() { }

	public virtual void Init() { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

}

