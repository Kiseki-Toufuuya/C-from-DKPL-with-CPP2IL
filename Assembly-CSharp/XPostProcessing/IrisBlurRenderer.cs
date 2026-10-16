namespace XPostProcessing;

public sealed class IrisBlurRenderer : PostProcessEffectRenderer<IrisBlur>
{
	private static class ShaderIDs
	{
		internal static readonly int Params; //Field offset: 0x0
		internal static readonly int BlurredTex; //Field offset: 0x4
		internal static readonly int BufferRT1; //Field offset: 0x8
		internal static readonly int BufferRT2; //Field offset: 0xC

		private static ShaderIDs() { }

	}

	private const string PROFILER_TAG = "X-IrisBlur"; //Field offset: 0x0
	private Shader shader; //Field offset: 0x10

	public IrisBlurRenderer() { }

	private void HandleMultipleIterationBlur(PostProcessRenderContext context, CommandBuffer cmd, PropertySheet sheet, int Iteration) { }

	private void HandleOneBlitBlur(PostProcessRenderContext context, CommandBuffer cmd, PropertySheet sheet) { }

	public virtual void Init() { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

}

