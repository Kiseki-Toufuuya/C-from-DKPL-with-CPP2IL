namespace XPostProcessing;

public sealed class GlitchImageBlockRenderer : PostProcessEffectRenderer<GlitchImageBlock>
{
	private static class ShaderIDs
	{
		internal static readonly int Params; //Field offset: 0x0
		internal static readonly int Params2; //Field offset: 0x4
		internal static readonly int Params3; //Field offset: 0x8

		private static ShaderIDs() { }

	}

	private const string PROFILER_TAG = "X-GlitchImageBlock"; //Field offset: 0x0
	private Shader shader; //Field offset: 0x10
	private float TimeX; //Field offset: 0x14

	public GlitchImageBlockRenderer() { }

	public virtual void Init() { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

}

