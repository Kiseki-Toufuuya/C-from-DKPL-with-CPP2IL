namespace XPostProcessing;

public sealed class DirectionalBlurRenderer : PostProcessEffectRenderer<DirectionalBlur>
{
	private static class ShaderIDs
	{
		internal static readonly int Params; //Field offset: 0x0
		internal static readonly int BufferRT; //Field offset: 0x4

		private static ShaderIDs() { }

	}

	private const string PROFILER_TAG = "X-DirectionalBlur"; //Field offset: 0x0
	private Shader shader; //Field offset: 0x10

	public DirectionalBlurRenderer() { }

	public virtual void Init() { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

}

