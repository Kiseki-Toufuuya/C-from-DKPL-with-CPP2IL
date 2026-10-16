namespace XPostProcessing;

public sealed class GlitchScreenJumpRenderer : PostProcessEffectRenderer<GlitchScreenJump>
{
	private static class ShaderIDs
	{
		internal static readonly int Params; //Field offset: 0x0

		private static ShaderIDs() { }

	}

	private Shader shader; //Field offset: 0x10
	private float ScreenJumpTime; //Field offset: 0x14

	public GlitchScreenJumpRenderer() { }

	public virtual void Init() { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

}

