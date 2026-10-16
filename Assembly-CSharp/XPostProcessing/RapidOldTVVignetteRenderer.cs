namespace XPostProcessing;

public sealed class RapidOldTVVignetteRenderer : PostProcessEffectRenderer<RapidOldTVVignette>
{
	private const string PROFILER_TAG = "X-RapidOldTVVignette"; //Field offset: 0x0
	private Shader shader; //Field offset: 0x10

	public RapidOldTVVignetteRenderer() { }

	public virtual void Init() { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

}

