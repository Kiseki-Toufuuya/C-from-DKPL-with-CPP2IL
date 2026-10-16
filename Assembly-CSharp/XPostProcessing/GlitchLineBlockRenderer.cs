namespace XPostProcessing;

public sealed class GlitchLineBlockRenderer : PostProcessEffectRenderer<GlitchLineBlock>
{
	private static class ShaderIDs
	{
		internal static readonly int Params; //Field offset: 0x0
		internal static readonly int Params2; //Field offset: 0x4

		private static ShaderIDs() { }

	}

	private const string PROFILER_TAG = "X-GlitchLineBlock"; //Field offset: 0x0
	private Shader shader; //Field offset: 0x10
	private float TimeX; //Field offset: 0x14
	private float randomFrequency; //Field offset: 0x18
	private int frameCount; //Field offset: 0x1C

	public GlitchLineBlockRenderer() { }

	public virtual void Init() { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

	private void UpdateFrequency(PropertySheet sheet) { }

}

