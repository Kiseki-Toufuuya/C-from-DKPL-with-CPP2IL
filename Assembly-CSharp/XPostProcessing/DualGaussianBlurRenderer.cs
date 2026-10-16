namespace XPostProcessing;

public sealed class DualGaussianBlurRenderer : PostProcessEffectRenderer<DualGaussianBlur>
{
	private struct Level
	{
		internal int down_vertical; //Field offset: 0x0
		internal int down_horizontal; //Field offset: 0x4
		internal int up_horizontal; //Field offset: 0x8
		internal int up_vertical; //Field offset: 0xC

	}

	private static class ShaderIDs
	{
		internal static readonly int BlurOffset; //Field offset: 0x0
		internal static readonly int BufferRT1; //Field offset: 0x4
		internal static readonly int BufferRT2; //Field offset: 0x8

		private static ShaderIDs() { }

	}

	private const string PROFILER_TAG = "X-DualGaussianBlur"; //Field offset: 0x0
	private const int k_MaxPyramidSize = 16; //Field offset: 0x0
	private Shader shader; //Field offset: 0x10
	private Level[] m_Pyramid; //Field offset: 0x14

	public DualGaussianBlurRenderer() { }

	public virtual void Init() { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

}

