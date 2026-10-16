namespace XPostProcessing;

public sealed class RapidVignetteRenderer : PostProcessEffectRenderer<RapidVignette>
{
	private const string PROFILER_TAG = "X-RapidVignette"; //Field offset: 0x0
	private Shader shader; //Field offset: 0x10

	public RapidVignetteRenderer() { }

	public virtual void Init() { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

}

