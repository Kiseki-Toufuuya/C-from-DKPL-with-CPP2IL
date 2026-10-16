namespace XPostProcessing;

[PostProcess(typeof(KawaseBlurRenderer), PostProcessEvent::AfterStack (2), "X-PostProcessing/Blur/KawaseBlur", True)]
public class KawaseBlur : PostProcessEffectSettings
{
	[Range(0, 5)]
	public FloatParameter BlurRadius; //Field offset: 0x18
	[Range(1, 10)]
	public IntParameter Iteration; //Field offset: 0x1C
	[Range(1, 8)]
	public FloatParameter RTDownScaling; //Field offset: 0x20

	public KawaseBlur() { }

}

