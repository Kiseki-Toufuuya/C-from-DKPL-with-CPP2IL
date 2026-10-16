namespace XPostProcessing;

public sealed class EdgeDetectionRobertsNeonV2Renderer : PostProcessEffectRenderer<EdgeDetectionRobertsNeonV2>
{
	private static class ShaderIDs
	{
		internal static readonly int Params; //Field offset: 0x0
		internal static readonly int BackgroundColor; //Field offset: 0x4

		private static ShaderIDs() { }

	}

	private const string PROFILER_TAG = "X-EdgeDetectionRobertsNeonV2"; //Field offset: 0x0
	private Shader shader; //Field offset: 0x10

	public EdgeDetectionRobertsNeonV2Renderer() { }

	public virtual void Init() { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

}

