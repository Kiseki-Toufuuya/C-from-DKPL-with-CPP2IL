namespace XPostProcessing;

public sealed class IrisBlurV3Renderer : PostProcessEffectRenderer<IrisBlurV3>
{
	private static class ShaderIDs
	{
		internal static readonly int GoldenRot; //Field offset: 0x0
		internal static readonly int Gradient; //Field offset: 0x4
		internal static readonly int Params; //Field offset: 0x8
		internal static readonly int VignetteIndensity; //Field offset: 0xC
		internal static readonly int VignetteSharpness; //Field offset: 0x10

		private static ShaderIDs() { }

	}

	private const string PROFILER_TAG = "X-IrisBlurV3"; //Field offset: 0x0
	private Shader shader; //Field offset: 0x10
	private Vector4 mGoldenRot; //Field offset: 0x14

	public IrisBlurV3Renderer() { }

	public virtual void Init() { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

}

