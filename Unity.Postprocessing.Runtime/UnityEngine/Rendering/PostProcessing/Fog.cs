namespace UnityEngine.Rendering.PostProcessing;

[Preserve]
public sealed class Fog
{
	[Tooltip("Enables the internal deferred fog pass. Actual fog settings should be set in the Lighting panel.")]
	public bool enabled; //Field offset: 0x8
	[Tooltip("Mark true for the fog to ignore the skybox")]
	public bool excludeSkybox; //Field offset: 0x9

	public Fog() { }

	internal DepthTextureMode GetCameraFlags() { }

	internal bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	internal void Render(PostProcessRenderContext context) { }

}

