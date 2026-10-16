namespace XPostProcessing;

[PostProcess(typeof(BokehBlurRenderer), PostProcessEvent::AfterStack (2), "X-PostProcessing/Blur/BokehBlur", True)]
public class BokehBlur : PostProcessEffectSettings
{
	[Range(0, 3)]
	public FloatParameter BlurRadius; //Field offset: 0x18
	[Range(8, 128)]
	public IntParameter Iteration; //Field offset: 0x1C
	[Range(1, 10)]
	public FloatParameter RTDownScaling; //Field offset: 0x20

	public BokehBlur() { }

}

