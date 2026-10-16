namespace XPostProcessing;

public sealed class SharpenV3Renderer : PostProcessEffectRenderer<SharpenV3>
{
	private static class ShaderIDs
	{
		internal static readonly int CentralFactor; //Field offset: 0x0
		internal static readonly int SideFactor; //Field offset: 0x4

		private static ShaderIDs() { }

	}

	private const string PROFILER_TAG = "X-SharpenV3"; //Field offset: 0x0
	private Shader shader; //Field offset: 0x10

	public SharpenV3Renderer() { }

	public virtual void Init() { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

}

