namespace XPostProcessing;

public sealed class GlitchTileJitterRenderer : PostProcessEffectRenderer<GlitchTileJitter>
{
	private static class ShaderIDs
	{
		internal static readonly int Params; //Field offset: 0x0

		private static ShaderIDs() { }

	}

	private const string PROFILER_TAG = "X-GlitchTileJitter"; //Field offset: 0x0
	private Shader shader; //Field offset: 0x10
	private float randomFrequency; //Field offset: 0x14

	public GlitchTileJitterRenderer() { }

	public virtual void Init() { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

	private void UpdateFrequency(PropertySheet sheet) { }

}

