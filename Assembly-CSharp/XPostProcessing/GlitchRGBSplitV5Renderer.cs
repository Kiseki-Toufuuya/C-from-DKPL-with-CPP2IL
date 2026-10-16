namespace XPostProcessing;

public sealed class GlitchRGBSplitV5Renderer : PostProcessEffectRenderer<GlitchRGBSplitV5>
{
	private static class ShaderIDs
	{
		internal static readonly int NoiseTex; //Field offset: 0x0
		internal static readonly int Params; //Field offset: 0x4

		private static ShaderIDs() { }

	}

	private const string PROFILER_TAG = "X-GlitchRGBSplitV5"; //Field offset: 0x0
	private Shader shader; //Field offset: 0x10
	private Texture2D NoiseTex; //Field offset: 0x14

	public GlitchRGBSplitV5Renderer() { }

	public virtual void Init() { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

}

