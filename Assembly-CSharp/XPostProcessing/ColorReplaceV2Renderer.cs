namespace XPostProcessing;

public sealed class ColorReplaceV2Renderer : PostProcessEffectRenderer<ColorReplaceV2>
{
	private static class ShaderIDs
	{
		internal static readonly int FromColor; //Field offset: 0x0
		internal static readonly int ToColor; //Field offset: 0x4
		internal static readonly int Range; //Field offset: 0x8
		internal static readonly int Fuzziness; //Field offset: 0xC

		private static ShaderIDs() { }

	}

	private const string PROFILER_TAG = "X-ColorReplaceV2"; //Field offset: 0x0
	private Shader shader; //Field offset: 0x10
	private float TimeX; //Field offset: 0x14

	public ColorReplaceV2Renderer() { }

	public virtual void Init() { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

}

