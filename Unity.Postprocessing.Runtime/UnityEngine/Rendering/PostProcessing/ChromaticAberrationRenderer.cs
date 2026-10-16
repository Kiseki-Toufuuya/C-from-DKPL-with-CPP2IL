namespace UnityEngine.Rendering.PostProcessing;

[Preserve]
internal sealed class ChromaticAberrationRenderer : PostProcessEffectRenderer<ChromaticAberration>
{
	private Texture2D m_InternalSpectralLut; //Field offset: 0x10

	public ChromaticAberrationRenderer() { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

}

