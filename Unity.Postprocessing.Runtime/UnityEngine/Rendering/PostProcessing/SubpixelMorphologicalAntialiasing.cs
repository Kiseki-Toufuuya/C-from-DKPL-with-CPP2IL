namespace UnityEngine.Rendering.PostProcessing;

[Preserve]
public sealed class SubpixelMorphologicalAntialiasing
{
	private enum Pass
	{
		EdgeDetection = 0,
		BlendWeights = 3,
		NeighborhoodBlending = 6,
	}

	internal enum Quality
	{
		Low = 0,
		Medium = 1,
		High = 2,
	}

	[Tooltip("Lower quality is faster at the expense of visual quality (Low = ~60%, Medium = ~80%).")]
	public Quality quality; //Field offset: 0x8

	public SubpixelMorphologicalAntialiasing() { }

	public bool IsSupported() { }

	internal void Render(PostProcessRenderContext context) { }

}

