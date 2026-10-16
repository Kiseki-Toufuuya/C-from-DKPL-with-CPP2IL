namespace UnityEngine.Rendering.PostProcessing;

internal interface IAmbientOcclusionMethod
{

	public void CompositeAmbientOnly(PostProcessRenderContext context) { }

	public DepthTextureMode GetCameraFlags() { }

	public void Release() { }

	public void RenderAfterOpaque(PostProcessRenderContext context) { }

	public void RenderAmbientOnly(PostProcessRenderContext context) { }

}

