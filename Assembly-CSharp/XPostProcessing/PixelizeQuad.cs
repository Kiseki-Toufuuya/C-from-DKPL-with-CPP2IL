namespace XPostProcessing;

[PostProcess(typeof(PixelizeQuadRenderer), PostProcessEvent::BeforeStack (1), "X-PostProcessing/Pixelize/PixelizeQuad", True)]
public class PixelizeQuad : PostProcessEffectSettings
{
	[Range(0.01, 1)]
	public FloatParameter pixelSize; //Field offset: 0x18
	public BoolParameter useAutoScreenRatio; //Field offset: 0x1C
	[Range(0.2, 5)]
	public FloatParameter pixelRatio; //Field offset: 0x20
	[Range(0.2, 5)]
	[Tooltip("像素缩放X")]
	public FloatParameter pixelScaleX; //Field offset: 0x24
	[Range(0.2, 5)]
	[Tooltip("像素缩放Y")]
	public FloatParameter pixelScaleY; //Field offset: 0x28

	public PixelizeQuad() { }

}

