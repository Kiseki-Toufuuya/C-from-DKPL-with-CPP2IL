namespace XPostProcessing;

[PostProcess(typeof(TiltShiftBlurRenderer), PostProcessEvent::AfterStack (2), "X-PostProcessing/Blur/TiltShiftBlur/TiltShiftBlurV1", True)]
public class TiltShiftBlur : PostProcessEffectSettings
{
	public TiltShiftBlurQualityLevelParameter QualityLevel; //Field offset: 0x18
	[Range(0, 1)]
	public FloatParameter AreaSize; //Field offset: 0x1C
	[Range(0, 1)]
	public FloatParameter BlurRadius; //Field offset: 0x20
	[Range(1, 8)]
	public IntParameter Iteration; //Field offset: 0x24
	[Range(1, 2)]
	public FloatParameter RTDownScaling; //Field offset: 0x28

	public TiltShiftBlur() { }

}

