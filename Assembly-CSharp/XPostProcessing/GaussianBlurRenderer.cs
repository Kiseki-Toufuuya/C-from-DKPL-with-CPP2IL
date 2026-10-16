namespace XPostProcessing;

public sealed class GaussianBlurRenderer : PostProcessEffectRenderer<GaussianBlur>
{
	private static class ShaderIDs
	{
		internal static readonly int BlurRadius; //Field offset: 0x0
		internal static readonly int BufferRT1; //Field offset: 0x4
		internal static readonly int BufferRT2; //Field offset: 0x8

		private static ShaderIDs() { }

	}

	private const string PROFILER_TAG = "X-GaussianBlur"; //Field offset: 0x0
	private Shader shader; //Field offset: 0x10

	public GaussianBlurRenderer() { }

	public virtual void Init() { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

}

