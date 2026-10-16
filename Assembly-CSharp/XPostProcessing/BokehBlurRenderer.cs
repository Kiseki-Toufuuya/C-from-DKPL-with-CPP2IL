namespace XPostProcessing;

public sealed class BokehBlurRenderer : PostProcessEffectRenderer<BokehBlur>
{
	private static class ShaderIDs
	{
		internal static readonly int GoldenRot; //Field offset: 0x0
		internal static readonly int Params; //Field offset: 0x4
		internal static readonly int BufferRT1; //Field offset: 0x8

		private static ShaderIDs() { }

	}

	private const string PROFILER_TAG = "X-BokehBlur"; //Field offset: 0x0
	private Shader shader; //Field offset: 0x10
	private Vector4 mGoldenRot; //Field offset: 0x14

	public BokehBlurRenderer() { }

	public virtual void Init() { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

}

