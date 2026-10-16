namespace XPostProcessing;

[PostProcess(typeof(PixelizeHexagonGridRenderer), PostProcessEvent::BeforeStack (1), "X-PostProcessing/Pixelize/PixelizeHexagonGrid", True)]
public class PixelizeHexagonGrid : PostProcessEffectSettings
{
	[Range(0.01, 1)]
	public FloatParameter pixelSize; //Field offset: 0x18
	[Range(0.01, 5)]
	public FloatParameter gridWidth; //Field offset: 0x1C
	public BoolParameter useAutoScreenRatio; //Field offset: 0x20
	[Range(0.2, 5)]
	public FloatParameter pixelRatio; //Field offset: 0x24
	[Range(0.2, 5)]
	public FloatParameter pixelScaleX; //Field offset: 0x28
	[Range(0.2, 5)]
	public FloatParameter pixelScaleY; //Field offset: 0x2C

	public PixelizeHexagonGrid() { }

}

