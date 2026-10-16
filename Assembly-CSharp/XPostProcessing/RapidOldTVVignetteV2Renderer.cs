namespace XPostProcessing;

public sealed class RapidOldTVVignetteV2Renderer : PostProcessEffectRenderer<RapidOldTVVignetteV2>
{
	private const string PROFILER_TAG = "X-GlitchLineBlock"; //Field offset: 0x0
	private Shader shader; //Field offset: 0x10

	public RapidOldTVVignetteV2Renderer() { }

	public virtual void Init() { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

}

