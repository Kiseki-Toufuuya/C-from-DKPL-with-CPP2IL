namespace XPostProcessing;

public sealed class SharpenV1Renderer : PostProcessEffectRenderer<SharpenV1>
{
	private static class ShaderIDs
	{
		internal static readonly int Strength; //Field offset: 0x0
		internal static readonly int Threshold; //Field offset: 0x4

		private static ShaderIDs() { }

	}

	private const string PROFILER_TAG = "X-SharpenV1"; //Field offset: 0x0
	private Shader shader; //Field offset: 0x10

	public SharpenV1Renderer() { }

	public virtual void Init() { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

}

