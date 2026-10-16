namespace XPostProcessing;

[PostProcess(typeof(IrisBlurRenderer), PostProcessEvent::AfterStack (2), "X-PostProcessing/Blur/IrisBlur/IrisBlurV1", True)]
public class IrisBlur : PostProcessEffectSettings
{
	public IrisBlurQualityLevelParameter QualityLevel; //Field offset: 0x18
	[Range(0, 1)]
	public FloatParameter AreaSize; //Field offset: 0x1C
	[Range(0, 1)]
	public FloatParameter BlurRadius; //Field offset: 0x20
	[Range(1, 8)]
	public IntParameter Iteration; //Field offset: 0x24
	[Range(1, 2)]
	public FloatParameter RTDownScaling; //Field offset: 0x28

	public IrisBlur() { }

}

