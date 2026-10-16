namespace XPostProcessing;

public sealed class IrisBlurV2Renderer : PostProcessEffectRenderer<IrisBlurV2>
{
	private static class ShaderIDs
	{
		internal static readonly int GoldenRot; //Field offset: 0x0
		internal static readonly int Gradient; //Field offset: 0x4
		internal static readonly int Params; //Field offset: 0x8

		private static ShaderIDs() { }

	}

	private const string PROFILER_TAG = "X-IrisBlurV2"; //Field offset: 0x0
	private Shader shader; //Field offset: 0x10
	private Vector4 mGoldenRot; //Field offset: 0x14

	public IrisBlurV2Renderer() { }

	public virtual void Init() { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

}

