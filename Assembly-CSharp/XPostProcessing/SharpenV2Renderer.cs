namespace XPostProcessing;

public sealed class SharpenV2Renderer : PostProcessEffectRenderer<SharpenV2>
{
	private static class ShaderIDs
	{
		internal static readonly int Sharpness; //Field offset: 0x0

		private static ShaderIDs() { }

	}

	private const string PROFILER_TAG = "X-SharpenV2"; //Field offset: 0x0
	private Shader shader; //Field offset: 0x10

	public SharpenV2Renderer() { }

	public virtual void Init() { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

}

