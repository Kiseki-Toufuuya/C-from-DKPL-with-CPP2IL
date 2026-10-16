namespace XPostProcessing;

[PostProcess(typeof(GrainyBlurRenderer), PostProcessEvent::AfterStack (2), "X-PostProcessing/Blur/GrainyBlur", True)]
public class GrainyBlur : PostProcessEffectSettings
{
	[Range(0, 50)]
	public FloatParameter BlurRadius; //Field offset: 0x18
	[Range(1, 8)]
	public IntParameter Iteration; //Field offset: 0x1C
	[Range(1, 10)]
	public FloatParameter RTDownScaling; //Field offset: 0x20

	public GrainyBlur() { }

}

