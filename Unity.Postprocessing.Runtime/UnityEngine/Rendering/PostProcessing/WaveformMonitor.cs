namespace UnityEngine.Rendering.PostProcessing;

public sealed class WaveformMonitor : Monitor
{
	private const int k_ThreadGroupSize = 256; //Field offset: 0x0
	private const int k_ThreadGroupSizeX = 16; //Field offset: 0x0
	private const int k_ThreadGroupSizeY = 16; //Field offset: 0x0
	public float exposure; //Field offset: 0x10
	public int height; //Field offset: 0x14
	private ComputeBuffer m_Data; //Field offset: 0x18

	public WaveformMonitor() { }

	internal virtual bool NeedsHalfRes() { }

	internal virtual void OnDisable() { }

	internal virtual void Render(PostProcessRenderContext context) { }

	internal virtual bool ShaderResourcesAvailable(PostProcessRenderContext context) { }

}

