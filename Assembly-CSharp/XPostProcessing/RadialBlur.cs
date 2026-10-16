namespace XPostProcessing;

[PostProcess(typeof(RadialBlurRenderer), PostProcessEvent::AfterStack (2), "X-PostProcessing/Blur/RadialBlur/RadialBlurV1", True)]
public class RadialBlur : PostProcessEffectSettings
{
	[Range(0, 1)]
	public FloatParameter BlurRadius; //Field offset: 0x18
	[Range(2, 30)]
	public IntParameter Iteration; //Field offset: 0x1C
	[Range(0, 1)]
	public FloatParameter RadialCenterX; //Field offset: 0x20
	[Range(0, 1)]
	public FloatParameter RadialCenterY; //Field offset: 0x24

	public RadialBlur() { }

}

