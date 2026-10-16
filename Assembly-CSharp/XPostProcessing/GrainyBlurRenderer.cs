namespace XPostProcessing;

public sealed class GrainyBlurRenderer : PostProcessEffectRenderer<GrainyBlur>
{
	private static class ShaderIDs
	{
		internal static readonly int Params; //Field offset: 0x0
		internal static readonly int BufferRT; //Field offset: 0x4

		private static ShaderIDs() { }

	}

	private const string PROFILER_TAG = "X-GrainyBlur"; //Field offset: 0x0
	private Shader shader; //Field offset: 0x10

	public GrainyBlurRenderer() { }

	public virtual void Init() { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

}

