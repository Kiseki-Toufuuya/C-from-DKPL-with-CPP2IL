namespace UnityEngine.Rendering.PostProcessing;

public abstract class PostProcessEffectRenderer
{
	protected bool m_ResetHistory; //Field offset: 0x8

	protected PostProcessEffectRenderer() { }

	public override DepthTextureMode GetCameraFlags() { }

	public override void Init() { }

	public override void Release() { }

	public abstract void Render(PostProcessRenderContext context) { }

	public override void ResetHistory() { }

	internal abstract void SetSettings(PostProcessEffectSettings settings) { }

}

