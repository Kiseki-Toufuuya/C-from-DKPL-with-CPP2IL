namespace XPostProcessing;

[PostProcess(typeof(DualTentBlurRenderer), PostProcessEvent::AfterStack (2), "X-PostProcessing/Blur/DualTentBlur", True)]
public class DualTentBlur : PostProcessEffectSettings
{
	[Range(0, 15)]
	public FloatParameter BlurRadius; //Field offset: 0x18
	[Range(1, 8)]
	public IntParameter Iteration; //Field offset: 0x1C
	[Range(1, 10)]
	public FloatParameter RTDownScaling; //Field offset: 0x20

	public DualTentBlur() { }

}

