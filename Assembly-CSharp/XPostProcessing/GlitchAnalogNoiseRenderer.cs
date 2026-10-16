namespace XPostProcessing;

public sealed class GlitchAnalogNoiseRenderer : PostProcessEffectRenderer<GlitchAnalogNoise>
{
	private static class ShaderIDs
	{
		internal static readonly int Params; //Field offset: 0x0

		private static ShaderIDs() { }

	}

	private const string PROFILER_TAG = "X-GlitchAnalogNoise"; //Field offset: 0x0
	private Shader shader; //Field offset: 0x10
	private float TimeX; //Field offset: 0x14

	public GlitchAnalogNoiseRenderer() { }

	public virtual void Init() { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

}

