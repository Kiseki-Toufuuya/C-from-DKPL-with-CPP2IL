namespace XPostProcessing;

public sealed class GlitchScreenShakeRenderer : PostProcessEffectRenderer<GlitchScreenShake>
{
	private static class ShaderIDs
	{
		internal static readonly int ScreenShakeIndensity; //Field offset: 0x0

		private static ShaderIDs() { }

	}

	private Shader shader; //Field offset: 0x10

	public GlitchScreenShakeRenderer() { }

	public virtual void Init() { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

}

