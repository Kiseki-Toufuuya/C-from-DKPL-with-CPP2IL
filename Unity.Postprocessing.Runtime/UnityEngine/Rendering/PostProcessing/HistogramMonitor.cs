namespace UnityEngine.Rendering.PostProcessing;

public sealed class HistogramMonitor : Monitor
{
	internal enum Channel
	{
		Red = 0,
		Green = 1,
		Blue = 2,
		Master = 3,
	}

	private const int k_NumBins = 256; //Field offset: 0x0
	private const int k_ThreadGroupSizeX = 16; //Field offset: 0x0
	private const int k_ThreadGroupSizeY = 16; //Field offset: 0x0
	public int width; //Field offset: 0x10
	public int height; //Field offset: 0x14
	public Channel channel; //Field offset: 0x18
	private ComputeBuffer m_Data; //Field offset: 0x1C

	public HistogramMonitor() { }

	internal virtual bool NeedsHalfRes() { }

	internal virtual void OnDisable() { }

	internal virtual void Render(PostProcessRenderContext context) { }

	internal virtual bool ShaderResourcesAvailable(PostProcessRenderContext context) { }

}

