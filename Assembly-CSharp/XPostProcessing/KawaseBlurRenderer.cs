namespace XPostProcessing;

public sealed class KawaseBlurRenderer : PostProcessEffectRenderer<KawaseBlur>
{
	private static class ShaderIDs
	{
		internal static readonly int BlurRadius; //Field offset: 0x0
		internal static readonly int BufferRT1; //Field offset: 0x4
		internal static readonly int BufferRT2; //Field offset: 0x8

		private static ShaderIDs() { }

	}

	private const string PROFILER_TAG = "X-KawaseBlur"; //Field offset: 0x0
	private Shader shader; //Field offset: 0x10

	public KawaseBlurRenderer() { }

	public virtual void Init() { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

}

