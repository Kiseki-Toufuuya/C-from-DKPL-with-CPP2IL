namespace XPostProcessing;

[PostProcess(typeof(RadialBlurV2Renderer), PostProcessEvent::AfterStack (2), "X-PostProcessing/Blur/RadialBlur/RadialBlurV2", True)]
public class RadialBlurV2 : PostProcessEffectSettings
{
	public RadialBlurQualityParameter QualityLevel; //Field offset: 0x18
	[Range(-1, 1)]
	public FloatParameter BlurRadius; //Field offset: 0x1C
	[Range(0, 1)]
	public FloatParameter RadialCenterX; //Field offset: 0x20
	[Range(0, 1)]
	public FloatParameter RadialCenterY; //Field offset: 0x24

	public RadialBlurV2() { }

}

