namespace XPostProcessing;

[PostProcess(typeof(EdgeDetectionSobelNeonV2Renderer), PostProcessEvent::AfterStack (2), "X-PostProcessing/EdgeDetection/EdgeDetectionSobelNeonV2", True)]
public class EdgeDetectionSobelNeonV2 : PostProcessEffectSettings
{
	[Range(0.05, 5)]
	public FloatParameter EdgeWidth; //Field offset: 0x18
	[Range(0.1, 1)]
	public FloatParameter EdgeNeonFade; //Field offset: 0x1C
	[Range(0, 1)]
	public FloatParameter BackgroundFade; //Field offset: 0x20
	[Range(0.2, 2)]
	public FloatParameter Brigtness; //Field offset: 0x24
	[ColorUsage(True, True, 0, 20, 0.125, 3)]
	public ColorParameter BackgroundColor; //Field offset: 0x28

	public EdgeDetectionSobelNeonV2() { }

}

