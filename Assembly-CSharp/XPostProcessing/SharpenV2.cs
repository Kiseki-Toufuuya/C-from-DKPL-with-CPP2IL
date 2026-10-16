namespace XPostProcessing;

[PostProcess(typeof(SharpenV2Renderer), PostProcessEvent::AfterStack (2), "X-PostProcessing/ImageProcessing/SharpenV2", True)]
public class SharpenV2 : PostProcessEffectSettings
{
	[Range(0, 5)]
	public FloatParameter Sharpness; //Field offset: 0x18

	public SharpenV2() { }

}

