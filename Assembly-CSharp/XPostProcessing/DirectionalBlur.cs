namespace XPostProcessing;

[PostProcess(typeof(DirectionalBlurRenderer), PostProcessEvent::AfterStack (2), "X-PostProcessing/Blur/DirectionalBlur", True)]
public class DirectionalBlur : PostProcessEffectSettings
{
	[Range(0, 5)]
	public FloatParameter BlurRadius; //Field offset: 0x18
	[Range(1, 30)]
	public IntParameter Iteration; //Field offset: 0x1C
	[Range(0, 6)]
	public FloatParameter Angle; //Field offset: 0x20
	[Range(1, 10)]
	public FloatParameter RTDownScaling; //Field offset: 0x24

	public DirectionalBlur() { }

}

