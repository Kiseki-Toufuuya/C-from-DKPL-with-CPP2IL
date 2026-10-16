namespace XPostProcessing;

[PostProcess(typeof(DualKawaseBlurRenderer), PostProcessEvent::AfterStack (2), "X-PostProcessing/Blur/DualKawaseBlur", True)]
public class DualKawaseBlur : PostProcessEffectSettings
{
	[Range(0, 15)]
	public FloatParameter BlurRadius; //Field offset: 0x18
	[Range(1, 10)]
	public IntParameter Iteration; //Field offset: 0x1C
	[Range(1, 10)]
	public FloatParameter RTDownScaling; //Field offset: 0x20

	public DualKawaseBlur() { }

}

