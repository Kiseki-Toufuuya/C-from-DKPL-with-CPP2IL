namespace UnityEngine.Rendering.PostProcessing;

[Preserve]
internal sealed class BloomRenderer : PostProcessEffectRenderer<Bloom>
{
	private struct Level
	{
		internal int down; //Field offset: 0x0
		internal int up; //Field offset: 0x4

	}

	private enum Pass
	{
		Prefilter13 = 0,
		Prefilter4 = 1,
		Downsample13 = 2,
		Downsample4 = 3,
		UpsampleTent = 4,
		UpsampleBox = 5,
		DebugOverlayThreshold = 6,
		DebugOverlayTent = 7,
		DebugOverlayBox = 8,
	}

	private const int k_MaxPyramidSize = 16; //Field offset: 0x0
	private Level[] m_Pyramid; //Field offset: 0x10

	public BloomRenderer() { }

	public virtual void Init() { }

	public virtual void Render(PostProcessRenderContext context) { }

}

