namespace UnityEngine.Rendering.PostProcessing;

[PostProcess(typeof(DepthOfFieldRenderer), "Unity/Depth of Field", False)]
public sealed class DepthOfField : PostProcessEffectSettings
{
	[Min(0.1)]
	[Tooltip("Distance to the point of focus.")]
	public FloatParameter focusDistance; //Field offset: 0x18
	[Range(0.05, 32)]
	[Tooltip("Ratio of aperture (known as f-stop or f-number). The smaller the value is, the shallower the depth of field is.")]
	public FloatParameter aperture; //Field offset: 0x1C
	[Range(1, 300)]
	[Tooltip("Distance between the lens and the film. The larger the value is, the shallower the depth of field is.")]
	public FloatParameter focalLength; //Field offset: 0x20
	[DisplayName("Max Blur Size")]
	[Tooltip("Convolution kernel size of the bokeh filter, which determines the maximum radius of bokeh. It also affects performances (the larger the kernel is, the longer the GPU time is required).")]
	public KernelSizeParameter kernelSize; //Field offset: 0x24

	public DepthOfField() { }

	public virtual bool IsEnabledAndSupported(PostProcessRenderContext context) { }

}

