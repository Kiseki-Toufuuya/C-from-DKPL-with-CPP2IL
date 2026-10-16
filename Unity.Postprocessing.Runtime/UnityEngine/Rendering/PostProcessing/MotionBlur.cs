namespace UnityEngine.Rendering.PostProcessing;

[PostProcess(typeof(MotionBlurRenderer), "Unity/Motion Blur", False)]
public sealed class MotionBlur : PostProcessEffectSettings
{
	[Range(0, 360)]
	[Tooltip("The angle of rotary shutter. Larger values give longer exposure.")]
	public FloatParameter shutterAngle; //Field offset: 0x18
	[Range(4, 32)]
	[Tooltip("The amount of sample points. This affects quality and performance.")]
	public IntParameter sampleCount; //Field offset: 0x1C

	public MotionBlur() { }

	public virtual bool IsEnabledAndSupported(PostProcessRenderContext context) { }

}

