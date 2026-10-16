namespace XPostProcessing;

[PostProcess(typeof(SharpenV1Renderer), PostProcessEvent::AfterStack (2), "X-PostProcessing/ImageProcessing/SharpenV1", True)]
public class SharpenV1 : PostProcessEffectSettings
{
	[Range(0, 5)]
	public FloatParameter Strength; //Field offset: 0x18
	[Range(0, 1)]
	public FloatParameter Threshold; //Field offset: 0x1C

	public SharpenV1() { }

}

