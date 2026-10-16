namespace XPostProcessing;

public sealed class ColorReplaceRenderer : PostProcessEffectRenderer<ColorReplace>
{
	private const string PROFILER_TAG = "X-ColorReplace"; //Field offset: 0x0
	private Shader shader; //Field offset: 0x10

	public ColorReplaceRenderer() { }

	public virtual void Init() { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

}

