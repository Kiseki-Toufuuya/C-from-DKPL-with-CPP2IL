namespace XPostProcessing;

public sealed class DualTentBlurRenderer : PostProcessEffectRenderer<DualTentBlur>
{
	private struct Level
	{
		internal int down; //Field offset: 0x0
		internal int up; //Field offset: 0x4

	}

	private static class ShaderIDs
	{
		internal static readonly int BlurOffset; //Field offset: 0x0
		internal static readonly int BufferRT1; //Field offset: 0x4
		internal static readonly int BufferRT2; //Field offset: 0x8

		private static ShaderIDs() { }

	}

	private const string PROFILER_TAG = "X-DualTentBlur"; //Field offset: 0x0
	private const int k_MaxPyramidSize = 16; //Field offset: 0x0
	private Shader shader; //Field offset: 0x10
	private Level[] m_Pyramid; //Field offset: 0x14

	public DualTentBlurRenderer() { }

	public virtual void Init() { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

}

