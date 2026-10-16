namespace UnityEngine.Rendering.PostProcessing;

internal sealed class LogHistogram
{
	public const int rangeMin = -9; //Field offset: 0x0
	public const int rangeMax = 9; //Field offset: 0x0
	private const int k_Bins = 128; //Field offset: 0x0
	[CompilerGenerated]
	private ComputeBuffer <data>k__BackingField; //Field offset: 0x8

	public private ComputeBuffer data
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public LogHistogram() { }

	public void Generate(PostProcessRenderContext context) { }

	[CompilerGenerated]
	public ComputeBuffer get_data() { }

	public Vector4 GetHistogramScaleOffsetRes(PostProcessRenderContext context) { }

	public void Release() { }

	[CompilerGenerated]
	private void set_data(ComputeBuffer value) { }

}

