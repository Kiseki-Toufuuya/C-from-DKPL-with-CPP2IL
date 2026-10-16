namespace XPostProcessing;

public sealed class EdgeDetectionScharrRenderer : PostProcessEffectRenderer<EdgeDetectionScharr>
{
	private static class ShaderIDs
	{
		internal static readonly int Params; //Field offset: 0x0
		internal static readonly int EdgeColor; //Field offset: 0x4
		internal static readonly int BackgroundColor; //Field offset: 0x8

		private static ShaderIDs() { }

	}

	private const string PROFILER_TAG = "X-EdgeDetectionScharr"; //Field offset: 0x0
	private Shader shader; //Field offset: 0x10

	public EdgeDetectionScharrRenderer() { }

	public virtual void Init() { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

}

