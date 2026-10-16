namespace XPostProcessing;

[PostProcess(typeof(PixelizeCircleRenderer), PostProcessEvent::BeforeStack (1), "X-PostProcessing/Pixelize/PixelizeCircle", True)]
public class PixelizeCircle : PostProcessEffectSettings
{
	[Range(0.01, 1)]
	public FloatParameter pixelSize; //Field offset: 0x18
	[Range(0.01, 1)]
	public FloatParameter circleRadius; //Field offset: 0x1C
	[Range(0.2, 5)]
	[Tooltip("Pixel interval X")]
	public FloatParameter pixelIntervalX; //Field offset: 0x20
	[Range(0.2, 5)]
	[Tooltip("Pixel interval Y")]
	public FloatParameter pixelIntervalY; //Field offset: 0x24
	[ColorUsage(True, True, 0, 20, 0.125, 3)]
	public ColorParameter BackgroundColor; //Field offset: 0x28

	public PixelizeCircle() { }

}

