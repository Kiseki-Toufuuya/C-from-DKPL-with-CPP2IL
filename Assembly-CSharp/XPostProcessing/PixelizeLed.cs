namespace XPostProcessing;

[PostProcess(typeof(PixelizeLedV2Renderer), PostProcessEvent::BeforeStack (1), "X-PostProcessing/Pixelize/PixelizeLed", True)]
public class PixelizeLed : PostProcessEffectSettings
{
	[Range(0.01, 1)]
	public FloatParameter pixelSize; //Field offset: 0x18
	[Range(0.01, 1)]
	public FloatParameter ledRadius; //Field offset: 0x1C
	[ColorUsage(True, True, 0, 20, 0.125, 3)]
	public ColorParameter BackgroundColor; //Field offset: 0x20
	public BoolParameter useAutoScreenRatio; //Field offset: 0x24
	[Range(0.2, 5)]
	public FloatParameter pixelRatio; //Field offset: 0x28

	public PixelizeLed() { }

}

