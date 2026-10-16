namespace XPostProcessing;

public sealed class EdgeDetectionSobelNeonRenderer : PostProcessEffectRenderer<EdgeDetectionSobelNeon>
{
	private static class ShaderIDs
	{
		internal static readonly int Params; //Field offset: 0x0
		internal static readonly int BackgroundColor; //Field offset: 0x4

		private static ShaderIDs() { }

	}

	private const string PROFILER_TAG = "X-EdgeDetectionSobelNeon"; //Field offset: 0x0
	private Shader shader; //Field offset: 0x10

	public EdgeDetectionSobelNeonRenderer() { }

	public virtual void Init() { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

}

