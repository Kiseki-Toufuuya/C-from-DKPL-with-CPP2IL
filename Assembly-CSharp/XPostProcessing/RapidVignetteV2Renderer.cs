namespace XPostProcessing;

public sealed class RapidVignetteV2Renderer : PostProcessEffectRenderer<RapidVignetteV2>
{
	private const string PROFILER_TAG = "X-RapidVignetteV2"; //Field offset: 0x0
	private Shader shader; //Field offset: 0x10

	public RapidVignetteV2Renderer() { }

	public virtual void Init() { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

}

