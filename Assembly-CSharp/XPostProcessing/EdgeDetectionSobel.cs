namespace XPostProcessing;

[PostProcess(typeof(EdgeDetectionSobelRenderer), PostProcessEvent::AfterStack (2), "X-PostProcessing/EdgeDetection/EdgeDetectionSobel", True)]
public class EdgeDetectionSobel : PostProcessEffectSettings
{
	[Range(0.05, 5)]
	public FloatParameter edgeWidth; //Field offset: 0x18
	[ColorUsage(True, True, 0, 20, 0.125, 3)]
	public ColorParameter edgeColor; //Field offset: 0x1C
	[Range(0, 1)]
	public FloatParameter backgroundFade; //Field offset: 0x20
	[ColorUsage(True, True, 0, 20, 0.125, 3)]
	public ColorParameter backgroundColor; //Field offset: 0x24

	public EdgeDetectionSobel() { }

}

