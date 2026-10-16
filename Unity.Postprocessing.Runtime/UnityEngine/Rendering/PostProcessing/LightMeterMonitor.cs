namespace UnityEngine.Rendering.PostProcessing;

public sealed class LightMeterMonitor : Monitor
{
	public int width; //Field offset: 0x10
	public int height; //Field offset: 0x14
	public bool showCurves; //Field offset: 0x18

	public LightMeterMonitor() { }

	internal virtual void Render(PostProcessRenderContext context) { }

	internal virtual bool ShaderResourcesAvailable(PostProcessRenderContext context) { }

}

