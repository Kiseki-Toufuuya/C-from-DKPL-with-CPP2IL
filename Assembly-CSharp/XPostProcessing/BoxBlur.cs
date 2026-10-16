namespace XPostProcessing;

[PostProcess(typeof(BoxBlurRenderer), PostProcessEvent::AfterStack (2), "X-PostProcessing/Blur/BoxBlur", True)]
public class BoxBlur : PostProcessEffectSettings
{
	[Range(0, 5)]
	public FloatParameter BlurRadius; //Field offset: 0x18
	[Range(1, 20)]
	public IntParameter Iteration; //Field offset: 0x1C
	[Range(1, 8)]
	public FloatParameter RTDownScaling; //Field offset: 0x20

	public BoxBlur() { }

}

