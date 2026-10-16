namespace XPostProcessing;

[PostProcess(typeof(SharpenV3Renderer), PostProcessEvent::AfterStack (2), "X-PostProcessing/ImageProcessing/SharpenV3", True)]
public class SharpenV3 : PostProcessEffectSettings
{
	[Range(0, 1)]
	public FloatParameter Sharpness; //Field offset: 0x18

	public SharpenV3() { }

}

